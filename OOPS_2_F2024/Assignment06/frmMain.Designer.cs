namespace Assignment06
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
            this.tls_bottom = new System.Windows.Forms.ToolStrip();
            this.tls_tsl_userDetails = new System.Windows.Forms.ToolStripLabel();
            this.tls_tsb_Exit = new System.Windows.Forms.ToolStripButton();
            this.mns_professorView = new System.Windows.Forms.MenuStrip();
            this.mns_pv_quizzes = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_pv_studentGrades = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_pv_logOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_pv_addNewQuiz = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_studentView = new System.Windows.Forms.MenuStrip();
            this.mns_sv_courses = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_sv_quizzes = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_sv_grades = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_sv_logOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_userTypeSelection = new System.Windows.Forms.MenuStrip();
            this.mns_uts_student = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_uts_professor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tls_bottom.SuspendLayout();
            this.mns_professorView.SuspendLayout();
            this.mns_studentView.SuspendLayout();
            this.mns_userTypeSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // tls_bottom
            // 
            this.tls_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            this.tls_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tls_bottom.Font = new System.Drawing.Font("Sanskrit Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tls_bottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tls_tsl_userDetails,
            this.tls_tsb_Exit});
            this.tls_bottom.Location = new System.Drawing.Point(0, 525);
            this.tls_bottom.Name = "tls_bottom";
            this.tls_bottom.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tls_bottom.Size = new System.Drawing.Size(884, 36);
            this.tls_bottom.TabIndex = 4;
            // 
            // tls_tsl_userDetails
            // 
            this.tls_tsl_userDetails.Name = "tls_tsl_userDetails";
            this.tls_tsl_userDetails.Size = new System.Drawing.Size(0, 33);
            // 
            // tls_tsb_Exit
            // 
            this.tls_tsb_Exit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tls_tsb_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tls_tsb_Exit.Font = new System.Drawing.Font("Vani", 12F, System.Drawing.FontStyle.Bold);
            this.tls_tsb_Exit.Image = ((System.Drawing.Image)(resources.GetObject("tls_tsb_Exit.Image")));
            this.tls_tsb_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_tsb_Exit.Name = "tls_tsb_Exit";
            this.tls_tsb_Exit.Size = new System.Drawing.Size(50, 33);
            this.tls_tsb_Exit.Text = "Exit";
            this.tls_tsb_Exit.Click += new System.EventHandler(this.tls_tsb_Exit_Click);
            // 
            // mns_professorView
            // 
            this.mns_professorView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.mns_professorView.Font = new System.Drawing.Font("Vani", 12F, System.Drawing.FontStyle.Bold);
            this.mns_professorView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mns_pv_quizzes,
            this.mns_pv_studentGrades,
            this.mns_pv_logOut,
            this.mns_pv_addNewQuiz});
            this.mns_professorView.Location = new System.Drawing.Point(0, 37);
            this.mns_professorView.Name = "mns_professorView";
            this.mns_professorView.Size = new System.Drawing.Size(884, 37);
            this.mns_professorView.TabIndex = 5;
            this.mns_professorView.Text = "menuStrip1";
            this.mns_professorView.Visible = false;
            // 
            // mns_pv_quizzes
            // 
            this.mns_pv_quizzes.ForeColor = System.Drawing.Color.White;
            this.mns_pv_quizzes.Name = "mns_pv_quizzes";
            this.mns_pv_quizzes.Size = new System.Drawing.Size(88, 33);
            this.mns_pv_quizzes.Text = "Quizzes";
            // 
            // mns_pv_studentGrades
            // 
            this.mns_pv_studentGrades.ForeColor = System.Drawing.Color.White;
            this.mns_pv_studentGrades.Name = "mns_pv_studentGrades";
            this.mns_pv_studentGrades.Size = new System.Drawing.Size(152, 33);
            this.mns_pv_studentGrades.Text = "Student Grades";
            // 
            // mns_pv_logOut
            // 
            this.mns_pv_logOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mns_pv_logOut.ForeColor = System.Drawing.Color.White;
            this.mns_pv_logOut.Name = "mns_pv_logOut";
            this.mns_pv_logOut.Size = new System.Drawing.Size(86, 33);
            this.mns_pv_logOut.Text = "Log out";
            this.mns_pv_logOut.Click += new System.EventHandler(this.mns_pv_logOut_Click);
            // 
            // mns_pv_addNewQuiz
            // 
            this.mns_pv_addNewQuiz.ForeColor = System.Drawing.Color.White;
            this.mns_pv_addNewQuiz.Name = "mns_pv_addNewQuiz";
            this.mns_pv_addNewQuiz.Size = new System.Drawing.Size(141, 33);
            this.mns_pv_addNewQuiz.Text = "Add New Quiz";
            // 
            // mns_studentView
            // 
            this.mns_studentView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.mns_studentView.Font = new System.Drawing.Font("Vani", 12F, System.Drawing.FontStyle.Bold);
            this.mns_studentView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mns_sv_courses,
            this.mns_sv_quizzes,
            this.mns_sv_grades,
            this.mns_sv_logOut});
            this.mns_studentView.Location = new System.Drawing.Point(0, 37);
            this.mns_studentView.Name = "mns_studentView";
            this.mns_studentView.Size = new System.Drawing.Size(884, 37);
            this.mns_studentView.TabIndex = 6;
            this.mns_studentView.Text = "menuStrip2";
            this.mns_studentView.Visible = false;
            // 
            // mns_sv_courses
            // 
            this.mns_sv_courses.ForeColor = System.Drawing.Color.White;
            this.mns_sv_courses.Name = "mns_sv_courses";
            this.mns_sv_courses.Size = new System.Drawing.Size(90, 33);
            this.mns_sv_courses.Text = "Courses";
            this.mns_sv_courses.Click += new System.EventHandler(this.mns_sv_courses_Click);
            // 
            // mns_sv_quizzes
            // 
            this.mns_sv_quizzes.ForeColor = System.Drawing.Color.White;
            this.mns_sv_quizzes.Name = "mns_sv_quizzes";
            this.mns_sv_quizzes.Size = new System.Drawing.Size(88, 33);
            this.mns_sv_quizzes.Text = "Quizzes";
            this.mns_sv_quizzes.Click += new System.EventHandler(this.mns_sv_quizzes_Click);
            // 
            // mns_sv_grades
            // 
            this.mns_sv_grades.ForeColor = System.Drawing.Color.White;
            this.mns_sv_grades.Name = "mns_sv_grades";
            this.mns_sv_grades.Size = new System.Drawing.Size(84, 33);
            this.mns_sv_grades.Text = "Grades";
            this.mns_sv_grades.Click += new System.EventHandler(this.mns_sv_grades_Click);
            // 
            // mns_sv_logOut
            // 
            this.mns_sv_logOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mns_sv_logOut.ForeColor = System.Drawing.Color.White;
            this.mns_sv_logOut.Name = "mns_sv_logOut";
            this.mns_sv_logOut.Size = new System.Drawing.Size(86, 33);
            this.mns_sv_logOut.Text = "Log out";
            this.mns_sv_logOut.Click += new System.EventHandler(this.mns_sv_logOut_Click);
            // 
            // mns_userTypeSelection
            // 
            this.mns_userTypeSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            this.mns_userTypeSelection.Font = new System.Drawing.Font("Vani", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mns_userTypeSelection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mns_uts_student,
            this.mns_uts_professor});
            this.mns_userTypeSelection.Location = new System.Drawing.Point(0, 0);
            this.mns_userTypeSelection.Name = "mns_userTypeSelection";
            this.mns_userTypeSelection.Size = new System.Drawing.Size(884, 37);
            this.mns_userTypeSelection.TabIndex = 7;
            this.mns_userTypeSelection.Text = "menuStrip3";
            // 
            // mns_uts_student
            // 
            this.mns_uts_student.Name = "mns_uts_student";
            this.mns_uts_student.Size = new System.Drawing.Size(89, 33);
            this.mns_uts_student.Text = "Student";
            this.mns_uts_student.Click += new System.EventHandler(this.mns_uts_student_Click);
            // 
            // mns_uts_professor
            // 
            this.mns_uts_professor.Name = "mns_uts_professor";
            this.mns_uts_professor.Size = new System.Drawing.Size(103, 33);
            this.mns_uts_professor.Text = "Professor";
            this.mns_uts_professor.Click += new System.EventHandler(this.mns_uts_professor_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tls_bottom);
            this.Controls.Add(this.mns_studentView);
            this.Controls.Add(this.mns_professorView);
            this.Controls.Add(this.mns_userTypeSelection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Portal";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tls_bottom.ResumeLayout(false);
            this.tls_bottom.PerformLayout();
            this.mns_professorView.ResumeLayout(false);
            this.mns_professorView.PerformLayout();
            this.mns_studentView.ResumeLayout(false);
            this.mns_studentView.PerformLayout();
            this.mns_userTypeSelection.ResumeLayout(false);
            this.mns_userTypeSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tls_bottom;
        private System.Windows.Forms.MenuStrip mns_professorView;
        private System.Windows.Forms.ToolStripLabel tls_tsl_userDetails;
        private System.Windows.Forms.ToolStripButton tls_tsb_Exit;
        private System.Windows.Forms.ToolStripMenuItem mns_pv_quizzes;
        private System.Windows.Forms.ToolStripMenuItem mns_pv_studentGrades;
        private System.Windows.Forms.MenuStrip mns_studentView;
        private System.Windows.Forms.ToolStripMenuItem mns_sv_quizzes;
        private System.Windows.Forms.ToolStripMenuItem mns_sv_grades;
        private System.Windows.Forms.MenuStrip mns_userTypeSelection;
        private System.Windows.Forms.ToolStripMenuItem mns_uts_student;
        private System.Windows.Forms.ToolStripMenuItem mns_uts_professor;
        private System.Windows.Forms.ToolStripMenuItem mns_pv_logOut;
        private System.Windows.Forms.ToolStripMenuItem mns_sv_logOut;
        private System.Windows.Forms.ToolStripMenuItem mns_pv_addNewQuiz;
        private System.Windows.Forms.ToolStripMenuItem mns_sv_courses;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}