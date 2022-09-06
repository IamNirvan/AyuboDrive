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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userNameErrorLbl = new System.Windows.Forms.Label();
            this.passwordErrorLbl = new System.Windows.Forms.Label();
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.userNamePnl = new System.Windows.Forms.Panel();
            this.passwordPnl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.signUpLbl = new System.Windows.Forms.Label();
            this.LoginLbl = new System.Windows.Forms.Label();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Carlito", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(414, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome back";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.label2.Location = new System.Drawing.Point(385, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.label3.Location = new System.Drawing.Point(387, 257);
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
            this.userNameErrorLbl.Location = new System.Drawing.Point(387, 225);
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
            this.passwordErrorLbl.Location = new System.Drawing.Point(387, 305);
            this.passwordErrorLbl.Name = "passwordErrorLbl";
            this.passwordErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.passwordErrorLbl.TabIndex = 6;
            this.passwordErrorLbl.Text = " ";
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.userNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.userNameTxtBox.Location = new System.Drawing.Point(388, 195);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.Size = new System.Drawing.Size(270, 19);
            this.userNameTxtBox.TabIndex = 7;
            this.userNameTxtBox.Enter += new System.EventHandler(this.UserNameTxtBox_Enter);
            this.userNameTxtBox.Leave += new System.EventHandler(this.UserNameTxtBox_Leave);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.passwordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.passwordTxtBox.Location = new System.Drawing.Point(388, 275);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(270, 19);
            this.passwordTxtBox.TabIndex = 8;
            this.passwordTxtBox.Enter += new System.EventHandler(this.PasswordTxtBox_Enter);
            this.passwordTxtBox.Leave += new System.EventHandler(this.PasswordTxtBox_Leave);
            // 
            // userNamePnl
            // 
            this.userNamePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.userNamePnl.Location = new System.Drawing.Point(388, 220);
            this.userNamePnl.Name = "userNamePnl";
            this.userNamePnl.Size = new System.Drawing.Size(270, 2);
            this.userNamePnl.TabIndex = 10;
            // 
            // passwordPnl
            // 
            this.passwordPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.passwordPnl.Location = new System.Drawing.Point(388, 300);
            this.passwordPnl.Name = "passwordPnl";
            this.passwordPnl.Size = new System.Drawing.Size(270, 2);
            this.passwordPnl.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.label4.Location = new System.Drawing.Point(513, 354);
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
            this.signUpLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.signUpLbl.Location = new System.Drawing.Point(620, 354);
            this.signUpLbl.Name = "signUpLbl";
            this.signUpLbl.Size = new System.Drawing.Size(40, 13);
            this.signUpLbl.TabIndex = 13;
            this.signUpLbl.Text = "Sign up";
            this.signUpLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SignUpLbl_Click);
            // 
            // LoginLbl
            // 
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginLbl.Font = new System.Drawing.Font("Carlito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.LoginLbl.Location = new System.Drawing.Point(388, 380);
            this.LoginLbl.MaximumSize = new System.Drawing.Size(270, 45);
            this.LoginLbl.MinimumSize = new System.Drawing.Size(270, 45);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(270, 45);
            this.LoginLbl.TabIndex = 15;
            this.LoginLbl.Text = "Login";
            this.LoginLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginLbl.Click += new System.EventHandler(this.LoginLbl_Click);
            this.LoginLbl.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginLbl_Paint);
            this.LoginLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginLbl_MouseDown);
            this.LoginLbl.MouseEnter += new System.EventHandler(this.LoginLbl_MouseEnter);
            this.LoginLbl.MouseLeave += new System.EventHandler(this.LoginLbl_MouseLeave);
            this.LoginLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginLbl_MouseUp);
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.imagePanel.BackgroundImage = global::AyuboDrive.Properties.Resources.LoginSidePanel1;
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagePanel.Location = new System.Drawing.Point(0, 0);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(350, 500);
            this.imagePanel.TabIndex = 1;
            // 
            // LoginFormV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.LoginLbl);
            this.Controls.Add(this.signUpLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordPnl);
            this.Controls.Add(this.userNamePnl);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.userNameTxtBox);
            this.Controls.Add(this.passwordErrorLbl);
            this.Controls.Add(this.userNameErrorLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imagePanel);
            this.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginFormV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginFormV2";
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
        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Panel userNamePnl;
        private System.Windows.Forms.Panel passwordPnl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label signUpLbl;
        private System.Windows.Forms.Label LoginLbl;
    }
}