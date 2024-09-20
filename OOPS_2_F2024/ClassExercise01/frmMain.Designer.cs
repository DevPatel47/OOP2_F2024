namespace ClassExercise01
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnIceCream = new System.Windows.Forms.Button();
            this.btnGuessTheNumber = new System.Windows.Forms.Button();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.panGuessTheNumber = new System.Windows.Forms.Panel();
            this.btn_GTN_exit = new System.Windows.Forms.Button();
            this.nudGTNNumGuesses = new System.Windows.Forms.NumericUpDown();
            this.nudGTNRandomNumber = new System.Windows.Forms.NumericUpDown();
            this.lbl_GTN_Output = new System.Windows.Forms.Label();
            this.btn_GTN_Guess = new System.Windows.Forms.Button();
            this.gbx_GTN_Settings = new System.Windows.Forms.GroupBox();
            this.lbl_GTN_DifficultyInstructions = new System.Windows.Forms.Label();
            this.cbo_GTN_Difficulty = new System.Windows.Forms.ComboBox();
            this.lbl_GTN_Difficulty = new System.Windows.Forms.Label();
            this.lbl_GTN_Title = new System.Windows.Forms.Label();
            this.lblGuessedNumber = new System.Windows.Forms.Label();
            this.nudGuessedNumber = new System.Windows.Forms.NumericUpDown();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.panMenu.SuspendLayout();
            this.panGuessTheNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNNumGuesses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNRandomNumber)).BeginInit();
            this.gbx_GTN_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuessedNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panMenu.BackColor = System.Drawing.Color.Black;
            this.panMenu.Controls.Add(this.btnIceCream);
            this.panMenu.Controls.Add(this.btnGuessTheNumber);
            this.panMenu.Controls.Add(this.lblMenuTitle);
            this.panMenu.Location = new System.Drawing.Point(0, 0);
            this.panMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(209, 926);
            this.panMenu.TabIndex = 0;
            // 
            // btnIceCream
            // 
            this.btnIceCream.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnIceCream.Location = new System.Drawing.Point(13, 225);
            this.btnIceCream.Margin = new System.Windows.Forms.Padding(4);
            this.btnIceCream.Name = "btnIceCream";
            this.btnIceCream.Size = new System.Drawing.Size(183, 76);
            this.btnIceCream.TabIndex = 2;
            this.btnIceCream.Text = "&Ice Cream";
            this.btnIceCream.UseVisualStyleBackColor = false;
            // 
            // btnGuessTheNumber
            // 
            this.btnGuessTheNumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGuessTheNumber.Location = new System.Drawing.Point(13, 141);
            this.btnGuessTheNumber.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuessTheNumber.Name = "btnGuessTheNumber";
            this.btnGuessTheNumber.Size = new System.Drawing.Size(183, 76);
            this.btnGuessTheNumber.TabIndex = 1;
            this.btnGuessTheNumber.Text = "&Guess The Number";
            this.toolTips.SetToolTip(this.btnGuessTheNumber, "Play Guess the Number game (ALT + G)");
            this.btnGuessTheNumber.UseVisualStyleBackColor = false;
            this.btnGuessTheNumber.Click += new System.EventHandler(this.btnGuessTheNumber_Click);
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMenuTitle.Location = new System.Drawing.Point(9, 10);
            this.lblMenuTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(189, 121);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.Text = "My Little Games";
            this.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panGuessTheNumber
            // 
            this.panGuessTheNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panGuessTheNumber.Controls.Add(this.btn_GTN_exit);
            this.panGuessTheNumber.Controls.Add(this.nudGTNNumGuesses);
            this.panGuessTheNumber.Controls.Add(this.nudGTNRandomNumber);
            this.panGuessTheNumber.Controls.Add(this.lbl_GTN_Output);
            this.panGuessTheNumber.Controls.Add(this.btn_GTN_Guess);
            this.panGuessTheNumber.Controls.Add(this.gbx_GTN_Settings);
            this.panGuessTheNumber.Controls.Add(this.lbl_GTN_Title);
            this.panGuessTheNumber.Controls.Add(this.lblGuessedNumber);
            this.panGuessTheNumber.Controls.Add(this.nudGuessedNumber);
            this.panGuessTheNumber.Location = new System.Drawing.Point(217, 15);
            this.panGuessTheNumber.Margin = new System.Windows.Forms.Padding(4);
            this.panGuessTheNumber.Name = "panGuessTheNumber";
            this.panGuessTheNumber.Size = new System.Drawing.Size(889, 898);
            this.panGuessTheNumber.TabIndex = 1;
            this.panGuessTheNumber.Visible = false;
            this.panGuessTheNumber.Paint += new System.Windows.Forms.PaintEventHandler(this.panGuessTheNumber_Paint);
            // 
            // btn_GTN_exit
            // 
            this.btn_GTN_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GTN_exit.Location = new System.Drawing.Point(727, 805);
            this.btn_GTN_exit.Name = "btn_GTN_exit";
            this.btn_GTN_exit.Size = new System.Drawing.Size(139, 47);
            this.btn_GTN_exit.TabIndex = 7;
            this.btn_GTN_exit.Text = "E&xit";
            this.toolTips.SetToolTip(this.btn_GTN_exit, "Click to exit Guess The Number game (ALT + X)");
            this.btn_GTN_exit.UseVisualStyleBackColor = true;
            this.btn_GTN_exit.Click += new System.EventHandler(this.btn_GTN_exit_Click);
            // 
            // nudGTNNumGuesses
            // 
            this.nudGTNNumGuesses.Enabled = false;
            this.nudGTNNumGuesses.Location = new System.Drawing.Point(698, 18);
            this.nudGTNNumGuesses.Margin = new System.Windows.Forms.Padding(4);
            this.nudGTNNumGuesses.Name = "nudGTNNumGuesses";
            this.nudGTNNumGuesses.Size = new System.Drawing.Size(160, 31);
            this.nudGTNNumGuesses.TabIndex = 6;
            this.nudGTNNumGuesses.Visible = false;
            // 
            // nudGTNRandomNumber
            // 
            this.nudGTNRandomNumber.Location = new System.Drawing.Point(698, 57);
            this.nudGTNRandomNumber.Margin = new System.Windows.Forms.Padding(4);
            this.nudGTNRandomNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGTNRandomNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGTNRandomNumber.Name = "nudGTNRandomNumber";
            this.nudGTNRandomNumber.Size = new System.Drawing.Size(160, 31);
            this.nudGTNRandomNumber.TabIndex = 5;
            this.nudGTNRandomNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGTNRandomNumber.Visible = false;
            // 
            // lbl_GTN_Output
            // 
            this.lbl_GTN_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GTN_Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_GTN_Output.Location = new System.Drawing.Point(29, 539);
            this.lbl_GTN_Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GTN_Output.Name = "lbl_GTN_Output";
            this.lbl_GTN_Output.Size = new System.Drawing.Size(837, 236);
            this.lbl_GTN_Output.TabIndex = 3;
            // 
            // btn_GTN_Guess
            // 
            this.btn_GTN_Guess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GTN_Guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GTN_Guess.Location = new System.Drawing.Point(29, 336);
            this.btn_GTN_Guess.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GTN_Guess.Name = "btn_GTN_Guess";
            this.btn_GTN_Guess.Size = new System.Drawing.Size(837, 169);
            this.btn_GTN_Guess.TabIndex = 5;
            this.btn_GTN_Guess.Text = "Click to Guess";
            this.toolTips.SetToolTip(this.btn_GTN_Guess, "Click to Guess");
            this.btn_GTN_Guess.UseVisualStyleBackColor = true;
            this.btn_GTN_Guess.Click += new System.EventHandler(this.btn_GTN_Guess_Click);
            // 
            // gbx_GTN_Settings
            // 
            this.gbx_GTN_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_GTN_Settings.Controls.Add(this.lbl_GTN_DifficultyInstructions);
            this.gbx_GTN_Settings.Controls.Add(this.cbo_GTN_Difficulty);
            this.gbx_GTN_Settings.Controls.Add(this.lbl_GTN_Difficulty);
            this.gbx_GTN_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_GTN_Settings.Location = new System.Drawing.Point(29, 89);
            this.gbx_GTN_Settings.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_GTN_Settings.Name = "gbx_GTN_Settings";
            this.gbx_GTN_Settings.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_GTN_Settings.Size = new System.Drawing.Size(837, 153);
            this.gbx_GTN_Settings.TabIndex = 3;
            this.gbx_GTN_Settings.TabStop = false;
            this.gbx_GTN_Settings.Text = "Settings";
            this.gbx_GTN_Settings.Enter += new System.EventHandler(this.gbx_GTN_Settings_Enter);
            // 
            // lbl_GTN_DifficultyInstructions
            // 
            this.lbl_GTN_DifficultyInstructions.AutoSize = true;
            this.lbl_GTN_DifficultyInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GTN_DifficultyInstructions.Location = new System.Drawing.Point(31, 110);
            this.lbl_GTN_DifficultyInstructions.Name = "lbl_GTN_DifficultyInstructions";
            this.lbl_GTN_DifficultyInstructions.Size = new System.Drawing.Size(0, 25);
            this.lbl_GTN_DifficultyInstructions.TabIndex = 9;
            // 
            // cbo_GTN_Difficulty
            // 
            this.cbo_GTN_Difficulty.FormattingEnabled = true;
            this.cbo_GTN_Difficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cbo_GTN_Difficulty.Location = new System.Drawing.Point(365, 37);
            this.cbo_GTN_Difficulty.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_GTN_Difficulty.Name = "cbo_GTN_Difficulty";
            this.cbo_GTN_Difficulty.Size = new System.Drawing.Size(182, 39);
            this.cbo_GTN_Difficulty.TabIndex = 0;
            this.toolTips.SetToolTip(this.cbo_GTN_Difficulty, "Select difficulty level");
            this.cbo_GTN_Difficulty.SelectedIndexChanged += new System.EventHandler(this.cbo_GTN_Difficulty_SelectedIndexChanged);
            // 
            // lbl_GTN_Difficulty
            // 
            this.lbl_GTN_Difficulty.Location = new System.Drawing.Point(3, 42);
            this.lbl_GTN_Difficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GTN_Difficulty.Name = "lbl_GTN_Difficulty";
            this.lbl_GTN_Difficulty.Size = new System.Drawing.Size(341, 34);
            this.lbl_GTN_Difficulty.TabIndex = 1;
            this.lbl_GTN_Difficulty.Text = "Select Dificulty Level";
            this.lbl_GTN_Difficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GTN_Title
            // 
            this.lbl_GTN_Title.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GTN_Title.Location = new System.Drawing.Point(19, 18);
            this.lbl_GTN_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GTN_Title.Name = "lbl_GTN_Title";
            this.lbl_GTN_Title.Size = new System.Drawing.Size(847, 68);
            this.lbl_GTN_Title.TabIndex = 2;
            this.lbl_GTN_Title.Text = "Guess The Number";
            this.lbl_GTN_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_GTN_Title.Click += new System.EventHandler(this.lbl_GTN_Title_Click);
            // 
            // lblGuessedNumber
            // 
            this.lblGuessedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            this.lblGuessedNumber.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblGuessedNumber.Location = new System.Drawing.Point(32, 266);
            this.lblGuessedNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuessedNumber.Name = "lblGuessedNumber";
            this.lblGuessedNumber.Size = new System.Drawing.Size(526, 50);
            this.lblGuessedNumber.TabIndex = 1;
            this.lblGuessedNumber.Text = "Enter a number that you want to guess";
            this.lblGuessedNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudGuessedNumber
            // 
            this.nudGuessedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            this.nudGuessedNumber.Location = new System.Drawing.Point(566, 266);
            this.nudGuessedNumber.Margin = new System.Windows.Forms.Padding(4);
            this.nudGuessedNumber.Name = "nudGuessedNumber";
            this.nudGuessedNumber.Size = new System.Drawing.Size(144, 38);
            this.nudGuessedNumber.TabIndex = 4;
            this.toolTips.SetToolTip(this.nudGuessedNumber, "Enter number to Guess");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1123, 926);
            this.Controls.Add(this.panGuessTheNumber);
            this.Controls.Add(this.panMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Little Games";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panMenu.ResumeLayout(false);
            this.panGuessTheNumber.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNNumGuesses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNRandomNumber)).EndInit();
            this.gbx_GTN_Settings.ResumeLayout(false);
            this.gbx_GTN_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuessedNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Button btnGuessTheNumber;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnIceCream;
        private System.Windows.Forms.Panel panGuessTheNumber;
        private System.Windows.Forms.Label lbl_GTN_Title;
        private System.Windows.Forms.Label lblGuessedNumber;
        private System.Windows.Forms.NumericUpDown nudGuessedNumber;
        private System.Windows.Forms.GroupBox gbx_GTN_Settings;
        private System.Windows.Forms.ComboBox cbo_GTN_Difficulty;
        private System.Windows.Forms.Label lbl_GTN_Difficulty;
        private System.Windows.Forms.Label lbl_GTN_Output;
        private System.Windows.Forms.Button btn_GTN_Guess;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.NumericUpDown nudGTNRandomNumber;
        private System.Windows.Forms.NumericUpDown nudGTNNumGuesses;
        private System.Windows.Forms.Label lbl_GTN_DifficultyInstructions;
        private System.Windows.Forms.Button btn_GTN_exit;
    }
}

