/*============================================================
 * Title    :   Assignment - 2 Battleship
 * Name     :   Dev Mayurkumar Patel
 * Date     :   11 October 2024
 * Purpose  :   Main Form file to run Battle Ship Game
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment02
{
    public partial class frmBattleShip : Form
    {
        public frmBattleShip()
        {
            InitializeComponent();
        }

        private void frmBattleShip_Load(object sender, EventArgs e)
        {
            CreateBoxes();
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {

        }

        private void CreateBoxes() 
        {
            int tabIndex = 2;
            for (int y = 0; y < Settings.DEF_NUMSQUARES; y++)
            {
                for (int x = 0; x < Settings.DEF_NUMSQUARES; x++)
                {
                    System.Windows.Forms.Button button = new System.Windows.Forms.Button();
                    button.BackColor = Color.FromArgb(100,0,0,0);
                    button.FlatStyle = FlatStyle.Flat;
                    button.Height = Settings.DEF_SQUARESIZE;
                    button.Width = Settings.DEF_SQUARESIZE;
                    button.TabIndex = tabIndex;
                    tabIndex++;
                    toolTip1.SetToolTip(button, "Click to Launch Missile here");
                    button.Anchor = AnchorStyles.None;

                    button.Top = Settings.DEF_TOPMARGIN + y * (Settings.DEF_SQUARESIZE + Settings.DEF_SPACE);
                    button.Left = Settings.DEF_LEFTMARGIN + x * (Settings.DEF_SQUARESIZE + Settings.DEF_SPACE);
                    

                    button.Click += new System.EventHandler(this.button_Click);

                    Settings.buttons[x, y] = button;
                    pan_GameWindow.Controls.Add(Settings.buttons[x, y]);

                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
        }

        private void btn_ShowBoats_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
