namespace Assignment06
{
    partial class frmStudentCourse
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
            this.dgv_student_courses = new System.Windows.Forms.DataGridView();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bds_StudentCourses = new System.Windows.Forms.BindingSource(this.components);
            this.dts_StudentCourses = new Assignment06.dts_StudentCourses();
            this.studentCoursesTableAdapter = new Assignment06.dts_StudentCoursesTableAdapters.StudentCoursesTableAdapter();
            this.btn_viewQuizzes = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student_courses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCoursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_StudentCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dts_StudentCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_student_courses
            // 
            this.dgv_student_courses.AllowUserToAddRows = false;
            this.dgv_student_courses.AllowUserToDeleteRows = false;
            this.dgv_student_courses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_student_courses.AutoGenerateColumns = false;
            this.dgv_student_courses.BackgroundColor = System.Drawing.Color.White;
            this.dgv_student_courses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_student_courses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_student_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student_courses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.professorNameDataGridViewTextBoxColumn});
            this.dgv_student_courses.DataSource = this.studentCoursesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_student_courses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_student_courses.Location = new System.Drawing.Point(0, 0);
            this.dgv_student_courses.Name = "dgv_student_courses";
            this.dgv_student_courses.ReadOnly = true;
            this.dgv_student_courses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_student_courses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_student_courses.Size = new System.Drawing.Size(800, 414);
            this.dgv_student_courses.TabIndex = 21;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "Course Code";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Course Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // professorNameDataGridViewTextBoxColumn
            // 
            this.professorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.professorNameDataGridViewTextBoxColumn.DataPropertyName = "ProfessorName";
            this.professorNameDataGridViewTextBoxColumn.HeaderText = "Professor Name";
            this.professorNameDataGridViewTextBoxColumn.Name = "professorNameDataGridViewTextBoxColumn";
            this.professorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentCoursesBindingSource
            // 
            this.studentCoursesBindingSource.DataMember = "StudentCourses";
            this.studentCoursesBindingSource.DataSource = this.bds_StudentCourses;
            // 
            // bds_StudentCourses
            // 
            this.bds_StudentCourses.DataSource = this.dts_StudentCourses;
            this.bds_StudentCourses.Position = 0;
            // 
            // dts_StudentCourses
            // 
            this.dts_StudentCourses.DataSetName = "dts_StudentCourses";
            this.dts_StudentCourses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentCoursesTableAdapter
            // 
            this.studentCoursesTableAdapter.ClearBeforeFill = true;
            // 
            // btn_viewQuizzes
            // 
            this.btn_viewQuizzes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_viewQuizzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_viewQuizzes.Location = new System.Drawing.Point(521, 420);
            this.btn_viewQuizzes.Name = "btn_viewQuizzes";
            this.btn_viewQuizzes.Size = new System.Drawing.Size(149, 34);
            this.btn_viewQuizzes.TabIndex = 0;
            this.btn_viewQuizzes.Text = "View Quizzes";
            this.btn_viewQuizzes.UseVisualStyleBackColor = true;
            this.btn_viewQuizzes.Click += new System.EventHandler(this.btn_viewQuizzes_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_close.Location = new System.Drawing.Point(676, 420);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(120, 34);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frmStudentCourse
            // 
            this.AcceptButton = this.btn_viewQuizzes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.ControlBox = false;
            this.Controls.Add(this.btn_viewQuizzes);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dgv_student_courses);
            this.Name = "frmStudentCourse";
            this.Load += new System.EventHandler(this.frmStudentCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student_courses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCoursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_StudentCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dts_StudentCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_student_courses;
        private System.Windows.Forms.BindingSource bds_StudentCourses;
        private dts_StudentCourses dts_StudentCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentCoursesBindingSource;
        private dts_StudentCoursesTableAdapters.StudentCoursesTableAdapter studentCoursesTableAdapter;
        private System.Windows.Forms.Button btn_viewQuizzes;
        private System.Windows.Forms.Button btn_close;
    }
}