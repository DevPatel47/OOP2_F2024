/*============================================================
 * Title    :   Assignment-6: Final Assignment
 * Name     :   Dev Mayurkumar Patel
 * Date     :   13 December 2024
 * Purpose  :   Quizzes Screen Form Class file
 *===========================================================*/

using DBAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment06
{
    /// <summary>
    /// Quizzes Screen Form Class method
    /// </summary>
    public partial class frmStudentQuizzes : Form
    {
        private string courseCode;
        /// <summary>
        /// method to initialize form
        /// </summary>
        /// <param name="tempCourseCode"></param>
        public frmStudentQuizzes(string tempCourseCode)
        {
            courseCode = tempCourseCode;
            InitializeComponent();
        }
        /// <summary>
        /// form load event method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStudentQuizzes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dts_quizzes.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.dts_quizzes.Courses);
            if (courseCode != null) 
            {
                cbo_selectCourse.SelectedValue = courseCode;
            }

        }
        /// <summary>
        /// method to load quiz list on combobox change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_quizzes_selectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_selectCourse.SelectedItem != null)
            {
                try
                {
                    string courseValue = cbo_selectCourse.SelectedValue.ToString();
                    this.courseQuizzesTableAdapter.Fill(this.dts_quizzes.CourseQuizzes, courseValue, Student.tempStudent.StudentID);
                }
                catch { MessageBox.Show("Invalid Course Code"); }
            }
        }
        /// <summary>
        /// method to close application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// method to load grades form on click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_viewGrades_Click(object sender, EventArgs e)
        {
            frmStudentGrades frmStudentGrades = new frmStudentGrades();
            frmStudentGrades.MdiParent = this.MdiParent;
            frmStudentGrades.Dock = DockStyle.Fill;
            frmStudentGrades.Show();
            this.Close();
        }
    }
}
