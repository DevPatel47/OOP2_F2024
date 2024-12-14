/*============================================================
 * Title    :   Assignment-6: Final Assignment
 * Name     :   Dev Mayurkumar Patel
 * Date     :   13 December 2024
 * Purpose  :   Common Screen Form Class file
 *===========================================================*/

using Assignment06.Properties;
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
using System.Xml.Linq;

namespace Assignment06
{
    /// <summary>
    /// Login form class method
    /// </summary>
    public partial class frmLogin : Form
    {
        private string userType;
        /// <summary>
        /// Method to initailize form
        /// </summary>
        public frmLogin(string tempUserType)
        {
            userType = tempUserType;
            InitializeComponent();
        }

        #region Event Methods

        /// <summary>
        /// Method to login user on click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = null;
                Professor professor = null;
                if (userType == "student")
                {
                    student = Student.GetStudent(tbx_email.Text.Trim(), int.Parse(tbx_password.Text.Trim()));
                }
                else if (userType == "professor") 
                {
                    professor = Professor.GetProfessor(tbx_email.Text.Trim(), int.Parse(tbx_password.Text.Trim()));
                }
                if (student != null)
                {
                    Student.tempStudent = student;
                    this.Close();
                }
                else if (professor != null)
                {
                    Professor.tempProfessor = professor;
                    this.Close();
                }
                else if (student == null && professor == null) 
                {
                    MessageBox.Show("Invalid Email and Password, Please Try Again!!", "Invalid Credentials");
                    tbx_email.Text = "";
                    tbx_password.Text = "";
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                tbx_email.Text = "";
                tbx_password.Text = "";
            }


        }
        /// <summary>
        /// Method to exit on click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        #endregion

    }
}
