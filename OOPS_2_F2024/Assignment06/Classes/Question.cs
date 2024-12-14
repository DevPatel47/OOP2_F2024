/*============================================================
 * Title    :   Assignment-6: Final Assignment
 * Name     :   Dev Mayurkumar Patel
 * Date     :   10 December 2024
 * Purpose  :   Question Class file
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
    /// Question Class
    /// </summary>
    public class Question
    {

        #region Default Values

        private const int DEFAULT_MARKS = 1;
        private const string DEFAULT_QUESTION = "No Question provided";
        private const string DEFAULT_OPTION = "No Option provided";
        private const string DEFAULT_ANSWER = "No Answer provided";

        #endregion

        #region Static List

        // A List to store all questions
        public static List<Question> questions = new List<Question>();

        #endregion

        #region Properties

        /// <summary>
        /// Represents QuestionID property of Question class with getter and setter
        /// </summary>
        private int _questionID;
        public int QuestionID
        {
            get { return _questionID; }
            set
            {
                bool isUnique = true;
                foreach (Question question in questions)
                {
                    if (value == question.QuestionID) { isUnique = false; }
                }
                if (isUnique)
                {
                    if (value > 0)
                    {
                        _questionID = value;
                    }
                    else throw new Exception("Question ID must be a positive number");
                }
                else throw new Exception("Provided Question ID is not Unique");
            }
        }

        /// <summary>
        /// Represents QuizID property of Question class with getter and setter
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
                        throw new Exception("QuizID must reference an existing Quiz.");
                    }
                }
                else
                {
                    throw new Exception("QuizID must be greater than 0.");
                }
            }
        }

        /// <summary>
        /// Represents Marks property of Question class with getter and setter
        /// </summary>
        private int _marks;
        public int Marks
        {
            get { return _marks; }
            set
            {
                if (value >= 0)
                {
                    _marks = value;
                }
                else
                {
                    throw new Exception("Marks must be zero or greater.");
                }
            }
        }

        /// <summary>
        /// Represents Question property of Question class with getter and setter
        /// </summary>
        private string _questionText;
        public string QuestionText 
        {
            get { return _questionText; }
            set
            {
                if (value.Trim().Length >= 0 && value.Trim().Length <= 255)
                {
                    _questionText = value.Trim();
                }
                else
                {
                    throw new Exception("Question Text must be non-empty and up to 255 characters.");
                }
            }
        }

        /// <summary>
        /// Represents FirstOption property of Question class with getter and setter
        /// </summary>
        private string _firstOption;
        public string FirstOption 
        {
            get { return _firstOption; }
            set
            {
                if (value.Trim().Length >= 0 && value.Trim().Length <= 50)
                {
                    _firstOption = value.Trim();
                }
                else
                {
                    throw new Exception("Option Text must be non-empty and up to 50 characters.");
                }
            }
        }

        /// <summary>
        /// Represents SecondOption property of Question class with getter and setter
        /// </summary>
        private string _secondOption;
        public string SecondOption 
        {
            get { return _secondOption; }
            set
            {
                if (value.Trim().Length >= 0 && value.Trim().Length <= 50)
                {
                    _secondOption = value.Trim();
                }
                else
                {
                    throw new Exception("Option Text must be non-empty and up to 50 characters.");
                }
            }
        }

        /// <summary>
        /// Represents ThirdOption property of Question class with getter and setter
        /// </summary>
        private string _thirdOption;
        public string ThirdOption
        {
            get { return _thirdOption; }
            set
            {
                if (value.Trim().Length >= 0 && value.Trim().Length <= 50)
                {
                    _thirdOption = value.Trim();
                }
                else
                {
                    throw new Exception("Option Text must be non-empty and up to 50 characters.");
                }
            }
        }

        /// <summary>
        /// Represents FourthOption property of Question class with getter and setter
        /// </summary>
        private string _fourthOption;
        public string FourthOption 
        {
            get { return _fourthOption; }
            set
            {
                if (value.Trim().Length >= 0 && value.Trim().Length <= 50)
                {
                    _fourthOption = value.Trim();
                }
                else
                {
                    throw new Exception("Option Text must be non-empty and up to 50 characters.");
                }
            }
        }

        /// <summary>
        /// Represents Answer property of Question class with getter and setter
        /// </summary>
        private string _answer;
        public string Answer 
        {
            get { return _answer; }
            set
            {
                if (value.Trim().Length >= 0 && value.Trim().Length <= 50)
                {
                    _answer = value.Trim();
                }
                else
                {
                    throw new Exception("Answer Text must be non-empty and up to 50 characters.");
                }
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Question()
        {
            SetDefault();
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        public Question(int questionID, int quizID, int marks, string questionText,
                        string firstOption, string secondOption, string thirdOption,
                        string fourthOption, string answer)
        {
            QuestionID = questionID;
            QuizID = quizID;
            Marks = marks;
            QuestionText = questionText;
            FirstOption = firstOption;
            SecondOption = secondOption;
            ThirdOption = thirdOption;
            FourthOption = fourthOption;
            Answer = answer;
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Method to fill questions list from database
        /// </summary>
        public static bool FillQuestions()
        {
            bool retBool = false;
            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Questions", connection);
                SqlDataReader reader = command.ExecuteReader();
                questions.Clear();
                while (reader.Read())
                {
                    Question question = new Question(
                        reader.GetInt32(0),  // QuestionID
                        reader.GetInt32(1),  // QuizID
                        reader.GetInt32(2),  // Marks
                        reader.GetString(3), // Question
                        reader.GetString(4), // FirstOption
                        reader.GetString(5), // SecondOption
                        reader.GetString(6), // ThirdOption
                        reader.GetString(7), // FourthOption
                        reader.GetString(8)  // Answer
                    );
                    questions.Add(question);
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
        /// Method to find a question by QuestionID
        /// </summary>
        /// <param name="questionID"></param>
        /// <returns></returns>
        public static Question FindQuestionById(int questionID)
        {
            foreach (Question question in questions)
            {
                if (question.QuestionID == questionID) return question;
            }
            return null;
        }

        /// <summary>
        /// Method to delete a question
        /// </summary>
        public static bool DeleteQuestion(int questionID)
        {
            bool retBool = false;
            string sql = "spDeleteQuestion";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@QuestionID", questionID);
                command.ExecuteNonQuery();
                FillQuestions();
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
            Marks = DEFAULT_MARKS;
            QuestionText = DEFAULT_QUESTION;
            FirstOption = DEFAULT_OPTION;
            SecondOption = DEFAULT_OPTION;
            ThirdOption = DEFAULT_OPTION;
            FourthOption = DEFAULT_OPTION;
            Answer = DEFAULT_ANSWER;
        }

        /// <summary>
        /// Method to insert a new question
        /// </summary>
        public bool InsertQuestion()
        {
            bool retBool = false;
            string sql = "spInsertNewQuestion";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@QuestionID", Tools.GetMaxID("Questions", "QuestionID") + 1);
                command.Parameters.AddWithValue("@QuizID", this.QuizID);
                command.Parameters.AddWithValue("@Marks", this.Marks);
                command.Parameters.AddWithValue("@Question", this.QuestionText);
                command.Parameters.AddWithValue("@FirstOption", this.FirstOption);
                command.Parameters.AddWithValue("@SecondOption", this.SecondOption);
                command.Parameters.AddWithValue("@ThirdOption", this.ThirdOption);
                command.Parameters.AddWithValue("@FourthOption", this.FourthOption);
                command.Parameters.AddWithValue("@Answer", this.Answer);
                command.ExecuteNonQuery();
                FillQuestions();
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
        /// Method to update an existing question
        /// </summary>
        public bool UpdateQuestion()
        {
            bool retBool = false;
            string sql = "spUpdateQuestion";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@QuestionID", this.QuestionID);
                command.Parameters.AddWithValue("@QuizID", this.QuizID);
                command.Parameters.AddWithValue("@Marks", this.Marks);
                command.Parameters.AddWithValue("@Question", this.QuestionText);
                command.Parameters.AddWithValue("@FirstOption", this.FirstOption);
                command.Parameters.AddWithValue("@SecondOption", this.SecondOption);
                command.Parameters.AddWithValue("@ThirdOption", this.ThirdOption);
                command.Parameters.AddWithValue("@FourthOption", this.FourthOption);
                command.Parameters.AddWithValue("@Answer", this.Answer);
                command.ExecuteNonQuery();
                FillQuestions();
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
        /// Returns a custom string for a question
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Question ID: {this.QuestionID}, Quiz ID: {this.QuizID}, Marks: {this.Marks}, Question: {this.QuestionText}";
        }

        #endregion

    }
}
