/*============================================================
 * Title    :   Assignment-6: Final Assignment
 * Name     :   Dev Mayurkumar Patel
 * Date     :   10 December 2024
 * Purpose  :   Enrollment Class file
 *===========================================================*/

using Assignment06.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DBAL
{
    /// <summary>
    /// Enrollment Class
    /// </summary>
    public class Enrollment
    {

        #region Static List

        // A List to store all enrollments
        public static List<Enrollment> enrollments = new List<Enrollment>();

        #endregion

        #region Properties

        /// <summary>
        /// Represents EnrollmentID property of Enrollment class with getter and setter
        /// </summary>
        private int _enrollmentID;
        public int EnrollmentID
        {
            get { return _enrollmentID; }
            set
            {
                bool isUnique = true;
                foreach (Enrollment enrollment in enrollments)
                {
                    if (value == enrollment.EnrollmentID) { isUnique = false; }
                }
                if (isUnique)
                {
                    if (value > 0)
                    {
                        _enrollmentID = value;
                    }
                    else throw new Exception("Enrollment ID must be a positive number");
                }
                else throw new Exception("Provided Enrollment ID is not Unique");
            }
        }

        /// <summary>
        /// Represents StudentID property of Enrollment class with getter and setter
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
        /// Represents CourseID property of Enrollment class with getter and setter
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
                    throw new Exception("Course ID must be an 8-character string.");
                }
            }
        }

        #endregion

        #region Constructors
        public Enrollment(int studentID, string courseID) 
        {
            StudentID = studentID;
            CourseID = courseID;
        }
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        public Enrollment(int enrollmentID, int studentID, string courseID)
        {
            EnrollmentID = enrollmentID;
            StudentID = studentID;
            CourseID = courseID;
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Method to fill enrollments list from database
        /// </summary>
        public static bool FillEnrollments()
        {
            bool retBool = false;
            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Enrollments", connection);
                SqlDataReader reader = command.ExecuteReader();
                enrollments.Clear();
                while (reader.Read())
                {
                    Enrollment enrollment = new Enrollment(
                        reader.GetInt32(0),  // EnrollmentID
                        reader.GetInt32(1),  // StudentID
                        reader.GetString(2)  // CourseID
                    );
                    enrollments.Add(enrollment);
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
        /// Method to find an enrollment by EnrollmentID
        /// </summary>
        /// <param name="enrollmentID"></param>
        /// <returns></returns>
        public static Enrollment FindEnrollmentById(int enrollmentID)
        {
            foreach (Enrollment enrollment in enrollments)
            {
                if (enrollment.EnrollmentID == enrollmentID) return enrollment;
            }
            return null;
        }

        /// <summary>
        /// Method to delete an enrollment
        /// </summary>
        public static bool DeleteEnrollment(int enrollmentID)
        {
            bool retBool = false;
            string sql = "spDeleteEnrollment";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@EnrollmentID", enrollmentID);
                command.ExecuteNonQuery();
                FillEnrollments();
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
        /// Method to insert a new enrollment
        /// </summary>
        public bool InsertEnrollment()
        {
            bool retBool = false;
            string sql = "spInsertNewEnrollment";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@EnrollmentID", Tools.GetMaxID("Enrollments", "EnrollmentID") + 1);
                command.Parameters.AddWithValue("@StudentID", this.StudentID);
                command.Parameters.AddWithValue("@CourseID", this.CourseID);
                command.ExecuteNonQuery();
                FillEnrollments();
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
        /// Method to update an existing enrollment
        /// </summary>
        public bool UpdateEnrollment()
        {
            bool retBool = false;
            string sql = "spUpdateEnrollment";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@EnrollmentID", this.EnrollmentID);
                command.Parameters.AddWithValue("@StudentID", this.StudentID);
                command.Parameters.AddWithValue("@CourseID", this.CourseID);
                command.ExecuteNonQuery();
                FillEnrollments();
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
        /// Returns a custom string for an enrollment
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Enrollment ID: {this.EnrollmentID}, Student ID: {this.StudentID}, Course ID: {this.CourseID}";
        }

        #endregion

    }
}
