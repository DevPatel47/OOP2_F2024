/*============================================================
 * Title    :   Assignment 5: Data Storage - Video Game Reviews
 * Name     :   Dev Mayurkumar Patel
 * Date     :   5 December 2024
 * Purpose  :   Registration form class file
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

namespace Assignment05
{
    /// <summary>
    /// Registration form class method
    /// </summary>
    public partial class frmRegistration : Form
    {
        // Stores login form
        private frmLogin frmLogin;
        /// <summary>
        /// Method to initialize form
        /// </summary>
        /// <param name="tempFrmLogin"></param>
        public frmRegistration(frmLogin tempFrmLogin)
        {
            InitializeComponent();
            frmLogin = tempFrmLogin;
        }

        #region Event Methods

        /// <summary>
        /// Method to close form on click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin.Show();
        }
        /// <summary>
        /// Method to register user on click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_register_Click(object sender, EventArgs e)
        {
            DBAL.User user = new DBAL.User();
            try
            {
                user.FirstName = tbx_firstName.Text;
                user.LastName = tbx_lastName.Text;
                user.Email = tbx_email.Text;
                user.PassKey = int.Parse(tbx_password.Text);
                user.InsertUser();
                MessageBox.Show("User Successfully Added", "Registration Complete");
                this.Close();
                frmLogin.Show();
            }
            catch
            {
                MessageBox.Show("Provided values are not valid, Please try again!!", "Invalid Values");
                tbx_firstName.Text = "";
                tbx_lastName.Text = "";
                tbx_email.Text = "";
                tbx_password.Text = "";
            }
            finally
            {
                User.FillUsers();
            }
        }

        #endregion

    }
}
