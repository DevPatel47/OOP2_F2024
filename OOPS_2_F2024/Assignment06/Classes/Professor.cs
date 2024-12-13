/*============================================================
 * Title    :   Assignment-6: Final Assignment
 * Name     :   Dev Mayurkumar Patel
 * Date     :   10 December 2024
 * Purpose  :   Professor Class file
 *===========================================================*/

using Assignment06.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DBAL
{
    /// <summary>
    /// Professor Class Method
    /// </summary>
    public class Professor
    {
        /// <summary>
        /// Stores Current Professor
        /// </summary>
        public static Professor professor;

        #region Default Values

        private const string DEFAULT_FIRST_NAME = "FirstName";
        private const string DEFAULT_LAST_NAME = "LastName";
        private const string DEFAULT_EMAIL = "noemail@example.com";
        private const int DEFAULT_PASSWORD = 1000;

        #endregion

        #region Static List

        // A List to store all professors
        public static List<Professor> professors = new List<Professor>();

        #endregion

        #region Properties

        /// <summary>
        /// Represents ProfessorID property of Professor class with getter and setter
        /// </summary>
        private int _professorID;
        public int ProfessorID
        {
            get { return _professorID; }
            set
            {
                bool isUnique = true;
                foreach (Professor professor in professors)
                {
                    if (value == professor.ProfessorID) { isUnique = false; }
                }
                if (isUnique)
                {
                    if (value > 0)
                    {
                        _professorID = value;
                    }
                    else throw new Exception("Professor ID must be a positive number");
                }
                else throw new Exception("Provided Professor ID is not Unique");
            }
        }
        /// <summary>
        /// Represents FirstName property of Professor class with getter and setter
        /// </summary>
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value.Trim().Length >= 2 && value.Trim().Length <= 50)
                {
                    _firstName = value.Trim();
                }
                else
                {
                    throw new Exception("First name must be non-empty and up to 50 characters.");
                }
            }
        }
        /// <summary>
        /// Represents LastName property of Professor class with getter and setter
        /// </summary>
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value.Trim().Length >= 2 && value.Trim().Length <= 50)
                {
                    _lastName = value.Trim();
                }
                else
                {
                    throw new Exception("Last name must be non-empty and up to 50 characters.");
                }
            }
        }
        /// <summary>
        /// Represents Email property of Professor class with getter and setter
        /// </summary>
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                bool isUnique = true;
                foreach (Professor professor in professors)
                {
                    if (value == professor.Email) { isUnique = false; }
                }
                if (isUnique && value.Trim().Length >= 6 && value.Length <= 100 && value.Contains("@") && !value.Contains(" "))
                {
                    _email = value.Trim().ToLower();
                }
                else
                {
                    throw new Exception("Invalid email format or exceeds 100 characters or email id is not unique.");
                }
            }
        }
        /// <summary>
        /// Represents Password property of Professor class with getter and setter
        /// </summary>
        private int _password;
        public int Password
        {
            get { return _password; }
            set
            {
                if (value >= 1000 && value <= 9999)
                {
                    _password = value;
                }
                else
                {
                    throw new Exception("Password must be a 4-digit number between 1000 and 9999.");
                }
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Professor()
        {
            SetDefault();
        }
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="professorID"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public Professor(int professorID, string firstName, string lastName, string email, int password)
        {
            ProfessorID = professorID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }

        #endregion

        #region Static method

        /// <summary>
        /// Method to fill professors list from database
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static bool FillProfessors()
        {
            bool retBool = false;
            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Professors", connection);
                SqlDataReader reader = command.ExecuteReader();
                professors.Clear();
                while (reader.Read())
                {
                    Professor professor = new Professor(
                        reader.GetInt32(0),  // ProfessorID
                        reader.GetString(1), // FirstName
                        reader.GetString(2), // LastName
                        reader.GetString(3), // Email
                        reader.GetInt32(4)   // Password
                    );
                    professors.Add(professor);
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
        /// Method to find professor by id
        /// </summary>
        /// <param name="professorID"></param>
        /// <returns></returns>
        public static Professor FindProfessorById(int professorID)
        {
            foreach (Professor professor in professors)
            {
                if (professor.ProfessorID == professorID) return professor;
            }
            return null;
        }
        /// <summary>
        /// Method to return Professor by email and password
        /// </summary>
        /// <param name="email"></param>
        /// <param name="passKey"></param>
        /// <returns></returns>
        public static Professor GetProfessor(string email, int password)
        {
            foreach (Professor professor in professors)
            {
                if (professor.Email == email && professor.Password == password) return professor;
            }
            return null;
        }
        /// <summary>
        /// Method to find professor by email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static Professor FindProfessorByEmail(string email)
        {
            foreach (Professor professor in professors)
            {
                if (professor.Email == email) return professor;
            }
            return null;
        }
        /// <summary>
        /// Method to delete professor
        /// </summary>
        /// <param name="studentID"></param>
        /// <exception cref="Exception"></exception>
        public static bool DeleteProfessor(int professorID)
        {
            bool retBool = false;
            string sql = "spDeleteProfessor";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProfessorID", professorID);
                command.ExecuteNonQuery();
                FillProfessors();
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
        /// Non-Static Method to Set default values
        /// </summary>
        private void SetDefault()
        {
            FirstName = DEFAULT_FIRST_NAME;
            LastName = DEFAULT_LAST_NAME;
            Email = DEFAULT_EMAIL;
            Password = DEFAULT_PASSWORD;
        }
        /// <summary>
        /// Method that returns a custom string for a Professor
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Professor: {this.FirstName} {this.LastName} ({this.Email})";
        }
        /// <summary>
        /// Method to insert new Professor 
        /// </summary>
        /// <exception cref="Exception"></exception>
        public bool InsertProfessor()
        {
            bool retBool = false;
            string sql = "spInsertNewProfessor";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@ProfessorID", Tools.GetMaxID("Professors", "ProfessorID") + 1);
                command.Parameters.AddWithValue("@FirstName", this.FirstName);
                command.Parameters.AddWithValue("@LastName", this.LastName);
                command.Parameters.AddWithValue("@Email", this.Email);
                command.Parameters.AddWithValue("@Password", this.Password);
                command.ExecuteNonQuery();
                FillProfessors();
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
        /// Method to update Professor
        /// </summary>
        /// <exception cref="Exception"></exception>
        public bool UpdateProfessor()
        {
            bool retBool = false;
            string sql = "spUpdateProfessor";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@ProfessorID", this.ProfessorID);
                command.Parameters.AddWithValue("@FirstName", this.FirstName);
                command.Parameters.AddWithValue("@LastName", this.LastName);
                command.Parameters.AddWithValue("@Email", this.Email);
                command.Parameters.AddWithValue("@Password", this.Password);
                command.ExecuteNonQuery();
                FillProfessors();
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

    }
}
