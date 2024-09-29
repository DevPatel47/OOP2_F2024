/*============================================================
 * Title    :   Assignment - 1 Tic-Tac-Toe
 * Name     :   Dev Mayurkumar Patel
 * Date     :   27 September 2024
 * Purpose  :   Main Form file to run Tic-Tac-Toe game
 *===========================================================*/

using System.Diagnostics.Eventing.Reader;

namespace Assignment01
{
    
    public partial class frmMain : Form
    {
        /// <summary>
        /// Main form constructor
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        #region Set Defaults

        /// <summary>
        /// Method to initialize main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            SetDefaults();
            CreateBoard();
        }

        /// <summary>
        /// Method to set Default setting of Game
        /// </summary>
        private void SetDefaults()
        {
            pan_StartWindow.Visible = true;
            pan_StartWindow.Focus();
            pan_GameWindow.Visible = false;
            pan_ResultWindow.Visible = false;
            tbx_SW_Player01.Text = Settings.DEF_PLAYER_1_NAME;
            tbx_SW_Player02.Text = Settings.DEF_PLAYER_2_NAME;
            rdb_SW_X.Checked = true;
            lbl_GW_X_Score.Text = Settings.scoreOfPlayer_X.ToString();
            lbl_GW_O_Score.Text = Settings.scoreOfPlayer_O.ToString();
            Settings.isPlayer_X = true;
        }

        #endregion

        #region Custom Methods

        /// <summary>
        /// Method to set player names, signs and turns
        /// </summary>
        private void setPlayers()
        {
            if (rdb_SW_X.Checked)
            {
                Settings.nameOfPlayer_X = tbx_SW_Player01.Text;
                Settings.nameOfPlayer_O = tbx_SW_Player02.Text;
            }
            else if (rdb_SW_O.Checked)
            {
                Settings.nameOfPlayer_O = tbx_SW_Player01.Text;
                Settings.nameOfPlayer_X = tbx_SW_Player02.Text;
            }
            else if (rdb_SW_Random.Checked)
            {
                int randomInt = Tools.RandomInt(0, 100);
                if (randomInt < 50)
                {
                    Settings.nameOfPlayer_X = tbx_SW_Player01.Text;
                    Settings.nameOfPlayer_O = tbx_SW_Player02.Text;
                }
                else if (randomInt > 49)
                {
                    Settings.nameOfPlayer_O = tbx_SW_Player01.Text;
                    Settings.nameOfPlayer_X = tbx_SW_Player02.Text;
                }
            }
            lbl_GW_TurnInstruction.Text = Settings.nameOfPlayer_X + "'s Turn";
        }

        /// <summary>
        /// Method containing events to perform while starting the game
        /// </summary>
        private void startGame()
        {
            if (Tools.isStringCorrect(tbx_SW_Player01.Text) && Tools.isStringCorrect(tbx_SW_Player02.Text))
            {
                if (tbx_SW_Player01.Text.Trim() == tbx_SW_Player02.Text.Trim())
                {
                    if (MessageBox.Show("Are you sure you want same names?", "Same Names", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        setPlayers();
                        loadGamePanel();
                    }
                }
                else { setPlayers(); loadGamePanel(); }
            }
            else
            {
                MessageBox.Show("Enter Valid Name!!\n  - Name must not be blank.\n  - Name length must be 2-10.", "Incorrect Name");
            }
        }

        /// <summary>
        /// Method containing events to perform while loading game panel
        /// </summary>
        private void loadGamePanel()
        {
            pan_StartWindow.Visible = false;
            pan_ResultWindow.Visible = false;
            pan_GameWindow.Visible = true;
            pan_GameWindow.Focus();
            lbl_GW_X_PlayerName.Text = Settings.nameOfPlayer_X;
            lbl_GW_O_PlayerName.Text = Settings.nameOfPlayer_O;
            lbl_GW_X_Score.Text = Settings.scoreOfPlayer_X.ToString();
            lbl_GW_O_Score.Text = Settings.scoreOfPlayer_O.ToString();
        }

        /// <summary>
        /// Method to create and display game board
        /// </summary>
        private void CreateBoard()
        {   
            int tabIndex = 1;
            for (int y = 0; y < 3; y++)
            {                
                for (int x = 0; x < 3; x++)
                {
                    // Create button
                    Button button = new Button();
                    button.BackColor = Color.White;
                    button.Font = new Font("Aharoni", 24F, FontStyle.Bold);
                    button.Height = 150;
                    button.Width = 150;
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    // Set tab index                   
                    button.TabIndex = tabIndex;
                    button.TabStop = true;
                    tabIndex++;
                    // Set position
                    button.Top = Settings.DEF_TOPMARGIN + y * (Settings.DEF_SQUARESIZE);
                    button.Left = Settings.DEF_LEFTMARGIN + x * (Settings.DEF_SQUARESIZE);
                    button.Anchor = AnchorStyles.None;
                    // Set Tooltip                    
                    toolTip1.SetToolTip(button, "Click to mark this box");
                    // add click event handlers
                    button.Click += new System.EventHandler(this.button_Click);
                    // copy these properties to the button in the array
                    Settings.buttons[x, y] = button;
                    //display board
                    pan_GameWindow.Controls.Add(Settings.buttons[x, y]);
                  
                    
                }
            }
        }

        /// <summary>
        /// Method to clear and reset board
        /// </summary>
        private void ClearBoard()
        {
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Button button = Settings.buttons[x, y];
                    button.Text = "";
                    button.BackColor = Color.White;
                    button.Enabled = true;
                }
            }

        }

        /// <summary>
        /// Method to reset game score
        /// </summary>
        private void ResetScore()
        {
            Settings.scoreOfPlayer_X = 0;
            Settings.scoreOfPlayer_O = 0;
            lbl_GW_X_Score.Text = Settings.scoreOfPlayer_X.ToString();
            lbl_GW_O_Score.Text = Settings.scoreOfPlayer_O.ToString();
        }

        /// <summary>
        /// Method to check for winner
        /// </summary>
        private void IsPlayerWon()
        {
            for (int y = 0; y < 3; y++)
            {
                int numberOf_X_InRow = 0;
                int numberOf_O_InRow = 0;
                for (int x = 0; x < 3; x++)
                {
                    Button button = Settings.buttons[x, y];
                    if (button.Text == "X") numberOf_X_InRow++;
                    else if (button.Text == "O") numberOf_O_InRow++;
                }
                if (numberOf_X_InRow == 3) Player_X_Won();
                else if (numberOf_O_InRow == 3) Player_O_Won();
            }

            for (int y = 0; y < 3; y++)
            {
                int numberOf_X_InColumn = 0;
                int numberOf_O_InColumn = 0;
                for (int x = 0; x < 3; x++)
                {
                    Button button = Settings.buttons[y, x];
                    if (button.Text == "X") numberOf_X_InColumn++;
                    else if (button.Text == "O") numberOf_O_InColumn++;
                }
                if (numberOf_X_InColumn == 3) Player_X_Won();
                else if (numberOf_O_InColumn == 3) Player_O_Won();
            }

            int numberOfFilledBoxes = 0;
            for (int y = 0; y < 3; y++) 
            {
                for (int x = 0; x < 3; x++)
                {
                    Button button = Settings.buttons[y, x];
                    if (button.Text != string.Empty) numberOfFilledBoxes++;
                    if (numberOfFilledBoxes == 9)
                    {
                        gameDraw();
                        numberOfFilledBoxes = 0;
                    }
                }
            }

            if (Settings.buttons[0, 0].Text == "X" & Settings.buttons[1, 1].Text == "X" & Settings.buttons[2, 2].Text == "X") Player_X_Won();
            else if (Settings.buttons[0, 0].Text == "O" & Settings.buttons[1, 1].Text == "O" & Settings.buttons[2, 2].Text == "O") Player_O_Won();

            if (Settings.buttons[0, 2].Text == "X" & Settings.buttons[1, 1].Text == "X" & Settings.buttons[2, 0].Text == "X") Player_X_Won();
            else if (Settings.buttons[0, 2].Text == "O" & Settings.buttons[1, 1].Text == "O" & Settings.buttons[2, 0].Text == "O") Player_O_Won();

        }

        /// <summary>
        /// Method containing events to perform when player X wins 
        /// </summary>
        private void Player_X_Won()
        {
            Settings.scoreOfPlayer_X++;
            lbl_GW_X_Score.Text = (Settings.scoreOfPlayer_X).ToString();
            pan_GameWindow.Visible = false;
            pan_ResultWindow.Visible = true;
            pan_StartWindow.Focus();
            lbl_RW_Result.Text = "Congratulations!!\n" + Settings.nameOfPlayer_X + " Won The Round";
        }

        /// <summary>
        ///  Method containing events to perform when player X wins 
        /// </summary>
        private void Player_O_Won()
        {
            Settings.scoreOfPlayer_O++;
            lbl_GW_O_Score.Text = (Settings.scoreOfPlayer_O).ToString();
            pan_GameWindow.Visible = false;
            pan_ResultWindow.Visible = true;
            pan_ResultWindow.Focus();
            lbl_RW_Result.Text = "Congratulations!!\n" + Settings.nameOfPlayer_O + " Won The Round";
        }

        /// <summary>
        ///  Method containing events to perform when it's a draw
        /// </summary>
        private void gameDraw()
        {
            pan_GameWindow.Visible = false;
            pan_ResultWindow.Visible = true;
            pan_ResultWindow.Focus();
            lbl_RW_Result.Text = "Board Full!!\nIt's a Draw";
        }
        #endregion

        #region Event Methods

        /// <summary>
        /// Method to exit the game on the click of Exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }

        /// <summary>
        /// Method to start game on the click of Start button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SW_Start_Click(object sender, EventArgs e)
        {
            startGame();
        }

        /// <summary>
        /// Method to perform a turn on the click of any box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (Settings.isPlayer_X)
            {
                btn.Text = "X";
                Settings.isPlayer_X = false;
                lbl_GW_TurnInstruction.Text = Settings.nameOfPlayer_O + "'s Turn";
                btn.Enabled = false;
                btn.BackColor = Color.LightBlue;
            }
            else
            {
                btn.Text = "O";
                Settings.isPlayer_X = true;
                lbl_GW_TurnInstruction.Text = Settings.nameOfPlayer_X + "'s Turn";
                btn.Enabled = false;
                btn.BackColor = Color.OrangeRed;
            }
            IsPlayerWon();
        }

        /// <summary>
        /// Method to clear and reset board on the click of reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GW_ResetBoard_Click(object sender, EventArgs e)
        {
            ClearBoard();
        }

        /// <summary>
        /// Method to clear current score on the click of reset score button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GW_ResetScore_Click(object sender, EventArgs e)
        {
            ResetScore();
        }

        /// <summary>
        /// Method to restart the game on the click of restart button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RestartGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to restart game", "Restart Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SetDefaults();
                ClearBoard();
                ResetScore();
            }
        }

        /// <summary>
        /// Method to continue the game on the click of continue game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Continue_Click(object sender, EventArgs e)
        {
            loadGamePanel();
            ClearBoard();
        }

        /// <summary>
        /// Method to start new game on the click of start new game button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_StartNewGame_Click(object sender, EventArgs e)
        {
            if (Settings.scoreOfPlayer_X > Settings.scoreOfPlayer_O)
            {
                MessageBox.Show(Settings.nameOfPlayer_X + "'s Score - " + Settings.scoreOfPlayer_X + "\n" +
                Settings.nameOfPlayer_O + "'s Score - " + Settings.scoreOfPlayer_O + "\n" + Settings.nameOfPlayer_X + " Won the Game", "Final Result");
            }
            else if (Settings.scoreOfPlayer_X < Settings.scoreOfPlayer_O)
            {
                MessageBox.Show(Settings.nameOfPlayer_X + "'s Score - " + Settings.scoreOfPlayer_X + "\n" +
                    Settings.nameOfPlayer_O + "'s Score - " + Settings.scoreOfPlayer_O + "\n" + Settings.nameOfPlayer_O + " Won the Game", "Final Result");
            }
            else
            {
                MessageBox.Show(Settings.nameOfPlayer_X + "'s Score - " + Settings.scoreOfPlayer_X + "\n" +
                    Settings.nameOfPlayer_O + "'s Score - " + Settings.scoreOfPlayer_O + "\nIt's A Draw", "Final Result");
            }
            SetDefaults();
            ClearBoard();
            ResetScore();
        }
        
        #endregion
    }
}
