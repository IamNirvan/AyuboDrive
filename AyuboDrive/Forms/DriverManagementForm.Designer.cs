namespace AyuboDrive.Forms
{
    partial class DriverManagementForm
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
            this.TablePanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NICPnl = new System.Windows.Forms.Panel();
            this.NICLbl = new System.Windows.Forms.Label();
            this.NICErrorLbl = new System.Windows.Forms.Label();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.ContactNumberPnl = new System.Windows.Forms.Panel();
            this.ContactNumberTxtBox = new System.Windows.Forms.TextBox();
            this.LastNamePnl = new System.Windows.Forms.Panel();
            this.ContactNumberErrLbl = new System.Windows.Forms.Label();
            this.ContactNumberLbl = new System.Windows.Forms.Label();
            this.FirstNamePnl = new System.Windows.Forms.Panel();
            this.LastNameErrLbl = new System.Windows.Forms.Label();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.FirstNameErrLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ManipulationPanel = new System.Windows.Forms.Panel();
            this.DriverStatusCmbBox = new System.Windows.Forms.ComboBox();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.NICTxtBox = new System.Windows.Forms.TextBox();
            this.DailyRatePnl = new System.Windows.Forms.Panel();
            this.DailyRateTxtBox = new System.Windows.Forms.TextBox();
            this.DriverStatusPnl = new System.Windows.Forms.Panel();
            this.DailyRateErrLbl = new System.Windows.Forms.Label();
            this.DailyRateLbl = new System.Windows.Forms.Label();
            this.OvernightRatePnl = new System.Windows.Forms.Panel();
            this.DriverStatusErrLbl = new System.Windows.Forms.Label();
            this.OvernightRateTxtBox = new System.Windows.Forms.TextBox();
            this.DriverStatusLbl = new System.Windows.Forms.Label();
            this.OvernightRateErrLbl = new System.Windows.Forms.Label();
            this.OvernightRateLbl = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.ButtonsPanel.SuspendLayout();
            this.ManipulationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablePanel
            // 
            this.TablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.TablePanel.Location = new System.Drawing.Point(9, 76);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.Size = new System.Drawing.Size(593, 384);
            this.TablePanel.TabIndex = 57;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(870, 30);
            this.flowLayoutPanel1.TabIndex = 58;
            // 
            // NICPnl
            // 
            this.NICPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.NICPnl.Location = new System.Drawing.Point(25, 56);
            this.NICPnl.Name = "NICPnl";
            this.NICPnl.Size = new System.Drawing.Size(188, 2);
            this.NICPnl.TabIndex = 40;
            // 
            // NICLbl
            // 
            this.NICLbl.AutoSize = true;
            this.NICLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NICLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.NICLbl.Location = new System.Drawing.Point(22, 16);
            this.NICLbl.Name = "NICLbl";
            this.NICLbl.Size = new System.Drawing.Size(61, 15);
            this.NICLbl.TabIndex = 33;
            this.NICLbl.Text = "Driver NIC";
            // 
            // NICErrorLbl
            // 
            this.NICErrorLbl.AutoSize = true;
            this.NICErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.NICErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NICErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.NICErrorLbl.Location = new System.Drawing.Point(22, 61);
            this.NICErrorLbl.Name = "NICErrorLbl";
            this.NICErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.NICErrorLbl.TabIndex = 34;
            this.NICErrorLbl.Text = " ";
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.InsertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.InsertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.Location = new System.Drawing.Point(148, 12);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(90, 100);
            this.InsertBtn.TabIndex = 5;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // ContactNumberPnl
            // 
            this.ContactNumberPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.ContactNumberPnl.Location = new System.Drawing.Point(25, 268);
            this.ContactNumberPnl.Name = "ContactNumberPnl";
            this.ContactNumberPnl.Size = new System.Drawing.Size(188, 2);
            this.ContactNumberPnl.TabIndex = 50;
            // 
            // ContactNumberTxtBox
            // 
            this.ContactNumberTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.ContactNumberTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContactNumberTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.ContactNumberTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.ContactNumberTxtBox.Location = new System.Drawing.Point(25, 246);
            this.ContactNumberTxtBox.Name = "ContactNumberTxtBox";
            this.ContactNumberTxtBox.Size = new System.Drawing.Size(188, 19);
            this.ContactNumberTxtBox.TabIndex = 47;
            this.ContactNumberTxtBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.ContactNumberTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnlyTextBox_KeyPress);
            this.ContactNumberTxtBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // LastNamePnl
            // 
            this.LastNamePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.LastNamePnl.Location = new System.Drawing.Point(25, 197);
            this.LastNamePnl.Name = "LastNamePnl";
            this.LastNamePnl.Size = new System.Drawing.Size(188, 2);
            this.LastNamePnl.TabIndex = 46;
            // 
            // ContactNumberErrLbl
            // 
            this.ContactNumberErrLbl.AutoSize = true;
            this.ContactNumberErrLbl.BackColor = System.Drawing.Color.Transparent;
            this.ContactNumberErrLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumberErrLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ContactNumberErrLbl.Location = new System.Drawing.Point(22, 273);
            this.ContactNumberErrLbl.Name = "ContactNumberErrLbl";
            this.ContactNumberErrLbl.Size = new System.Drawing.Size(9, 13);
            this.ContactNumberErrLbl.TabIndex = 49;
            this.ContactNumberErrLbl.Text = " ";
            // 
            // ContactNumberLbl
            // 
            this.ContactNumberLbl.AutoSize = true;
            this.ContactNumberLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumberLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.ContactNumberLbl.Location = new System.Drawing.Point(22, 228);
            this.ContactNumberLbl.Name = "ContactNumberLbl";
            this.ContactNumberLbl.Size = new System.Drawing.Size(93, 15);
            this.ContactNumberLbl.TabIndex = 48;
            this.ContactNumberLbl.Text = "Contact number";
            // 
            // FirstNamePnl
            // 
            this.FirstNamePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.FirstNamePnl.Location = new System.Drawing.Point(25, 127);
            this.FirstNamePnl.Name = "FirstNamePnl";
            this.FirstNamePnl.Size = new System.Drawing.Size(188, 2);
            this.FirstNamePnl.TabIndex = 42;
            // 
            // LastNameErrLbl
            // 
            this.LastNameErrLbl.AutoSize = true;
            this.LastNameErrLbl.BackColor = System.Drawing.Color.Transparent;
            this.LastNameErrLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameErrLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.LastNameErrLbl.Location = new System.Drawing.Point(22, 202);
            this.LastNameErrLbl.Name = "LastNameErrLbl";
            this.LastNameErrLbl.Size = new System.Drawing.Size(9, 13);
            this.LastNameErrLbl.TabIndex = 45;
            this.LastNameErrLbl.Text = " ";
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.LastNameLbl.Location = new System.Drawing.Point(22, 157);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(59, 15);
            this.LastNameLbl.TabIndex = 44;
            this.LastNameLbl.Text = "Last name";
            // 
            // FirstNameErrLbl
            // 
            this.FirstNameErrLbl.AutoSize = true;
            this.FirstNameErrLbl.BackColor = System.Drawing.Color.Transparent;
            this.FirstNameErrLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameErrLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.FirstNameErrLbl.Location = new System.Drawing.Point(22, 132);
            this.FirstNameErrLbl.Name = "FirstNameErrLbl";
            this.FirstNameErrLbl.Size = new System.Drawing.Size(9, 13);
            this.FirstNameErrLbl.TabIndex = 31;
            this.FirstNameErrLbl.Text = " ";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.firstNameLbl.Location = new System.Drawing.Point(22, 87);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(62, 15);
            this.firstNameLbl.TabIndex = 30;
            this.firstNameLbl.Text = "First name";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.ButtonsPanel.Controls.Add(this.DeleteBtn);
            this.ButtonsPanel.Controls.Add(this.UpdateBtn);
            this.ButtonsPanel.Controls.Add(this.InsertBtn);
            this.ButtonsPanel.Location = new System.Drawing.Point(608, 337);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(250, 123);
            this.ButtonsPanel.TabIndex = 60;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DeleteBtn.Location = new System.Drawing.Point(13, 66);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(129, 45);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            this.DeleteBtn.MouseEnter += new System.EventHandler(this.DeleteBtn_MouseEnter);
            this.DeleteBtn.MouseLeave += new System.EventHandler(this.DeleteBtn_MouseLeave);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(199)))), ((int)(((byte)(151)))));
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(199)))), ((int)(((byte)(151)))));
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(13, 12);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(129, 45);
            this.UpdateBtn.TabIndex = 6;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ManipulationPanel
            // 
            this.ManipulationPanel.AutoScroll = true;
            this.ManipulationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.ManipulationPanel.Controls.Add(this.DriverStatusCmbBox);
            this.ManipulationPanel.Controls.Add(this.LastNameTxtBox);
            this.ManipulationPanel.Controls.Add(this.FirstNameTxtBox);
            this.ManipulationPanel.Controls.Add(this.NICTxtBox);
            this.ManipulationPanel.Controls.Add(this.DailyRatePnl);
            this.ManipulationPanel.Controls.Add(this.DailyRateTxtBox);
            this.ManipulationPanel.Controls.Add(this.DriverStatusPnl);
            this.ManipulationPanel.Controls.Add(this.DailyRateErrLbl);
            this.ManipulationPanel.Controls.Add(this.DailyRateLbl);
            this.ManipulationPanel.Controls.Add(this.OvernightRatePnl);
            this.ManipulationPanel.Controls.Add(this.DriverStatusErrLbl);
            this.ManipulationPanel.Controls.Add(this.OvernightRateTxtBox);
            this.ManipulationPanel.Controls.Add(this.DriverStatusLbl);
            this.ManipulationPanel.Controls.Add(this.OvernightRateErrLbl);
            this.ManipulationPanel.Controls.Add(this.OvernightRateLbl);
            this.ManipulationPanel.Controls.Add(this.NICPnl);
            this.ManipulationPanel.Controls.Add(this.NICLbl);
            this.ManipulationPanel.Controls.Add(this.NICErrorLbl);
            this.ManipulationPanel.Controls.Add(this.ContactNumberPnl);
            this.ManipulationPanel.Controls.Add(this.ContactNumberTxtBox);
            this.ManipulationPanel.Controls.Add(this.LastNamePnl);
            this.ManipulationPanel.Controls.Add(this.ContactNumberErrLbl);
            this.ManipulationPanel.Controls.Add(this.ContactNumberLbl);
            this.ManipulationPanel.Controls.Add(this.FirstNamePnl);
            this.ManipulationPanel.Controls.Add(this.LastNameErrLbl);
            this.ManipulationPanel.Controls.Add(this.LastNameLbl);
            this.ManipulationPanel.Controls.Add(this.FirstNameErrLbl);
            this.ManipulationPanel.Controls.Add(this.firstNameLbl);
            this.ManipulationPanel.Location = new System.Drawing.Point(608, 76);
            this.ManipulationPanel.Name = "ManipulationPanel";
            this.ManipulationPanel.Size = new System.Drawing.Size(250, 255);
            this.ManipulationPanel.TabIndex = 59;
            // 
            // DriverStatusCmbBox
            // 
            this.DriverStatusCmbBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.DriverStatusCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DriverStatusCmbBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.DriverStatusCmbBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DriverStatusCmbBox.FormattingEnabled = true;
            this.DriverStatusCmbBox.Location = new System.Drawing.Point(25, 315);
            this.DriverStatusCmbBox.Name = "DriverStatusCmbBox";
            this.DriverStatusCmbBox.Size = new System.Drawing.Size(188, 26);
            this.DriverStatusCmbBox.TabIndex = 62;
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.LastNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.LastNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.LastNameTxtBox.Location = new System.Drawing.Point(25, 175);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(188, 19);
            this.LastNameTxtBox.TabIndex = 61;
            this.LastNameTxtBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.LastNameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharacterOnlyTextBox_KeyPress);
            this.LastNameTxtBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.FirstNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstNameTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.FirstNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.FirstNameTxtBox.Location = new System.Drawing.Point(25, 105);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(188, 19);
            this.FirstNameTxtBox.TabIndex = 60;
            this.FirstNameTxtBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.FirstNameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharacterOnlyTextBox_KeyPress);
            this.FirstNameTxtBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // NICTxtBox
            // 
            this.NICTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.NICTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NICTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.NICTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.NICTxtBox.Location = new System.Drawing.Point(25, 34);
            this.NICTxtBox.Name = "NICTxtBox";
            this.NICTxtBox.Size = new System.Drawing.Size(188, 19);
            this.NICTxtBox.TabIndex = 59;
            this.NICTxtBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.NICTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOrCharacterOnlyTextBox_KeyPress);
            this.NICTxtBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // DailyRatePnl
            // 
            this.DailyRatePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.DailyRatePnl.Location = new System.Drawing.Point(25, 412);
            this.DailyRatePnl.Name = "DailyRatePnl";
            this.DailyRatePnl.Size = new System.Drawing.Size(188, 2);
            this.DailyRatePnl.TabIndex = 58;
            // 
            // DailyRateTxtBox
            // 
            this.DailyRateTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.DailyRateTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DailyRateTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.DailyRateTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.DailyRateTxtBox.Location = new System.Drawing.Point(25, 390);
            this.DailyRateTxtBox.Name = "DailyRateTxtBox";
            this.DailyRateTxtBox.Size = new System.Drawing.Size(188, 19);
            this.DailyRateTxtBox.TabIndex = 55;
            this.DailyRateTxtBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.DailyRateTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnlyTextBox_KeyPress);
            this.DailyRateTxtBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // DriverStatusPnl
            // 
            this.DriverStatusPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.DriverStatusPnl.Location = new System.Drawing.Point(25, 339);
            this.DriverStatusPnl.Name = "DriverStatusPnl";
            this.DriverStatusPnl.Size = new System.Drawing.Size(188, 2);
            this.DriverStatusPnl.TabIndex = 58;
            // 
            // DailyRateErrLbl
            // 
            this.DailyRateErrLbl.AutoSize = true;
            this.DailyRateErrLbl.BackColor = System.Drawing.Color.Transparent;
            this.DailyRateErrLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyRateErrLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DailyRateErrLbl.Location = new System.Drawing.Point(22, 417);
            this.DailyRateErrLbl.Name = "DailyRateErrLbl";
            this.DailyRateErrLbl.Size = new System.Drawing.Size(9, 13);
            this.DailyRateErrLbl.TabIndex = 57;
            this.DailyRateErrLbl.Text = " ";
            // 
            // DailyRateLbl
            // 
            this.DailyRateLbl.AutoSize = true;
            this.DailyRateLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyRateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.DailyRateLbl.Location = new System.Drawing.Point(22, 372);
            this.DailyRateLbl.Name = "DailyRateLbl";
            this.DailyRateLbl.Size = new System.Drawing.Size(87, 15);
            this.DailyRateLbl.TabIndex = 56;
            this.DailyRateLbl.Text = "Daily rate (LKR)";
            // 
            // OvernightRatePnl
            // 
            this.OvernightRatePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.OvernightRatePnl.Location = new System.Drawing.Point(25, 484);
            this.OvernightRatePnl.Name = "OvernightRatePnl";
            this.OvernightRatePnl.Size = new System.Drawing.Size(188, 2);
            this.OvernightRatePnl.TabIndex = 54;
            // 
            // DriverStatusErrLbl
            // 
            this.DriverStatusErrLbl.AutoSize = true;
            this.DriverStatusErrLbl.BackColor = System.Drawing.Color.Transparent;
            this.DriverStatusErrLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverStatusErrLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DriverStatusErrLbl.Location = new System.Drawing.Point(22, 344);
            this.DriverStatusErrLbl.Name = "DriverStatusErrLbl";
            this.DriverStatusErrLbl.Size = new System.Drawing.Size(9, 13);
            this.DriverStatusErrLbl.TabIndex = 57;
            this.DriverStatusErrLbl.Text = " ";
            // 
            // OvernightRateTxtBox
            // 
            this.OvernightRateTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.OvernightRateTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OvernightRateTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.OvernightRateTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.OvernightRateTxtBox.Location = new System.Drawing.Point(25, 462);
            this.OvernightRateTxtBox.Name = "OvernightRateTxtBox";
            this.OvernightRateTxtBox.Size = new System.Drawing.Size(188, 19);
            this.OvernightRateTxtBox.TabIndex = 51;
            this.OvernightRateTxtBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.OvernightRateTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnlyTextBox_KeyPress);
            this.OvernightRateTxtBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // DriverStatusLbl
            // 
            this.DriverStatusLbl.AutoSize = true;
            this.DriverStatusLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverStatusLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.DriverStatusLbl.Location = new System.Drawing.Point(22, 299);
            this.DriverStatusLbl.Name = "DriverStatusLbl";
            this.DriverStatusLbl.Size = new System.Drawing.Size(74, 15);
            this.DriverStatusLbl.TabIndex = 56;
            this.DriverStatusLbl.Text = "Driver status";
            // 
            // OvernightRateErrLbl
            // 
            this.OvernightRateErrLbl.AutoSize = true;
            this.OvernightRateErrLbl.BackColor = System.Drawing.Color.Transparent;
            this.OvernightRateErrLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OvernightRateErrLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.OvernightRateErrLbl.Location = new System.Drawing.Point(22, 489);
            this.OvernightRateErrLbl.Name = "OvernightRateErrLbl";
            this.OvernightRateErrLbl.Size = new System.Drawing.Size(9, 13);
            this.OvernightRateErrLbl.TabIndex = 53;
            this.OvernightRateErrLbl.Text = " ";
            // 
            // OvernightRateLbl
            // 
            this.OvernightRateLbl.AutoSize = true;
            this.OvernightRateLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OvernightRateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.OvernightRateLbl.Location = new System.Drawing.Point(22, 444);
            this.OvernightRateLbl.Name = "OvernightRateLbl";
            this.OvernightRateLbl.Size = new System.Drawing.Size(114, 15);
            this.OvernightRateLbl.TabIndex = 52;
            this.OvernightRateLbl.Text = "Overnight rate (LKR)";
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Carlito", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.TitleLbl.Location = new System.Drawing.Point(12, 34);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(278, 39);
            this.TitleLbl.TabIndex = 56;
            this.TitleLbl.Text = "Driver Management";
            // 
            // DriverManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(870, 470);
            this.Controls.Add(this.ManipulationPanel);
            this.Controls.Add(this.TablePanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.TitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DriverManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverManagementForm";
            this.Load += new System.EventHandler(this.DriverManagementForm_Load);
            this.ButtonsPanel.ResumeLayout(false);
            this.ManipulationPanel.ResumeLayout(false);
            this.ManipulationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel TablePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel NICPnl;
        private System.Windows.Forms.Label NICLbl;
        private System.Windows.Forms.Label NICErrorLbl;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Panel ContactNumberPnl;
        private System.Windows.Forms.TextBox ContactNumberTxtBox;
        private System.Windows.Forms.Panel LastNamePnl;
        private System.Windows.Forms.Label ContactNumberErrLbl;
        private System.Windows.Forms.Label ContactNumberLbl;
        private System.Windows.Forms.Panel FirstNamePnl;
        private System.Windows.Forms.Label LastNameErrLbl;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.Label FirstNameErrLbl;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Panel ManipulationPanel;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Panel OvernightRatePnl;
        private System.Windows.Forms.TextBox OvernightRateTxtBox;
        private System.Windows.Forms.Label OvernightRateErrLbl;
        private System.Windows.Forms.Label OvernightRateLbl;
        private System.Windows.Forms.Panel DriverStatusPnl;
        private System.Windows.Forms.Label DriverStatusErrLbl;
        private System.Windows.Forms.Label DriverStatusLbl;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.TextBox NICTxtBox;
        private System.Windows.Forms.Panel DailyRatePnl;
        private System.Windows.Forms.TextBox DailyRateTxtBox;
        private System.Windows.Forms.Label DailyRateErrLbl;
        private System.Windows.Forms.Label DailyRateLbl;
        private System.Windows.Forms.ComboBox DriverStatusCmbBox;
    }
}