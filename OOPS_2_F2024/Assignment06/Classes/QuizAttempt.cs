/*============================================================
 * Title    :   Assignment-6: Final Assignment
 * Name     :   Dev Mayurkumar Patel
 * Date     :   10 December 2024
 * Purpose  :   QuizAttempt Class file
 *===========================================================*/

using Assignment06.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DBAL
{
    /// <summary>
    /// QuizAttempt Class
    /// </summary>
    public class QuizAttempt
    {

        #region Default Values

        private const int DEFAULT_STUDENT_ID = 1;
        private const int DEFAULT_QUIZ_ID = 1;
        private const int DEFAULT_MARKS_OBTAINED = 0;

        #endregion

        #region Static List

        // A List to store all quiz attempts
        public static List<QuizAttempt> quizAttempts = new List<QuizAttempt>();

        #endregion

        #region Properties

        /// <summary>
        /// Represents QuizAttemptID property with getter and setter
        /// </summary>
        private int _quizAttemptID;
        public int QuizAttemptID
        {
            get { return _quizAttemptID; }
            set
            {
                bool isUnique = true;
                foreach (QuizAttempt quizAttempt in quizAttempts)
                {
                    if (value == quizAttempt.QuizAttemptID) { isUnique = false; }
                }
                if (isUnique)
                {
                    if (value > 0)
                    {
                        _quizAttemptID = value;
                    }
                    else throw new Exception("QuizAttempt ID must be a positive number");
                }
                else throw new Exception("Provided QuizAttempt ID is not Unique");
            }
        }

        /// <summary>
        /// Represents StudentID property with getter and setter
        /// </summary>
        private int _studentID;
        public int StudentID
        {
            get { return _studentID; }
            set
            {
                if (value > 0)
                {
                    if (Student.FindStudentById(value) != null)
                    {
                        _studentID = value;
                    }
                    else
                    {
                        throw new Exception("StudentID must reference an existing Student.");
                    }
                }
                else
                {
                    throw new Exception("StudentID must be greater than 0.");
                }
            }
        }

        /// <summary>
        /// Represents QuizID property with getter and setter
        /// </summary>
        private int _quizID;
        public int QuizID
        {
            get { return _quizID; }
            set
            {
                if (value > 0)
                {
                    if (Quiz.FindQuizById(value) != null)
                    {
                        _quizID = value;
                    }
                    else
                    {
                        throw new Exception("Quiz ID must reference an existing Quiz.");
                    }
                }
                else
                {
                    throw new Exception("Quiz ID must be greater than 0.");
                }
            }
        }

        /// <summary>
        /// Represents MarksObtained property with getter and setter
        /// </summary>
        private int _marksObtained;
        public int MarksObtained
        {
            get { return _marksObtained; }
            set
            {
                if (value >= 0)
                {
                    _marksObtained = value;
                }
                else
                {
                    throw new Exception("Marks Obtained must be zero or greater.");
                }
            }
        }

        /// <summary>
        /// Represents AttemptTime property
        /// </summary>
        public DateTime AttemptTime { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public QuizAttempt()
        {
            SetDefault();
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        public QuizAttempt(int quizAttemptID, int studentID, int quizID, int marksObtained, DateTime attemptTime)
        {
            QuizAttemptID = quizAttemptID;
            StudentID = studentID;
            QuizID = quizID;
            MarksObtained = marksObtained;
            AttemptTime = attemptTime;
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Method to fill quiz attempts list from database
        /// </summary>
        public static bool FillQuizAttempts()
        {
            bool retBool = false;
            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM QuizAttempts", connection);
                SqlDataReader reader = command.ExecuteReader();
                quizAttempts.Clear();
                while (reader.Read())
                {
                    QuizAttempt quizAttempt = new QuizAttempt(
                        reader.GetInt32(0),  // QuizAttemptID
                        reader.GetInt32(1),  // StudentID
                        reader.GetInt32(2),  // QuizID
                        reader.GetInt32(3),  // MarksObtained
                        reader.GetDateTime(4) // AttemptTime
                    );
                    quizAttempts.Add(quizAttempt);
                    retBool = true;
                }
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
        /// Method to find a quiz attempt by QuizAttemptID
        /// </summary>
        /// <param name="quizAttemptID"></param>
        /// <returns></returns>
        public static QuizAttempt FindQuizAttemptById(int quizAttemptID)
        {
            foreach (QuizAttempt quizAttempt in quizAttempts)
            {
                if (quizAttempt.QuizAttemptID == quizAttemptID) return quizAttempt;
            }
            return null;
        }

        /// <summary>
        /// Method to delete a quiz attempt
        /// </summary>
        public static bool DeleteQuizAttempt(int quizAttemptID)
        {
            bool retBool = false;
            string sql = "spDeleteQuizAttempts";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@QuizAttemptID", quizAttemptID);
                command.ExecuteNonQuery();
                FillQuizAttempts();
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
            StudentID = DEFAULT_STUDENT_ID;
            QuizID = DEFAULT_QUIZ_ID;
            MarksObtained = DEFAULT_MARKS_OBTAINED;
            AttemptTime = DateTime.Now;
        }

        /// <summary>
        /// Method to insert a new quiz attempt
        /// </summary>
        public bool InsertQuizAttempt()
        {
            bool retBool = false;
            string sql = "spInsertNewQuizAttempts";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@QuizAttemptID", Tools.GetMaxID("QuizAttempts", "QuizAttemptID") + 1);
                command.Parameters.AddWithValue("@StudentID", this.StudentID);
                command.Parameters.AddWithValue("@QuizID", this.QuizID);
                command.Parameters.AddWithValue("@MarksObtained", this.MarksObtained);
                command.Parameters.AddWithValue("@AttemptTime", this.AttemptTime);
                command.ExecuteNonQuery();
                FillQuizAttempts();
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
        /// Method to update an existing quiz attempt
        /// </summary>
        public bool UpdateQuizAttempt()
        {
            bool retBool = false;
            string sql = "spUpdateQuizAttempts";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@QuizAttemptID", this.QuizAttemptID);
                command.Parameters.AddWithValue("@StudentID", this.StudentID);
                command.Parameters.AddWithValue("@QuizID", this.QuizID);
                command.Parameters.AddWithValue("@MarksObtained", this.MarksObtained);
                command.Parameters.AddWithValue("@AttemptTime", this.AttemptTime);
                command.ExecuteNonQuery();
                FillQuizAttempts();
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
        /// Returns a custom string for a quiz attempt
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"QuizAttempt ID: {this.QuizAttemptID}, Student ID: {this.StudentID}, Quiz ID: {this.QuizID}, Marks: {this.MarksObtained}, Attempt Time: {this.AttemptTime}";
        }

        #endregion

    }
}
