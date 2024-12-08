namespace Assignment05
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(23, 123);
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
            this.lbl_password.Location = new System.Drawing.Point(23, 186);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(91, 23);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password";
            this.lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_LoginWindow
            // 
            this.lbl_LoginWindow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_LoginWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_LoginWindow.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginWindow.ForeColor = System.Drawing.Color.White;
            this.lbl_LoginWindow.Location = new System.Drawing.Point(0, 0);
            this.lbl_LoginWindow.Name = "lbl_LoginWindow";
            this.lbl_LoginWindow.Size = new System.Drawing.Size(384, 49);
            this.lbl_LoginWindow.TabIndex = 2;
            this.lbl_LoginWindow.Text = "Login Window";
            this.lbl_LoginWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_email
            // 
            this.tbx_email.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_email.Location = new System.Drawing.Point(89, 120);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(272, 26);
            this.tbx_email.TabIndex = 0;
            this.toolTip1.SetToolTip(this.tbx_email, "Click to Enter Email");
            // 
            // tbx_password
            // 
            this.tbx_password.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_password.Location = new System.Drawing.Point(120, 183);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(241, 26);
            this.tbx_password.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tbx_password, "Click to Enter Password");
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F);
            this.btn_login.Location = new System.Drawing.Point(74, 266);
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
            this.btn_cancel.Location = new System.Drawing.Point(209, 266);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(102, 36);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btn_cancel, "Click to Exit");
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Don\'t have an Account?";
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F);
            this.btn_register.Location = new System.Drawing.Point(138, 374);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(102, 36);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "Register";
            this.toolTip1.SetToolTip(this.btn_register, "Click to Register");
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(384, 484);
            this.ControlBox = false;
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_email);
            this.Controls.Add(this.lbl_LoginWindow);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_email);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}