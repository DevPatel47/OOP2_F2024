/*============================================================
 * Title    :   Assignment-6: Final Assignment
 * Name     :   Dev Mayurkumar Patel
 * Date     :   13 December 2024
 * Purpose  :   Splash Screen Form Class file
 *===========================================================*/

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
    /// Splash Screen Form Class method
    /// </summary>
    public partial class frmSplashScreen : Form
    {
        private frmMain frmMain;
        /// <summary>
        /// method to initialize form
        /// </summary>
        /// <param name="tempFrmMain"></param>
        public frmSplashScreen(frmMain tempFrmMain)
        {
            InitializeComponent();
            frmMain = tempFrmMain;
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
            frmMain.Show();
            this.Close();

        }
    }
}
