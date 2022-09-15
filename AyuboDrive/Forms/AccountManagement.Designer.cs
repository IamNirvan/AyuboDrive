﻿namespace AyuboDrive.Forms
{
    partial class AccountManagement
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
            this.TitleLbl = new System.Windows.Forms.Label();
            this.ManipulationPanel = new System.Windows.Forms.Panel();
            this.ImagePathBtn = new System.Windows.Forms.Button();
            this.ImagePathTxtBox = new System.Windows.Forms.TextBox();
            this.ImagePathPnl = new System.Windows.Forms.Panel();
            this.ImagePathLbl = new System.Windows.Forms.Label();
            this.ImagePathErrorLbl = new System.Windows.Forms.Label();
            this.PasswordMask = new System.Windows.Forms.Button();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordPnl = new System.Windows.Forms.Panel();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.PasswordErrorLbl = new System.Windows.Forms.Label();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.LastNamePnl = new System.Windows.Forms.Panel();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.LastNameErrorLbl = new System.Windows.Forms.Label();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.FirstNamePnl = new System.Windows.Forms.Panel();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.FirstNameErrorLbl = new System.Windows.Forms.Label();
            this.UserNameTxtBox = new System.Windows.Forms.TextBox();
            this.UserNamePnl = new System.Windows.Forms.Panel();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.UserNameErrorLbl = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ProfileImagePicBox = new System.Windows.Forms.PictureBox();
            this.EnableUpdateCheckbox = new System.Windows.Forms.CheckBox();
            this.ManipulationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImagePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Carlito", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.TitleLbl.Location = new System.Drawing.Point(12, 34);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(308, 39);
            this.TitleLbl.TabIndex = 66;
            this.TitleLbl.Text = "Account Management";
            // 
            // ManipulationPanel
            // 
            this.ManipulationPanel.AutoScroll = true;
            this.ManipulationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.ManipulationPanel.Controls.Add(this.ImagePathBtn);
            this.ManipulationPanel.Controls.Add(this.ImagePathTxtBox);
            this.ManipulationPanel.Controls.Add(this.ImagePathPnl);
            this.ManipulationPanel.Controls.Add(this.ImagePathLbl);
            this.ManipulationPanel.Controls.Add(this.ImagePathErrorLbl);
            this.ManipulationPanel.Controls.Add(this.PasswordMask);
            this.ManipulationPanel.Controls.Add(this.PasswordTxtBox);
            this.ManipulationPanel.Controls.Add(this.PasswordPnl);
            this.ManipulationPanel.Controls.Add(this.PasswordLbl);
            this.ManipulationPanel.Controls.Add(this.PasswordErrorLbl);
            this.ManipulationPanel.Controls.Add(this.LastNameTxtBox);
            this.ManipulationPanel.Controls.Add(this.LastNamePnl);
            this.ManipulationPanel.Controls.Add(this.LastNameLbl);
            this.ManipulationPanel.Controls.Add(this.LastNameErrorLbl);
            this.ManipulationPanel.Controls.Add(this.FirstNameTxtBox);
            this.ManipulationPanel.Controls.Add(this.FirstNamePnl);
            this.ManipulationPanel.Controls.Add(this.FirstNameLbl);
            this.ManipulationPanel.Controls.Add(this.FirstNameErrorLbl);
            this.ManipulationPanel.Controls.Add(this.UserNameTxtBox);
            this.ManipulationPanel.Controls.Add(this.UserNamePnl);
            this.ManipulationPanel.Controls.Add(this.userNameLbl);
            this.ManipulationPanel.Controls.Add(this.UserNameErrorLbl);
            this.ManipulationPanel.Location = new System.Drawing.Point(12, 87);
            this.ManipulationPanel.Name = "ManipulationPanel";
            this.ManipulationPanel.Size = new System.Drawing.Size(269, 296);
            this.ManipulationPanel.TabIndex = 69;
            // 
            // ImagePathBtn
            // 
            this.ImagePathBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.ImagePathBtn.BackgroundImage = global::AyuboDrive.Properties.Resources.SearchBlack16;
            this.ImagePathBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ImagePathBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImagePathBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.ImagePathBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImagePathBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagePathBtn.Location = new System.Drawing.Point(172, 316);
            this.ImagePathBtn.Name = "ImagePathBtn";
            this.ImagePathBtn.Size = new System.Drawing.Size(25, 25);
            this.ImagePathBtn.TabIndex = 77;
            this.ImagePathBtn.UseVisualStyleBackColor = false;
            this.ImagePathBtn.Click += new System.EventHandler(this.ImagePathBtn_Click);
            // 
            // ImagePathTxtBox
            // 
            this.ImagePathTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.ImagePathTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImagePathTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.ImagePathTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.ImagePathTxtBox.Location = new System.Drawing.Point(16, 319);
            this.ImagePathTxtBox.Name = "ImagePathTxtBox";
            this.ImagePathTxtBox.Size = new System.Drawing.Size(150, 19);
            this.ImagePathTxtBox.TabIndex = 76;
            // 
            // ImagePathPnl
            // 
            this.ImagePathPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.ImagePathPnl.Location = new System.Drawing.Point(16, 337);
            this.ImagePathPnl.Name = "ImagePathPnl";
            this.ImagePathPnl.Size = new System.Drawing.Size(150, 2);
            this.ImagePathPnl.TabIndex = 75;
            // 
            // ImagePathLbl
            // 
            this.ImagePathLbl.AutoSize = true;
            this.ImagePathLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagePathLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.ImagePathLbl.Location = new System.Drawing.Point(13, 297);
            this.ImagePathLbl.Name = "ImagePathLbl";
            this.ImagePathLbl.Size = new System.Drawing.Size(65, 15);
            this.ImagePathLbl.TabIndex = 73;
            this.ImagePathLbl.Text = "Image path";
            // 
            // ImagePathErrorLbl
            // 
            this.ImagePathErrorLbl.AutoSize = true;
            this.ImagePathErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.ImagePathErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagePathErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ImagePathErrorLbl.Location = new System.Drawing.Point(13, 342);
            this.ImagePathErrorLbl.Name = "ImagePathErrorLbl";
            this.ImagePathErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.ImagePathErrorLbl.TabIndex = 74;
            this.ImagePathErrorLbl.Text = " ";
            // 
            // PasswordMask
            // 
            this.PasswordMask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.PasswordMask.BackgroundImage = global::AyuboDrive.Properties.Resources.PasswordVisibleBlack16;
            this.PasswordMask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PasswordMask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasswordMask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.PasswordMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordMask.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordMask.Location = new System.Drawing.Point(205, 243);
            this.PasswordMask.Name = "PasswordMask";
            this.PasswordMask.Size = new System.Drawing.Size(25, 25);
            this.PasswordMask.TabIndex = 72;
            this.PasswordMask.UseVisualStyleBackColor = false;
            this.PasswordMask.Click += new System.EventHandler(this.PasswordMask_Click);
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.PasswordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.PasswordTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.PasswordTxtBox.Location = new System.Drawing.Point(17, 248);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '*';
            this.PasswordTxtBox.Size = new System.Drawing.Size(188, 19);
            this.PasswordTxtBox.TabIndex = 60;
            this.PasswordTxtBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.PasswordTxtBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // PasswordPnl
            // 
            this.PasswordPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.PasswordPnl.Location = new System.Drawing.Point(17, 266);
            this.PasswordPnl.Name = "PasswordPnl";
            this.PasswordPnl.Size = new System.Drawing.Size(213, 2);
            this.PasswordPnl.TabIndex = 59;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.PasswordLbl.Location = new System.Drawing.Point(14, 226);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(58, 15);
            this.PasswordLbl.TabIndex = 57;
            this.PasswordLbl.Text = "Password";
            // 
            // PasswordErrorLbl
            // 
            this.PasswordErrorLbl.AutoSize = true;
            this.PasswordErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.PasswordErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.PasswordErrorLbl.Location = new System.Drawing.Point(14, 271);
            this.PasswordErrorLbl.Name = "PasswordErrorLbl";
            this.PasswordErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.PasswordErrorLbl.TabIndex = 58;
            this.PasswordErrorLbl.Text = " ";
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.LastNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.LastNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.LastNameTxtBox.Location = new System.Drawing.Point(17, 179);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(213, 19);
            this.LastNameTxtBox.TabIndex = 56;
            this.LastNameTxtBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.LastNameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharacterOnlyTextBox_KeyPress);
            this.LastNameTxtBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // LastNamePnl
            // 
            this.LastNamePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.LastNamePnl.Location = new System.Drawing.Point(17, 197);
            this.LastNamePnl.Name = "LastNamePnl";
            this.LastNamePnl.Size = new System.Drawing.Size(213, 2);
            this.LastNamePnl.TabIndex = 55;
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.LastNameLbl.Location = new System.Drawing.Point(14, 157);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(59, 15);
            this.LastNameLbl.TabIndex = 53;
            this.LastNameLbl.Text = "Last name";
            // 
            // LastNameErrorLbl
            // 
            this.LastNameErrorLbl.AutoSize = true;
            this.LastNameErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.LastNameErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.LastNameErrorLbl.Location = new System.Drawing.Point(14, 202);
            this.LastNameErrorLbl.Name = "LastNameErrorLbl";
            this.LastNameErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.LastNameErrorLbl.TabIndex = 54;
            this.LastNameErrorLbl.Text = " ";
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.FirstNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstNameTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.FirstNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.FirstNameTxtBox.Location = new System.Drawing.Point(17, 110);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(213, 19);
            this.FirstNameTxtBox.TabIndex = 52;
            this.FirstNameTxtBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.FirstNameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharacterOnlyTextBox_KeyPress);
            this.FirstNameTxtBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // FirstNamePnl
            // 
            this.FirstNamePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.FirstNamePnl.Location = new System.Drawing.Point(17, 128);
            this.FirstNamePnl.Name = "FirstNamePnl";
            this.FirstNamePnl.Size = new System.Drawing.Size(213, 2);
            this.FirstNamePnl.TabIndex = 51;
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.FirstNameLbl.Location = new System.Drawing.Point(14, 88);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(62, 15);
            this.FirstNameLbl.TabIndex = 49;
            this.FirstNameLbl.Text = "First name";
            // 
            // FirstNameErrorLbl
            // 
            this.FirstNameErrorLbl.AutoSize = true;
            this.FirstNameErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.FirstNameErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.FirstNameErrorLbl.Location = new System.Drawing.Point(14, 133);
            this.FirstNameErrorLbl.Name = "FirstNameErrorLbl";
            this.FirstNameErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.FirstNameErrorLbl.TabIndex = 50;
            this.FirstNameErrorLbl.Text = " ";
            // 
            // UserNameTxtBox
            // 
            this.UserNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.UserNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.UserNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.UserNameTxtBox.Location = new System.Drawing.Point(17, 39);
            this.UserNameTxtBox.Name = "UserNameTxtBox";
            this.UserNameTxtBox.Size = new System.Drawing.Size(213, 19);
            this.UserNameTxtBox.TabIndex = 48;
            this.UserNameTxtBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserNameTxtBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // UserNamePnl
            // 
            this.UserNamePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.UserNamePnl.Location = new System.Drawing.Point(17, 57);
            this.UserNamePnl.Name = "UserNamePnl";
            this.UserNamePnl.Size = new System.Drawing.Size(213, 2);
            this.UserNamePnl.TabIndex = 40;
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.userNameLbl.Location = new System.Drawing.Point(14, 17);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(63, 15);
            this.userNameLbl.TabIndex = 33;
            this.userNameLbl.Text = "User name";
            // 
            // UserNameErrorLbl
            // 
            this.UserNameErrorLbl.AutoSize = true;
            this.UserNameErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.UserNameErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.UserNameErrorLbl.Location = new System.Drawing.Point(14, 62);
            this.UserNameErrorLbl.Name = "UserNameErrorLbl";
            this.UserNameErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.UserNameErrorLbl.TabIndex = 34;
            this.UserNameErrorLbl.Text = " ";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DeleteBtn.Location = new System.Drawing.Point(294, 338);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(143, 45);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "Delete Account";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            this.DeleteBtn.MouseEnter += new System.EventHandler(this.DeleteBtn_MouseEnter);
            this.DeleteBtn.MouseLeave += new System.EventHandler(this.DeleteBtn_MouseLeave);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(199)))), ((int)(((byte)(151)))));
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.Enabled = false;
            this.UpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(199)))), ((int)(((byte)(151)))));
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(294, 282);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(143, 50);
            this.UpdateBtn.TabIndex = 6;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(463, 30);
            this.flowLayoutPanel1.TabIndex = 68;
            // 
            // ProfileImagePicBox
            // 
            this.ProfileImagePicBox.BackColor = System.Drawing.Color.Transparent;
            this.ProfileImagePicBox.Location = new System.Drawing.Point(287, 87);
            this.ProfileImagePicBox.Name = "ProfileImagePicBox";
            this.ProfileImagePicBox.Size = new System.Drawing.Size(150, 150);
            this.ProfileImagePicBox.TabIndex = 0;
            this.ProfileImagePicBox.TabStop = false;
            // 
            // EnableUpdateCheckbox
            // 
            this.EnableUpdateCheckbox.AutoSize = true;
            this.EnableUpdateCheckbox.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnableUpdateCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.EnableUpdateCheckbox.Location = new System.Drawing.Point(294, 258);
            this.EnableUpdateCheckbox.Name = "EnableUpdateCheckbox";
            this.EnableUpdateCheckbox.Size = new System.Drawing.Size(96, 18);
            this.EnableUpdateCheckbox.TabIndex = 72;
            this.EnableUpdateCheckbox.Text = "Enable update";
            this.EnableUpdateCheckbox.UseVisualStyleBackColor = true;
            this.EnableUpdateCheckbox.CheckedChanged += new System.EventHandler(this.EnableUpdateCheckbox_CheckedChanged);
            // 
            // AccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(463, 398);
            this.Controls.Add(this.EnableUpdateCheckbox);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ProfileImagePicBox);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.ManipulationPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountManagement";
            this.ManipulationPanel.ResumeLayout(false);
            this.ManipulationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImagePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Panel ManipulationPanel;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Panel PasswordPnl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label PasswordErrorLbl;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.Panel LastNamePnl;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.Label LastNameErrorLbl;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.Panel FirstNamePnl;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label FirstNameErrorLbl;
        private System.Windows.Forms.TextBox UserNameTxtBox;
        private System.Windows.Forms.Panel UserNamePnl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label UserNameErrorLbl;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox ProfileImagePicBox;
        private System.Windows.Forms.Button PasswordMask;
        private System.Windows.Forms.CheckBox EnableUpdateCheckbox;
        private System.Windows.Forms.TextBox ImagePathTxtBox;
        private System.Windows.Forms.Panel ImagePathPnl;
        private System.Windows.Forms.Label ImagePathLbl;
        private System.Windows.Forms.Label ImagePathErrorLbl;
        private System.Windows.Forms.Button ImagePathBtn;
    }
}