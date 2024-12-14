/*============================================================
 * Title    :   Assignment-6: Final Assignment
 * Name     :   Dev Mayurkumar Patel
 * Date     :   13 December 2024
 * Purpose  :   Common Screen Form Class file
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
    /// Common Screen Form Class method
    /// </summary>
    public partial class frmCommonScreen : Form
    {
        /// <summary>
        /// Method to initailize common screen
        /// </summary>
        public frmCommonScreen()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Method to close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) this.MdiParent.Close();
        }

    }
}
