namespace Assignment05
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.lbl_RegistrationWindow = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.tbx_lastName = new System.Windows.Forms.TextBox();
            this.tbx_firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbl_RegistrationWindow
            // 
            this.lbl_RegistrationWindow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_RegistrationWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_RegistrationWindow.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegistrationWindow.ForeColor = System.Drawing.Color.White;
            this.lbl_RegistrationWindow.Location = new System.Drawing.Point(0, 0);
            this.lbl_RegistrationWindow.Name = "lbl_RegistrationWindow";
            this.lbl_RegistrationWindow.Size = new System.Drawing.Size(384, 49);
            this.lbl_RegistrationWindow.TabIndex = 3;
            this.lbl_RegistrationWindow.Text = "Registration Window";
            this.lbl_RegistrationWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F);
            this.btn_cancel.Location = new System.Drawing.Point(209, 412);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(102, 36);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btn_cancel, "Click to Exit");
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F);
            this.btn_register.Location = new System.Drawing.Point(74, 412);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(102, 36);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "Register";
            this.toolTip1.SetToolTip(this.btn_register, "Click to Register");
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // tbx_password
            // 
            this.tbx_password.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_password.Location = new System.Drawing.Point(119, 323);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(241, 26);
            this.tbx_password.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tbx_password, "Click to Enter Password");
            // 
            // tbx_email
            // 
            this.tbx_email.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_email.Location = new System.Drawing.Point(88, 242);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(272, 26);
            this.tbx_email.TabIndex = 2;
            this.toolTip1.SetToolTip(this.tbx_email, "Click to Enter Email");
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(22, 326);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(91, 23);
            this.lbl_password.TabIndex = 10;
            this.lbl_password.Text = "Password";
            this.lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(22, 245);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(60, 23);
            this.lbl_email.TabIndex = 9;
            this.lbl_email.Text = "Email";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstName.Location = new System.Drawing.Point(22, 83);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(103, 23);
            this.lbl_firstName.TabIndex = 13;
            this.lbl_firstName.Text = "First Name";
            this.lbl_firstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastName.Location = new System.Drawing.Point(22, 164);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(100, 23);
            this.lbl_lastName.TabIndex = 14;
            this.lbl_lastName.Text = "Last Name";
            this.lbl_lastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_lastName
            // 
            this.tbx_lastName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_lastName.Location = new System.Drawing.Point(128, 161);
            this.tbx_lastName.Name = "tbx_lastName";
            this.tbx_lastName.Size = new System.Drawing.Size(232, 26);
            this.tbx_lastName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tbx_lastName, "Click to Enter Last Name");
            // 
            // tbx_firstName
            // 
            this.tbx_firstName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_firstName.Location = new System.Drawing.Point(131, 80);
            this.tbx_firstName.Name = "tbx_firstName";
            this.tbx_firstName.Size = new System.Drawing.Size(229, 26);
            this.tbx_firstName.TabIndex = 0;
            this.toolTip1.SetToolTip(this.tbx_firstName, "Click to Enter First Name");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Password must be a 4 digit number and must be between 1000 and 9999.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRegistration
            // 
            this.AcceptButton = this.btn_register;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(384, 484);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_firstName);
            this.Controls.Add(this.tbx_lastName);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.lbl_firstName);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_email);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.lbl_RegistrationWindow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "frmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RegistrationWindow;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.TextBox tbx_lastName;
        private System.Windows.Forms.TextBox tbx_firstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}