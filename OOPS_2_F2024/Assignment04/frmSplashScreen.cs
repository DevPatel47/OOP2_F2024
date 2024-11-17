/*============================================================
 * Title    :   Assignment 4: File IO and Exception Handling
 * Name     :   Dev Mayurkumar Patel
 * Date     :   15 November 2024
 * Purpose  :   Splash Screen form file
 *===========================================================*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment04
{
    /// <summary>
    /// Splash Screen Form Class
    /// </summary>
    public partial class frmSplashScreen : Form
    {
        // Stores Main Form
        private frmMainScreen frmMainScreen;
        /// <summary>
        /// Method to initoalize Splash Screen Form
        /// </summary>
        /// <param name="frmMain"></param>
        public frmSplashScreen(frmMainScreen frmMain)
        {
            InitializeComponent();
            frmMainScreen = frmMain;
            Timer MyTimer = new Timer();
            MyTimer.Interval = (5000);
            MyTimer.Tick += new EventHandler(timer1_Tick);
            MyTimer.Start();
        }
        /// <summary>
        /// Event Method to close form in 5 secs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            frmMainScreen.Show();
            this.Close();

        }

    }
}
