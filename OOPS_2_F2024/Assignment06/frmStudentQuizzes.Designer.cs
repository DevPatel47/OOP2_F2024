namespace Assignment06
{
    partial class frmStudentQuizzes
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
            this.bds_Quizzes = new System.Windows.Forms.BindingSource(this.components);
            this.dts_quizzes = new Assignment06.dts_quizzes();
            this.dgv_student_quizzes = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attemptCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseQuizzesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_selectCourse = new System.Windows.Forms.ComboBox();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_viewGrades = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.coursesTableAdapter = new Assignment06.dts_quizzesTableAdapters.CoursesTableAdapter();
            this.courseQuizzesTableAdapter = new Assignment06.dts_quizzesTableAdapters.CourseQuizzesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Quizzes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dts_quizzes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student_quizzes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseQuizzesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bds_Quizzes
            // 
            this.bds_Quizzes.DataSource = this.dts_quizzes;
            this.bds_Quizzes.Position = 0;
            // 
            // dts_quizzes
            // 
            this.dts_quizzes.DataSetName = "dts_quizzes";
            this.dts_quizzes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv_student_quizzes
            // 
            this.dgv_student_quizzes.AllowUserToAddRows = false;
            this.dgv_student_quizzes.AllowUserToDeleteRows = false;
            this.dgv_student_quizzes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_student_quizzes.AutoGenerateColumns = false;
            this.dgv_student_quizzes.BackgroundColor = System.Drawing.Color.White;
            this.dgv_student_quizzes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_student_quizzes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_student_quizzes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student_quizzes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.totalMarksDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.attemptCountDataGridViewTextBoxColumn});
            this.dgv_student_quizzes.DataSource = this.courseQuizzesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_student_quizzes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_student_quizzes.Location = new System.Drawing.Point(-3, 70);
            this.dgv_student_quizzes.Name = "dgv_student_quizzes";
            this.dgv_student_quizzes.ReadOnly = true;
            this.dgv_student_quizzes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_student_quizzes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_student_quizzes.Size = new System.Drawing.Size(807, 325);
            this.dgv_student_quizzes.TabIndex = 7;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Quiz Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalMarksDataGridViewTextBoxColumn
            // 
            this.totalMarksDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalMarksDataGridViewTextBoxColumn.DataPropertyName = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.HeaderText = "Total Marks";
            this.totalMarksDataGridViewTextBoxColumn.Name = "totalMarksDataGridViewTextBoxColumn";
            this.totalMarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "Start Time";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "End Time";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attemptCountDataGridViewTextBoxColumn
            // 
            this.attemptCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.attemptCountDataGridViewTextBoxColumn.DataPropertyName = "AttemptCount";
            this.attemptCountDataGridViewTextBoxColumn.HeaderText = "Attempt Count";
            this.attemptCountDataGridViewTextBoxColumn.Name = "attemptCountDataGridViewTextBoxColumn";
            this.attemptCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseQuizzesBindingSource
            // 
            this.courseQuizzesBindingSource.DataMember = "CourseQuizzes";
            this.courseQuizzesBindingSource.DataSource = this.bds_Quizzes;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Course";
            // 
            // cbo_selectCourse
            // 
            this.cbo_selectCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_selectCourse.DataSource = this.coursesBindingSource;
            this.cbo_selectCourse.DisplayMember = "Name";
            this.cbo_selectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_selectCourse.FormattingEnabled = true;
            this.cbo_selectCourse.Location = new System.Drawing.Point(325, 22);
            this.cbo_selectCourse.Name = "cbo_selectCourse";
            this.cbo_selectCourse.Size = new System.Drawing.Size(304, 26);
            this.cbo_selectCourse.TabIndex = 5;
            this.cbo_selectCourse.ValueMember = "CourseID";
            this.cbo_selectCourse.SelectedIndexChanged += new System.EventHandler(this.cbo_quizzes_selectCourse_SelectedIndexChanged);
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.bds_Quizzes;
            // 
            // btn_viewGrades
            // 
            this.btn_viewGrades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_viewGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_viewGrades.Location = new System.Drawing.Point(515, 404);
            this.btn_viewGrades.Name = "btn_viewGrades";
            this.btn_viewGrades.Size = new System.Drawing.Size(149, 34);
            this.btn_viewGrades.TabIndex = 9;
            this.btn_viewGrades.Text = "View Grades";
            this.btn_viewGrades.UseVisualStyleBackColor = true;
            this.btn_viewGrades.Click += new System.EventHandler(this.btn_viewGrades_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_close.Location = new System.Drawing.Point(670, 404);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(120, 34);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // courseQuizzesTableAdapter
            // 
            this.courseQuizzesTableAdapter.ClearBeforeFill = true;
            // 
            // frmStudentQuizzes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_viewGrades);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dgv_student_quizzes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_selectCourse);
            this.Name = "frmStudentQuizzes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmStudentQuizzes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bds_Quizzes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dts_quizzes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student_quizzes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseQuizzesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bds_Quizzes;
        private dts_quizzes dts_quizzes;
        private System.Windows.Forms.DataGridView dgv_student_quizzes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_selectCourse;
        private System.Windows.Forms.Button btn_viewGrades;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private dts_quizzesTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attemptCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource courseQuizzesBindingSource;
        private dts_quizzesTableAdapters.CourseQuizzesTableAdapter courseQuizzesTableAdapter;
    }
}