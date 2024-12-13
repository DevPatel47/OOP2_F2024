/*============================================================
 * Title    :   Assignment 5: Data Storage - Video Game Reviews
 * Name     :   Dev Mayurkumar Patel
 * Date     :   5 December 2024
 * Purpose  :   Login form class file
 *===========================================================*/

using Assignment06.Properties;
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

        #endregion

    }
}
