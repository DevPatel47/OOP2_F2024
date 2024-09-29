using System.Diagnostics.Eventing.Reader;

namespace Assignment01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Set Defaults
        private void frmMain_Load(object sender, EventArgs e)
        {
            SetDefaults();
            CreateBoard();
        }

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

        private void CreateBoard()
        {   
            int tabIndex = 1;
            for (int y = 0; y < 3; y++)
            {                
                for (int x = 0; x < 3; x++)
                {
                    // Create Label
                    Label label = new Label();
                    label.BackColor = Color.White;
                    label.BorderStyle = BorderStyle.FixedSingle;
                    label.Font = new Font("Aharoni", 24F, FontStyle.Bold);
                    label.Height = 150;
                    label.Width = 150;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    
                    label.Focus();
                    label.TabIndex = tabIndex;
                    label.TabStop = true;
                   
                    tabIndex++;

                    // position
                    label.Top = Settings.DEF_TOPMARGIN + y * (Settings.DEF_SQUARESIZE);
                    label.Left = Settings.DEF_LEFTMARGIN + x * (Settings.DEF_SQUARESIZE);
                    label.Anchor = AnchorStyles.None;
                    
                    // add click event handlers
                    label.Click += new System.EventHandler(this.label_Click);
                    // copy these properties to the label in the array
                    Settings.labels[x, y] = label;
                    pan_GameWindow.Controls.Add(Settings.labels[x, y]);
                    

                }
            }
        }

        private void ClearBoard()
        {
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Label label = Settings.labels[x, y];
                    label.Text = " ";
                    label.BackColor = Color.White;
                    label.Enabled = true;
                }
            }

        }

        private void ResetScore()
        {
            Settings.scoreOfPlayer_X = 0;
            Settings.scoreOfPlayer_O = 0;
            lbl_GW_X_Score.Text = Settings.scoreOfPlayer_X.ToString();
            lbl_GW_O_Score.Text = Settings.scoreOfPlayer_O.ToString();
        }

        private void IsPlayerWon()
        {
            for (int y = 0; y < 3; y++)
            {
                int numberOf_X_InRow = 0;
                int numberOf_O_InRow = 0;
                for (int x = 0; x < 3; x++)
                {
                    Label label = Settings.labels[x, y];
                    if (label.Text == "X") numberOf_X_InRow++;
                    else if (label.Text == "O") numberOf_O_InRow++;
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
                    Label label = Settings.labels[y, x];
                    if (label.Text == "X") numberOf_X_InColumn++;
                    else if (label.Text == "O") numberOf_O_InColumn++;
                }
                if (numberOf_X_InColumn == 3) Player_X_Won();
                else if (numberOf_O_InColumn == 3) Player_O_Won();
            }

            if (Settings.labels[0, 0].Text == "X" & Settings.labels[1, 1].Text == "X" & Settings.labels[2, 2].Text == "X") Player_X_Won();
            else if (Settings.labels[0, 0].Text == "O" & Settings.labels[1, 1].Text == "O" & Settings.labels[2, 2].Text == "O") Player_O_Won();

            if (Settings.labels[0, 2].Text == "X" & Settings.labels[1, 1].Text == "X" & Settings.labels[2, 0].Text == "X") Player_X_Won();
            else if (Settings.labels[0, 2].Text == "O" & Settings.labels[1, 1].Text == "O" & Settings.labels[2, 0].Text == "O") Player_O_Won();

        }

        private void Player_X_Won()
        {
            Settings.scoreOfPlayer_X++;
            lbl_GW_X_Score.Text = (Settings.scoreOfPlayer_X).ToString();
            pan_GameWindow.Visible = false;
            pan_ResultWindow.Visible = true;
            pan_StartWindow.Focus();
            lbl_RW_Result.Text = "Congratulations!!\n" + Settings.nameOfPlayer_X + " Won the Round";
        }

        private void Player_O_Won()
        {
            Settings.scoreOfPlayer_O++;
            lbl_GW_O_Score.Text = (Settings.scoreOfPlayer_O).ToString();
            pan_GameWindow.Visible = false;
            pan_ResultWindow.Visible = true;
            pan_ResultWindow.Focus();
            lbl_RW_Result.Text = "Congratulations!!\n" + Settings.nameOfPlayer_O + " Won the Round";
        }
        #endregion

        #region Event Methods

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }

        private void btn_SW_Start_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            if (Settings.isPlayer_X)
            {
                lbl.Text = "X";
                Settings.isPlayer_X = false;
                lbl_GW_TurnInstruction.Text = Settings.nameOfPlayer_O + "'s Turn";
                lbl.Enabled = false;
                lbl.BackColor = Color.LightBlue;
            }
            else
            {
                lbl.Text = "O";
                Settings.isPlayer_X = true;
                lbl_GW_TurnInstruction.Text = Settings.nameOfPlayer_X + "'s Turn";
                lbl.Enabled = false;
                lbl.BackColor = Color.OrangeRed;
            }
            IsPlayerWon();
        }

        private void btn_GW_ResetBoard_Click(object sender, EventArgs e)
        {
            ClearBoard();
        }

        private void btn_GW_ResetScore_Click(object sender, EventArgs e)
        {
            ResetScore();
        }

        private void btn_RestartGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to restart game", "Restart Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SetDefaults();
                ClearBoard();
                ResetScore();
            }
        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            loadGamePanel();
            ClearBoard();
        }

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
