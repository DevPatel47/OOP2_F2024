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
    public partial class frmSplashScreen : Form
    {
        private frmMainScreen frmMainScreen;

        public frmSplashScreen(frmMainScreen frmMain)
        {
            InitializeComponent();
            frmMainScreen = frmMain;
            Timer MyTimer = new Timer();
            MyTimer.Interval = (5000);
            MyTimer.Tick += new EventHandler(timer1_Tick);
            MyTimer.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            frmMainScreen.Show();
            this.Close();

        }
    }
}
