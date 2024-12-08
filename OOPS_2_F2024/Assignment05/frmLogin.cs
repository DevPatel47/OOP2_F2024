/*============================================================
 * Title    :   Assignment 5: Data Storage - Video Game Reviews
 * Name     :   Dev Mayurkumar Patel
 * Date     :   5 December 2024
 * Purpose  :   Login form class file
 *===========================================================*/

using Assignment05.Properties;
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

namespace Assignment05
{
    /// <summary>
    /// Login form class method
    /// </summary>
    public partial class frmLogin : Form
    {
        // Stores Main Form
        private frmMain frmMain;
        /// <summary>
        /// Method to initailize form
        /// </summary>
        /// <param name="tempFrmMain"></param>
        public frmLogin(frmMain tempFrmMain)
        {
            InitializeComponent();
            frmMain = tempFrmMain;
        }

        #region Event Methods

        /// <summary>
        /// Method to login user on click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_login_Click(object sender, EventArgs e)
        {
            int outputCount = 0;
            String sql = "SELECT COUNT(userID) FROM Users WHERE Email = @Email AND PassKey = @PassKey";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command;

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.AddWithValue("@Email", tbx_email.Text.Trim());
                command.Parameters.AddWithValue("@PassKey", int.Parse(tbx_password.Text.Trim()));
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                outputCount = reader.GetInt32(0);

                if (outputCount == 0)
                {
                    MessageBox.Show("Invalid Email and Password, Please Try Again!!", "Invalid Credentials");
                    tbx_email.Text = "";
                    tbx_password.Text = "";
                }
                else if (outputCount == 1)
                {
                    frmMain.user = DBAL.User.FindUserByEmail(tbx_email.Text.Trim().ToLower());
                    this.Close();
                    frmMain.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Email and Password, Please Try Again!!", "Invalid Credentials");
                tbx_email.Text = "";
                tbx_password.Text = "";
            }
            finally
            {
                connection.Close();
            }


        }
        /// <summary>
        /// Method to exit on click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Method to load registration form on click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistration frmRegistration = new frmRegistration(this);
            frmRegistration.ShowDialog();
        }

        #endregion

    }
}
