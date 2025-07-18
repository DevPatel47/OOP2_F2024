﻿using System.Drawing;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lbl_SelectCharacter = new System.Windows.Forms.Label();
            this.cbo_Characters = new System.Windows.Forms.ComboBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_CreateCharacter = new System.Windows.Forms.Button();
            this.btn_EditCharacter = new System.Windows.Forms.Button();
            this.tbx_CharacterDetails = new System.Windows.Forms.TextBox();
            this.pbx_CharacterImage = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_CharacterImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SelectCharacter
            // 
            this.lbl_SelectCharacter.BackColor = System.Drawing.Color.Firebrick;
            this.lbl_SelectCharacter.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectCharacter.ForeColor = System.Drawing.Color.White;
            this.lbl_SelectCharacter.Location = new System.Drawing.Point(22, 17);
            this.lbl_SelectCharacter.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_SelectCharacter.Name = "lbl_SelectCharacter";
            this.lbl_SelectCharacter.Size = new System.Drawing.Size(293, 52);
            this.lbl_SelectCharacter.TabIndex = 1;
            this.lbl_SelectCharacter.Text = "Select Character";
            this.lbl_SelectCharacter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_Characters
            // 
            this.cbo_Characters.FormattingEnabled = true;
            this.cbo_Characters.Location = new System.Drawing.Point(326, 28);
            this.cbo_Characters.Margin = new System.Windows.Forms.Padding(6);
            this.cbo_Characters.Name = "cbo_Characters";
            this.cbo_Characters.Size = new System.Drawing.Size(301, 32);
            this.cbo_Characters.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cbo_Characters, "Click to select character");
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
            this.btn_Exit.Location = new System.Drawing.Point(1236, 737);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(211, 74);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btn_Exit, "Click to Exit");
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_CreateCharacter
            // 
            this.btn_CreateCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_CreateCharacter.BackColor = System.Drawing.Color.Firebrick;
            this.btn_CreateCharacter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_CreateCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateCharacter.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateCharacter.ForeColor = System.Drawing.Color.White;
            this.btn_CreateCharacter.Location = new System.Drawing.Point(323, 737);
            this.btn_CreateCharacter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CreateCharacter.Name = "btn_CreateCharacter";
            this.btn_CreateCharacter.Size = new System.Drawing.Size(402, 74);
            this.btn_CreateCharacter.TabIndex = 2;
            this.btn_CreateCharacter.Text = "Create &New Character";
            this.toolTip1.SetToolTip(this.btn_CreateCharacter, "Click to create new character");
            this.btn_CreateCharacter.UseVisualStyleBackColor = false;
            this.btn_CreateCharacter.Click += new System.EventHandler(this.btn_CreateCharacter_Click);
            // 
            // btn_EditCharacter
            // 
            this.btn_EditCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_EditCharacter.BackColor = System.Drawing.Color.Firebrick;
            this.btn_EditCharacter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_EditCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditCharacter.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditCharacter.ForeColor = System.Drawing.Color.White;
            this.btn_EditCharacter.Location = new System.Drawing.Point(22, 737);
            this.btn_EditCharacter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_EditCharacter.Name = "btn_EditCharacter";
            this.btn_EditCharacter.Size = new System.Drawing.Size(293, 74);
            this.btn_EditCharacter.TabIndex = 1;
            this.btn_EditCharacter.Text = "&Edit Character";
            this.toolTip1.SetToolTip(this.btn_EditCharacter, "Click to edit character");
            this.btn_EditCharacter.UseVisualStyleBackColor = false;
            this.btn_EditCharacter.Click += new System.EventHandler(this.btn_EditCharacter_Click);
            // 
            // tbx_CharacterDetails
            // 
            this.tbx_CharacterDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_CharacterDetails.Enabled = false;
            this.tbx_CharacterDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_CharacterDetails.Location = new System.Drawing.Point(22, 78);
            this.tbx_CharacterDetails.Margin = new System.Windows.Forms.Padding(6);
            this.tbx_CharacterDetails.Multiline = true;
            this.tbx_CharacterDetails.Name = "tbx_CharacterDetails";
            this.tbx_CharacterDetails.Size = new System.Drawing.Size(952, 646);
            this.tbx_CharacterDetails.TabIndex = 6;
            // 
            // pbx_CharacterImage
            // 
            this.pbx_CharacterImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_CharacterImage.BackgroundImage = global::Assignment03.Properties.Resources.pngegg__1_;
            this.pbx_CharacterImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbx_CharacterImage.Location = new System.Drawing.Point(983, 78);
            this.pbx_CharacterImage.Name = "pbx_CharacterImage";
            this.pbx_CharacterImage.Size = new System.Drawing.Size(464, 646);
            this.pbx_CharacterImage.TabIndex = 7;
            this.pbx_CharacterImage.TabStop = false;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btn_CreateCharacter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.pbx_CharacterImage);
            this.Controls.Add(this.tbx_CharacterDetails);
            this.Controls.Add(this.btn_EditCharacter);
            this.Controls.Add(this.btn_CreateCharacter);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.cbo_Characters);
            this.Controls.Add(this.lbl_SelectCharacter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1491, 895);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dungeons and Dragons";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_CharacterImage)).EndInit();
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
        private System.Windows.Forms.PictureBox pbx_CharacterImage;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}