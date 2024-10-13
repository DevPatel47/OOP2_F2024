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
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment02.BS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Assignment02
{   
    /// <summary>
    /// Main Form Class
    /// </summary>
    public partial class frmBattleShip : Form
    {   
        /// <summary>
        /// Method to initialize game form
        /// </summary>
        public frmBattleShip()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to load game form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBattleShip_Load(object sender, EventArgs e)
        {
            CreateBoxes();
            SetDefault();
        }


        #region Default Methods
        /// <summary>
        /// Method to set default settings
        /// </summary>
        private void SetDefault()
        {
            ResetBoxes();
            ResetProgressBars();
            Settings.turnCount = 0;
            Settings.cruiserValue = 0;
            Settings.carrierValue = 0;
            Settings.battleshipValue = 0;
            Settings.destroyerValue = 0;
            Settings.submarineValue = 0;
            nud_BS_TurnTakenCount.Value = Settings.turnCount;
            cbo_LM_X.SelectedIndex = 0;
            cbo_LM_Y.SelectedIndex = 0;
            BS.ClearBoatPosition();
            BS.ClearBoardStatus();
            BS.RandomizeBoats();
        }
        #endregion


        #region Custom Methods

        /// <summary>
        /// Method to create game board
        /// </summary>
        private void CreateBoxes()
        {
            int tabIndex = 2;
            for (int y = 0; y < Settings.DEF_NUMSQUARES; y++)
            {
                for (int x = 0; x < Settings.DEF_NUMSQUARES; x++)
                {
                    System.Windows.Forms.Button button = new System.Windows.Forms.Button();
                    button.BackColor = Color.FromArgb(100, 0, 0, 0);
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

        /// <summary>
        /// Method to reset game boxes
        /// </summary>
        private void ResetBoxes()
        {
            foreach (System.Windows.Forms.Button button in Settings.buttons)
            {
                button.BackColor = Color.FromArgb(100, 0, 0, 0);
                button.Enabled = true;
            }
        }
        
        /// <summary>
        /// Method to reset progress bars
        /// </summary>
        private void ResetProgressBars()
        {
            pgb_BS_Battleship.Value = 0;
            pgb_BS_Carrier.Value = 0;
            pgb_BS_Cruiser.Value = 0;
            pgb_BS_Destroyer.Value = 0;
            pgb_BS_Submarine.Value = 0;
        }

        /// <summary>
        /// Method to check if the player won or not
        /// </summary>
        private void IsPlayerWon()
        {
            if (pgb_BS_Carrier.Value == 1 && pgb_BS_Battleship.Value == 1 && pgb_BS_Submarine.Value == 1
                && pgb_BS_Cruiser.Value == 1 && pgb_BS_Destroyer.Value == 1)
            {
                if (MessageBox.Show("You Won!!\nYou took " + Settings.turnCount + " turns to finish the game.\n\nDo you want to Start New Game?", "Result", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SetDefault();
                }
                else { Application.Exit(); }
            }
        }

        /// <summary>
        /// Method to check if the boat sunk or not
        /// </summary>
        private void IsBoatSunk()
        {
            if (Settings.carrierValue == 5) { pgb_BS_Carrier.Value = 1; }
            if (Settings.battleshipValue == 4) { pgb_BS_Battleship.Value = 1; }
            if (Settings.submarineValue == 3) { pgb_BS_Submarine.Value = 1; }
            if (Settings.cruiserValue == 3) { pgb_BS_Cruiser.Value = 1; }
            if (Settings.destroyerValue == 2) { pgb_BS_Destroyer.Value = 1; }
        }

        /// <summary>
        /// Method to call Launch missile method on click event
        /// </summary>
        /// <param name="btn"></param>
        private void ClickActions(System.Windows.Forms.Button btn)
        {
            if (btn.Enabled)
            {
                BS.LaunchMissile(btn);
                nud_BS_TurnTakenCount.Value = Settings.turnCount;
            }
            else { MessageBox.Show("Missile is already launched at this location. Try different location"); }
            IsBoatSunk();
            IsPlayerWon();
        }
        #endregion


        #region General Event Methods

        /// <summary>
        /// Method to start new game on the click or new game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            SetDefault();
        }

        /// <summary>
        /// Method to display boats on the click of show boat button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ShowBoats_Click(object sender, EventArgs e)
        {
            DisplayBoats();
        }

        /// <summary>
        /// Method to exit the program on the click of exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }

        /// <summary>
        /// Method to perform required action on the click of button or launching missile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            ClickActions(btn);
        }

        /// <summary>
        /// Method to perform required action on the click of launch button using coordinates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LM_Launch_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = Settings.buttons[cbo_LM_X.SelectedIndex, cbo_LM_Y.SelectedIndex];
            ClickActions(btn);

        }
        #endregion

    }
}
