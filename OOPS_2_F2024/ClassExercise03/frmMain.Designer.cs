namespace ClassExercise03
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
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_selectTeam = new System.Windows.Forms.Label();
            this.cbo_teams = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bds_sportleagues = new System.Windows.Forms.BindingSource(this.components);
            this.sportleaguesDataSet = new ClassExercise03.SportleaguesDataSet();
            this.dgv_playerList = new System.Windows.Forms.DataGridView();
            this.teamPlayersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamsTableAdapter = new ClassExercise03.SportleaguesDataSetTableAdapters.teamsTableAdapter();
            this.teamPlayersTableAdapter = new ClassExercise03.SportleaguesDataSetTableAdapters.TeamPlayersTableAdapter();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jerseynumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isactiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sportleagues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_playerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamPlayersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.BackColor = System.Drawing.Color.Black;
            this.lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_header.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.White;
            this.lbl_header.Location = new System.Drawing.Point(0, 0);
            this.lbl_header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(684, 51);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Player list";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_selectTeam
            // 
            this.lbl_selectTeam.AutoSize = true;
            this.lbl_selectTeam.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectTeam.Location = new System.Drawing.Point(106, 62);
            this.lbl_selectTeam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_selectTeam.Name = "lbl_selectTeam";
            this.lbl_selectTeam.Size = new System.Drawing.Size(131, 25);
            this.lbl_selectTeam.TabIndex = 1;
            this.lbl_selectTeam.Text = "Select Team";
            // 
            // cbo_teams
            // 
            this.cbo_teams.DataSource = this.teamsBindingSource;
            this.cbo_teams.DisplayMember = "teamname";
            this.cbo_teams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_teams.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbo_teams.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_teams.FormattingEnabled = true;
            this.cbo_teams.Location = new System.Drawing.Point(241, 64);
            this.cbo_teams.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_teams.Name = "cbo_teams";
            this.cbo_teams.Size = new System.Drawing.Size(337, 26);
            this.cbo_teams.TabIndex = 2;
            this.cbo_teams.ValueMember = "teamid";
            this.cbo_teams.SelectedIndexChanged += new System.EventHandler(this.cbo_teams_SelectedIndexChanged);
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "teams";
            this.teamsBindingSource.DataSource = this.bds_sportleagues;
            // 
            // bds_sportleagues
            // 
            this.bds_sportleagues.DataSource = this.sportleaguesDataSet;
            this.bds_sportleagues.Position = 0;
            // 
            // sportleaguesDataSet
            // 
            this.sportleaguesDataSet.DataSetName = "SportleaguesDataSet";
            this.sportleaguesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv_playerList
            // 
            this.dgv_playerList.AllowUserToAddRows = false;
            this.dgv_playerList.AllowUserToDeleteRows = false;
            this.dgv_playerList.AutoGenerateColumns = false;
            this.dgv_playerList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_playerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_playerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_playerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullnameDataGridViewTextBoxColumn,
            this.jerseynumberDataGridViewTextBoxColumn,
            this.regnumberDataGridViewTextBoxColumn,
            this.isactiveDataGridViewTextBoxColumn});
            this.dgv_playerList.DataSource = this.teamPlayersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_playerList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_playerList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_playerList.Location = new System.Drawing.Point(0, 105);
            this.dgv_playerList.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_playerList.Name = "dgv_playerList";
            this.dgv_playerList.ReadOnly = true;
            this.dgv_playerList.RowHeadersWidth = 72;
            this.dgv_playerList.RowTemplate.Height = 31;
            this.dgv_playerList.Size = new System.Drawing.Size(684, 556);
            this.dgv_playerList.TabIndex = 3;
            // 
            // teamPlayersBindingSource
            // 
            this.teamPlayersBindingSource.DataMember = "TeamPlayers";
            this.teamPlayersBindingSource.DataSource = this.bds_sportleagues;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // teamPlayersTableAdapter
            // 
            this.teamPlayersTableAdapter.ClearBeforeFill = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Player Name";
            this.fullnameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // jerseynumberDataGridViewTextBoxColumn
            // 
            this.jerseynumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.jerseynumberDataGridViewTextBoxColumn.DataPropertyName = "jerseynumber";
            this.jerseynumberDataGridViewTextBoxColumn.HeaderText = "Jersey Number";
            this.jerseynumberDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.jerseynumberDataGridViewTextBoxColumn.Name = "jerseynumberDataGridViewTextBoxColumn";
            this.jerseynumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.jerseynumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // regnumberDataGridViewTextBoxColumn
            // 
            this.regnumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.regnumberDataGridViewTextBoxColumn.DataPropertyName = "regnumber";
            this.regnumberDataGridViewTextBoxColumn.HeaderText = "Registration Number";
            this.regnumberDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.regnumberDataGridViewTextBoxColumn.Name = "regnumberDataGridViewTextBoxColumn";
            this.regnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.regnumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // isactiveDataGridViewTextBoxColumn
            // 
            this.isactiveDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.isactiveDataGridViewTextBoxColumn.DataPropertyName = "isactive";
            this.isactiveDataGridViewTextBoxColumn.HeaderText = "Is Active";
            this.isactiveDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.isactiveDataGridViewTextBoxColumn.Name = "isactiveDataGridViewTextBoxColumn";
            this.isactiveDataGridViewTextBoxColumn.ReadOnly = true;
            this.isactiveDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isactiveDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isactiveDataGridViewTextBoxColumn.Width = 140;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.dgv_playerList);
            this.Controls.Add(this.cbo_teams);
            this.Controls.Add(this.lbl_selectTeam);
            this.Controls.Add(this.lbl_header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(700, 700);
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sport Leagues Team Details";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sportleagues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_playerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamPlayersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_selectTeam;
        private System.Windows.Forms.ComboBox cbo_teams;
        private System.Windows.Forms.BindingSource bds_sportleagues;
        private SportleaguesDataSet sportleaguesDataSet;
        private System.Windows.Forms.DataGridView dgv_playerList;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private SportleaguesDataSetTableAdapters.teamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.BindingSource teamPlayersBindingSource;
        private SportleaguesDataSetTableAdapters.TeamPlayersTableAdapter teamPlayersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jerseynumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isactiveDataGridViewTextBoxColumn;
    }
}