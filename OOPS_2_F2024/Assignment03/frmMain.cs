/*============================================================
 * Title    :   Assignment - 3 Dungeons and Dragons
 * Name     :   Dev Mayurkumar Patel
 * Date     :   22 October 2024
 * Purpose  :   Main screen form file
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            SetDefaults();
        }

        private void SetDefaults()
        {
            foreach (Character character in Classes.Character.characters)
            {
                cbo_Characters.Items.Add(character.Name);
            }
        }

        private void SetCharacterDetails()
        {
            tbx_CharacterDetails.Text = Classes.Character.ShowCharacterDetails(cbo_Characters.SelectedItem.ToString());
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }

        private void cbo_Characters_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCharacterDetails();
        }
    }
}
