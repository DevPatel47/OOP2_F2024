namespace Assignment05
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ts_tbx_user = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_User_logOut = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_user_deleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_tbx_about = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_about_aboutDeveloper = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.StatusStrip();
            this.tss_lbl_UserDetails = new System.Windows.Forms.ToolStripStatusLabel();
            this.gameReviewsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bds_reviews = new System.Windows.Forms.BindingSource(this.components);
            this.vgr_dts_reviews = new Assignment05.VideoGameReviewsDataSet2();
            this.dgv_games = new System.Windows.Forms.DataGridView();
            this.GameID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bds_games = new System.Windows.Forms.BindingSource(this.components);
            this.vgr_dts_games = new Assignment05.VideoGameReviewsDataSet1();
            this.gbx_addReview = new System.Windows.Forms.GroupBox();
            this.btn_addReview = new System.Windows.Forms.Button();
            this.tbr_Rating = new System.Windows.Forms.TrackBar();
            this.lbl_rate = new System.Windows.Forms.Label();
            this.tbx_Review = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_DeleteReview = new System.Windows.Forms.Button();
            this.gamesTableAdapter = new Assignment05.VideoGameReviewsDataSet1TableAdapters.GamesTableAdapter();
            this.reviewsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reviewsTableAdapter = new Assignment05.VideoGameReviewsDataSet2TableAdapters.ReviewsTableAdapter();
            this.gameReviewsTableAdapter = new Assignment05.VideoGameReviewsDataSet2TableAdapters.GameReviewsTableAdapter();
            this.lbl_games = new System.Windows.Forms.Label();
            this.lbl_reviews = new System.Windows.Forms.Label();
            this.dgv_reviews = new System.Windows.Forms.DataGridView();
            this.ReviewID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameReviewsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameReviewsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_reviews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vgr_dts_reviews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_games)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_games)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vgr_dts_games)).BeginInit();
            this.gbx_addReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_Rating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reviews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameReviewsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_tbx_user,
            this.ts_tbx_about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ts_tbx_user
            // 
            this.ts_tbx_user.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_User_logOut,
            this.ts_user_deleteUser});
            this.ts_tbx_user.Name = "ts_tbx_user";
            this.ts_tbx_user.Size = new System.Drawing.Size(42, 20);
            this.ts_tbx_user.Text = "User";
            // 
            // ts_User_logOut
            // 
            this.ts_User_logOut.Name = "ts_User_logOut";
            this.ts_User_logOut.Size = new System.Drawing.Size(180, 22);
            this.ts_User_logOut.Text = "Log Out";
            this.ts_User_logOut.Click += new System.EventHandler(this.ts_User_logOut_Click);
            // 
            // ts_user_deleteUser
            // 
            this.ts_user_deleteUser.Name = "ts_user_deleteUser";
            this.ts_user_deleteUser.Size = new System.Drawing.Size(180, 22);
            this.ts_user_deleteUser.Text = "Delete User";
            this.ts_user_deleteUser.Click += new System.EventHandler(this.ts_user_deleteUser_Click);
            // 
            // ts_tbx_about
            // 
            this.ts_tbx_about.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_about_aboutDeveloper});
            this.ts_tbx_about.Name = "ts_tbx_about";
            this.ts_tbx_about.Size = new System.Drawing.Size(52, 20);
            this.ts_tbx_about.Text = "About";
            // 
            // ts_about_aboutDeveloper
            // 
            this.ts_about_aboutDeveloper.Name = "ts_about_aboutDeveloper";
            this.ts_about_aboutDeveloper.Size = new System.Drawing.Size(163, 22);
            this.ts_about_aboutDeveloper.Text = "About Developer";
            this.ts_about_aboutDeveloper.Click += new System.EventHandler(this.ts_about_aboutDeveloper_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_lbl_UserDetails});
            this.toolStrip.Location = new System.Drawing.Point(0, 639);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(834, 22);
            this.toolStrip.TabIndex = 1;
            // 
            // tss_lbl_UserDetails
            // 
            this.tss_lbl_UserDetails.BackColor = System.Drawing.Color.Transparent;
            this.tss_lbl_UserDetails.Name = "tss_lbl_UserDetails";
            this.tss_lbl_UserDetails.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.tss_lbl_UserDetails.Size = new System.Drawing.Size(80, 17);
            this.tss_lbl_UserDetails.Text = "User";
            // 
            // gameReviewsBindingSource
            // 
            this.gameReviewsBindingSource.DataMember = "GameReviews";
            this.gameReviewsBindingSource.DataSource = this.bds_reviews;
            // 
            // bds_reviews
            // 
            this.bds_reviews.DataSource = this.vgr_dts_reviews;
            this.bds_reviews.Position = 0;
            // 
            // vgr_dts_reviews
            // 
            this.vgr_dts_reviews.DataSetName = "VideoGameReviewsDataSet2";
            this.vgr_dts_reviews.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv_games
            // 
            this.dgv_games.AllowUserToAddRows = false;
            this.dgv_games.AllowUserToDeleteRows = false;
            this.dgv_games.AutoGenerateColumns = false;
            this.dgv_games.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_games.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_games.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_games.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GameID,
            this.titleDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn});
            this.dgv_games.DataSource = this.gamesBindingSource;
            this.dgv_games.Location = new System.Drawing.Point(12, 59);
            this.dgv_games.Name = "dgv_games";
            this.dgv_games.ReadOnly = true;
            this.dgv_games.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_games.Size = new System.Drawing.Size(415, 235);
            this.dgv_games.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dgv_games, "Click to select Game");
            this.dgv_games.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_games_CellClick);
            // 
            // GameID
            // 
            this.GameID.DataPropertyName = "GameID";
            this.GameID.HeaderText = "GameID";
            this.GameID.Name = "GameID";
            this.GameID.ReadOnly = true;
            this.GameID.Width = 50;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 115;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            this.releaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.releaseDateDataGridViewTextBoxColumn.Width = 85;
            // 
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataMember = "Games";
            this.gamesBindingSource.DataSource = this.bds_games;
            // 
            // bds_games
            // 
            this.bds_games.DataSource = this.vgr_dts_games;
            this.bds_games.Position = 0;
            // 
            // vgr_dts_games
            // 
            this.vgr_dts_games.DataSetName = "VideoGameReviewsDataSet1";
            this.vgr_dts_games.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbx_addReview
            // 
            this.gbx_addReview.Controls.Add(this.btn_addReview);
            this.gbx_addReview.Controls.Add(this.tbr_Rating);
            this.gbx_addReview.Controls.Add(this.lbl_rate);
            this.gbx_addReview.Controls.Add(this.tbx_Review);
            this.gbx_addReview.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_addReview.Location = new System.Drawing.Point(433, 27);
            this.gbx_addReview.Name = "gbx_addReview";
            this.gbx_addReview.Size = new System.Drawing.Size(389, 267);
            this.gbx_addReview.TabIndex = 4;
            this.gbx_addReview.TabStop = false;
            this.gbx_addReview.Text = "Add Review";
            // 
            // btn_addReview
            // 
            this.btn_addReview.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F);
            this.btn_addReview.Location = new System.Drawing.Point(112, 225);
            this.btn_addReview.Name = "btn_addReview";
            this.btn_addReview.Size = new System.Drawing.Size(161, 36);
            this.btn_addReview.TabIndex = 6;
            this.btn_addReview.Text = "&Add Review";
            this.toolTip1.SetToolTip(this.btn_addReview, "Click to Add Review");
            this.btn_addReview.UseVisualStyleBackColor = true;
            this.btn_addReview.Click += new System.EventHandler(this.btn_addReview_Click);
            // 
            // tbr_Rating
            // 
            this.tbr_Rating.AutoSize = false;
            this.tbr_Rating.LargeChange = 2;
            this.tbr_Rating.Location = new System.Drawing.Point(77, 32);
            this.tbr_Rating.Minimum = 1;
            this.tbr_Rating.Name = "tbr_Rating";
            this.tbr_Rating.Size = new System.Drawing.Size(288, 20);
            this.tbr_Rating.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tbr_Rating, "Move the dial to give Rating");
            this.tbr_Rating.Value = 1;
            // 
            // lbl_rate
            // 
            this.lbl_rate.AutoSize = true;
            this.lbl_rate.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rate.Location = new System.Drawing.Point(28, 32);
            this.lbl_rate.Name = "lbl_rate";
            this.lbl_rate.Size = new System.Drawing.Size(43, 20);
            this.lbl_rate.TabIndex = 14;
            this.lbl_rate.Text = "Rate";
            this.lbl_rate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_Review
            // 
            this.tbx_Review.Location = new System.Drawing.Point(6, 80);
            this.tbx_Review.Multiline = true;
            this.tbx_Review.Name = "tbx_Review";
            this.tbx_Review.Size = new System.Drawing.Size(377, 139);
            this.tbx_Review.TabIndex = 5;
            this.toolTip1.SetToolTip(this.tbx_Review, "Click to Enter Review");
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F);
            this.btn_exit.Location = new System.Drawing.Point(728, 600);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(102, 36);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btn_exit, "Click to Exit");
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_DeleteReview
            // 
            this.btn_DeleteReview.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F);
            this.btn_DeleteReview.Location = new System.Drawing.Point(561, 601);
            this.btn_DeleteReview.Name = "btn_DeleteReview";
            this.btn_DeleteReview.Size = new System.Drawing.Size(161, 36);
            this.btn_DeleteReview.TabIndex = 7;
            this.btn_DeleteReview.Text = "&Delete Review";
            this.toolTip1.SetToolTip(this.btn_DeleteReview, "Click to Delete Review");
            this.btn_DeleteReview.UseVisualStyleBackColor = true;
            this.btn_DeleteReview.Click += new System.EventHandler(this.btn_DeleteReview_Click);
            // 
            // gamesTableAdapter
            // 
            this.gamesTableAdapter.ClearBeforeFill = true;
            // 
            // reviewsBindingSource
            // 
            this.reviewsBindingSource.DataMember = "Reviews";
            this.reviewsBindingSource.DataSource = this.bds_reviews;
            // 
            // reviewsTableAdapter
            // 
            this.reviewsTableAdapter.ClearBeforeFill = true;
            // 
            // gameReviewsTableAdapter
            // 
            this.gameReviewsTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_games
            // 
            this.lbl_games.BackColor = System.Drawing.Color.Black;
            this.lbl_games.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_games.ForeColor = System.Drawing.Color.White;
            this.lbl_games.Location = new System.Drawing.Point(12, 27);
            this.lbl_games.Name = "lbl_games";
            this.lbl_games.Size = new System.Drawing.Size(415, 29);
            this.lbl_games.TabIndex = 0;
            this.lbl_games.Text = "Games";
            this.lbl_games.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_reviews
            // 
            this.lbl_reviews.BackColor = System.Drawing.Color.Black;
            this.lbl_reviews.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reviews.ForeColor = System.Drawing.Color.White;
            this.lbl_reviews.Location = new System.Drawing.Point(12, 297);
            this.lbl_reviews.Name = "lbl_reviews";
            this.lbl_reviews.Size = new System.Drawing.Size(810, 29);
            this.lbl_reviews.TabIndex = 2;
            this.lbl_reviews.Text = "Reviews";
            this.lbl_reviews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_reviews
            // 
            this.dgv_reviews.AllowUserToAddRows = false;
            this.dgv_reviews.AllowUserToDeleteRows = false;
            this.dgv_reviews.AutoGenerateColumns = false;
            this.dgv_reviews.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_reviews.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_reviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reviews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReviewID,
            this.reviewerNameDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.reviewDateDataGridViewTextBoxColumn,
            this.reviewTextDataGridViewTextBoxColumn});
            this.dgv_reviews.DataSource = this.gameReviewsBindingSource1;
            this.dgv_reviews.Location = new System.Drawing.Point(12, 329);
            this.dgv_reviews.Name = "dgv_reviews";
            this.dgv_reviews.ReadOnly = true;
            this.dgv_reviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_reviews.Size = new System.Drawing.Size(810, 265);
            this.dgv_reviews.TabIndex = 3;
            this.toolTip1.SetToolTip(this.dgv_reviews, "Click to select Review");
            // 
            // ReviewID
            // 
            this.ReviewID.DataPropertyName = "ReviewID";
            this.ReviewID.HeaderText = "ReviewID";
            this.ReviewID.Name = "ReviewID";
            this.ReviewID.ReadOnly = true;
            this.ReviewID.Width = 60;
            // 
            // reviewerNameDataGridViewTextBoxColumn
            // 
            this.reviewerNameDataGridViewTextBoxColumn.DataPropertyName = "ReviewerName";
            this.reviewerNameDataGridViewTextBoxColumn.HeaderText = "ReviewerName";
            this.reviewerNameDataGridViewTextBoxColumn.Name = "reviewerNameDataGridViewTextBoxColumn";
            this.reviewerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.reviewerNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reviewDateDataGridViewTextBoxColumn
            // 
            this.reviewDateDataGridViewTextBoxColumn.DataPropertyName = "ReviewDate";
            this.reviewDateDataGridViewTextBoxColumn.HeaderText = "ReviewDate";
            this.reviewDateDataGridViewTextBoxColumn.Name = "reviewDateDataGridViewTextBoxColumn";
            this.reviewDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.reviewDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // reviewTextDataGridViewTextBoxColumn
            // 
            this.reviewTextDataGridViewTextBoxColumn.DataPropertyName = "ReviewText";
            this.reviewTextDataGridViewTextBoxColumn.HeaderText = "ReviewText";
            this.reviewTextDataGridViewTextBoxColumn.Name = "reviewTextDataGridViewTextBoxColumn";
            this.reviewTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.reviewTextDataGridViewTextBoxColumn.Width = 307;
            // 
            // gameReviewsBindingSource1
            // 
            this.gameReviewsBindingSource1.DataMember = "GameReviews";
            this.gameReviewsBindingSource1.DataSource = this.bds_reviews;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btn_addReview;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(834, 661);
            this.Controls.Add(this.dgv_reviews);
            this.Controls.Add(this.lbl_reviews);
            this.Controls.Add(this.lbl_games);
            this.Controls.Add(this.btn_DeleteReview);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.gbx_addReview);
            this.Controls.Add(this.dgv_games);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(850, 700);
            this.MinimumSize = new System.Drawing.Size(850, 700);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Game Reviews";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameReviewsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_reviews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vgr_dts_reviews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_games)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_games)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vgr_dts_games)).EndInit();
            this.gbx_addReview.ResumeLayout(false);
            this.gbx_addReview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_Rating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reviews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameReviewsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip toolStrip;
        private System.Windows.Forms.ToolStripStatusLabel tss_lbl_UserDetails;
        private System.Windows.Forms.DataGridView dgv_games;
        private System.Windows.Forms.GroupBox gbx_addReview;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_DeleteReview;
        private System.Windows.Forms.TextBox tbx_Review;
        private System.Windows.Forms.TrackBar tbr_Rating;
        private System.Windows.Forms.Label lbl_rate;
        private System.Windows.Forms.Button btn_addReview;
        private System.Windows.Forms.BindingSource bds_games;
        private VideoGameReviewsDataSet1 vgr_dts_games;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private VideoGameReviewsDataSet1TableAdapters.GamesTableAdapter gamesTableAdapter;
        private System.Windows.Forms.BindingSource bds_reviews;
        private VideoGameReviewsDataSet2 vgr_dts_reviews;
        private System.Windows.Forms.BindingSource reviewsBindingSource;
        private VideoGameReviewsDataSet2TableAdapters.ReviewsTableAdapter reviewsTableAdapter;
        private System.Windows.Forms.BindingSource gameReviewsBindingSource;
        private VideoGameReviewsDataSet2TableAdapters.GameReviewsTableAdapter gameReviewsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameID;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_games;
        private System.Windows.Forms.Label lbl_reviews;
        private System.Windows.Forms.DataGridView dgv_reviews;
        private System.Windows.Forms.BindingSource gameReviewsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewID;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem ts_tbx_user;
        private System.Windows.Forms.ToolStripMenuItem ts_tbx_about;
        private System.Windows.Forms.ToolStripMenuItem ts_User_logOut;
        private System.Windows.Forms.ToolStripMenuItem ts_about_aboutDeveloper;
        private System.Windows.Forms.ToolStripMenuItem ts_user_deleteUser;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}