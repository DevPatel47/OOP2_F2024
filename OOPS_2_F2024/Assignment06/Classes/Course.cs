/*============================================================
 * Title    :   Assignment-6: Final Assignment
 * Name     :   Dev Mayurkumar Patel
 * Date     :   10 December 2024
 * Purpose  :   Course Class file
 *===========================================================*/

using Assignment06.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DBAL
{
    /// <summary>
    /// Course Class
    /// </summary>
    public class Course
    {

        #region Default Values

        private const string DEFAULT_NAME = "Unknown Course";

        #endregion

        #region Static List

        // A List to store all courses
        public static List<Course> courses = new List<Course>();

        #endregion

        #region Properties

        /// <summary>
        /// Represents CourseID property of Course class with getter and setter
        /// </summary>
        private string _courseID;
        public string CourseID
        {
            get { return _courseID; }
            set
            {
                if (value.Trim().Length == 8)
                {
                    _courseID = value.Trim();
                }
                else
                {
                    throw new Exception("Course ID must be an 8-character string.");
                }
            }
        }

        /// <summary>
        /// Represents ProfessorID property of Course class with getter and setter
        /// </summary>
        private int _professorID;
        public int ProfessorID
        {
            get { return _professorID; }
            set
            {
                if (Professor.FindProfessorById(value) != null)
                {
                    _professorID = value;
                }
                else
                {
                    throw new Exception("Professor ID must reference an existing Professor.");
                }
            }
        }

        /// <summary>
        /// Represents Name property of Course class with getter and setter
        /// </summary>
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Trim().Length >= 2 && value.Trim().Length <= 50)
                {
                    _name = value.Trim();
                }
                else
                {
                    throw new Exception("Course name must be non-empty and up to 50 characters.");
                }
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Course()
        {
            SetDefault();
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="courseID"></param>
        /// <param name="professorID"></param>
        /// <param name="name"></param>
        public Course(string courseID, int professorID, string name)
        {
            CourseID = courseID;
            ProfessorID = professorID;
            Name = name;
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Method to fill courses list from database
        /// </summary>
        public static bool FillCourses()
        {
            bool retBool = false;
            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Courses", connection);
                SqlDataReader reader = command.ExecuteReader();
                courses.Clear();
                while (reader.Read())
                {
                    Course course = new Course(
                        reader.GetString(0), // CourseID
                        reader.GetInt32(1),  // ProfessorID
                        reader.GetString(2)  // Name
                    );
                    courses.Add(course);
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
        /// Method to find a course by CourseID
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public static Course FindCourseById(string courseID)
        {
            foreach (Course course in courses)
            {
                if (course.CourseID == courseID) return course;
            }
            return null;
        }
        /// <summary>
        /// Method to delete a course
        /// </summary>
        public static bool DeleteCourse(string courseID)
        {
            bool retBool = false;
            string sql = "spDeleteCourse";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@CourseID", courseID);
                command.ExecuteNonQuery();
                FillCourses();
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
        }

        /// <summary>
        /// Method to insert a new course
        /// </summary>
        public bool InsertCourse()
        {
            bool retBool = false;
            string sql = "spInsertNewCourse";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@CourseID", Tools.RandomUniqueCourseCode(courses));
                if (this.ProfessorID == -1) 
                {
                    command.Parameters.AddWithValue("@ProfessorID", null);
                }
                else { command.Parameters.AddWithValue("@ProfessorID", this.ProfessorID); }
                command.Parameters.AddWithValue("@Name", this.Name);
                command.ExecuteNonQuery();
                FillCourses();
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
        /// Method to update an existing course
        /// </summary>
        public bool UpdateCourse()
        {
            bool retBool = false;
            string sql = "spUpdateCourse";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@CourseID", this.CourseID);
                if (this.ProfessorID == -1)
                {
                    command.Parameters.AddWithValue("@ProfessorID", null);
                }
                else { command.Parameters.AddWithValue("@ProfessorID", this.ProfessorID); }
                command.Parameters.AddWithValue("@Name", this.Name);
                command.ExecuteNonQuery();
                FillCourses();
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
        /// Returns a custom string for a course
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Course: {this.Name} (ID: {this.CourseID}), Professor ID: {this.ProfessorID}";
        }

        #endregion

    }
}
