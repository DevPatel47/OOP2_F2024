/*============================================================
 * Title    :   Assignment-6: Final Assignment
 * Name     :   Dev Mayurkumar Patel
 * Date     :   13 December 2024
 * Purpose  :   Professor Screen Form Class file
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
    /// Professor Screen Form Class method
    /// </summary>
    public partial class frmProfessorScreen : Form
    {
        /// <summary>
        /// Method to initialize form
        /// </summary>
        public frmProfessorScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// method to exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            MdiParent.Close();
        }
    }
}
