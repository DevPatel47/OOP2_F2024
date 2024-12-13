using DBAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment06.Properties;

namespace Assignment06
{
    public partial class frmMain : Form
    {
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
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           

        }
    }
}
