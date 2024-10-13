using System.Drawing;

namespace Assignment02
{
    partial class frmBattleShip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBattleShip));
            this.pan_BattleShip_Heading = new System.Windows.Forms.Panel();
            this.lbl_BSH_BattleShip = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_ShowBoats = new System.Windows.Forms.Button();
            this.cbo_LM_X = new System.Windows.Forms.ComboBox();
            this.cbo_LM_Y = new System.Windows.Forms.ComboBox();
            this.btn_LM_Launch = new System.Windows.Forms.Button();
            this.pan_GameWindow = new System.Windows.Forms.Panel();
            this.pan_GW_LaunchMissile = new System.Windows.Forms.Panel();
            this.lbl_LM_Y = new System.Windows.Forms.Label();
            this.lbl_LM_X = new System.Windows.Forms.Label();
            this.lbl_LM_SelectCoordinates = new System.Windows.Forms.Label();
            this.lbl_LM_LaunchMissile = new System.Windows.Forms.Label();
            this.lbl_GW_2 = new System.Windows.Forms.Label();
            this.lbl_GW_3 = new System.Windows.Forms.Label();
            this.lbl_GW_4 = new System.Windows.Forms.Label();
            this.lbl_GW_5 = new System.Windows.Forms.Label();
            this.lbl_GW_6 = new System.Windows.Forms.Label();
            this.lbl_GW_7 = new System.Windows.Forms.Label();
            this.lbl_GW_8 = new System.Windows.Forms.Label();
            this.lbl_GW_10 = new System.Windows.Forms.Label();
            this.lbl_GW_9 = new System.Windows.Forms.Label();
            this.lbl_GW_1 = new System.Windows.Forms.Label();
            this.lbl_GW_B = new System.Windows.Forms.Label();
            this.lbl_GW_C = new System.Windows.Forms.Label();
            this.lbl_GW_D = new System.Windows.Forms.Label();
            this.lbl_GW_E = new System.Windows.Forms.Label();
            this.lbl_GW_F = new System.Windows.Forms.Label();
            this.lbl_GW_G = new System.Windows.Forms.Label();
            this.lbl_GW_H = new System.Windows.Forms.Label();
            this.lbl_GW_J = new System.Windows.Forms.Label();
            this.lbl_GW_I = new System.Windows.Forms.Label();
            this.lbl_GW_A = new System.Windows.Forms.Label();
            this.pan_GW_BoatStatuses = new System.Windows.Forms.Panel();
            this.nud_BS_TurnTakenCount = new System.Windows.Forms.NumericUpDown();
            this.lbl_BS_TurnTaken = new System.Windows.Forms.Label();
            this.pgb_BS_Battleship = new System.Windows.Forms.ProgressBar();
            this.pgb_BS_Cruiser = new System.Windows.Forms.ProgressBar();
            this.pgb_BS_Destroyer = new System.Windows.Forms.ProgressBar();
            this.pgb_BS_Submarine = new System.Windows.Forms.ProgressBar();
            this.pgb_BS_Carrier = new System.Windows.Forms.ProgressBar();
            this.lbl_BS_Destroyer = new System.Windows.Forms.Label();
            this.lbl_BS_Submarine = new System.Windows.Forms.Label();
            this.lbl_BS_Cruiser = new System.Windows.Forms.Label();
            this.lbl_BS_Battleship = new System.Windows.Forms.Label();
            this.lbl_BS_Carrier = new System.Windows.Forms.Label();
            this.lbl_BS_BoatStatuses = new System.Windows.Forms.Label();
            this.pan_BattleShip_Heading.SuspendLayout();
            this.pan_GameWindow.SuspendLayout();
            this.pan_GW_LaunchMissile.SuspendLayout();
            this.pan_GW_BoatStatuses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BS_TurnTakenCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_BattleShip_Heading
            // 
            this.pan_BattleShip_Heading.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pan_BattleShip_Heading.Controls.Add(this.lbl_BSH_BattleShip);
            this.pan_BattleShip_Heading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_BattleShip_Heading.Location = new System.Drawing.Point(0, 0);
            this.pan_BattleShip_Heading.Margin = new System.Windows.Forms.Padding(2);
            this.pan_BattleShip_Heading.Name = "pan_BattleShip_Heading";
            this.pan_BattleShip_Heading.Size = new System.Drawing.Size(734, 54);
            this.pan_BattleShip_Heading.TabIndex = 0;
            // 
            // lbl_BSH_BattleShip
            // 
            this.lbl_BSH_BattleShip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_BSH_BattleShip.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BSH_BattleShip.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_BSH_BattleShip.Location = new System.Drawing.Point(7, 0);
            this.lbl_BSH_BattleShip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_BSH_BattleShip.Name = "lbl_BSH_BattleShip";
            this.lbl_BSH_BattleShip.Size = new System.Drawing.Size(720, 54);
            this.lbl_BSH_BattleShip.TabIndex = 0;
            this.lbl_BSH_BattleShip.Text = "BATTLE SHIP";
            this.lbl_BSH_BattleShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.BackColor = System.Drawing.Color.Black;
            this.btn_NewGame.ForeColor = System.Drawing.Color.White;
            this.btn_NewGame.Location = new System.Drawing.Point(7, 3);
            this.btn_NewGame.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(71, 30);
            this.btn_NewGame.TabIndex = 0;
            this.btn_NewGame.Text = "New &Game";
            this.toolTip1.SetToolTip(this.btn_NewGame, "Click to Start New Game");
            this.btn_NewGame.UseVisualStyleBackColor = false;
            this.btn_NewGame.Click += new System.EventHandler(this.btn_NewGame_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.Color.Black;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(661, 625);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(71, 30);
            this.btn_Exit.TabIndex = 105;
            this.btn_Exit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btn_Exit, "Click to Exit");
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_ShowBoats
            // 
            this.btn_ShowBoats.BackColor = System.Drawing.Color.Black;
            this.btn_ShowBoats.ForeColor = System.Drawing.Color.White;
            this.btn_ShowBoats.Location = new System.Drawing.Point(81, 3);
            this.btn_ShowBoats.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ShowBoats.Name = "btn_ShowBoats";
            this.btn_ShowBoats.Size = new System.Drawing.Size(76, 30);
            this.btn_ShowBoats.TabIndex = 1;
            this.btn_ShowBoats.Text = "Show &Boats";
            this.toolTip1.SetToolTip(this.btn_ShowBoats, "Click to See Boat Locations");
            this.btn_ShowBoats.UseVisualStyleBackColor = false;
            this.btn_ShowBoats.Click += new System.EventHandler(this.btn_ShowBoats_Click);
            // 
            // cbo_LM_X
            // 
            this.cbo_LM_X.FormattingEnabled = true;
            this.cbo_LM_X.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbo_LM_X.Location = new System.Drawing.Point(67, 101);
            this.cbo_LM_X.Name = "cbo_LM_X";
            this.cbo_LM_X.Size = new System.Drawing.Size(121, 21);
            this.cbo_LM_X.TabIndex = 102;
            this.toolTip1.SetToolTip(this.cbo_LM_X, "Select X Coordinates");
            // 
            // cbo_LM_Y
            // 
            this.cbo_LM_Y.FormattingEnabled = true;
            this.cbo_LM_Y.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J"});
            this.cbo_LM_Y.Location = new System.Drawing.Point(67, 144);
            this.cbo_LM_Y.Name = "cbo_LM_Y";
            this.cbo_LM_Y.Size = new System.Drawing.Size(121, 21);
            this.cbo_LM_Y.TabIndex = 103;
            this.toolTip1.SetToolTip(this.cbo_LM_Y, "Select Y Coordinates");
            // 
            // btn_LM_Launch
            // 
            this.btn_LM_Launch.BackColor = System.Drawing.Color.White;
            this.btn_LM_Launch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_LM_Launch.Location = new System.Drawing.Point(16, 190);
            this.btn_LM_Launch.Name = "btn_LM_Launch";
            this.btn_LM_Launch.Size = new System.Drawing.Size(172, 38);
            this.btn_LM_Launch.TabIndex = 104;
            this.btn_LM_Launch.Text = "&Launch";
            this.toolTip1.SetToolTip(this.btn_LM_Launch, "Click to launch");
            this.btn_LM_Launch.UseVisualStyleBackColor = false;
            this.btn_LM_Launch.Click += new System.EventHandler(this.btn_LM_Launch_Click);
            // 
            // pan_GameWindow
            // 
            this.pan_GameWindow.BackColor = System.Drawing.Color.Transparent;
            this.pan_GameWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pan_GameWindow.Controls.Add(this.pan_GW_LaunchMissile);
            this.pan_GameWindow.Controls.Add(this.lbl_GW_2);
            this.pan_GameWindow.Controls.Add(this.lbl_GW_3);
            this.pan_GameWindow.Controls.Add(this.lbl_GW_4);
            this.pan_GameWindow.Controls.Add(this.lbl_GW_5);
            this.pan_GameWindow.Controls.Add(this.lbl_GW_6);
            this.pan_GameWindow.Controls.Add(this.lbl_GW_7);
            this.pan_GameWindow.Controls.Add(this.lbl_GW_8);
            this.pan_GameWindow.Controls.Add(this.lbl_GW_10);
            this.pan_GameWindow.Controls.Add(this.lbl_GW_9);
            this.pan_GameWindow.Controls.Add(this.lbl_GW_1);
            this.pan_GameWindow.Controls.Add(this.lbl_GW_B);
            this.pan_GameWindow.Controls.Add(this.lbl_GW_C);
            this.pan_GameWindow.Controls.Add(this.lbl_GW_D);
            this.pan_GameWindow.Controls.Add(this.lbl_GW_E);
            this.pan_GameWindow.Controls.Add(this.lbl_GW_F);
            this.pan_GameWindow.Controls.Add(this.lbl_GW_G);
            this.pan_GameWindow.Controls.Add(this.lbl_GW_H);
            this.pan_GameWindow.Controls.Add(this.lbl_GW_J);
            this.pan_GameWindow.Controls.Add(this.lbl_GW_I);
            this.pan_GameWindow.Controls.Add(this.lbl_GW_A);
            this.pan_GameWindow.Controls.Add(this.pan_GW_BoatStatuses);
            this.pan_GameWindow.Controls.Add(this.btn_Exit);
            this.pan_GameWindow.Controls.Add(this.btn_ShowBoats);
            this.pan_GameWindow.Controls.Add(this.btn_NewGame);
            this.pan_GameWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_GameWindow.Location = new System.Drawing.Point(0, 54);
            this.pan_GameWindow.Margin = new System.Windows.Forms.Padding(2);
            this.pan_GameWindow.Name = "pan_GameWindow";
            this.pan_GameWindow.Size = new System.Drawing.Size(734, 657);
            this.pan_GameWindow.TabIndex = 1;
            // 
            // pan_GW_LaunchMissile
            // 
            this.pan_GW_LaunchMissile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_GW_LaunchMissile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_GW_LaunchMissile.Controls.Add(this.btn_LM_Launch);
            this.pan_GW_LaunchMissile.Controls.Add(this.lbl_LM_Y);
            this.pan_GW_LaunchMissile.Controls.Add(this.lbl_LM_X);
            this.pan_GW_LaunchMissile.Controls.Add(this.cbo_LM_Y);
            this.pan_GW_LaunchMissile.Controls.Add(this.cbo_LM_X);
            this.pan_GW_LaunchMissile.Controls.Add(this.lbl_LM_SelectCoordinates);
            this.pan_GW_LaunchMissile.Controls.Add(this.lbl_LM_LaunchMissile);
            this.pan_GW_LaunchMissile.Location = new System.Drawing.Point(520, 263);
            this.pan_GW_LaunchMissile.Name = "pan_GW_LaunchMissile";
            this.pan_GW_LaunchMissile.Size = new System.Drawing.Size(204, 260);
            this.pan_GW_LaunchMissile.TabIndex = 103;
            // 
            // lbl_LM_Y
            // 
            this.lbl_LM_Y.AutoSize = true;
            this.lbl_LM_Y.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LM_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_LM_Y.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_LM_Y.Location = new System.Drawing.Point(13, 145);
            this.lbl_LM_Y.Name = "lbl_LM_Y";
            this.lbl_LM_Y.Size = new System.Drawing.Size(15, 15);
            this.lbl_LM_Y.TabIndex = 107;
            this.lbl_LM_Y.Text = "Y";
            this.lbl_LM_Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_LM_X
            // 
            this.lbl_LM_X.AutoSize = true;
            this.lbl_LM_X.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LM_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_LM_X.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_LM_X.Location = new System.Drawing.Point(13, 102);
            this.lbl_LM_X.Name = "lbl_LM_X";
            this.lbl_LM_X.Size = new System.Drawing.Size(16, 15);
            this.lbl_LM_X.TabIndex = 106;
            this.lbl_LM_X.Text = "X";
            this.lbl_LM_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_LM_SelectCoordinates
            // 
            this.lbl_LM_SelectCoordinates.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LM_SelectCoordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_LM_SelectCoordinates.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_LM_SelectCoordinates.Location = new System.Drawing.Point(0, 49);
            this.lbl_LM_SelectCoordinates.Name = "lbl_LM_SelectCoordinates";
            this.lbl_LM_SelectCoordinates.Size = new System.Drawing.Size(200, 23);
            this.lbl_LM_SelectCoordinates.TabIndex = 1;
            this.lbl_LM_SelectCoordinates.Text = "Select Coordinates";
            this.lbl_LM_SelectCoordinates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_LM_LaunchMissile
            // 
            this.lbl_LM_LaunchMissile.BackColor = System.Drawing.Color.Black;
            this.lbl_LM_LaunchMissile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold);
            this.lbl_LM_LaunchMissile.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_LM_LaunchMissile.Location = new System.Drawing.Point(0, 0);
            this.lbl_LM_LaunchMissile.Name = "lbl_LM_LaunchMissile";
            this.lbl_LM_LaunchMissile.Size = new System.Drawing.Size(204, 34);
            this.lbl_LM_LaunchMissile.TabIndex = 0;
            this.lbl_LM_LaunchMissile.Text = "Launch Missile";
            this.lbl_LM_LaunchMissile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_2
            // 
            this.lbl_GW_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GW_2.BackColor = System.Drawing.Color.Black;
            this.lbl_GW_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GW_2.ForeColor = System.Drawing.Color.White;
            this.lbl_GW_2.Location = new System.Drawing.Point(124, 92);
            this.lbl_GW_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GW_2.Name = "lbl_GW_2";
            this.lbl_GW_2.Size = new System.Drawing.Size(30, 30);
            this.lbl_GW_2.TabIndex = 24;
            this.lbl_GW_2.Text = "2";
            this.lbl_GW_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_3
            // 
            this.lbl_GW_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GW_3.BackColor = System.Drawing.Color.Black;
            this.lbl_GW_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GW_3.ForeColor = System.Drawing.Color.White;
            this.lbl_GW_3.Location = new System.Drawing.Point(164, 92);
            this.lbl_GW_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GW_3.Name = "lbl_GW_3";
            this.lbl_GW_3.Size = new System.Drawing.Size(30, 30);
            this.lbl_GW_3.TabIndex = 23;
            this.lbl_GW_3.Text = "3";
            this.lbl_GW_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_4
            // 
            this.lbl_GW_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GW_4.BackColor = System.Drawing.Color.Black;
            this.lbl_GW_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GW_4.ForeColor = System.Drawing.Color.White;
            this.lbl_GW_4.Location = new System.Drawing.Point(204, 92);
            this.lbl_GW_4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GW_4.Name = "lbl_GW_4";
            this.lbl_GW_4.Size = new System.Drawing.Size(30, 30);
            this.lbl_GW_4.TabIndex = 22;
            this.lbl_GW_4.Text = "4";
            this.lbl_GW_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_5
            // 
            this.lbl_GW_5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GW_5.BackColor = System.Drawing.Color.Black;
            this.lbl_GW_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GW_5.ForeColor = System.Drawing.Color.White;
            this.lbl_GW_5.Location = new System.Drawing.Point(244, 92);
            this.lbl_GW_5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GW_5.Name = "lbl_GW_5";
            this.lbl_GW_5.Size = new System.Drawing.Size(30, 30);
            this.lbl_GW_5.TabIndex = 21;
            this.lbl_GW_5.Text = "5";
            this.lbl_GW_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_6
            // 
            this.lbl_GW_6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GW_6.BackColor = System.Drawing.Color.Black;
            this.lbl_GW_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GW_6.ForeColor = System.Drawing.Color.White;
            this.lbl_GW_6.Location = new System.Drawing.Point(284, 92);
            this.lbl_GW_6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GW_6.Name = "lbl_GW_6";
            this.lbl_GW_6.Size = new System.Drawing.Size(30, 30);
            this.lbl_GW_6.TabIndex = 20;
            this.lbl_GW_6.Text = "6";
            this.lbl_GW_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_7
            // 
            this.lbl_GW_7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GW_7.BackColor = System.Drawing.Color.Black;
            this.lbl_GW_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GW_7.ForeColor = System.Drawing.Color.White;
            this.lbl_GW_7.Location = new System.Drawing.Point(324, 92);
            this.lbl_GW_7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GW_7.Name = "lbl_GW_7";
            this.lbl_GW_7.Size = new System.Drawing.Size(30, 30);
            this.lbl_GW_7.TabIndex = 19;
            this.lbl_GW_7.Text = "7";
            this.lbl_GW_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_8
            // 
            this.lbl_GW_8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GW_8.BackColor = System.Drawing.Color.Black;
            this.lbl_GW_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GW_8.ForeColor = System.Drawing.Color.White;
            this.lbl_GW_8.Location = new System.Drawing.Point(364, 92);
            this.lbl_GW_8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GW_8.Name = "lbl_GW_8";
            this.lbl_GW_8.Size = new System.Drawing.Size(30, 30);
            this.lbl_GW_8.TabIndex = 18;
            this.lbl_GW_8.Text = "8";
            this.lbl_GW_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_10
            // 
            this.lbl_GW_10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GW_10.BackColor = System.Drawing.Color.Black;
            this.lbl_GW_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GW_10.ForeColor = System.Drawing.Color.White;
            this.lbl_GW_10.Location = new System.Drawing.Point(444, 92);
            this.lbl_GW_10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GW_10.Name = "lbl_GW_10";
            this.lbl_GW_10.Size = new System.Drawing.Size(30, 30);
            this.lbl_GW_10.TabIndex = 17;
            this.lbl_GW_10.Text = "10";
            this.lbl_GW_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_9
            // 
            this.lbl_GW_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GW_9.BackColor = System.Drawing.Color.Black;
            this.lbl_GW_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GW_9.ForeColor = System.Drawing.Color.White;
            this.lbl_GW_9.Location = new System.Drawing.Point(404, 92);
            this.lbl_GW_9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GW_9.Name = "lbl_GW_9";
            this.lbl_GW_9.Size = new System.Drawing.Size(30, 30);
            this.lbl_GW_9.TabIndex = 16;
            this.lbl_GW_9.Text = "9";
            this.lbl_GW_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_1
            // 
            this.lbl_GW_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GW_1.BackColor = System.Drawing.Color.Black;
            this.lbl_GW_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GW_1.ForeColor = System.Drawing.Color.White;
            this.lbl_GW_1.Location = new System.Drawing.Point(84, 92);
            this.lbl_GW_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GW_1.Name = "lbl_GW_1";
            this.lbl_GW_1.Size = new System.Drawing.Size(30, 30);
            this.lbl_GW_1.TabIndex = 15;
            this.lbl_GW_1.Text = "1";
            this.lbl_GW_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_B
            // 
            this.lbl_GW_B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GW_B.BackColor = System.Drawing.Color.Black;
            this.lbl_GW_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GW_B.ForeColor = System.Drawing.Color.White;
            this.lbl_GW_B.Location = new System.Drawing.Point(44, 172);
            this.lbl_GW_B.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GW_B.Name = "lbl_GW_B";
            this.lbl_GW_B.Size = new System.Drawing.Size(30, 30);
            this.lbl_GW_B.TabIndex = 14;
            this.lbl_GW_B.Text = "B";
            this.lbl_GW_B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_C
            // 
            this.lbl_GW_C.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GW_C.BackColor = System.Drawing.Color.Black;
            this.lbl_GW_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GW_C.ForeColor = System.Drawing.Color.White;
            this.lbl_GW_C.Location = new System.Drawing.Point(44, 212);
            this.lbl_GW_C.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GW_C.Name = "lbl_GW_C";
            this.lbl_GW_C.Size = new System.Drawing.Size(30, 30);
            this.lbl_GW_C.TabIndex = 13;
            this.lbl_GW_C.Text = "C";
            this.lbl_GW_C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_D
            // 
            this.lbl_GW_D.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GW_D.BackColor = System.Drawing.Color.Black;
            this.lbl_GW_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GW_D.ForeColor = System.Drawing.Color.White;
            this.lbl_GW_D.Location = new System.Drawing.Point(44, 252);
            this.lbl_GW_D.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GW_D.Name = "lbl_GW_D";
            this.lbl_GW_D.Size = new System.Drawing.Size(30, 30);
            this.lbl_GW_D.TabIndex = 12;
            this.lbl_GW_D.Text = "D";
            this.lbl_GW_D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_E
            // 
            this.lbl_GW_E.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GW_E.BackColor = System.Drawing.Color.Black;
            this.lbl_GW_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GW_E.ForeColor = System.Drawing.Color.White;
            this.lbl_GW_E.Location = new System.Drawing.Point(44, 292);
            this.lbl_GW_E.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GW_E.Name = "lbl_GW_E";
            this.lbl_GW_E.Size = new System.Drawing.Size(30, 30);
            this.lbl_GW_E.TabIndex = 11;
            this.lbl_GW_E.Text = "E";
            this.lbl_GW_E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_F
            // 
            this.lbl_GW_F.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GW_F.BackColor = System.Drawing.Color.Black;
            this.lbl_GW_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GW_F.ForeColor = System.Drawing.Color.White;
            this.lbl_GW_F.Location = new System.Drawing.Point(44, 333);
            this.lbl_GW_F.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GW_F.Name = "lbl_GW_F";
            this.lbl_GW_F.Size = new System.Drawing.Size(30, 30);
            this.lbl_GW_F.TabIndex = 10;
            this.lbl_GW_F.Text = "F";
            this.lbl_GW_F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_G
            // 
            this.lbl_GW_G.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GW_G.BackColor = System.Drawing.Color.Black;
            this.lbl_GW_G.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GW_G.ForeColor = System.Drawing.Color.White;
            this.lbl_GW_G.Location = new System.Drawing.Point(44, 373);
            this.lbl_GW_G.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GW_G.Name = "lbl_GW_G";
            this.lbl_GW_G.Size = new System.Drawing.Size(30, 30);
            this.lbl_GW_G.TabIndex = 9;
            this.lbl_GW_G.Text = "G";
            this.lbl_GW_G.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_H
            // 
            this.lbl_GW_H.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GW_H.BackColor = System.Drawing.Color.Black;
            this.lbl_GW_H.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GW_H.ForeColor = System.Drawing.Color.White;
            this.lbl_GW_H.Location = new System.Drawing.Point(44, 413);
            this.lbl_GW_H.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GW_H.Name = "lbl_GW_H";
            this.lbl_GW_H.Size = new System.Drawing.Size(30, 30);
            this.lbl_GW_H.TabIndex = 8;
            this.lbl_GW_H.Text = "H";
            this.lbl_GW_H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_J
            // 
            this.lbl_GW_J.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GW_J.BackColor = System.Drawing.Color.Black;
            this.lbl_GW_J.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GW_J.ForeColor = System.Drawing.Color.White;
            this.lbl_GW_J.Location = new System.Drawing.Point(44, 493);
            this.lbl_GW_J.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GW_J.Name = "lbl_GW_J";
            this.lbl_GW_J.Size = new System.Drawing.Size(30, 30);
            this.lbl_GW_J.TabIndex = 7;
            this.lbl_GW_J.Text = "J";
            this.lbl_GW_J.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_I
            // 
            this.lbl_GW_I.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GW_I.BackColor = System.Drawing.Color.Black;
            this.lbl_GW_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GW_I.ForeColor = System.Drawing.Color.White;
            this.lbl_GW_I.Location = new System.Drawing.Point(44, 453);
            this.lbl_GW_I.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GW_I.Name = "lbl_GW_I";
            this.lbl_GW_I.Size = new System.Drawing.Size(30, 30);
            this.lbl_GW_I.TabIndex = 6;
            this.lbl_GW_I.Text = "I";
            this.lbl_GW_I.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GW_A
            // 
            this.lbl_GW_A.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GW_A.BackColor = System.Drawing.Color.Black;
            this.lbl_GW_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GW_A.ForeColor = System.Drawing.Color.White;
            this.lbl_GW_A.Location = new System.Drawing.Point(44, 132);
            this.lbl_GW_A.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GW_A.Name = "lbl_GW_A";
            this.lbl_GW_A.Size = new System.Drawing.Size(30, 30);
            this.lbl_GW_A.TabIndex = 4;
            this.lbl_GW_A.Text = "A";
            this.lbl_GW_A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_GW_BoatStatuses
            // 
            this.pan_GW_BoatStatuses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_GW_BoatStatuses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_GW_BoatStatuses.Controls.Add(this.nud_BS_TurnTakenCount);
            this.pan_GW_BoatStatuses.Controls.Add(this.lbl_BS_TurnTaken);
            this.pan_GW_BoatStatuses.Controls.Add(this.pgb_BS_Battleship);
            this.pan_GW_BoatStatuses.Controls.Add(this.pgb_BS_Cruiser);
            this.pan_GW_BoatStatuses.Controls.Add(this.pgb_BS_Destroyer);
            this.pan_GW_BoatStatuses.Controls.Add(this.pgb_BS_Submarine);
            this.pan_GW_BoatStatuses.Controls.Add(this.pgb_BS_Carrier);
            this.pan_GW_BoatStatuses.Controls.Add(this.lbl_BS_Destroyer);
            this.pan_GW_BoatStatuses.Controls.Add(this.lbl_BS_Submarine);
            this.pan_GW_BoatStatuses.Controls.Add(this.lbl_BS_Cruiser);
            this.pan_GW_BoatStatuses.Controls.Add(this.lbl_BS_Battleship);
            this.pan_GW_BoatStatuses.Controls.Add(this.lbl_BS_Carrier);
            this.pan_GW_BoatStatuses.Controls.Add(this.lbl_BS_BoatStatuses);
            this.pan_GW_BoatStatuses.Location = new System.Drawing.Point(520, 9);
            this.pan_GW_BoatStatuses.Margin = new System.Windows.Forms.Padding(2);
            this.pan_GW_BoatStatuses.Name = "pan_GW_BoatStatuses";
            this.pan_GW_BoatStatuses.Size = new System.Drawing.Size(204, 216);
            this.pan_GW_BoatStatuses.TabIndex = 3;
            // 
            // nud_BS_TurnTakenCount
            // 
            this.nud_BS_TurnTakenCount.Enabled = false;
            this.nud_BS_TurnTakenCount.Location = new System.Drawing.Point(106, 189);
            this.nud_BS_TurnTakenCount.Name = "nud_BS_TurnTakenCount";
            this.nud_BS_TurnTakenCount.Size = new System.Drawing.Size(86, 20);
            this.nud_BS_TurnTakenCount.TabIndex = 12;
            // 
            // lbl_BS_TurnTaken
            // 
            this.lbl_BS_TurnTaken.AutoSize = true;
            this.lbl_BS_TurnTaken.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BS_TurnTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BS_TurnTaken.ForeColor = System.Drawing.Color.White;
            this.lbl_BS_TurnTaken.Location = new System.Drawing.Point(7, 189);
            this.lbl_BS_TurnTaken.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_BS_TurnTaken.Name = "lbl_BS_TurnTaken";
            this.lbl_BS_TurnTaken.Size = new System.Drawing.Size(79, 15);
            this.lbl_BS_TurnTaken.TabIndex = 11;
            this.lbl_BS_TurnTaken.Text = "Turn Taken";
            // 
            // pgb_BS_Battleship
            // 
            this.pgb_BS_Battleship.BackColor = System.Drawing.Color.White;
            this.pgb_BS_Battleship.ForeColor = System.Drawing.Color.Lime;
            this.pgb_BS_Battleship.Location = new System.Drawing.Point(106, 75);
            this.pgb_BS_Battleship.Margin = new System.Windows.Forms.Padding(2);
            this.pgb_BS_Battleship.Maximum = 1;
            this.pgb_BS_Battleship.Name = "pgb_BS_Battleship";
            this.pgb_BS_Battleship.Size = new System.Drawing.Size(86, 14);
            this.pgb_BS_Battleship.Step = 1;
            this.pgb_BS_Battleship.TabIndex = 10;
            // 
            // pgb_BS_Cruiser
            // 
            this.pgb_BS_Cruiser.BackColor = System.Drawing.Color.White;
            this.pgb_BS_Cruiser.ForeColor = System.Drawing.Color.Lime;
            this.pgb_BS_Cruiser.Location = new System.Drawing.Point(106, 104);
            this.pgb_BS_Cruiser.Margin = new System.Windows.Forms.Padding(2);
            this.pgb_BS_Cruiser.Maximum = 1;
            this.pgb_BS_Cruiser.Name = "pgb_BS_Cruiser";
            this.pgb_BS_Cruiser.Size = new System.Drawing.Size(86, 14);
            this.pgb_BS_Cruiser.Step = 1;
            this.pgb_BS_Cruiser.TabIndex = 9;
            // 
            // pgb_BS_Destroyer
            // 
            this.pgb_BS_Destroyer.BackColor = System.Drawing.Color.White;
            this.pgb_BS_Destroyer.ForeColor = System.Drawing.Color.Lime;
            this.pgb_BS_Destroyer.Location = new System.Drawing.Point(106, 161);
            this.pgb_BS_Destroyer.Margin = new System.Windows.Forms.Padding(2);
            this.pgb_BS_Destroyer.Maximum = 1;
            this.pgb_BS_Destroyer.Name = "pgb_BS_Destroyer";
            this.pgb_BS_Destroyer.Size = new System.Drawing.Size(86, 14);
            this.pgb_BS_Destroyer.Step = 1;
            this.pgb_BS_Destroyer.TabIndex = 8;
            // 
            // pgb_BS_Submarine
            // 
            this.pgb_BS_Submarine.BackColor = System.Drawing.Color.White;
            this.pgb_BS_Submarine.ForeColor = System.Drawing.Color.Lime;
            this.pgb_BS_Submarine.Location = new System.Drawing.Point(106, 133);
            this.pgb_BS_Submarine.Margin = new System.Windows.Forms.Padding(2);
            this.pgb_BS_Submarine.Maximum = 1;
            this.pgb_BS_Submarine.Name = "pgb_BS_Submarine";
            this.pgb_BS_Submarine.Size = new System.Drawing.Size(86, 14);
            this.pgb_BS_Submarine.Step = 1;
            this.pgb_BS_Submarine.TabIndex = 7;
            // 
            // pgb_BS_Carrier
            // 
            this.pgb_BS_Carrier.BackColor = System.Drawing.Color.White;
            this.pgb_BS_Carrier.ForeColor = System.Drawing.Color.Lime;
            this.pgb_BS_Carrier.Location = new System.Drawing.Point(106, 47);
            this.pgb_BS_Carrier.Margin = new System.Windows.Forms.Padding(2);
            this.pgb_BS_Carrier.Maximum = 1;
            this.pgb_BS_Carrier.Name = "pgb_BS_Carrier";
            this.pgb_BS_Carrier.Size = new System.Drawing.Size(86, 14);
            this.pgb_BS_Carrier.Step = 1;
            this.pgb_BS_Carrier.TabIndex = 6;
            // 
            // lbl_BS_Destroyer
            // 
            this.lbl_BS_Destroyer.AutoSize = true;
            this.lbl_BS_Destroyer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BS_Destroyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BS_Destroyer.ForeColor = System.Drawing.Color.White;
            this.lbl_BS_Destroyer.Location = new System.Drawing.Point(7, 161);
            this.lbl_BS_Destroyer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_BS_Destroyer.Name = "lbl_BS_Destroyer";
            this.lbl_BS_Destroyer.Size = new System.Drawing.Size(90, 15);
            this.lbl_BS_Destroyer.TabIndex = 5;
            this.lbl_BS_Destroyer.Text = "Destroyer (2)";
            // 
            // lbl_BS_Submarine
            // 
            this.lbl_BS_Submarine.AutoSize = true;
            this.lbl_BS_Submarine.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BS_Submarine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BS_Submarine.ForeColor = System.Drawing.Color.White;
            this.lbl_BS_Submarine.Location = new System.Drawing.Point(7, 133);
            this.lbl_BS_Submarine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_BS_Submarine.Name = "lbl_BS_Submarine";
            this.lbl_BS_Submarine.Size = new System.Drawing.Size(99, 15);
            this.lbl_BS_Submarine.TabIndex = 4;
            this.lbl_BS_Submarine.Text = "Submarine (3)";
            // 
            // lbl_BS_Cruiser
            // 
            this.lbl_BS_Cruiser.AutoSize = true;
            this.lbl_BS_Cruiser.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BS_Cruiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BS_Cruiser.ForeColor = System.Drawing.Color.White;
            this.lbl_BS_Cruiser.Location = new System.Drawing.Point(7, 104);
            this.lbl_BS_Cruiser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_BS_Cruiser.Name = "lbl_BS_Cruiser";
            this.lbl_BS_Cruiser.Size = new System.Drawing.Size(75, 15);
            this.lbl_BS_Cruiser.TabIndex = 3;
            this.lbl_BS_Cruiser.Text = "Cruiser (3)";
            // 
            // lbl_BS_Battleship
            // 
            this.lbl_BS_Battleship.AutoSize = true;
            this.lbl_BS_Battleship.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BS_Battleship.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BS_Battleship.ForeColor = System.Drawing.Color.White;
            this.lbl_BS_Battleship.Location = new System.Drawing.Point(7, 75);
            this.lbl_BS_Battleship.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_BS_Battleship.Name = "lbl_BS_Battleship";
            this.lbl_BS_Battleship.Size = new System.Drawing.Size(93, 15);
            this.lbl_BS_Battleship.TabIndex = 2;
            this.lbl_BS_Battleship.Text = "Battleship (4)";
            // 
            // lbl_BS_Carrier
            // 
            this.lbl_BS_Carrier.AutoSize = true;
            this.lbl_BS_Carrier.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BS_Carrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BS_Carrier.ForeColor = System.Drawing.Color.White;
            this.lbl_BS_Carrier.Location = new System.Drawing.Point(7, 47);
            this.lbl_BS_Carrier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_BS_Carrier.Name = "lbl_BS_Carrier";
            this.lbl_BS_Carrier.Size = new System.Drawing.Size(73, 15);
            this.lbl_BS_Carrier.TabIndex = 1;
            this.lbl_BS_Carrier.Text = "Carrier (5)";
            // 
            // lbl_BS_BoatStatuses
            // 
            this.lbl_BS_BoatStatuses.BackColor = System.Drawing.Color.Black;
            this.lbl_BS_BoatStatuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BS_BoatStatuses.ForeColor = System.Drawing.Color.White;
            this.lbl_BS_BoatStatuses.Location = new System.Drawing.Point(0, 0);
            this.lbl_BS_BoatStatuses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_BS_BoatStatuses.Name = "lbl_BS_BoatStatuses";
            this.lbl_BS_BoatStatuses.Size = new System.Drawing.Size(204, 34);
            this.lbl_BS_BoatStatuses.TabIndex = 0;
            this.lbl_BS_BoatStatuses.Text = "Boat Statuses";
            this.lbl_BS_BoatStatuses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBattleShip
            // 
            this.AcceptButton = this.btn_NewGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment02.Properties.Resources.wp11552736_battleship_game_wallpapers__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.pan_GameWindow);
            this.Controls.Add(this.pan_BattleShip_Heading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(750, 750);
            this.MinimumSize = new System.Drawing.Size(750, 750);
            this.Name = "frmBattleShip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle Ship";
            this.Load += new System.EventHandler(this.frmBattleShip_Load);
            this.pan_BattleShip_Heading.ResumeLayout(false);
            this.pan_GameWindow.ResumeLayout(false);
            this.pan_GW_LaunchMissile.ResumeLayout(false);
            this.pan_GW_LaunchMissile.PerformLayout();
            this.pan_GW_BoatStatuses.ResumeLayout(false);
            this.pan_GW_BoatStatuses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BS_TurnTakenCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_BattleShip_Heading;
        private System.Windows.Forms.Label lbl_BSH_BattleShip;
        private System.Windows.Forms.Panel pan_GameWindow;
        private System.Windows.Forms.Button btn_ShowBoats;
        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel pan_GW_BoatStatuses;
        private System.Windows.Forms.Label lbl_BS_BoatStatuses;
        private System.Windows.Forms.Label lbl_BS_Destroyer;
        private System.Windows.Forms.Label lbl_BS_Submarine;
        private System.Windows.Forms.Label lbl_BS_Cruiser;
        private System.Windows.Forms.Label lbl_BS_Battleship;
        private System.Windows.Forms.Label lbl_BS_Carrier;
        private System.Windows.Forms.ProgressBar pgb_BS_Battleship;
        private System.Windows.Forms.ProgressBar pgb_BS_Cruiser;
        private System.Windows.Forms.ProgressBar pgb_BS_Destroyer;
        private System.Windows.Forms.ProgressBar pgb_BS_Submarine;
        private System.Windows.Forms.ProgressBar pgb_BS_Carrier;
        private System.Windows.Forms.Label lbl_GW_B;
        private System.Windows.Forms.Label lbl_GW_C;
        private System.Windows.Forms.Label lbl_GW_D;
        private System.Windows.Forms.Label lbl_GW_E;
        private System.Windows.Forms.Label lbl_GW_F;
        private System.Windows.Forms.Label lbl_GW_G;
        private System.Windows.Forms.Label lbl_GW_H;
        private System.Windows.Forms.Label lbl_GW_J;
        private System.Windows.Forms.Label lbl_GW_I;
        private System.Windows.Forms.Label lbl_GW_A;
        private System.Windows.Forms.Label lbl_GW_2;
        private System.Windows.Forms.Label lbl_GW_3;
        private System.Windows.Forms.Label lbl_GW_4;
        private System.Windows.Forms.Label lbl_GW_5;
        private System.Windows.Forms.Label lbl_GW_6;
        private System.Windows.Forms.Label lbl_GW_7;
        private System.Windows.Forms.Label lbl_GW_8;
        private System.Windows.Forms.Label lbl_GW_10;
        private System.Windows.Forms.Label lbl_GW_9;
        private System.Windows.Forms.Label lbl_GW_1;
        private System.Windows.Forms.NumericUpDown nud_BS_TurnTakenCount;
        private System.Windows.Forms.Label lbl_BS_TurnTaken;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pan_GW_LaunchMissile;
        private System.Windows.Forms.Label lbl_LM_LaunchMissile;
        private System.Windows.Forms.ComboBox cbo_LM_X;
        private System.Windows.Forms.Label lbl_LM_SelectCoordinates;
        private System.Windows.Forms.Label lbl_LM_Y;
        private System.Windows.Forms.Label lbl_LM_X;
        private System.Windows.Forms.ComboBox cbo_LM_Y;
        private System.Windows.Forms.Button btn_LM_Launch;
    }
}

