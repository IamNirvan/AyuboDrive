namespace AyuboDrive.Forms
{
    partial class LoginFormV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFormV2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userNameErrorLbl = new System.Windows.Forms.Label();
            this.passwordErrorLbl = new System.Windows.Forms.Label();
            this.UserNameTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.userNamePnl = new System.Windows.Forms.Panel();
            this.passwordPnl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.signUpLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new AyuboDrive.Utility.CustomButton();
            this.PasswordMask = new AyuboDrive.Utility.CustomButton();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Carlito", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(387, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(389, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(391, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // userNameErrorLbl
            // 
            this.userNameErrorLbl.AutoSize = true;
            this.userNameErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.userNameErrorLbl.Location = new System.Drawing.Point(391, 223);
            this.userNameErrorLbl.Name = "userNameErrorLbl";
            this.userNameErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.userNameErrorLbl.TabIndex = 5;
            this.userNameErrorLbl.Text = " ";
            // 
            // passwordErrorLbl
            // 
            this.passwordErrorLbl.AutoSize = true;
            this.passwordErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.passwordErrorLbl.Location = new System.Drawing.Point(391, 303);
            this.passwordErrorLbl.Name = "passwordErrorLbl";
            this.passwordErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.passwordErrorLbl.TabIndex = 6;
            this.passwordErrorLbl.Text = " ";
            // 
            // UserNameTxtBox
            // 
            this.UserNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.UserNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.UserNameTxtBox.Location = new System.Drawing.Point(392, 193);
            this.UserNameTxtBox.Name = "UserNameTxtBox";
            this.UserNameTxtBox.Size = new System.Drawing.Size(270, 19);
            this.UserNameTxtBox.TabIndex = 7;
            this.UserNameTxtBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserNameTxtBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.PasswordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.PasswordTxtBox.Location = new System.Drawing.Point(392, 273);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '*';
            this.PasswordTxtBox.Size = new System.Drawing.Size(241, 19);
            this.PasswordTxtBox.TabIndex = 8;
            this.PasswordTxtBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.PasswordTxtBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // userNamePnl
            // 
            this.userNamePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(67)))), ((int)(((byte)(214)))));
            this.userNamePnl.Location = new System.Drawing.Point(392, 218);
            this.userNamePnl.Name = "userNamePnl";
            this.userNamePnl.Size = new System.Drawing.Size(270, 1);
            this.userNamePnl.TabIndex = 10;
            // 
            // passwordPnl
            // 
            this.passwordPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(67)))), ((int)(((byte)(214)))));
            this.passwordPnl.Location = new System.Drawing.Point(392, 298);
            this.passwordPnl.Name = "passwordPnl";
            this.passwordPnl.Size = new System.Drawing.Size(270, 1);
            this.passwordPnl.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(517, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Don\'t have an account?";
            // 
            // signUpLbl
            // 
            this.signUpLbl.AutoSize = true;
            this.signUpLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(67)))), ((int)(((byte)(214)))));
            this.signUpLbl.Location = new System.Drawing.Point(624, 352);
            this.signUpLbl.Name = "signUpLbl";
            this.signUpLbl.Size = new System.Drawing.Size(40, 13);
            this.signUpLbl.TabIndex = 13;
            this.signUpLbl.Text = "Sign up";
            this.signUpLbl.Click += new System.EventHandler(this.SignUpLbl_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(67)))), ((int)(((byte)(214)))));
            this.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.Black;
            this.LoginBtn.Location = new System.Drawing.Point(392, 372);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(270, 45);
            this.LoginBtn.TabIndex = 80;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordMask
            // 
            this.PasswordMask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(67)))), ((int)(((byte)(214)))));
            this.PasswordMask.BackgroundImage = global::AyuboDrive.Properties.Resources.PasswordVisibleBlack16;
            this.PasswordMask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PasswordMask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasswordMask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.PasswordMask.FlatAppearance.BorderSize = 0;
            this.PasswordMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordMask.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordMask.Location = new System.Drawing.Point(637, 273);
            this.PasswordMask.Name = "PasswordMask";
            this.PasswordMask.Size = new System.Drawing.Size(25, 25);
            this.PasswordMask.TabIndex = 81;
            this.PasswordMask.UseVisualStyleBackColor = false;
            this.PasswordMask.Click += new System.EventHandler(this.PasswordMask_Click);
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.imagePanel.BackgroundImage = global::AyuboDrive.Properties.Resources.loginSidePanelIllustartion;
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagePanel.Controls.Add(this.label7);
            this.imagePanel.Controls.Add(this.label6);
            this.imagePanel.Controls.Add(this.label5);
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagePanel.Location = new System.Drawing.Point(0, 0);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(350, 500);
            this.imagePanel.TabIndex = 200;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.label7.Location = new System.Drawing.Point(23, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 28);
            this.label7.TabIndex = 83;
            this.label7.Text = "Manage all of your services using Ayubo Drive IMS,\r\na product of Ayubo Leisure (P" +
    "vt) Ltd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Carlito", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(20, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 36);
            this.label6.TabIndex = 82;
            this.label6.Text = "Welcome back!";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.label5.Location = new System.Drawing.Point(12, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "A product of Ayubo Leisure (Pvt) Ltd";
            // 
            // LoginFormV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.PasswordMask);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.signUpLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordPnl);
            this.Controls.Add(this.userNamePnl);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.UserNameTxtBox);
            this.Controls.Add(this.passwordErrorLbl);
            this.Controls.Add(this.userNameErrorLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imagePanel);
            this.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginFormV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginFormV2";
            this.imagePanel.ResumeLayout(false);
            this.imagePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userNameErrorLbl;
        private System.Windows.Forms.Label passwordErrorLbl;
        private System.Windows.Forms.TextBox UserNameTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Panel userNamePnl;
        private System.Windows.Forms.Panel passwordPnl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label signUpLbl;
        private Utility.CustomButton LoginBtn;
        private Utility.CustomButton PasswordMask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}