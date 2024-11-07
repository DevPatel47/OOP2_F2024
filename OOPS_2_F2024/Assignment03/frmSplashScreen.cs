/*============================================================
 * Title    :   Assignment - 3 Dungeons and Dragons
 * Name     :   Dev Mayurkumar Patel
 * Date     :   22 October 2024
 * Purpose  :   Splash screen form file
 *===========================================================*/

using Assignment03.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment03
{
    /// <summary>
    /// Splash Screen Form Class
    /// </summary>
    public partial class frmSplashScreen : Form
    {
        /// <summary>
        /// Method to initialize Splash screen form
        /// </summary>
        public frmSplashScreen()
        {
            InitializeComponent();
            Classes.Class.PopulateClasses();
            Classes.Race.PopulateRaces();
        }

        #region General Event Methods

        /// <summary>
        /// Method to exit application on a click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }

        /// <summary>
        /// Method to open Main Form on a click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frm = new frmMain();
            frm.Show();
        }

        #endregion

    }

}

