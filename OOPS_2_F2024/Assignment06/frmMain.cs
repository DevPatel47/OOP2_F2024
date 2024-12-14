/*============================================================
 * Title    :   Assignment-6: Final Assignment
 * Name     :   Dev Mayurkumar Patel
 * Date     :   13 December 2024
 * Purpose  :   Main Form Class file
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
    /// Main Form Class method
    /// </summary>
    public partial class frmMain : Form
    {
        /// <summary>
        /// Method to initailize form
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            try
            {
                DBAL.Student.FillStudents();
                DBAL.Professor.FillProfessors();
                DBAL.Course.FillCourses();
                DBAL.Quiz.FillQuizzes();
                DBAL.Question.FillQuestions();
                DBAL.Enrollment.FillEnrollments();
                DBAL.QuizAttempt.FillQuizAttempts();
                DBAL.QuestionAttempt.FillQuestionAttempts();
            }
            catch
            {
                MessageBox.Show("Error while Loading Data, Please cleck your connection and try again!!", "Connection Error");
                Application.Exit();
            }
            SetDefaults();
        }

        #region Event Methods

        /// <summary>
        /// Method to load login screen for student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mns_uts_student_Click(object sender, EventArgs e)
        {
            Student.tempStudent = null;
            Professor.tempProfessor = null;

            frmLogin frmLogin = new frmLogin("student");
            frmLogin.ShowDialog();
            if (Student.tempStudent != null) 
            {
                if (ActiveMdiChild != null) ActiveMdiChild.Close();
                mns_studentView.Visible = true;
                mns_professorView.Visible = false;
                tls_tsl_userDetails.Text = Student.tempStudent.ToString();
                
            }
        }
        /// <summary>
        /// Method to load login screen for professor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mns_uts_professor_Click(object sender, EventArgs e)
        {
            
            Student.tempStudent = null;
            Professor.tempProfessor = null;

            frmLogin frmLogin = new frmLogin("professor");
            frmLogin.ShowDialog();
            if (Professor.tempProfessor != null)
            {
                if (ActiveMdiChild != null) ActiveMdiChild.Close();
                mns_professorView.Visible = true;
                mns_studentView.Visible = false;
                tls_tsl_userDetails.Text = Professor.tempProfessor.ToString();
                frmProfessorScreen frmProfessorScreen = new frmProfessorScreen();
                frmProfessorScreen.MdiParent = this;
                frmProfessorScreen.Dock = DockStyle.Fill;
                frmProfessorScreen.Show();

            }
        }
        /// <summary>
        /// Method to exit application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tls_tsb_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }
        /// <summary>
        /// Method to log out student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mns_sv_logOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Logout?", "Logout Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SetDefaults();
            }
        }
        /// <summary>
        /// Method to set defaults
        /// </summary>
        private void SetDefaults() 
        {
            
            Student.tempStudent = null;
            Professor.tempProfessor = null;
            mns_professorView.Visible = false;
            mns_studentView.Visible = false;
            tls_tsl_userDetails.Text = "";
            
        }
        /// <summary>
        /// method to load courses screen 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mns_sv_courses_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            frmStudentCourse frmStudentCourse = new frmStudentCourse();
            frmStudentCourse.MdiParent = this;
            frmStudentCourse.Dock = DockStyle.Fill;
            frmStudentCourse.Show();
        }
        /// <summary>
        /// method to load quizzes screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mns_sv_quizzes_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            frmStudentQuizzes frmStudentQuizzes = new frmStudentQuizzes(null);
            frmStudentQuizzes.MdiParent = this;
            frmStudentQuizzes.Dock = DockStyle.Fill;
            frmStudentQuizzes.Show();
        }
        /// <summary>
        /// method to load grades screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mns_sv_grades_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            frmStudentGrades frmStudentGrades = new frmStudentGrades();
            frmStudentGrades.MdiParent = this;
            frmStudentGrades.Dock = DockStyle.Fill;
            frmStudentGrades.Show();
        }
        /// <summary>
        /// Form load method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmSplashScreen frm = new frmSplashScreen(this);
            frm.ShowDialog();
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            frmCommonScreen frmCommonScreen = new frmCommonScreen();
            frmCommonScreen.MdiParent = this;
            frmCommonScreen.Dock = DockStyle.Fill;
            frmCommonScreen.Show();

        }
        /// <summary>
        /// Method to log out professor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mns_pv_logOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Logout?", "Logout Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SetDefaults();
            }
        }

        #endregion

    }
}
