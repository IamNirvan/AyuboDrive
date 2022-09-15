namespace AyuboDrive.Forms
{
    partial class PaymentManagementForm
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
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.ManipulationPanel = new System.Windows.Forms.Panel();
            this.RentalBookingIDCmbBox = new System.Windows.Forms.ComboBox();
            this.RentalBookingIDPnl = new System.Windows.Forms.Panel();
            this.HireBookingIDPnl = new System.Windows.Forms.Panel();
            this.HireBookingIDCmbBox = new System.Windows.Forms.ComboBox();
            this.RentalBookingIDLbl = new System.Windows.Forms.Label();
            this.RentalBookingIDErrorLbl = new System.Windows.Forms.Label();
            this.HireBookingIDLbl = new System.Windows.Forms.Label();
            this.DateOfPaymentDTP = new System.Windows.Forms.DateTimePicker();
            this.CustomerIDCmbBox = new System.Windows.Forms.ComboBox();
            this.HireBookingIDErrorLbl = new System.Windows.Forms.Label();
            this.AmountPaidPnl = new System.Windows.Forms.Panel();
            this.AmountPaidTxtBox = new System.Windows.Forms.TextBox();
            this.DateOfPaymentPnl = new System.Windows.Forms.Panel();
            this.AmountPaidErrorLbl = new System.Windows.Forms.Label();
            this.AmountPaidLbl = new System.Windows.Forms.Label();
            this.CustomerIDPnl = new System.Windows.Forms.Panel();
            this.DateOfPaymentErrorLbl = new System.Windows.Forms.Label();
            this.DateOfPaymentLbl = new System.Windows.Forms.Label();
            this.CustomerIDErrorLbl = new System.Windows.Forms.Label();
            this.CustomerIDLbl = new System.Windows.Forms.Label();
            this.TablePanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.HireBookingsRBtn = new System.Windows.Forms.RadioButton();
            this.RentalBookingsRBtn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonsPanel.SuspendLayout();
            this.ManipulationPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Carlito", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.TitleLbl.Location = new System.Drawing.Point(12, 34);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(313, 39);
            this.TitleLbl.TabIndex = 34;
            this.TitleLbl.Text = "Payment Management";
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
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.ButtonsPanel.Controls.Add(this.DeleteBtn);
            this.ButtonsPanel.Controls.Add(this.UpdateBtn);
            this.ButtonsPanel.Controls.Add(this.InsertBtn);
            this.ButtonsPanel.Location = new System.Drawing.Point(488, 337);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(250, 123);
            this.ButtonsPanel.TabIndex = 38;
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
            // ManipulationPanel
            // 
            this.ManipulationPanel.AutoScroll = true;
            this.ManipulationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.ManipulationPanel.Controls.Add(this.RentalBookingIDCmbBox);
            this.ManipulationPanel.Controls.Add(this.RentalBookingIDPnl);
            this.ManipulationPanel.Controls.Add(this.HireBookingIDPnl);
            this.ManipulationPanel.Controls.Add(this.HireBookingIDCmbBox);
            this.ManipulationPanel.Controls.Add(this.RentalBookingIDLbl);
            this.ManipulationPanel.Controls.Add(this.RentalBookingIDErrorLbl);
            this.ManipulationPanel.Controls.Add(this.HireBookingIDLbl);
            this.ManipulationPanel.Controls.Add(this.DateOfPaymentDTP);
            this.ManipulationPanel.Controls.Add(this.CustomerIDCmbBox);
            this.ManipulationPanel.Controls.Add(this.HireBookingIDErrorLbl);
            this.ManipulationPanel.Controls.Add(this.AmountPaidPnl);
            this.ManipulationPanel.Controls.Add(this.AmountPaidTxtBox);
            this.ManipulationPanel.Controls.Add(this.DateOfPaymentPnl);
            this.ManipulationPanel.Controls.Add(this.AmountPaidErrorLbl);
            this.ManipulationPanel.Controls.Add(this.AmountPaidLbl);
            this.ManipulationPanel.Controls.Add(this.CustomerIDPnl);
            this.ManipulationPanel.Controls.Add(this.DateOfPaymentErrorLbl);
            this.ManipulationPanel.Controls.Add(this.DateOfPaymentLbl);
            this.ManipulationPanel.Controls.Add(this.CustomerIDErrorLbl);
            this.ManipulationPanel.Controls.Add(this.CustomerIDLbl);
            this.ManipulationPanel.Location = new System.Drawing.Point(488, 76);
            this.ManipulationPanel.Name = "ManipulationPanel";
            this.ManipulationPanel.Size = new System.Drawing.Size(250, 255);
            this.ManipulationPanel.TabIndex = 37;
            // 
            // RentalBookingIDCmbBox
            // 
            this.RentalBookingIDCmbBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.RentalBookingIDCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentalBookingIDCmbBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.RentalBookingIDCmbBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RentalBookingIDCmbBox.FormattingEnabled = true;
            this.RentalBookingIDCmbBox.Location = new System.Drawing.Point(25, 29);
            this.RentalBookingIDCmbBox.Name = "RentalBookingIDCmbBox";
            this.RentalBookingIDCmbBox.Size = new System.Drawing.Size(188, 26);
            this.RentalBookingIDCmbBox.TabIndex = 52;
            // 
            // RentalBookingIDPnl
            // 
            this.RentalBookingIDPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.RentalBookingIDPnl.Location = new System.Drawing.Point(25, 56);
            this.RentalBookingIDPnl.Name = "RentalBookingIDPnl";
            this.RentalBookingIDPnl.Size = new System.Drawing.Size(188, 2);
            this.RentalBookingIDPnl.TabIndex = 41;
            // 
            // HireBookingIDPnl
            // 
            this.HireBookingIDPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.HireBookingIDPnl.Location = new System.Drawing.Point(25, 56);
            this.HireBookingIDPnl.Name = "HireBookingIDPnl";
            this.HireBookingIDPnl.Size = new System.Drawing.Size(188, 2);
            this.HireBookingIDPnl.TabIndex = 40;
            // 
            // HireBookingIDCmbBox
            // 
            this.HireBookingIDCmbBox.BackColor = System.Drawing.SystemColors.Window;
            this.HireBookingIDCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HireBookingIDCmbBox.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HireBookingIDCmbBox.FormattingEnabled = true;
            this.HireBookingIDCmbBox.Location = new System.Drawing.Point(25, 29);
            this.HireBookingIDCmbBox.Name = "HireBookingIDCmbBox";
            this.HireBookingIDCmbBox.Size = new System.Drawing.Size(188, 26);
            this.HireBookingIDCmbBox.TabIndex = 51;
            // 
            // RentalBookingIDLbl
            // 
            this.RentalBookingIDLbl.AutoSize = true;
            this.RentalBookingIDLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalBookingIDLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.RentalBookingIDLbl.Location = new System.Drawing.Point(22, 16);
            this.RentalBookingIDLbl.Name = "RentalBookingIDLbl";
            this.RentalBookingIDLbl.Size = new System.Drawing.Size(100, 15);
            this.RentalBookingIDLbl.TabIndex = 27;
            this.RentalBookingIDLbl.Text = "Rental booking ID";
            // 
            // RentalBookingIDErrorLbl
            // 
            this.RentalBookingIDErrorLbl.AutoSize = true;
            this.RentalBookingIDErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.RentalBookingIDErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalBookingIDErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.RentalBookingIDErrorLbl.Location = new System.Drawing.Point(22, 61);
            this.RentalBookingIDErrorLbl.Name = "RentalBookingIDErrorLbl";
            this.RentalBookingIDErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.RentalBookingIDErrorLbl.TabIndex = 28;
            this.RentalBookingIDErrorLbl.Text = " ";
            // 
            // HireBookingIDLbl
            // 
            this.HireBookingIDLbl.AutoSize = true;
            this.HireBookingIDLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HireBookingIDLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.HireBookingIDLbl.Location = new System.Drawing.Point(22, 16);
            this.HireBookingIDLbl.Name = "HireBookingIDLbl";
            this.HireBookingIDLbl.Size = new System.Drawing.Size(89, 15);
            this.HireBookingIDLbl.TabIndex = 33;
            this.HireBookingIDLbl.Text = "Hire booking ID";
            // 
            // DateOfPaymentDTP
            // 
            this.DateOfPaymentDTP.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.DateOfPaymentDTP.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.DateOfPaymentDTP.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DateOfPaymentDTP.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.DateOfPaymentDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfPaymentDTP.Location = new System.Drawing.Point(25, 171);
            this.DateOfPaymentDTP.Name = "DateOfPaymentDTP";
            this.DateOfPaymentDTP.Size = new System.Drawing.Size(188, 26);
            this.DateOfPaymentDTP.TabIndex = 54;
            // 
            // CustomerIDCmbBox
            // 
            this.CustomerIDCmbBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.CustomerIDCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerIDCmbBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.CustomerIDCmbBox.FormattingEnabled = true;
            this.CustomerIDCmbBox.Location = new System.Drawing.Point(25, 101);
            this.CustomerIDCmbBox.Name = "CustomerIDCmbBox";
            this.CustomerIDCmbBox.Size = new System.Drawing.Size(188, 26);
            this.CustomerIDCmbBox.TabIndex = 53;
            // 
            // HireBookingIDErrorLbl
            // 
            this.HireBookingIDErrorLbl.AutoSize = true;
            this.HireBookingIDErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.HireBookingIDErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HireBookingIDErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.HireBookingIDErrorLbl.Location = new System.Drawing.Point(22, 61);
            this.HireBookingIDErrorLbl.Name = "HireBookingIDErrorLbl";
            this.HireBookingIDErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.HireBookingIDErrorLbl.TabIndex = 34;
            this.HireBookingIDErrorLbl.Text = " ";
            // 
            // AmountPaidPnl
            // 
            this.AmountPaidPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.AmountPaidPnl.Location = new System.Drawing.Point(25, 268);
            this.AmountPaidPnl.Name = "AmountPaidPnl";
            this.AmountPaidPnl.Size = new System.Drawing.Size(188, 2);
            this.AmountPaidPnl.TabIndex = 50;
            // 
            // AmountPaidTxtBox
            // 
            this.AmountPaidTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.AmountPaidTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmountPaidTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.AmountPaidTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.AmountPaidTxtBox.Location = new System.Drawing.Point(25, 246);
            this.AmountPaidTxtBox.Name = "AmountPaidTxtBox";
            this.AmountPaidTxtBox.Size = new System.Drawing.Size(188, 19);
            this.AmountPaidTxtBox.TabIndex = 47;
            this.AmountPaidTxtBox.Enter += new System.EventHandler(this.AmountPaidTxtBox_Enter);
            this.AmountPaidTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnlyTextBox_KeyPress);
            this.AmountPaidTxtBox.Leave += new System.EventHandler(this.AmountPaidTxtBox_Leave);
            // 
            // DateOfPaymentPnl
            // 
            this.DateOfPaymentPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.DateOfPaymentPnl.Location = new System.Drawing.Point(25, 197);
            this.DateOfPaymentPnl.Name = "DateOfPaymentPnl";
            this.DateOfPaymentPnl.Size = new System.Drawing.Size(188, 2);
            this.DateOfPaymentPnl.TabIndex = 46;
            // 
            // AmountPaidErrorLbl
            // 
            this.AmountPaidErrorLbl.AutoSize = true;
            this.AmountPaidErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.AmountPaidErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountPaidErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.AmountPaidErrorLbl.Location = new System.Drawing.Point(22, 273);
            this.AmountPaidErrorLbl.Name = "AmountPaidErrorLbl";
            this.AmountPaidErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.AmountPaidErrorLbl.TabIndex = 49;
            this.AmountPaidErrorLbl.Text = " ";
            // 
            // AmountPaidLbl
            // 
            this.AmountPaidLbl.AutoSize = true;
            this.AmountPaidLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountPaidLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.AmountPaidLbl.Location = new System.Drawing.Point(22, 228);
            this.AmountPaidLbl.Name = "AmountPaidLbl";
            this.AmountPaidLbl.Size = new System.Drawing.Size(76, 15);
            this.AmountPaidLbl.TabIndex = 48;
            this.AmountPaidLbl.Text = "Amount paid";
            // 
            // CustomerIDPnl
            // 
            this.CustomerIDPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.CustomerIDPnl.Location = new System.Drawing.Point(25, 127);
            this.CustomerIDPnl.Name = "CustomerIDPnl";
            this.CustomerIDPnl.Size = new System.Drawing.Size(188, 2);
            this.CustomerIDPnl.TabIndex = 42;
            // 
            // DateOfPaymentErrorLbl
            // 
            this.DateOfPaymentErrorLbl.AutoSize = true;
            this.DateOfPaymentErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.DateOfPaymentErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfPaymentErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DateOfPaymentErrorLbl.Location = new System.Drawing.Point(22, 202);
            this.DateOfPaymentErrorLbl.Name = "DateOfPaymentErrorLbl";
            this.DateOfPaymentErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.DateOfPaymentErrorLbl.TabIndex = 45;
            this.DateOfPaymentErrorLbl.Text = " ";
            // 
            // DateOfPaymentLbl
            // 
            this.DateOfPaymentLbl.AutoSize = true;
            this.DateOfPaymentLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfPaymentLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.DateOfPaymentLbl.Location = new System.Drawing.Point(22, 157);
            this.DateOfPaymentLbl.Name = "DateOfPaymentLbl";
            this.DateOfPaymentLbl.Size = new System.Drawing.Size(94, 15);
            this.DateOfPaymentLbl.TabIndex = 44;
            this.DateOfPaymentLbl.Text = "Date of payment";
            // 
            // CustomerIDErrorLbl
            // 
            this.CustomerIDErrorLbl.AutoSize = true;
            this.CustomerIDErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.CustomerIDErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.CustomerIDErrorLbl.Location = new System.Drawing.Point(22, 132);
            this.CustomerIDErrorLbl.Name = "CustomerIDErrorLbl";
            this.CustomerIDErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.CustomerIDErrorLbl.TabIndex = 31;
            this.CustomerIDErrorLbl.Text = " ";
            // 
            // CustomerIDLbl
            // 
            this.CustomerIDLbl.AutoSize = true;
            this.CustomerIDLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.CustomerIDLbl.Location = new System.Drawing.Point(22, 87);
            this.CustomerIDLbl.Name = "CustomerIDLbl";
            this.CustomerIDLbl.Size = new System.Drawing.Size(72, 15);
            this.CustomerIDLbl.TabIndex = 30;
            this.CustomerIDLbl.Text = "Customer ID";
            // 
            // TablePanel
            // 
            this.TablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.TablePanel.Location = new System.Drawing.Point(9, 76);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.Size = new System.Drawing.Size(470, 384);
            this.TablePanel.TabIndex = 35;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(750, 30);
            this.flowLayoutPanel1.TabIndex = 36;
            // 
            // HireBookingsRBtn
            // 
            this.HireBookingsRBtn.AutoSize = true;
            this.HireBookingsRBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.HireBookingsRBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HireBookingsRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.HireBookingsRBtn.Location = new System.Drawing.Point(132, 8);
            this.HireBookingsRBtn.Name = "HireBookingsRBtn";
            this.HireBookingsRBtn.Size = new System.Drawing.Size(89, 17);
            this.HireBookingsRBtn.TabIndex = 0;
            this.HireBookingsRBtn.Text = "Hire bookings";
            this.HireBookingsRBtn.UseVisualStyleBackColor = true;
            this.HireBookingsRBtn.CheckedChanged += new System.EventHandler(this.HireBookingsRBtn_CheckedChanged);
            // 
            // RentalBookingsRBtn
            // 
            this.RentalBookingsRBtn.AutoSize = true;
            this.RentalBookingsRBtn.Checked = true;
            this.RentalBookingsRBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.RentalBookingsRBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentalBookingsRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.RentalBookingsRBtn.Location = new System.Drawing.Point(25, 8);
            this.RentalBookingsRBtn.Name = "RentalBookingsRBtn";
            this.RentalBookingsRBtn.Size = new System.Drawing.Size(101, 17);
            this.RentalBookingsRBtn.TabIndex = 1;
            this.RentalBookingsRBtn.TabStop = true;
            this.RentalBookingsRBtn.Text = "Rental bookings";
            this.RentalBookingsRBtn.UseVisualStyleBackColor = true;
            this.RentalBookingsRBtn.CheckedChanged += new System.EventHandler(this.RentalBookingsRBtn_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.RentalBookingsRBtn);
            this.panel1.Controls.Add(this.HireBookingsRBtn);
            this.panel1.Location = new System.Drawing.Point(488, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 34);
            this.panel1.TabIndex = 55;
            // 
            // PaymentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(750, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ManipulationPanel);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.TablePanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentManagementForm";
            this.Load += new System.EventHandler(this.PaymentManagementForm_Load);
            this.ButtonsPanel.ResumeLayout(false);
            this.ManipulationPanel.ResumeLayout(false);
            this.ManipulationPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Panel ManipulationPanel;
        private System.Windows.Forms.Panel TablePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox AmountPaidTxtBox;
        private System.Windows.Forms.Panel HireBookingIDPnl;
        private System.Windows.Forms.Label HireBookingIDLbl;
        private System.Windows.Forms.Label HireBookingIDErrorLbl;
        private System.Windows.Forms.DateTimePicker DateOfPaymentDTP;
        private System.Windows.Forms.ComboBox CustomerIDCmbBox;
        private System.Windows.Forms.Panel AmountPaidPnl;
        private System.Windows.Forms.Panel DateOfPaymentPnl;
        private System.Windows.Forms.Label AmountPaidErrorLbl;
        private System.Windows.Forms.Label AmountPaidLbl;
        private System.Windows.Forms.Panel CustomerIDPnl;
        private System.Windows.Forms.Label DateOfPaymentErrorLbl;
        private System.Windows.Forms.Label DateOfPaymentLbl;
        private System.Windows.Forms.Label CustomerIDErrorLbl;
        private System.Windows.Forms.Label CustomerIDLbl;
        private System.Windows.Forms.RadioButton HireBookingsRBtn;
        private System.Windows.Forms.RadioButton RentalBookingsRBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox RentalBookingIDCmbBox;
        private System.Windows.Forms.Panel RentalBookingIDPnl;
        private System.Windows.Forms.Label RentalBookingIDLbl;
        private System.Windows.Forms.Label RentalBookingIDErrorLbl;
        private System.Windows.Forms.ComboBox HireBookingIDCmbBox;
    }
}