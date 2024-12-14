/*============================================================
 * Title    :   Assignment-6: Final Assignment
 * Name     :   Dev Mayurkumar Patel
 * Date     :   13 December 2024
 * Purpose  :   Courses Screen Form Class file
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
    /// Courses Screen Form Class method
    /// </summary>
    public partial class frmStudentCourse : Form
    {
        /// <summary>
        /// method to initailize form
        /// </summary>
        public frmStudentCourse()
        {
            InitializeComponent();
        }
        /// <summary>
        /// form load event method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStudentCourse_Load(object sender, EventArgs e)
        {
            this.studentCoursesTableAdapter.Fill(this.dts_StudentCourses.StudentCourses, Student.tempStudent.StudentID);

        }
        /// <summary>
        /// method to close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// method to load quizzes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_viewQuizzes_Click(object sender, EventArgs e)
        {
            frmStudentQuizzes frmStudentQuizzes = new frmStudentQuizzes(null);
            frmStudentQuizzes.MdiParent = this.MdiParent;
            frmStudentQuizzes.Dock = DockStyle.Fill;
            frmStudentQuizzes.Show();
            this.Close();
        }
    }
}
