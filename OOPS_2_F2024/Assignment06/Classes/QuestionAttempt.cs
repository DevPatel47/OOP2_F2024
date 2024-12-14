/*============================================================
 * Title    :   Assignment-6: Final Assignment
 * Name     :   Dev Mayurkumar Patel
 * Date     :   10 December 2024
 * Purpose  :   QuestionAttempt Class file
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
    /// QuestionAttempt Class
    /// </summary>
    public class QuestionAttempt
    {

        #region Default Values

        private const int DEFAULT_QUIZ_ATTEMPT_ID = 1;
        private const int DEFAULT_QUESTION_ID = 1;
        private const string DEFAULT_STUDENT_ANSWER = "Not Answered";
        private const int DEFAULT_IS_CORRECT = 0;

        #endregion

        #region Static List

        // A List to store all question attempts
        public static List<QuestionAttempt> questionAttempts = new List<QuestionAttempt>();

        #endregion

        #region Properties

        /// <summary>
        /// Represents QuestionAttemptID property of QuestionAttempt class with getter and setter
        /// </summary>
        private int _questionAttemptID;
        public int QuestionAttemptID 
        {
            get { return _questionAttemptID; }
            set
            {
                bool isUnique = true;
                foreach (QuestionAttempt questionAttempt in questionAttempts)
                {
                    if (value == questionAttempt.QuestionAttemptID) { isUnique = false; }
                }
                if (isUnique)
                {
                    if (value > 0)
                    {
                        _questionAttemptID = value;
                    }
                    else throw new Exception("QuestionAttempt ID must be a positive number");
                }
                else throw new Exception("Provided QuestionAttempt ID is not Unique");
            }
        }

        /// <summary>
        /// Represents QuizAttemptID property of QuestionAttempt class with getter and setter
        /// </summary>
        private int _quizAttemptID;
        public int QuizAttemptID 
        {
            get { return _quizAttemptID; }
            set
            {
                if (value > 0)
                {
                    if (QuizAttempt.FindQuizAttemptById(value) != null)
                    {
                        _quizAttemptID = value;
                    }
                    else
                    {
                        throw new Exception("QuizAttempt ID must reference an existing QuizAttempt.");
                    }
                }
                else
                {
                    throw new Exception("QuizAttempt ID must be greater than 0.");
                }
            }

        }

        /// <summary>
        /// Represents QuestionID property of QuestionAttempt class with getter and setter
        /// </summary>
        private int _questionID;
        public int QuestionID 
        {
            get { return _questionID; }
            set
            {
                if (value > 0)
                {
                    if (Question.FindQuestionById(value) != null)
                    {
                        _questionID = value;
                    }
                    else
                    {
                        throw new Exception("Question ID must reference an existing Question.");
                    }
                }
                else
                {
                    throw new Exception("Question ID must be greater than 0.");
                }
            }
        }

        /// <summary>
        /// Represents StudentAnswer property of QuestionAttempt class with getter and setter
        /// </summary>
        private string _studentAnswer;
        public string StudentAnswer 
        {
            get { return _studentAnswer; }
            set
            {
                if (value.Trim().Length >= 0 && value.Trim().Length <= 50)
                {
                    _studentAnswer = value.Trim();
                }
                else
                {
                    throw new Exception("Answer Text must be non-empty and up to 50 characters.");
                }
            }
        }

        /// <summary>
        /// Represents IsCorrect property of QuestionAttempt class with getter and setter
        /// </summary>
        private int _isCorrect;
        public int IsCorrect 
        {
            get { return _isCorrect; }
            set
            {
                if (value == 0 || value == 1)
                {
                    _isCorrect = value;
                }
                else
                {
                    throw new Exception("Invalid value for IsCorrect property");
                }
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public QuestionAttempt()
        {
            SetDefault();
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        public QuestionAttempt(int questionAttemptID, int quizAttemptID, int questionID, string studentAnswer, int isCorrect)
        {
            QuestionAttemptID = questionAttemptID;
            QuizAttemptID = quizAttemptID;
            QuestionID = questionID;
            StudentAnswer = studentAnswer;
            IsCorrect = isCorrect;
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Method to fill questionAttempts list from database
        /// </summary>
        public static bool FillQuestionAttempts()
        {
            bool retBool = false;
            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM QuestionAttempts", connection);
                SqlDataReader reader = command.ExecuteReader();
                questionAttempts.Clear();
                while (reader.Read())
                {
                    QuestionAttempt attempt = new QuestionAttempt(
                        reader.GetInt32(0),  // QuestionAttemptID
                        reader.GetInt32(1),  // QuizAttemptID
                        reader.GetInt32(2),  // QuestionID
                        reader.GetString(3), // StudentAnswer
                        reader.GetInt32(4)   // IsCorrect
                    );
                    questionAttempts.Add(attempt);
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
        /// Method to find a question attempt by QuestionAttemptID
        /// </summary>
        /// <param name="questionAttemptID"></param>
        /// <returns></returns>
        public static QuestionAttempt FindQuestionAttemptById(int questionAttemptID)
        {
            foreach (QuestionAttempt attempt in questionAttempts)
            {
                if (attempt.QuestionAttemptID == questionAttemptID) return attempt;
            }
            return null;
        }

        /// <summary>
        /// Method to delete a question attempt
        /// </summary>
        public static bool DeleteQuestionAttempt(int questionAttemptID)
        {
            bool retBool = false;
            string sql = "spDeleteQuestionAttempts";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@QuestionAttemptID", questionAttemptID);
                command.ExecuteNonQuery();
                FillQuestionAttempts();
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
            QuizAttemptID = DEFAULT_QUIZ_ATTEMPT_ID;
            QuestionID = DEFAULT_QUESTION_ID;
            StudentAnswer = DEFAULT_STUDENT_ANSWER;
            IsCorrect = DEFAULT_IS_CORRECT;
        }

        /// <summary>
        /// Method to insert a new question attempt
        /// </summary>
        public bool InsertQuestionAttempt()
        {
            bool retBool = false;
            string sql = "spInsertNewQuestionAttempts";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@QuestionAttemptID", Tools.GetMaxID("QuestionAttempts", "QuestionAttemptID") + 1);
                command.Parameters.AddWithValue("@QuizAttemptID", this.QuizAttemptID);
                command.Parameters.AddWithValue("@QuestionID", this.QuestionID);
                command.Parameters.AddWithValue("@StudentAnswer", this.StudentAnswer);
                command.Parameters.AddWithValue("@IsCorrect", this.IsCorrect);
                command.ExecuteNonQuery();
                FillQuestionAttempts();
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
        /// Method to update an existing question attempt
        /// </summary>
        public bool UpdateQuestionAttempt()
        {
            bool retBool = false;
            string sql = "spUpdateQuestionAttempts";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@QuestionAttemptID", this.QuestionAttemptID);
                command.Parameters.AddWithValue("@QuizAttemptID", this.QuizAttemptID);
                command.Parameters.AddWithValue("@QuestionID", this.QuestionID);
                command.Parameters.AddWithValue("@StudentAnswer", this.StudentAnswer);
                command.Parameters.AddWithValue("@IsCorrect", this.IsCorrect);
                command.ExecuteNonQuery();
                FillQuestionAttempts();
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
        /// Returns a custom string for a question attempt
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Attempt ID: {this.QuestionAttemptID}, Quiz Attempt ID: {this.QuizAttemptID}, Question ID: {this.QuestionID}, Answer: {this.StudentAnswer}, Correct: {this.IsCorrect}";
        }

        #endregion

    }
}
