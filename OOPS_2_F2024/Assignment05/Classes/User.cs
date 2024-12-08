/*============================================================
 * Title    :   Assignment 5: Data Storage - Video Game Reviews
 * Name     :   Dev Mayurkumar Patel
 * Date     :   5 December 2024
 * Purpose  :   User Class file
 *===========================================================*/

using Assignment05.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBAL
{
    /// <summary>
    /// User Class Method
    /// </summary>
    public class User
    {

        #region Default Values

        private const string DEFAULT_FIRST_NAME = "Unknown";
        private const string DEFAULT_LAST_NAME = "Unknown";
        private const string DEFAULT_EMAIL = "noemail@example.com";
        private const int DEFAULT_PASSKEY = 1000;

        #endregion


        #region Static List

        // A List to store all users
        public static List<User> users = new List<User>();

        #endregion


        #region Properties

        /// <summary>
        /// Represents UserID property of User class with getter and setter
        /// </summary>
        private int _userID;
        public int UserID
        {
            get { return _userID; }
            set
            {
                Boolean isUnique = true;
                foreach (User user in users)
                {
                    if (value == user.UserID) { isUnique = false; }
                }
                if (isUnique)
                {
                    if (value > 0)
                    {
                        _userID = value;
                    }
                    else throw new Exception("User ID must be a positive number");
                }
                else throw new Exception("Provided User ID is not Unique");
            }
        }
        /// <summary>
        /// Represents FirstName property of User class with getter and setter
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
        /// Represents LastName property of User class with getter and setter
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
        /// Represents Email property of User class with getter and setter
        /// </summary>
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                Boolean isUnique = true;
                foreach (User user in users)
                {
                    if (value == user.Email) { isUnique = false; }
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
        /// Represents PassKey property of User class with getter and setter
        /// </summary>
        private int _passKey;
        public int PassKey
        {
            get { return _passKey; }
            set
            {
                if (value >= 1000 && value <= 9999)
                {
                    _passKey = value;
                }
                else
                {
                    throw new Exception("PassKey must be a 4-digit number between 1000 and 9999.");
                }
            }
        }

        #endregion


        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public User()
        {
            SetDefault();
        }
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="passKey"></param>
        public User(int userID, string firstName, string lastName, string email, int passKey)
        {
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PassKey = passKey;
        }

        #endregion


        #region Non-static method to set the default values using constants

        /// <summary>
        /// Non-Static Method to Set default values
        /// </summary>
        private void SetDefault()
        {
            FirstName = DEFAULT_FIRST_NAME;
            LastName = DEFAULT_LAST_NAME;
            Email = DEFAULT_EMAIL;
            PassKey = DEFAULT_PASSKEY;
        }

        #endregion


        #region Static method

        /// <summary>
        /// Method to fill games list from database
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void FillUsers()
        {
            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);

            try
            {
                connection.Open();
                SqlCommand command;

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Users";
                command.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                users.Clear();
                while (reader.Read())
                {
                    User user = new User(
                        reader.GetInt32(0),  // UserID
                        reader.GetString(1), // FirstName
                        reader.GetString(2), // LastName
                        reader.GetString(3), // Email
                        reader.GetInt32(4)   // PassKey
                    );
                    users.Add(user);
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
        }
        /// <summary>
        /// Method to find User BY id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static User FindUserById(int userId)
        {
            foreach (User user in users)
            {
                if (user.UserID == userId) return user;
            }
            return null;
        }
        /// <summary>
        /// Method to find user by email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static User FindUserByEmail(string email)
        {
            foreach (User user in users)
            {
                if (user.Email == email) return user;
            }
            return null;
        }
        /// <summary>
        /// Method to delete user
        /// </summary>
        /// <param name="userID"></param>
        /// <exception cref="Exception"></exception>
        public static void DeleteUser(int userID)
        {
            string sql = "spDeleteUser";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", userID);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                FillUsers();
                connection.Close();
            }
        }
        /// <summary>
        /// Method to return user by email and passkey
        /// </summary>
        /// <param name="email"></param>
        /// <param name="passKey"></param>
        /// <returns></returns>
        public static User GetUser(string email, int passKey)
        {
            foreach (User user in users)
            {
                if (user.Email == email && user.PassKey == passKey) return user;
            }
            return null;
        }

        #endregion


        #region Instance methods

        /// <summary>
        /// Method to insert new user 
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void InsertUser()
        {
            string sql = "spInsertNewUser";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@userID", Tools.GetMaxID("Users", "UserID") + 1);
                command.Parameters.AddWithValue("@firstName", this.FirstName);
                command.Parameters.AddWithValue("@lastName", this.LastName);
                command.Parameters.AddWithValue("@email", this.Email);
                command.Parameters.AddWithValue("@passKey", this.PassKey);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                FillUsers();
                connection.Close();
            }

        }
        /// <summary>
        /// Method to update user
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void UpdateUser()
        {
            string sql = "spUpdateUser";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@userID", this.UserID);
                command.Parameters.AddWithValue("@firstName", this.FirstName);
                command.Parameters.AddWithValue("@lastName", this.LastName);
                command.Parameters.AddWithValue("@email", this.Email);
                command.Parameters.AddWithValue("@passKey", this.PassKey);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                FillUsers();
                connection.Close();
            }

        }
        /// <summary>
        /// Method that returns a custom string for a user
        /// </summary>
        /// <returns></returns>
        public override string ToString() 
        {
            string retString = string.Empty;
            retString = $"{this.FirstName} {this.LastName} ({this.Email})";
            return retString;
        }

        #endregion

    }
}
