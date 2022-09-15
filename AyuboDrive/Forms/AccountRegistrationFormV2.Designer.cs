using AyuboDrive.Utility;

namespace AyuboDrive.Forms
{
    partial class AccountRegistrationFormV2
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
            this.KeyPnl = new System.Windows.Forms.Panel();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.KeyTxtBox = new System.Windows.Forms.TextBox();
            this.LastNamePnl = new System.Windows.Forms.Panel();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.FirstNamePnl = new System.Windows.Forms.Panel();
            this.UserNameTxtBox = new System.Windows.Forms.TextBox();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.PasswordErrorLbl = new System.Windows.Forms.Label();
            this.KeyErrorLbl = new System.Windows.Forms.Label();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.FirstNameErrorLbl = new System.Windows.Forms.Label();
            this.UserNamePnl = new System.Windows.Forms.Panel();
            this.PasswordPnl = new System.Windows.Forms.Panel();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.LastNameErrorLbl = new System.Windows.Forms.Label();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.KeyLbl = new System.Windows.Forms.Label();
            this.UserNameErrorLbl = new System.Windows.Forms.Label();
            this.ImagePathLbl = new System.Windows.Forms.Label();
            this.ImagePathPnl = new System.Windows.Forms.Panel();
            this.ImagePathErrorLbl = new System.Windows.Forms.Label();
            this.PasswordMask = new AyuboDrive.Utility.CustomButton();
            this.ImagePathBtn = new AyuboDrive.Utility.CustomButton();
            this.SecretKeyBtn = new AyuboDrive.Utility.CustomButton();
            this.UploadImageCheckBox = new System.Windows.Forms.CheckBox();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.ImagePathTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // KeyPnl
            // 
            this.KeyPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.KeyPnl.Location = new System.Drawing.Point(342, 195);
            this.KeyPnl.Name = "KeyPnl";
            this.KeyPnl.Size = new System.Drawing.Size(270, 2);
            this.KeyPnl.TabIndex = 56;
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.FirstNameLbl.Location = new System.Drawing.Point(41, 49);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(62, 15);
            this.FirstNameLbl.TabIndex = 36;
            this.FirstNameLbl.Text = "First name";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.PasswordLbl.Location = new System.Drawing.Point(39, 278);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(58, 15);
            this.PasswordLbl.TabIndex = 48;
            this.PasswordLbl.Text = "Password";
            // 
            // KeyTxtBox
            // 
            this.KeyTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.KeyTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeyTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.KeyTxtBox.Location = new System.Drawing.Point(342, 170);
            this.KeyTxtBox.Name = "KeyTxtBox";
            this.KeyTxtBox.PasswordChar = '*';
            this.KeyTxtBox.Size = new System.Drawing.Size(270, 19);
            this.KeyTxtBox.TabIndex = 55;
            this.KeyTxtBox.TextChanged += new System.EventHandler(this.KeyTxtBox_TextChanged);
            this.KeyTxtBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.KeyTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharacterOnlyTextBox_KeyPress);
            this.KeyTxtBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // LastNamePnl
            // 
            this.LastNamePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.LastNamePnl.Location = new System.Drawing.Point(42, 167);
            this.LastNamePnl.Name = "LastNamePnl";
            this.LastNamePnl.Size = new System.Drawing.Size(270, 2);
            this.LastNamePnl.TabIndex = 46;
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.LastNameLbl.Location = new System.Drawing.Point(39, 124);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(59, 15);
            this.LastNameLbl.TabIndex = 40;
            this.LastNameLbl.Text = "Last name";
            // 
            // FirstNamePnl
            // 
            this.FirstNamePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.FirstNamePnl.Location = new System.Drawing.Point(42, 92);
            this.FirstNamePnl.Name = "FirstNamePnl";
            this.FirstNamePnl.Size = new System.Drawing.Size(270, 2);
            this.FirstNamePnl.TabIndex = 39;
            // 
            // UserNameTxtBox
            // 
            this.UserNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.UserNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.UserNameTxtBox.Location = new System.Drawing.Point(42, 219);
            this.UserNameTxtBox.Name = "UserNameTxtBox";
            this.UserNameTxtBox.Size = new System.Drawing.Size(270, 19);
            this.UserNameTxtBox.TabIndex = 45;
            this.UserNameTxtBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserNameTxtBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.UserNameLbl.Location = new System.Drawing.Point(41, 201);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(63, 15);
            this.UserNameLbl.TabIndex = 41;
            this.UserNameLbl.Text = "User name";
            // 
            // PasswordErrorLbl
            // 
            this.PasswordErrorLbl.AutoSize = true;
            this.PasswordErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.PasswordErrorLbl.Location = new System.Drawing.Point(41, 326);
            this.PasswordErrorLbl.Name = "PasswordErrorLbl";
            this.PasswordErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.PasswordErrorLbl.TabIndex = 49;
            this.PasswordErrorLbl.Text = " ";
            // 
            // KeyErrorLbl
            // 
            this.KeyErrorLbl.AutoSize = true;
            this.KeyErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.KeyErrorLbl.Location = new System.Drawing.Point(341, 200);
            this.KeyErrorLbl.Name = "KeyErrorLbl";
            this.KeyErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.KeyErrorLbl.TabIndex = 54;
            this.KeyErrorLbl.Text = " ";
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.LastNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.LastNameTxtBox.Location = new System.Drawing.Point(42, 142);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(270, 19);
            this.LastNameTxtBox.TabIndex = 44;
            this.LastNameTxtBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.LastNameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharacterOnlyTextBox_KeyPress);
            this.LastNameTxtBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // FirstNameErrorLbl
            // 
            this.FirstNameErrorLbl.AutoSize = true;
            this.FirstNameErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.FirstNameErrorLbl.Location = new System.Drawing.Point(41, 97);
            this.FirstNameErrorLbl.Name = "FirstNameErrorLbl";
            this.FirstNameErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.FirstNameErrorLbl.TabIndex = 37;
            this.FirstNameErrorLbl.Text = " ";
            // 
            // UserNamePnl
            // 
            this.UserNamePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.UserNamePnl.Location = new System.Drawing.Point(42, 244);
            this.UserNamePnl.Name = "UserNamePnl";
            this.UserNamePnl.Size = new System.Drawing.Size(270, 2);
            this.UserNamePnl.TabIndex = 47;
            // 
            // PasswordPnl
            // 
            this.PasswordPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.PasswordPnl.Location = new System.Drawing.Point(42, 321);
            this.PasswordPnl.Name = "PasswordPnl";
            this.PasswordPnl.Size = new System.Drawing.Size(270, 2);
            this.PasswordPnl.TabIndex = 51;
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.FirstNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstNameTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.FirstNameTxtBox.Location = new System.Drawing.Point(42, 67);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(270, 19);
            this.FirstNameTxtBox.TabIndex = 38;
            this.FirstNameTxtBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.FirstNameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharacterOnlyTextBox_KeyPress);
            this.FirstNameTxtBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // LastNameErrorLbl
            // 
            this.LastNameErrorLbl.AutoSize = true;
            this.LastNameErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.LastNameErrorLbl.Location = new System.Drawing.Point(41, 172);
            this.LastNameErrorLbl.Name = "LastNameErrorLbl";
            this.LastNameErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.LastNameErrorLbl.TabIndex = 42;
            this.LastNameErrorLbl.Text = " ";
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.PasswordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.PasswordTxtBox.Location = new System.Drawing.Point(42, 296);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '*';
            this.PasswordTxtBox.Size = new System.Drawing.Size(239, 19);
            this.PasswordTxtBox.TabIndex = 50;
            this.PasswordTxtBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.PasswordTxtBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // KeyLbl
            // 
            this.KeyLbl.AutoSize = true;
            this.KeyLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.KeyLbl.Location = new System.Drawing.Point(339, 152);
            this.KeyLbl.Name = "KeyLbl";
            this.KeyLbl.Size = new System.Drawing.Size(61, 15);
            this.KeyLbl.TabIndex = 53;
            this.KeyLbl.Text = "Secret key";
            // 
            // UserNameErrorLbl
            // 
            this.UserNameErrorLbl.AutoSize = true;
            this.UserNameErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.UserNameErrorLbl.Location = new System.Drawing.Point(41, 249);
            this.UserNameErrorLbl.Name = "UserNameErrorLbl";
            this.UserNameErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.UserNameErrorLbl.TabIndex = 43;
            this.UserNameErrorLbl.Text = " ";
            // 
            // ImagePathLbl
            // 
            this.ImagePathLbl.AutoSize = true;
            this.ImagePathLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagePathLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.ImagePathLbl.Location = new System.Drawing.Point(341, 77);
            this.ImagePathLbl.Name = "ImagePathLbl";
            this.ImagePathLbl.Size = new System.Drawing.Size(65, 15);
            this.ImagePathLbl.TabIndex = 62;
            this.ImagePathLbl.Text = "Image path";
            // 
            // ImagePathPnl
            // 
            this.ImagePathPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.ImagePathPnl.Location = new System.Drawing.Point(342, 120);
            this.ImagePathPnl.Name = "ImagePathPnl";
            this.ImagePathPnl.Size = new System.Drawing.Size(190, 2);
            this.ImagePathPnl.TabIndex = 65;
            // 
            // ImagePathErrorLbl
            // 
            this.ImagePathErrorLbl.AutoSize = true;
            this.ImagePathErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagePathErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ImagePathErrorLbl.Location = new System.Drawing.Point(341, 125);
            this.ImagePathErrorLbl.Name = "ImagePathErrorLbl";
            this.ImagePathErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.ImagePathErrorLbl.TabIndex = 63;
            this.ImagePathErrorLbl.Text = " ";
            // 
            // PasswordMask
            // 
            this.PasswordMask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.PasswordMask.BackgroundImage = global::AyuboDrive.Properties.Resources.PasswordVisibleBlack16;
            this.PasswordMask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PasswordMask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasswordMask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.PasswordMask.FlatAppearance.BorderSize = 0;
            this.PasswordMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordMask.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordMask.Location = new System.Drawing.Point(287, 298);
            this.PasswordMask.Name = "PasswordMask";
            this.PasswordMask.Size = new System.Drawing.Size(25, 25);
            this.PasswordMask.TabIndex = 73;
            this.PasswordMask.UseVisualStyleBackColor = false;
            this.PasswordMask.Click += new System.EventHandler(this.PasswordMask_Click);
            // 
            // ImagePathBtn
            // 
            this.ImagePathBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.ImagePathBtn.BackgroundImage = global::AyuboDrive.Properties.Resources.SearchBlack16;
            this.ImagePathBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ImagePathBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImagePathBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.ImagePathBtn.FlatAppearance.BorderSize = 0;
            this.ImagePathBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImagePathBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagePathBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ImagePathBtn.Location = new System.Drawing.Point(538, 98);
            this.ImagePathBtn.Name = "ImagePathBtn";
            this.ImagePathBtn.Size = new System.Drawing.Size(25, 25);
            this.ImagePathBtn.TabIndex = 78;
            this.ImagePathBtn.UseVisualStyleBackColor = false;
            this.ImagePathBtn.Click += new System.EventHandler(this.ImagePathBtn_Click);
            // 
            // SecretKeyBtn
            // 
            this.SecretKeyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.SecretKeyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SecretKeyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SecretKeyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.SecretKeyBtn.FlatAppearance.BorderSize = 0;
            this.SecretKeyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SecretKeyBtn.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretKeyBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.SecretKeyBtn.Location = new System.Drawing.Point(342, 244);
            this.SecretKeyBtn.Name = "SecretKeyBtn";
            this.SecretKeyBtn.Size = new System.Drawing.Size(270, 45);
            this.SecretKeyBtn.TabIndex = 79;
            this.SecretKeyBtn.Text = "Send secret key";
            this.SecretKeyBtn.UseVisualStyleBackColor = false;
            this.SecretKeyBtn.Click += new System.EventHandler(this.SecretKeyBtn_Click);
            // 
            // UploadImageCheckBox
            // 
            this.UploadImageCheckBox.AutoSize = true;
            this.UploadImageCheckBox.Font = new System.Drawing.Font("Carlito", 9.75F);
            this.UploadImageCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.UploadImageCheckBox.Location = new System.Drawing.Point(344, 48);
            this.UploadImageCheckBox.Name = "UploadImageCheckBox";
            this.UploadImageCheckBox.Size = new System.Drawing.Size(137, 19);
            this.UploadImageCheckBox.TabIndex = 80;
            this.UploadImageCheckBox.Text = "Upload profile photo";
            this.UploadImageCheckBox.UseVisualStyleBackColor = true;
            this.UploadImageCheckBox.CheckedChanged += new System.EventHandler(this.UploadImageCheckBox_CheckedChanged);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.SignUpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.SignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpBtn.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.SignUpBtn.Location = new System.Drawing.Point(342, 244);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(270, 45);
            this.SignUpBtn.TabIndex = 81;
            this.SignUpBtn.Text = "Sign up";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // ImagePathTxtBox
            // 
            this.ImagePathTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.ImagePathTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImagePathTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagePathTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.ImagePathTxtBox.Location = new System.Drawing.Point(342, 100);
            this.ImagePathTxtBox.Name = "ImagePathTxtBox";
            this.ImagePathTxtBox.Size = new System.Drawing.Size(190, 19);
            this.ImagePathTxtBox.TabIndex = 82;
            // 
            // AccountRegistrationFormV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(651, 361);
            this.Controls.Add(this.ImagePathTxtBox);
            this.Controls.Add(this.SecretKeyBtn);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.UploadImageCheckBox);
            this.Controls.Add(this.ImagePathBtn);
            this.Controls.Add(this.PasswordMask);
            this.Controls.Add(this.ImagePathLbl);
            this.Controls.Add(this.ImagePathPnl);
            this.Controls.Add(this.ImagePathErrorLbl);
            this.Controls.Add(this.KeyPnl);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.KeyTxtBox);
            this.Controls.Add(this.LastNamePnl);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.FirstNamePnl);
            this.Controls.Add(this.UserNameTxtBox);
            this.Controls.Add(this.UserNameLbl);
            this.Controls.Add(this.PasswordErrorLbl);
            this.Controls.Add(this.KeyErrorLbl);
            this.Controls.Add(this.LastNameTxtBox);
            this.Controls.Add(this.FirstNameErrorLbl);
            this.Controls.Add(this.UserNamePnl);
            this.Controls.Add(this.PasswordPnl);
            this.Controls.Add(this.FirstNameTxtBox);
            this.Controls.Add(this.LastNameErrorLbl);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.KeyLbl);
            this.Controls.Add(this.UserNameErrorLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountRegistrationFormV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountRegistrationFormV2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel KeyPnl;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox KeyTxtBox;
        private System.Windows.Forms.Panel LastNamePnl;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.Panel FirstNamePnl;
        private System.Windows.Forms.TextBox UserNameTxtBox;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.Label PasswordErrorLbl;
        private System.Windows.Forms.Label KeyErrorLbl;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.Label FirstNameErrorLbl;
        private System.Windows.Forms.Panel UserNamePnl;
        private System.Windows.Forms.Panel PasswordPnl;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.Label LastNameErrorLbl;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Label KeyLbl;
        private System.Windows.Forms.Label UserNameErrorLbl;
        private System.Windows.Forms.Label ImagePathLbl;
        private System.Windows.Forms.Panel ImagePathPnl;
        private System.Windows.Forms.Label ImagePathErrorLbl;
        private System.Windows.Forms.CheckBox UploadImageCheckBox;
        private System.Windows.Forms.Button SignUpBtn;
        private CustomButton PasswordMask;
        private CustomButton ImagePathBtn;
        private CustomButton SecretKeyBtn;
        private System.Windows.Forms.TextBox ImagePathTxtBox;
    }
}