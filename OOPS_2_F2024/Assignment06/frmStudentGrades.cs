/*============================================================
 * Title    :   Assignment-6: Final Assignment
 * Name     :   Dev Mayurkumar Patel
 * Date     :   13 December 2024
 * Purpose  :   Grades Screen Form Class file
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
    /// Grades Screen Form Class method
    /// </summary>
    public partial class frmStudentGrades : Form
    {
        /// <summary>
        /// method to initialize form
        /// </summary>
        public frmStudentGrades()
        {
            InitializeComponent();
        }
        /// <summary>
        /// method to load quizzes on combobox change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_quizzes_selectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_quizzes_selectCourse.SelectedItem != null)
            {
                try
                {
                    string courseValue = cbo_quizzes_selectCourse.SelectedValue.ToString();
                    this.studentGradeTableAdapter.Fill(this.dts_Student_Grades.StudentGrade, Student.tempStudent.StudentID, courseValue);
                }
                catch { MessageBox.Show("Invalid Course Code"); }
            }
        }
        /// <summary>
        /// method to load courses form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_viewCourses_Click(object sender, EventArgs e)
        {
            frmStudentCourse frmStudentCourse = new frmStudentCourse();
            frmStudentCourse.MdiParent = this.MdiParent;
            frmStudentCourse.Dock = DockStyle.Fill;
            frmStudentCourse.Show();
            this.Close();
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
        /// form load event method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStudentGrades_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dts_Student_Grades.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.dts_Student_Grades.Courses);

        }
    }
}
