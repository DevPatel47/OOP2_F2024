namespace Assignment06
{
    partial class frmStudentGrades
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
            this.btn_viewCourses = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.cbo_quizzes_selectCourse = new System.Windows.Forms.ComboBox();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bds_StudentGrades = new System.Windows.Forms.BindingSource(this.components);
            this.dts_Student_Grades = new Assignment06.dts_Student_Grades();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_student_grades = new System.Windows.Forms.DataGridView();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quizNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksObtainedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attemptTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new Assignment06.dts_Student_GradesTableAdapters.CoursesTableAdapter();
            this.studentGradeTableAdapter = new Assignment06.dts_Student_GradesTableAdapters.StudentGradeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_StudentGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dts_Student_Grades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student_grades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_viewCourses
            // 
            this.btn_viewCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_viewCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_viewCourses.Location = new System.Drawing.Point(533, 423);
            this.btn_viewCourses.Name = "btn_viewCourses";
            this.btn_viewCourses.Size = new System.Drawing.Size(149, 34);
            this.btn_viewCourses.TabIndex = 1;
            this.btn_viewCourses.Text = "View Courses";
            this.btn_viewCourses.UseVisualStyleBackColor = true;
            this.btn_viewCourses.Click += new System.EventHandler(this.btn_viewCourses_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_close.Location = new System.Drawing.Point(688, 423);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(120, 34);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // cbo_quizzes_selectCourse
            // 
            this.cbo_quizzes_selectCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_quizzes_selectCourse.DataSource = this.coursesBindingSource;
            this.cbo_quizzes_selectCourse.DisplayMember = "Name";
            this.cbo_quizzes_selectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_quizzes_selectCourse.FormattingEnabled = true;
            this.cbo_quizzes_selectCourse.Location = new System.Drawing.Point(308, 16);
            this.cbo_quizzes_selectCourse.Name = "cbo_quizzes_selectCourse";
            this.cbo_quizzes_selectCourse.Size = new System.Drawing.Size(335, 26);
            this.cbo_quizzes_selectCourse.TabIndex = 0;
            this.cbo_quizzes_selectCourse.ValueMember = "CourseID";
            this.cbo_quizzes_selectCourse.SelectedIndexChanged += new System.EventHandler(this.cbo_quizzes_selectCourse_SelectedIndexChanged);
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.bds_StudentGrades;
            // 
            // bds_StudentGrades
            // 
            this.bds_StudentGrades.DataSource = this.dts_Student_Grades;
            this.bds_StudentGrades.Position = 0;
            // 
            // dts_Student_Grades
            // 
            this.dts_Student_Grades.DataSetName = "dts_Student_Grades";
            this.dts_Student_Grades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select Course";
            // 
            // dgv_student_grades
            // 
            this.dgv_student_grades.AllowUserToAddRows = false;
            this.dgv_student_grades.AllowUserToDeleteRows = false;
            this.dgv_student_grades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_student_grades.AutoGenerateColumns = false;
            this.dgv_student_grades.BackgroundColor = System.Drawing.Color.White;
            this.dgv_student_grades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_student_grades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_student_grades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student_grades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseNameDataGridViewTextBoxColumn,
            this.quizNameDataGridViewTextBoxColumn,
            this.totalMarksDataGridViewTextBoxColumn,
            this.marksObtainedDataGridViewTextBoxColumn,
            this.attemptTimeDataGridViewTextBoxColumn});
            this.dgv_student_grades.DataSource = this.studentGradeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_student_grades.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_student_grades.Location = new System.Drawing.Point(0, 61);
            this.dgv_student_grades.Name = "dgv_student_grades";
            this.dgv_student_grades.ReadOnly = true;
            this.dgv_student_grades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_student_grades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_student_grades.Size = new System.Drawing.Size(807, 356);
            this.dgv_student_grades.TabIndex = 21;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quizNameDataGridViewTextBoxColumn
            // 
            this.quizNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quizNameDataGridViewTextBoxColumn.DataPropertyName = "QuizName";
            this.quizNameDataGridViewTextBoxColumn.HeaderText = "QuizName";
            this.quizNameDataGridViewTextBoxColumn.Name = "quizNameDataGridViewTextBoxColumn";
            this.quizNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalMarksDataGridViewTextBoxColumn
            // 
            this.totalMarksDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalMarksDataGridViewTextBoxColumn.DataPropertyName = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.HeaderText = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.Name = "totalMarksDataGridViewTextBoxColumn";
            this.totalMarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marksObtainedDataGridViewTextBoxColumn
            // 
            this.marksObtainedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.marksObtainedDataGridViewTextBoxColumn.DataPropertyName = "MarksObtained";
            this.marksObtainedDataGridViewTextBoxColumn.HeaderText = "MarksObtained";
            this.marksObtainedDataGridViewTextBoxColumn.Name = "marksObtainedDataGridViewTextBoxColumn";
            this.marksObtainedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attemptTimeDataGridViewTextBoxColumn
            // 
            this.attemptTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.attemptTimeDataGridViewTextBoxColumn.DataPropertyName = "AttemptTime";
            this.attemptTimeDataGridViewTextBoxColumn.HeaderText = "AttemptTime";
            this.attemptTimeDataGridViewTextBoxColumn.Name = "attemptTimeDataGridViewTextBoxColumn";
            this.attemptTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentGradeBindingSource
            // 
            this.studentGradeBindingSource.DataMember = "StudentGrade";
            this.studentGradeBindingSource.DataSource = this.bds_StudentGrades;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // studentGradeTableAdapter
            // 
            this.studentGradeTableAdapter.ClearBeforeFill = true;
            // 
            // frmStudentGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 460);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_student_grades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_viewCourses);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.cbo_quizzes_selectCourse);
            this.Name = "frmStudentGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmStudentGrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_StudentGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dts_Student_Grades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student_grades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_viewCourses;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cbo_quizzes_selectCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bds_StudentGrades;
        private System.Windows.Forms.DataGridView dgv_student_grades;
        private dts_Student_Grades dts_Student_Grades;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private dts_Student_GradesTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quizNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marksObtainedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attemptTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentGradeBindingSource;
        private dts_Student_GradesTableAdapters.StudentGradeTableAdapter studentGradeTableAdapter;
    }
}