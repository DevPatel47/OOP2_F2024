/*============================================================
 * Title    :   Assignment-6: Final Assignment
 * Name     :   Dev Mayurkumar Patel
 * Date     :   10 December 2024
 * Purpose  :   Quiz Class file
 *===========================================================*/

/*
 * This code was developed with assistance from ChatGPT during a conversation on 10 December 2024.
 * Summary of the collaboration:
 * 1. I provided my SQL table and a sample class file for reference.
 * 2. ChatGPT helped generate the necessary class file for database interaction, incorporating the SQL table structure and foreign key relationships.
 * 
 * This final code combines all the methods and classes, ensuring proper database interactions and functionality.
 */

using Assignment06.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DBAL
{
    /// <summary>
    /// Quiz Class
    /// </summary>
    public class Quiz
    {

        #region Default Values

        private const string DEFAULT_NAME = "Untitled Quiz";
        private const int DEFAULT_TOTAL_MARKS = 0;

        #endregion

        #region Static List

        // A List to store all quizzes
        public static List<Quiz> quizzes = new List<Quiz>();

        #endregion

        #region Properties

        /// <summary>
        /// Represents QuizID property of Quiz class with getter and setter
        /// </summary>
        private int _quizID;
        public int QuizID 
        {
            get { return _quizID; }
            set
            {
                bool isUnique = true;
                foreach (Quiz quiz in quizzes)
                {
                    if (value == quiz.QuizID) { isUnique = false; }
                }
                if (isUnique)
                {
                    if (value > 0)
                    {
                        _quizID = value;
                    }
                    else throw new Exception("Quiz ID must be a positive number");
                }
                else throw new Exception("Provided Quiz ID is not Unique");
            }
        }

        /// <summary>
        /// Represents CourseID property of Quiz class with getter and setter
        /// </summary>
        private string _courseID;
        public string CourseID
        {
            get { return _courseID; }
            set
            {
                if (value.Length == 8)
                {
                    if (Course.FindCourseById(value) != null)
                    {
                        _courseID = value;
                    }
                    else
                    {
                        throw new Exception("CourseID must reference an existing Course.");
                    }
                }
                else
                {
                    throw new Exception("CourseID must be a non-empty string of length 8.");
                }
            }
        }

        /// <summary>
        /// Represents Name property of Quiz class with getter and setter
        /// </summary>
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 50)
                {
                    _name = value.Trim();
                }
                else
                {
                    throw new Exception("Name must be a non-empty string of up to 50 characters.");
                }
            }
        }

        /// <summary>
        /// Represents TotalMarks property of Quiz class with getter and setter
        /// </summary>
        private int _totalMarks;
        public int TotalMarks 
        {
            get { return _totalMarks; }
            set 
            {
                if (value > 0)
                {
                    _totalMarks = value;
                }
                else
                {
                    throw new Exception("Total Marks must be greater than 0.");
                }
            } 
        
        }

        /// <summary>
        /// Represents StartTime property of Quiz class with getter and setter
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Represents EndTime property of Quiz class with getter and setter
        /// </summary>
        public DateTime EndTime { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Quiz()
        {
            SetDefault();
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="quizID"></param>
        /// <param name="courseID"></param>
        /// <param name="name"></param>
        /// <param name="totalMarks"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        public Quiz(int quizID, string courseID, string name, int totalMarks, DateTime startTime, DateTime endTime)
        {
            QuizID = quizID;
            CourseID = courseID;
            Name = name;
            TotalMarks = totalMarks;
            StartTime = startTime;
            EndTime = endTime;
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Method to fill quizzes list from database
        /// </summary>
        public static bool FillQuizzes()
        {
            bool retBool = false;
            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Quizzes", connection);
                SqlDataReader reader = command.ExecuteReader();
                quizzes.Clear();
                while (reader.Read())
                {
                    Quiz quiz = new Quiz(
                        reader.GetInt32(0),   // QuizID
                        reader.GetString(1),  // CourseID
                        reader.GetString(2),  // Name
                        reader.GetInt32(3),   // TotalMarks
                        reader.GetDateTime(4), // StartTime
                        reader.GetDateTime(5)  // EndTime
                    );
                    quizzes.Add(quiz);
                }
                retBool = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return retBool;
        }

        /// <summary>
        /// Method to find a quiz by QuizID
        /// </summary>
        /// <param name="quizID"></param>
        /// <returns></returns>
        public static Quiz FindQuizById(int quizID)
        {
            foreach (Quiz quiz in quizzes)
            {
                if (quiz.QuizID == quizID) return quiz;
            }
            return null;
        }

        /// <summary>
        /// Method to delete a quiz
        /// </summary>
        public static bool DeleteQuiz(int quizID)
        {
            bool retBool = false;
            string sql = "spDeleteQuiz";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@QuizID", quizID);
                command.ExecuteNonQuery();
                FillQuizzes();
                retBool = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return retBool;
        }
        #endregion

        #region Non-Static Methods

        /// <summary>
        /// Method to set default values
        /// </summary>
        private void SetDefault()
        {
            Name = DEFAULT_NAME;
            TotalMarks = DEFAULT_TOTAL_MARKS;
            StartTime = DateTime.Now;
            EndTime = DateTime.Now.AddHours(1);
        }

        /// <summary>
        /// Method to insert a new quiz
        /// </summary>
        public bool InsertQuiz()
        {
            bool retBool = false;
            string sql = "spInsertNewQuiz";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@QuizID", Tools.GetMaxID("Quizzes", "QuizID") + 1);
                command.Parameters.AddWithValue("@CourseID", this.CourseID);
                command.Parameters.AddWithValue("@Name", this.Name);
                command.Parameters.AddWithValue("@TotalMarks", this.TotalMarks);
                command.Parameters.AddWithValue("@StartTime", this.StartTime);
                command.Parameters.AddWithValue("@EndTime", this.EndTime);
                command.ExecuteNonQuery();
                FillQuizzes();
                retBool = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return retBool;
        }

        /// <summary>
        /// Method to update an existing quiz
        /// </summary>
        public bool UpdateQuiz()
        {
            bool retBool = false;
            string sql = "spUpdateQuiz";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@QuizID", this.QuizID);
                command.Parameters.AddWithValue("@CourseID", this.CourseID);
                command.Parameters.AddWithValue("@Name", this.Name);
                command.Parameters.AddWithValue("@TotalMarks", this.TotalMarks);
                command.Parameters.AddWithValue("@StartTime", this.StartTime);
                command.Parameters.AddWithValue("@EndTime", this.EndTime);
                command.ExecuteNonQuery();
                FillQuizzes();
                retBool = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return retBool;
        }

        /// <summary>
        /// Returns a custom string for a quiz
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Quiz: {this.Name} (ID: {this.QuizID}), Course ID: {this.CourseID}, Total Marks: {this.TotalMarks}, Start Time: {this.StartTime}, End Time: {this.EndTime}";
        }

        #endregion

    }
}
