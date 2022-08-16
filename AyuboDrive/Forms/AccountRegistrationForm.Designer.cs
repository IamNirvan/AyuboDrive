﻿namespace AyuboDrive.Forms
{
    partial class AccountRegistrationForm
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
            this.signUpBtn = new System.Windows.Forms.Button();
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.headingLbl = new System.Windows.Forms.Label();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.firstNamePanel = new System.Windows.Forms.Panel();
            this.lastNamePanel = new System.Windows.Forms.Panel();
            this.userNamePanel = new System.Windows.Forms.Panel();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.firstNameErrorLbl = new System.Windows.Forms.Label();
            this.lastNameErrorLbl = new System.Windows.Forms.Label();
            this.userNameErrorLbl = new System.Windows.Forms.Label();
            this.passwordErrorLbl = new System.Windows.Forms.Label();
            this.getOTPBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OTPTxtBox = new System.Windows.Forms.TextBox();
            this.OTPLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.signUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpBtn.Font = new System.Drawing.Font("Carlito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.signUpBtn.Location = new System.Drawing.Point(347, 272);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(271, 45);
            this.signUpBtn.TabIndex = 13;
            this.signUpBtn.Text = "Sign up";
            this.signUpBtn.UseVisualStyleBackColor = false;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            this.signUpBtn.MouseEnter += new System.EventHandler(this.signUpBtn_MouseEnter);
            this.signUpBtn.MouseLeave += new System.EventHandler(this.signUpBtn_MouseLeave);
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxtBox.Location = new System.Drawing.Point(50, 286);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.Size = new System.Drawing.Size(270, 19);
            this.userNameTxtBox.TabIndex = 10;
            this.userNameTxtBox.Enter += new System.EventHandler(this.userNameTxtBox_Enter);
            this.userNameTxtBox.Leave += new System.EventHandler(this.userNameTxtBox_Leave);
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.userNameLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.Location = new System.Drawing.Point(47, 268);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(60, 15);
            this.userNameLbl.TabIndex = 8;
            this.userNameLbl.Text = "Username";
            // 
            // headingLbl
            // 
            this.headingLbl.AutoSize = true;
            this.headingLbl.BackColor = System.Drawing.Color.Transparent;
            this.headingLbl.Font = new System.Drawing.Font("Carlito", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLbl.Location = new System.Drawing.Point(162, 40);
            this.headingLbl.Name = "headingLbl";
            this.headingLbl.Size = new System.Drawing.Size(334, 42);
            this.headingLbl.TabIndex = 7;
            this.headingLbl.Text = "Create a New Account";
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTxtBox.Location = new System.Drawing.Point(51, 217);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(270, 19);
            this.lastNameTxtBox.TabIndex = 17;
            this.lastNameTxtBox.Enter += new System.EventHandler(this.lastNameTxtBox_Enter);
            this.lastNameTxtBox.Leave += new System.EventHandler(this.lastNameTxtBox_Leave);
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTxtBox.Location = new System.Drawing.Point(50, 140);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(270, 19);
            this.firstNameTxtBox.TabIndex = 16;
            this.firstNameTxtBox.Enter += new System.EventHandler(this.firstNameTxtBox_Enter);
            this.firstNameTxtBox.Leave += new System.EventHandler(this.firstNameTxtBox_Leave);
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLbl.Location = new System.Drawing.Point(47, 195);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(59, 15);
            this.lastNameLbl.TabIndex = 15;
            this.lastNameLbl.Text = "Last name";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.Location = new System.Drawing.Point(47, 122);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(62, 15);
            this.firstNameLbl.TabIndex = 14;
            this.firstNameLbl.Text = "First name";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.Location = new System.Drawing.Point(347, 140);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(270, 19);
            this.passwordTxtBox.TabIndex = 19;
            this.passwordTxtBox.Enter += new System.EventHandler(this.passwordTxtBox_Enter);
            this.passwordTxtBox.Leave += new System.EventHandler(this.passwordTxtBox_Leave);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(342, 122);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(58, 15);
            this.passwordLbl.TabIndex = 18;
            this.passwordLbl.Text = "Password";
            // 
            // firstNamePanel
            // 
            this.firstNamePanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.firstNamePanel.Location = new System.Drawing.Point(50, 165);
            this.firstNamePanel.Name = "firstNamePanel";
            this.firstNamePanel.Size = new System.Drawing.Size(270, 2);
            this.firstNamePanel.TabIndex = 22;
            // 
            // lastNamePanel
            // 
            this.lastNamePanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lastNamePanel.Location = new System.Drawing.Point(52, 242);
            this.lastNamePanel.Name = "lastNamePanel";
            this.lastNamePanel.Size = new System.Drawing.Size(270, 2);
            this.lastNamePanel.TabIndex = 23;
            // 
            // userNamePanel
            // 
            this.userNamePanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.userNamePanel.Location = new System.Drawing.Point(52, 311);
            this.userNamePanel.Name = "userNamePanel";
            this.userNamePanel.Size = new System.Drawing.Size(270, 2);
            this.userNamePanel.TabIndex = 24;
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.passwordPanel.Location = new System.Drawing.Point(348, 165);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(270, 2);
            this.passwordPanel.TabIndex = 25;
            // 
            // firstNameErrorLbl
            // 
            this.firstNameErrorLbl.AutoSize = true;
            this.firstNameErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.firstNameErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameErrorLbl.ForeColor = System.Drawing.Color.DimGray;
            this.firstNameErrorLbl.Location = new System.Drawing.Point(47, 168);
            this.firstNameErrorLbl.Name = "firstNameErrorLbl";
            this.firstNameErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.firstNameErrorLbl.TabIndex = 26;
            // 
            // lastNameErrorLbl
            // 
            this.lastNameErrorLbl.AutoSize = true;
            this.lastNameErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.lastNameErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameErrorLbl.ForeColor = System.Drawing.Color.DimGray;
            this.lastNameErrorLbl.Location = new System.Drawing.Point(48, 245);
            this.lastNameErrorLbl.Name = "lastNameErrorLbl";
            this.lastNameErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.lastNameErrorLbl.TabIndex = 27;
            // 
            // userNameErrorLbl
            // 
            this.userNameErrorLbl.AutoSize = true;
            this.userNameErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.userNameErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameErrorLbl.ForeColor = System.Drawing.Color.DimGray;
            this.userNameErrorLbl.Location = new System.Drawing.Point(47, 314);
            this.userNameErrorLbl.Name = "userNameErrorLbl";
            this.userNameErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.userNameErrorLbl.TabIndex = 28;
            // 
            // passwordErrorLbl
            // 
            this.passwordErrorLbl.AutoSize = true;
            this.passwordErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordErrorLbl.ForeColor = System.Drawing.Color.DimGray;
            this.passwordErrorLbl.Location = new System.Drawing.Point(346, 169);
            this.passwordErrorLbl.Name = "passwordErrorLbl";
            this.passwordErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.passwordErrorLbl.TabIndex = 29;
            // 
            // getOTPBtn
            // 
            this.getOTPBtn.BackColor = System.Drawing.Color.Transparent;
            this.getOTPBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getOTPBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.getOTPBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getOTPBtn.Font = new System.Drawing.Font("Carlito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getOTPBtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.getOTPBtn.Location = new System.Drawing.Point(347, 272);
            this.getOTPBtn.Name = "getOTPBtn";
            this.getOTPBtn.Size = new System.Drawing.Size(271, 45);
            this.getOTPBtn.TabIndex = 30;
            this.getOTPBtn.Text = "Get OPT";
            this.getOTPBtn.UseVisualStyleBackColor = false;
            this.getOTPBtn.Click += new System.EventHandler(this.getOTPBtn_Click);
            this.getOTPBtn.MouseEnter += new System.EventHandler(this.getOTPBtn_MouseEnter);
            this.getOTPBtn.MouseLeave += new System.EventHandler(this.getOTPBtn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Location = new System.Drawing.Point(346, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 2);
            this.panel1.TabIndex = 33;
            // 
            // OTPTxtBox
            // 
            this.OTPTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OTPTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPTxtBox.Location = new System.Drawing.Point(345, 217);
            this.OTPTxtBox.Name = "OTPTxtBox";
            this.OTPTxtBox.Size = new System.Drawing.Size(270, 19);
            this.OTPTxtBox.TabIndex = 32;
            this.OTPTxtBox.TextChanged += new System.EventHandler(this.OTPTxtBox_TextChanged);
            this.OTPTxtBox.Enter += new System.EventHandler(this.OTPTxtBox_Enter);
            this.OTPTxtBox.Leave += new System.EventHandler(this.OTPTxtBox_Leave);
            // 
            // OTPLbl
            // 
            this.OTPLbl.AutoSize = true;
            this.OTPLbl.BackColor = System.Drawing.Color.Transparent;
            this.OTPLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPLbl.Location = new System.Drawing.Point(342, 195);
            this.OTPLbl.Name = "OTPLbl";
            this.OTPLbl.Size = new System.Drawing.Size(29, 15);
            this.OTPLbl.TabIndex = 31;
            this.OTPLbl.Text = "OTP";
            // 
            // AccountRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OTPTxtBox);
            this.Controls.Add(this.OTPLbl);
            this.Controls.Add(this.getOTPBtn);
            this.Controls.Add(this.passwordErrorLbl);
            this.Controls.Add(this.userNameErrorLbl);
            this.Controls.Add(this.lastNameErrorLbl);
            this.Controls.Add(this.firstNameErrorLbl);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.userNamePanel);
            this.Controls.Add(this.lastNamePanel);
            this.Controls.Add(this.firstNamePanel);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.lastNameTxtBox);
            this.Controls.Add(this.firstNameTxtBox);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.userNameTxtBox);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.headingLbl);
            this.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AccountRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountRegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label headingLbl;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Panel firstNamePanel;
        private System.Windows.Forms.Panel lastNamePanel;
        private System.Windows.Forms.Panel userNamePanel;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.Label firstNameErrorLbl;
        private System.Windows.Forms.Label lastNameErrorLbl;
        private System.Windows.Forms.Label userNameErrorLbl;
        private System.Windows.Forms.Label passwordErrorLbl;
        private System.Windows.Forms.Button getOTPBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox OTPTxtBox;
        private System.Windows.Forms.Label OTPLbl;
    }
}