﻿namespace MRIC_Peer_Review
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkListSpecialisms = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword1 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegister.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(143, 371);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(77, 35);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(12, 381);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Return to Login Screen";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkListSpecialisms
            // 
            this.chkListSpecialisms.CheckOnClick = true;
            this.chkListSpecialisms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkListSpecialisms.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListSpecialisms.FormattingEnabled = true;
            this.chkListSpecialisms.Location = new System.Drawing.Point(25, 228);
            this.chkListSpecialisms.Name = "chkListSpecialisms";
            this.chkListSpecialisms.Size = new System.Drawing.Size(195, 132);
            this.chkListSpecialisms.TabIndex = 5;
            this.chkListSpecialisms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkListSpecialisms_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFirstname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPassword1);
            this.groupBox1.Controls.Add(this.chkListSpecialisms);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(230, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 411);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(5, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Specialisms :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(5, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Name :";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtFirstname.Location = new System.Drawing.Point(25, 43);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(195, 22);
            this.txtFirstname.TabIndex = 1;
            this.txtFirstname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirstname_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(5, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Surname :";
            // 
            // lblPassword1
            // 
            this.lblPassword1.AutoSize = true;
            this.lblPassword1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword1.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPassword1.Location = new System.Drawing.Point(5, 156);
            this.lblPassword1.Name = "lblPassword1";
            this.lblPassword1.Size = new System.Drawing.Size(77, 16);
            this.lblPassword1.TabIndex = 27;
            this.lblPassword1.Text = "Password :";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtSurname.Location = new System.Drawing.Point(25, 87);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(195, 22);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSurname_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtPassword.Location = new System.Drawing.Point(25, 175);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(195, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtUsername.Location = new System.Drawing.Point(25, 131);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(195, 22);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(5, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Username :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::MRIC_Peer_Review.Properties.Resources.MRIC;
            this.pictureBox1.Location = new System.Drawing.Point(5, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckedListBox chkListSpecialisms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassword1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}