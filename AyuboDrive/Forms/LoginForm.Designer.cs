namespace AyuboDrive.Forms
{
    partial class LoginForm
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
            this.headingLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SignUpLbl = new System.Windows.Forms.Label();
            this.questionLbl = new System.Windows.Forms.Label();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.userNamePanel = new System.Windows.Forms.Panel();
            this.passwordErrorLbl = new System.Windows.Forms.Label();
            this.userNameErrorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headingLbl
            // 
            this.headingLbl.AutoSize = true;
            this.headingLbl.BackColor = System.Drawing.Color.Transparent;
            this.headingLbl.Font = new System.Drawing.Font("Carlito", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLbl.Location = new System.Drawing.Point(134, 69);
            this.headingLbl.Name = "headingLbl";
            this.headingLbl.Size = new System.Drawing.Size(333, 42);
            this.headingLbl.TabIndex = 0;
            this.headingLbl.Text = "Log in to Your Account";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.userNameLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.Location = new System.Drawing.Point(161, 148);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(60, 15);
            this.userNameLbl.TabIndex = 1;
            this.userNameLbl.Text = "Username";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(160, 217);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(58, 15);
            this.PasswordLbl.TabIndex = 2;
            this.PasswordLbl.Text = "Password";
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.userNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxtBox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.userNameTxtBox.Location = new System.Drawing.Point(164, 166);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.Size = new System.Drawing.Size(270, 19);
            this.userNameTxtBox.TabIndex = 3;
            this.userNameTxtBox.Enter += new System.EventHandler(this.userNameTxtBox_Enter);
            this.userNameTxtBox.Leave += new System.EventHandler(this.userNameTxtBox_Leave);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.passwordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.passwordTxtBox.Location = new System.Drawing.Point(164, 239);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(270, 19);
            this.passwordTxtBox.TabIndex = 4;
            this.passwordTxtBox.Enter += new System.EventHandler(this.passwordTxtBox_Enter);
            this.passwordTxtBox.Leave += new System.EventHandler(this.passwordTxtBox_Leave);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Carlito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.loginBtn.Location = new System.Drawing.Point(162, 310);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(271, 45);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            this.loginBtn.MouseEnter += new System.EventHandler(this.loginBtn_MouseEnter);
            this.loginBtn.MouseLeave += new System.EventHandler(this.loginBtn_MouseLeave);
            // 
            // SignUpLbl
            // 
            this.SignUpLbl.AutoSize = true;
            this.SignUpLbl.BackColor = System.Drawing.Color.Transparent;
            this.SignUpLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.SignUpLbl.Location = new System.Drawing.Point(391, 291);
            this.SignUpLbl.Name = "SignUpLbl";
            this.SignUpLbl.Size = new System.Drawing.Size(40, 13);
            this.SignUpLbl.TabIndex = 23;
            this.SignUpLbl.Text = "Sign up";
            this.SignUpLbl.Click += new System.EventHandler(this.SignUpLbl_Click);
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.BackColor = System.Drawing.Color.Transparent;
            this.questionLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.ForeColor = System.Drawing.Color.DimGray;
            this.questionLbl.Location = new System.Drawing.Point(283, 291);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(112, 13);
            this.questionLbl.TabIndex = 22;
            this.questionLbl.Text = "Don\'t have an account?";
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.passwordPanel.Location = new System.Drawing.Point(163, 264);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(270, 2);
            this.passwordPanel.TabIndex = 27;
            // 
            // userNamePanel
            // 
            this.userNamePanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.userNamePanel.Location = new System.Drawing.Point(165, 190);
            this.userNamePanel.Name = "userNamePanel";
            this.userNamePanel.Size = new System.Drawing.Size(270, 2);
            this.userNamePanel.TabIndex = 26;
            // 
            // passwordErrorLbl
            // 
            this.passwordErrorLbl.AutoSize = true;
            this.passwordErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordErrorLbl.ForeColor = System.Drawing.Color.DimGray;
            this.passwordErrorLbl.Location = new System.Drawing.Point(162, 269);
            this.passwordErrorLbl.Name = "passwordErrorLbl";
            this.passwordErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.passwordErrorLbl.TabIndex = 31;
            // 
            // userNameErrorLbl
            // 
            this.userNameErrorLbl.AutoSize = true;
            this.userNameErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.userNameErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameErrorLbl.ForeColor = System.Drawing.Color.DimGray;
            this.userNameErrorLbl.Location = new System.Drawing.Point(162, 193);
            this.userNameErrorLbl.Name = "userNameErrorLbl";
            this.userNameErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.userNameErrorLbl.TabIndex = 30;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 411);
            this.Controls.Add(this.passwordErrorLbl);
            this.Controls.Add(this.userNameErrorLbl);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.userNamePanel);
            this.Controls.Add(this.SignUpLbl);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.userNameTxtBox);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.headingLbl);
            this.Font = new System.Drawing.Font("Garamond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLbl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label SignUpLbl;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.Panel userNamePanel;
        private System.Windows.Forms.Label passwordErrorLbl;
        private System.Windows.Forms.Label userNameErrorLbl;
    }
}