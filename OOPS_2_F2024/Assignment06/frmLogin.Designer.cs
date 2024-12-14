namespace Assignment06
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_LoginWindow = new System.Windows.Forms.Label();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(23, 122);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(60, 23);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Email";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(23, 171);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(91, 23);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password";
            this.lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_LoginWindow
            // 
            this.lbl_LoginWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            this.lbl_LoginWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_LoginWindow.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginWindow.ForeColor = System.Drawing.Color.White;
            this.lbl_LoginWindow.Location = new System.Drawing.Point(0, 0);
            this.lbl_LoginWindow.Name = "lbl_LoginWindow";
            this.lbl_LoginWindow.Size = new System.Drawing.Size(384, 73);
            this.lbl_LoginWindow.TabIndex = 2;
            this.lbl_LoginWindow.Text = "Login Window";
            this.lbl_LoginWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_email
            // 
            this.tbx_email.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_email.Location = new System.Drawing.Point(89, 119);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(272, 26);
            this.tbx_email.TabIndex = 0;
            this.toolTip1.SetToolTip(this.tbx_email, "Click to Enter Email");
            // 
            // tbx_password
            // 
            this.tbx_password.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_password.Location = new System.Drawing.Point(120, 168);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(241, 26);
            this.tbx_password.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tbx_password, "Click to Enter Password");
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F);
            this.btn_login.Location = new System.Drawing.Point(74, 221);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(102, 36);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.toolTip1.SetToolTip(this.btn_login, "Click to Login");
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F);
            this.btn_cancel.Location = new System.Drawing.Point(209, 221);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(102, 36);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btn_cancel, "Click to Exit");
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.panel1.Location = new System.Drawing.Point(-2, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 10);
            this.panel1.TabIndex = 4;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(384, 284);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_email);
            this.Controls.Add(this.lbl_LoginWindow);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_email);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_LoginWindow;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
    }
}