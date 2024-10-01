namespace Assignment01
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pan_StartWindow = new Panel();
            lbl_SW_Note = new Label();
            rdb_SW_Random = new RadioButton();
            rdb_SW_O = new RadioButton();
            rdb_SW_X = new RadioButton();
            lbl_SW_SelectSign = new Label();
            lbl_SW_EnterPlayersName = new Label();
            tbx_SW_Player02 = new TextBox();
            tbx_SW_Player01 = new TextBox();
            btn_SW_Start = new Button();
            pbx_SW_Logo = new PictureBox();
            pan_GameWindow = new Panel();
            lbl_GW_TurnInstruction = new Label();
            btn_GW_ResetScore = new Button();
            btn_GW_ResetBoard = new Button();
            lbl_GW_O_Score = new Label();
            lbl_GW_X_Score = new Label();
            lbl_GW_Score = new Label();
            lbl_GW_O_PlayerName = new Label();
            lbl_GW_O = new Label();
            lbl_GW_X_PlayerName = new Label();
            lbl_GW_X = new Label();
            toolTip1 = new ToolTip(components);
            btn_Exit = new Button();
            btn_StartNewGame = new Button();
            btn_Continue = new Button();
            btn_RestartGame = new Button();
            pan_ResultWindow = new Panel();
            lbl_RW_Result = new Label();
            pan_StartWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_SW_Logo).BeginInit();
            pan_GameWindow.SuspendLayout();
            pan_ResultWindow.SuspendLayout();
            SuspendLayout();
            // 
            // pan_StartWindow
            // 
            pan_StartWindow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pan_StartWindow.BackColor = Color.AliceBlue;
            pan_StartWindow.Controls.Add(lbl_SW_Note);
            pan_StartWindow.Controls.Add(rdb_SW_Random);
            pan_StartWindow.Controls.Add(rdb_SW_O);
            pan_StartWindow.Controls.Add(rdb_SW_X);
            pan_StartWindow.Controls.Add(lbl_SW_SelectSign);
            pan_StartWindow.Controls.Add(lbl_SW_EnterPlayersName);
            pan_StartWindow.Controls.Add(tbx_SW_Player02);
            pan_StartWindow.Controls.Add(tbx_SW_Player01);
            pan_StartWindow.Controls.Add(btn_SW_Start);
            pan_StartWindow.Controls.Add(pbx_SW_Logo);
            pan_StartWindow.Location = new Point(12, 12);
            pan_StartWindow.Name = "pan_StartWindow";
            pan_StartWindow.Size = new Size(1390, 908);
            pan_StartWindow.TabIndex = 3;
            // 
            // lbl_SW_Note
            // 
            lbl_SW_Note.Anchor = AnchorStyles.None;
            lbl_SW_Note.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_SW_Note.Location = new Point(409, 618);
            lbl_SW_Note.Name = "lbl_SW_Note";
            lbl_SW_Note.Size = new Size(573, 47);
            lbl_SW_Note.TabIndex = 9;
            lbl_SW_Note.Text = "Note: Player with the sign X will play first move.";
            // 
            // rdb_SW_Random
            // 
            rdb_SW_Random.Anchor = AnchorStyles.None;
            rdb_SW_Random.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            rdb_SW_Random.Location = new Point(1030, 541);
            rdb_SW_Random.Name = "rdb_SW_Random";
            rdb_SW_Random.Size = new Size(192, 46);
            rdb_SW_Random.TabIndex = 5;
            rdb_SW_Random.Text = "Random";
            toolTip1.SetToolTip(rdb_SW_Random, "Click to select Random");
            rdb_SW_Random.UseVisualStyleBackColor = true;
            // 
            // rdb_SW_O
            // 
            rdb_SW_O.Anchor = AnchorStyles.None;
            rdb_SW_O.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            rdb_SW_O.Location = new Point(852, 541);
            rdb_SW_O.Name = "rdb_SW_O";
            rdb_SW_O.Size = new Size(93, 46);
            rdb_SW_O.TabIndex = 4;
            rdb_SW_O.Text = "O";
            toolTip1.SetToolTip(rdb_SW_O, "Click to select O");
            rdb_SW_O.UseVisualStyleBackColor = true;
            // 
            // rdb_SW_X
            // 
            rdb_SW_X.Anchor = AnchorStyles.None;
            rdb_SW_X.Checked = true;
            rdb_SW_X.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            rdb_SW_X.Location = new Point(677, 541);
            rdb_SW_X.Name = "rdb_SW_X";
            rdb_SW_X.Size = new Size(90, 46);
            rdb_SW_X.TabIndex = 3;
            rdb_SW_X.TabStop = true;
            rdb_SW_X.Text = "X";
            toolTip1.SetToolTip(rdb_SW_X, "Click to select X");
            rdb_SW_X.UseVisualStyleBackColor = true;
            // 
            // lbl_SW_SelectSign
            // 
            lbl_SW_SelectSign.Anchor = AnchorStyles.None;
            lbl_SW_SelectSign.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lbl_SW_SelectSign.Location = new Point(168, 541);
            lbl_SW_SelectSign.Name = "lbl_SW_SelectSign";
            lbl_SW_SelectSign.Size = new Size(424, 46);
            lbl_SW_SelectSign.TabIndex = 5;
            lbl_SW_SelectSign.Text = "Select Sign for Player - 1:";
            lbl_SW_SelectSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_SW_EnterPlayersName
            // 
            lbl_SW_EnterPlayersName.Anchor = AnchorStyles.None;
            lbl_SW_EnterPlayersName.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lbl_SW_EnterPlayersName.Location = new Point(168, 453);
            lbl_SW_EnterPlayersName.Name = "lbl_SW_EnterPlayersName";
            lbl_SW_EnterPlayersName.Size = new Size(356, 44);
            lbl_SW_EnterPlayersName.TabIndex = 4;
            lbl_SW_EnterPlayersName.Text = "Enter Players Name:";
            lbl_SW_EnterPlayersName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbx_SW_Player02
            // 
            tbx_SW_Player02.Anchor = AnchorStyles.None;
            tbx_SW_Player02.BackColor = Color.White;
            tbx_SW_Player02.BorderStyle = BorderStyle.None;
            tbx_SW_Player02.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            tbx_SW_Player02.Location = new Point(889, 453);
            tbx_SW_Player02.Name = "tbx_SW_Player02";
            tbx_SW_Player02.Size = new Size(333, 38);
            tbx_SW_Player02.TabIndex = 2;
            tbx_SW_Player02.Text = "Player-2";
            tbx_SW_Player02.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(tbx_SW_Player02, "Click to enter player 2 name");
            // 
            // tbx_SW_Player01
            // 
            tbx_SW_Player01.Anchor = AnchorStyles.None;
            tbx_SW_Player01.BackColor = Color.White;
            tbx_SW_Player01.BorderStyle = BorderStyle.None;
            tbx_SW_Player01.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            tbx_SW_Player01.Location = new Point(540, 453);
            tbx_SW_Player01.Name = "tbx_SW_Player01";
            tbx_SW_Player01.Size = new Size(333, 38);
            tbx_SW_Player01.TabIndex = 1;
            tbx_SW_Player01.Text = "Player-1";
            tbx_SW_Player01.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(tbx_SW_Player01, "Click to enter player 1 name");
            // 
            // btn_SW_Start
            // 
            btn_SW_Start.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_SW_Start.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_SW_Start.Location = new Point(445, 706);
            btn_SW_Start.Name = "btn_SW_Start";
            btn_SW_Start.Size = new Size(500, 143);
            btn_SW_Start.TabIndex = 6;
            btn_SW_Start.Text = "&Start";
            toolTip1.SetToolTip(btn_SW_Start, "Click to start the game");
            btn_SW_Start.UseVisualStyleBackColor = true;
            btn_SW_Start.Click += btn_SW_Start_Click;
            // 
            // pbx_SW_Logo
            // 
            pbx_SW_Logo.Anchor = AnchorStyles.Top;
            pbx_SW_Logo.Image = (Image)resources.GetObject("pbx_SW_Logo.Image");
            pbx_SW_Logo.Location = new Point(295, -157);
            pbx_SW_Logo.Name = "pbx_SW_Logo";
            pbx_SW_Logo.Size = new Size(800, 800);
            pbx_SW_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_SW_Logo.TabIndex = 0;
            pbx_SW_Logo.TabStop = false;
            // 
            // pan_GameWindow
            // 
            pan_GameWindow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pan_GameWindow.Controls.Add(lbl_GW_TurnInstruction);
            pan_GameWindow.Controls.Add(btn_GW_ResetScore);
            pan_GameWindow.Controls.Add(btn_GW_ResetBoard);
            pan_GameWindow.Controls.Add(lbl_GW_O_Score);
            pan_GameWindow.Controls.Add(lbl_GW_X_Score);
            pan_GameWindow.Controls.Add(lbl_GW_Score);
            pan_GameWindow.Controls.Add(lbl_GW_O_PlayerName);
            pan_GameWindow.Controls.Add(lbl_GW_O);
            pan_GameWindow.Controls.Add(lbl_GW_X_PlayerName);
            pan_GameWindow.Controls.Add(lbl_GW_X);
            pan_GameWindow.Location = new Point(2, 12);
            pan_GameWindow.Name = "pan_GameWindow";
            pan_GameWindow.Size = new Size(1400, 908);
            pan_GameWindow.TabIndex = 10;
            // 
            // lbl_GW_TurnInstruction
            // 
            lbl_GW_TurnInstruction.Anchor = AnchorStyles.None;
            lbl_GW_TurnInstruction.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_GW_TurnInstruction.Location = new Point(562, 189);
            lbl_GW_TurnInstruction.Name = "lbl_GW_TurnInstruction";
            lbl_GW_TurnInstruction.Size = new Size(277, 64);
            lbl_GW_TurnInstruction.TabIndex = 18;
            lbl_GW_TurnInstruction.Text = "Player - 1's Turn";
            lbl_GW_TurnInstruction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_GW_ResetScore
            // 
            btn_GW_ResetScore.Anchor = AnchorStyles.None;
            btn_GW_ResetScore.Location = new Point(710, 785);
            btn_GW_ResetScore.Name = "btn_GW_ResetScore";
            btn_GW_ResetScore.Size = new Size(210, 70);
            btn_GW_ResetScore.TabIndex = 11;
            btn_GW_ResetScore.Text = "Reset Score";
            toolTip1.SetToolTip(btn_GW_ResetScore, "Click to clear current score");
            btn_GW_ResetScore.UseVisualStyleBackColor = true;
            btn_GW_ResetScore.Click += btn_GW_ResetScore_Click;
            // 
            // btn_GW_ResetBoard
            // 
            btn_GW_ResetBoard.Anchor = AnchorStyles.None;
            btn_GW_ResetBoard.Location = new Point(470, 785);
            btn_GW_ResetBoard.Name = "btn_GW_ResetBoard";
            btn_GW_ResetBoard.Size = new Size(210, 70);
            btn_GW_ResetBoard.TabIndex = 10;
            btn_GW_ResetBoard.Text = "Reset Board";
            toolTip1.SetToolTip(btn_GW_ResetBoard, "Click to clear current board");
            btn_GW_ResetBoard.UseVisualStyleBackColor = true;
            btn_GW_ResetBoard.Click += btn_GW_ResetBoard_Click;
            // 
            // lbl_GW_O_Score
            // 
            lbl_GW_O_Score.Anchor = AnchorStyles.Top;
            lbl_GW_O_Score.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold);
            lbl_GW_O_Score.ForeColor = Color.OrangeRed;
            lbl_GW_O_Score.Location = new Point(802, 70);
            lbl_GW_O_Score.Name = "lbl_GW_O_Score";
            lbl_GW_O_Score.Size = new Size(150, 60);
            lbl_GW_O_Score.TabIndex = 6;
            lbl_GW_O_Score.Text = "0";
            lbl_GW_O_Score.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_GW_X_Score
            // 
            lbl_GW_X_Score.Anchor = AnchorStyles.Top;
            lbl_GW_X_Score.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold);
            lbl_GW_X_Score.ForeColor = Color.DodgerBlue;
            lbl_GW_X_Score.Location = new Point(449, 70);
            lbl_GW_X_Score.Name = "lbl_GW_X_Score";
            lbl_GW_X_Score.Size = new Size(150, 60);
            lbl_GW_X_Score.TabIndex = 5;
            lbl_GW_X_Score.Text = "0";
            lbl_GW_X_Score.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_GW_Score
            // 
            lbl_GW_Score.Anchor = AnchorStyles.Top;
            lbl_GW_Score.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold);
            lbl_GW_Score.ForeColor = SystemColors.Desktop;
            lbl_GW_Score.Location = new Point(608, 70);
            lbl_GW_Score.Name = "lbl_GW_Score";
            lbl_GW_Score.Size = new Size(195, 60);
            lbl_GW_Score.TabIndex = 4;
            lbl_GW_Score.Text = "- Score -";
            lbl_GW_Score.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_O_PlayerName
            // 
            lbl_GW_O_PlayerName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_GW_O_PlayerName.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_GW_O_PlayerName.ForeColor = Color.OrangeRed;
            lbl_GW_O_PlayerName.Location = new Point(1157, 75);
            lbl_GW_O_PlayerName.Name = "lbl_GW_O_PlayerName";
            lbl_GW_O_PlayerName.Size = new Size(174, 60);
            lbl_GW_O_PlayerName.TabIndex = 3;
            lbl_GW_O_PlayerName.Text = "Player-2";
            // 
            // lbl_GW_O
            // 
            lbl_GW_O.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_GW_O.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_GW_O.ForeColor = Color.OrangeRed;
            lbl_GW_O.Location = new Point(1091, 75);
            lbl_GW_O.Name = "lbl_GW_O";
            lbl_GW_O.Size = new Size(77, 60);
            lbl_GW_O.TabIndex = 2;
            lbl_GW_O.Text = "O -";
            // 
            // lbl_GW_X_PlayerName
            // 
            lbl_GW_X_PlayerName.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_GW_X_PlayerName.ForeColor = Color.DodgerBlue;
            lbl_GW_X_PlayerName.Location = new Point(140, 70);
            lbl_GW_X_PlayerName.Name = "lbl_GW_X_PlayerName";
            lbl_GW_X_PlayerName.Size = new Size(174, 60);
            lbl_GW_X_PlayerName.TabIndex = 1;
            lbl_GW_X_PlayerName.Text = "Player-1";
            // 
            // lbl_GW_X
            // 
            lbl_GW_X.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_GW_X.ForeColor = Color.DodgerBlue;
            lbl_GW_X.Location = new Point(74, 70);
            lbl_GW_X.Name = "lbl_GW_X";
            lbl_GW_X.Size = new Size(77, 60);
            lbl_GW_X.TabIndex = 0;
            lbl_GW_X.Text = "X -";
            // 
            // btn_Exit
            // 
            btn_Exit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Exit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(1192, 926);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(210, 70);
            btn_Exit.TabIndex = 8;
            btn_Exit.Text = "E&xit Game";
            toolTip1.SetToolTip(btn_Exit, "Click to exit the game");
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_StartNewGame
            // 
            btn_StartNewGame.Anchor = AnchorStyles.None;
            btn_StartNewGame.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_StartNewGame.Location = new Point(751, 602);
            btn_StartNewGame.Name = "btn_StartNewGame";
            btn_StartNewGame.Size = new Size(251, 112);
            btn_StartNewGame.TabIndex = 2;
            btn_StartNewGame.Text = "Start &New Game";
            toolTip1.SetToolTip(btn_StartNewGame, "Click to start a new game");
            btn_StartNewGame.UseVisualStyleBackColor = true;
            btn_StartNewGame.Click += btn_StartNewGame_Click;
            // 
            // btn_Continue
            // 
            btn_Continue.Anchor = AnchorStyles.None;
            btn_Continue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Continue.Location = new Point(389, 602);
            btn_Continue.Name = "btn_Continue";
            btn_Continue.Size = new Size(251, 112);
            btn_Continue.TabIndex = 1;
            btn_Continue.Text = "&Continue Game";
            toolTip1.SetToolTip(btn_Continue, "Click to continue playing current game");
            btn_Continue.UseVisualStyleBackColor = true;
            btn_Continue.Click += btn_Continue_Click;
            // 
            // btn_RestartGame
            // 
            btn_RestartGame.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_RestartGame.Location = new Point(960, 927);
            btn_RestartGame.Name = "btn_RestartGame";
            btn_RestartGame.Size = new Size(210, 70);
            btn_RestartGame.TabIndex = 7;
            btn_RestartGame.Text = "&Restart Game";
            toolTip1.SetToolTip(btn_RestartGame, "Click to restart a new game");
            btn_RestartGame.UseVisualStyleBackColor = true;
            btn_RestartGame.Click += btn_RestartGame_Click;
            // 
            // pan_ResultWindow
            // 
            pan_ResultWindow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pan_ResultWindow.Controls.Add(btn_StartNewGame);
            pan_ResultWindow.Controls.Add(btn_Continue);
            pan_ResultWindow.Controls.Add(lbl_RW_Result);
            pan_ResultWindow.Location = new Point(2, 12);
            pan_ResultWindow.Name = "pan_ResultWindow";
            pan_ResultWindow.Size = new Size(1397, 905);
            pan_ResultWindow.TabIndex = 19;
            // 
            // lbl_RW_Result
            // 
            lbl_RW_Result.Anchor = AnchorStyles.None;
            lbl_RW_Result.Font = new Font("Edwardian Script ITC", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_RW_Result.ForeColor = Color.IndianRed;
            lbl_RW_Result.Location = new Point(169, 96);
            lbl_RW_Result.Name = "lbl_RW_Result";
            lbl_RW_Result.Size = new Size(1059, 456);
            lbl_RW_Result.TabIndex = 0;
            lbl_RW_Result.Text = "Congratulations! \r\nPlayer-1 Won The Game";
            lbl_RW_Result.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            AcceptButton = btn_SW_Start;
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.AliceBlue;
            CancelButton = btn_Exit;
            ClientSize = new Size(1416, 1016);
            Controls.Add(btn_RestartGame);
            Controls.Add(btn_Exit);
            Controls.Add(pan_ResultWindow);
            Controls.Add(pan_GameWindow);
            Controls.Add(pan_StartWindow);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MinimumSize = new Size(1440, 1080);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic-Tac-Toe";
            Load += frmMain_Load;
            pan_StartWindow.ResumeLayout(false);
            pan_StartWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_SW_Logo).EndInit();
            pan_GameWindow.ResumeLayout(false);
            pan_ResultWindow.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pan_StartWindow;
        private PictureBox pbx_SW_Logo;
        private Button btn_SW_Start;
        private TextBox tbx_SW_Player02;
        private TextBox tbx_SW_Player01;
        private Label lbl_SW_EnterPlayersName;
        private Label lbl_SW_SelectSign;
        private RadioButton rdb_SW_X;
        private RadioButton rdb_SW_Random;
        private RadioButton rdb_SW_O;
        private Label lbl_SW_Note;
        private ToolTip toolTip1;
        private Panel pan_GameWindow;
        private Label lbl_GW_O_PlayerName;
        private Label lbl_GW_O;
        private Label lbl_GW_X_PlayerName;
        private Label lbl_GW_X;
        private Label lbl_GW_Score;
        private Label lbl_GW_O_Score;
        private Label lbl_GW_X_Score;
        private Button btn_Exit;
        private Button btn_GW_ResetBoard;
        private Button btn_GW_ResetScore;
        private Label lbl_GW_TurnInstruction;
        private Panel pan_ResultWindow;
        private Label lbl_RW_Result;
        private Button btn_StartNewGame;
        private Button btn_Continue;
        private Button btn_RestartGame;
    }
}
