using System.Drawing;

namespace Assignment03
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
            this.lbl_SelectCharacter = new System.Windows.Forms.Label();
            this.cbo_Characters = new System.Windows.Forms.ComboBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_CreateCharacter = new System.Windows.Forms.Button();
            this.btn_EditCharacter = new System.Windows.Forms.Button();
            this.tbx_CharacterDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_SelectCharacter
            // 
            this.lbl_SelectCharacter.BackColor = System.Drawing.Color.Firebrick;
            this.lbl_SelectCharacter.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectCharacter.ForeColor = System.Drawing.Color.White;
            this.lbl_SelectCharacter.Location = new System.Drawing.Point(12, 9);
            this.lbl_SelectCharacter.Name = "lbl_SelectCharacter";
            this.lbl_SelectCharacter.Size = new System.Drawing.Size(160, 28);
            this.lbl_SelectCharacter.TabIndex = 1;
            this.lbl_SelectCharacter.Text = "Select Character";
            this.lbl_SelectCharacter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_Characters
            // 
            this.cbo_Characters.FormattingEnabled = true;
            this.cbo_Characters.Location = new System.Drawing.Point(178, 15);
            this.cbo_Characters.Name = "cbo_Characters";
            this.cbo_Characters.Size = new System.Drawing.Size(166, 21);
            this.cbo_Characters.TabIndex = 2;
            this.cbo_Characters.SelectedIndexChanged += new System.EventHandler(this.cbo_Characters_SelectedIndexChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(674, 399);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(115, 40);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "E&xit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_CreateCharacter
            // 
            this.btn_CreateCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CreateCharacter.BackColor = System.Drawing.Color.Firebrick;
            this.btn_CreateCharacter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_CreateCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateCharacter.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateCharacter.ForeColor = System.Drawing.Color.White;
            this.btn_CreateCharacter.Location = new System.Drawing.Point(189, 399);
            this.btn_CreateCharacter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CreateCharacter.Name = "btn_CreateCharacter";
            this.btn_CreateCharacter.Size = new System.Drawing.Size(173, 40);
            this.btn_CreateCharacter.TabIndex = 4;
            this.btn_CreateCharacter.Text = "Create Character";
            this.btn_CreateCharacter.UseVisualStyleBackColor = false;
            // 
            // btn_EditCharacter
            // 
            this.btn_EditCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EditCharacter.BackColor = System.Drawing.Color.Firebrick;
            this.btn_EditCharacter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_EditCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditCharacter.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditCharacter.ForeColor = System.Drawing.Color.White;
            this.btn_EditCharacter.Location = new System.Drawing.Point(12, 399);
            this.btn_EditCharacter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EditCharacter.Name = "btn_EditCharacter";
            this.btn_EditCharacter.Size = new System.Drawing.Size(173, 40);
            this.btn_EditCharacter.TabIndex = 5;
            this.btn_EditCharacter.Text = "Edit Character";
            this.btn_EditCharacter.UseVisualStyleBackColor = false;
            // 
            // tbx_CharacterDetails
            // 
            this.tbx_CharacterDetails.Enabled = false;
            this.tbx_CharacterDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_CharacterDetails.Location = new System.Drawing.Point(12, 42);
            this.tbx_CharacterDetails.Multiline = true;
            this.tbx_CharacterDetails.Name = "tbx_CharacterDetails";
            this.tbx_CharacterDetails.Size = new System.Drawing.Size(777, 352);
            this.tbx_CharacterDetails.TabIndex = 6;            
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment03.Properties.Resources.MainFrm_Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_CharacterDetails);
            this.Controls.Add(this.btn_EditCharacter);
            this.Controls.Add(this.btn_CreateCharacter);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.cbo_Characters);
            this.Controls.Add(this.lbl_SelectCharacter);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dungeons and Dragons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_SelectCharacter;
        private System.Windows.Forms.ComboBox cbo_Characters;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_CreateCharacter;
        private System.Windows.Forms.Button btn_EditCharacter;
        private System.Windows.Forms.TextBox tbx_CharacterDetails;
    }
}