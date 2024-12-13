/*============================================================
 * Title    :   Assignment-6: Final Assignment
 * Name     :   Dev Mayurkumar Patel
 * Date     :   10 December 2024
 * Purpose  :   Student Class File
 *===========================================================*/

using Assignment06.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DBAL
{
    /// <summary>
    /// Student Class Method
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Stores Current User
        /// </summary>
        public static Student student;

        #region Default Values

        private const string DEFAULT_FIRST_NAME = "FirstName";
        private const string DEFAULT_LAST_NAME = "LastName";
        private const string DEFAULT_EMAIL = "email@example.com";
        private const int DEFAULT_PASSWORD = 1000;

        #endregion

        #region Static List

        // A List to store all students
        public static List<Student> students = new List<Student>();

        #endregion

        #region Properties

        /// <summary>
        /// Represents StudentID property of Student class with getter and setter
        /// </summary>
        private int _studentID;
        public int StudentID
        {
            get { return _studentID; }
            set
            {
                Boolean isUnique = true;
                foreach (Student student in students)
                {
                    if (value == student.StudentID) { isUnique = false; }
                }
                if (isUnique)
                {
                    if (value > 0)
                    {
                        _studentID = value;
                    }
                    else throw new Exception("Student ID must be a positive number");
                }
                else throw new Exception("Provided Student ID is not Unique");
            }
        }
        /// <summary>
        /// Represents FirstName property of Student class with getter and setter
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
        /// Represents LastName property of Student class with getter and setter
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
        /// Represents Email property of Student class with getter and setter
        /// </summary>
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                Boolean isUnique = true;
                foreach (Student student in students)
                {
                    if (value == student.Email) { isUnique = false; }
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
        /// Represents Password property of Student class with getter and setter
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
        public Student()
        {
            SetDefaultValues();
        }
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public Student(int studentID, string firstName, string lastName, string email, int password)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Method to fill students list from database
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static bool FillStudents()
        {
            bool retBool = false;
            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Students", connection);
                SqlDataReader reader = command.ExecuteReader();
                students.Clear();
                while (reader.Read())
                {
                    Student student = new Student(
                        reader.GetInt32(0), // StudentID
                        reader.GetString(1), // FirstName
                        reader.GetString(2), // LastName
                        reader.GetString(3), // Email
                        reader.GetInt32(4) // Password
                    );
                    students.Add(student);
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
        /// Method to find Student by id
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public static Student FindStudentById(int studentID)
        {
            foreach (Student student in students)
            {
                if (student.StudentID == studentID) return student;
            }
            return null;
        }
        /// <summary>
        /// Method to find Student by email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static Student FindStudentByEmail(string email)
        {
            foreach (Student student in students)
            {
                if (student.Email == email) return student;
            }
            return null;
        }
        /// <summary>
        /// Method to return student by email and password
        /// </summary>
        /// <param name="email"></param>
        /// <param name="passKey"></param>
        /// <returns></returns>
        public static Student GetStudent(string email, int password)
        {
            foreach (Student student in students)
            {
                if (student.Email == email && student.Password == password) return student;
            }
            return null;
        }
        /// <summary>
        /// Method to delete Student
        /// </summary>
        /// <param name="studentID"></param>
        /// <exception cref="Exception"></exception>
        public static bool DeleteStudent(int studentID)
        {
            bool retBool = false;
            string sql = "spDeleteStudent";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StudentID", studentID);
                command.ExecuteNonQuery();
                FillStudents();
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

        #region Non-static Methods

        /// <summary>
        /// Non-Static Method to Set default values
        /// </summary>
        private void SetDefaultValues()
        {
            FirstName = DEFAULT_FIRST_NAME;
            LastName = DEFAULT_LAST_NAME;
            Email = DEFAULT_EMAIL;
            Password = DEFAULT_PASSWORD;
        }
        /// <summary>
        /// Method that returns a custom string for a Student
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Student: {FirstName} {LastName} ({Email})";
        }
        /// <summary>
        /// Method to insert new student 
        /// </summary>
        /// <exception cref="Exception"></exception>
        public bool InsertStudent()
        {
            bool retBool = false;
            string sql = "spInsertNewStudent";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@studentID", Tools.GetMaxID("Students", "studentID") + 1);
                command.Parameters.AddWithValue("@firstName", this.FirstName);
                command.Parameters.AddWithValue("@lastName", this.LastName);
                command.Parameters.AddWithValue("@email", this.Email);
                command.Parameters.AddWithValue("@password", this.Password);
                command.ExecuteNonQuery();
                FillStudents();
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
        /// Method to update student
        /// </summary>
        /// <exception cref="Exception"></exception>
        public bool UpdateStudent()
        {
            bool retBool = false;
            string sql = "spUpdateStudent";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@studentID", this.StudentID);
                command.Parameters.AddWithValue("@firstName", this.FirstName);
                command.Parameters.AddWithValue("@lastName", this.LastName);
                command.Parameters.AddWithValue("@email", this.Email);
                command.Parameters.AddWithValue("@Password", this.Password);
                command.ExecuteNonQuery();
                FillStudents();
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
