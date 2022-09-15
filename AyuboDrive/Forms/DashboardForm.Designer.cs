namespace AyuboDrive.Forms
{
    partial class DashboardForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userNamePanel = new System.Windows.Forms.Panel();
            this.closedBookingsValueLbl = new System.Windows.Forms.Label();
            this.openBookingsValueLbl = new System.Windows.Forms.Label();
            this.ongoingBookingsTextLbl = new System.Windows.Forms.Label();
            this.closedBookingTextLbl = new System.Windows.Forms.Label();
            this.fullNameLbl = new System.Windows.Forms.Label();
            this.greetingLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DriverBtn = new System.Windows.Forms.Button();
            this.BookingClosureBtn = new System.Windows.Forms.Button();
            this.LongTourBookingsBtn = new System.Windows.Forms.Button();
            this.PaymentBtn = new System.Windows.Forms.Button();
            this.PackageTypeBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.AccountBtn = new System.Windows.Forms.Button();
            this.VehicleBtn = new System.Windows.Forms.Button();
            this.VehicleTypeBtn = new System.Windows.Forms.Button();
            this.CustomerBtn = new System.Windows.Forms.Button();
            this.RentalBookingsBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.userNamePanel);
            this.panel1.Controls.Add(this.closedBookingsValueLbl);
            this.panel1.Controls.Add(this.openBookingsValueLbl);
            this.panel1.Controls.Add(this.ongoingBookingsTextLbl);
            this.panel1.Controls.Add(this.closedBookingTextLbl);
            this.panel1.Controls.Add(this.fullNameLbl);
            this.panel1.Controls.Add(this.greetingLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 208);
            this.panel1.TabIndex = 1;
            // 
            // userNamePanel
            // 
            this.userNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.userNamePanel.Location = new System.Drawing.Point(0, 206);
            this.userNamePanel.Name = "userNamePanel";
            this.userNamePanel.Size = new System.Drawing.Size(700, 2);
            this.userNamePanel.TabIndex = 25;
            // 
            // closedBookingsValueLbl
            // 
            this.closedBookingsValueLbl.AutoSize = true;
            this.closedBookingsValueLbl.BackColor = System.Drawing.Color.Transparent;
            this.closedBookingsValueLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closedBookingsValueLbl.Font = new System.Drawing.Font("Carlito", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closedBookingsValueLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.closedBookingsValueLbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.closedBookingsValueLbl.Location = new System.Drawing.Point(476, 79);
            this.closedBookingsValueLbl.Name = "closedBookingsValueLbl";
            this.closedBookingsValueLbl.Size = new System.Drawing.Size(33, 39);
            this.closedBookingsValueLbl.TabIndex = 9;
            this.closedBookingsValueLbl.Text = "#\r\n";
            this.closedBookingsValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openBookingsValueLbl
            // 
            this.openBookingsValueLbl.AutoSize = true;
            this.openBookingsValueLbl.BackColor = System.Drawing.Color.Transparent;
            this.openBookingsValueLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openBookingsValueLbl.Font = new System.Drawing.Font("Carlito", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBookingsValueLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.openBookingsValueLbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.openBookingsValueLbl.Location = new System.Drawing.Point(601, 79);
            this.openBookingsValueLbl.Name = "openBookingsValueLbl";
            this.openBookingsValueLbl.Size = new System.Drawing.Size(33, 39);
            this.openBookingsValueLbl.TabIndex = 10;
            this.openBookingsValueLbl.Text = "#\r\n";
            this.openBookingsValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ongoingBookingsTextLbl
            // 
            this.ongoingBookingsTextLbl.AutoSize = true;
            this.ongoingBookingsTextLbl.BackColor = System.Drawing.Color.Transparent;
            this.ongoingBookingsTextLbl.Font = new System.Drawing.Font("Carlito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ongoingBookingsTextLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.ongoingBookingsTextLbl.Location = new System.Drawing.Point(554, 122);
            this.ongoingBookingsTextLbl.Name = "ongoingBookingsTextLbl";
            this.ongoingBookingsTextLbl.Size = new System.Drawing.Size(125, 19);
            this.ongoingBookingsTextLbl.TabIndex = 14;
            this.ongoingBookingsTextLbl.Text = "Ongoing bookings";
            this.ongoingBookingsTextLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closedBookingTextLbl
            // 
            this.closedBookingTextLbl.AutoSize = true;
            this.closedBookingTextLbl.BackColor = System.Drawing.Color.Transparent;
            this.closedBookingTextLbl.Font = new System.Drawing.Font("Carlito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closedBookingTextLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.closedBookingTextLbl.Location = new System.Drawing.Point(431, 122);
            this.closedBookingTextLbl.Name = "closedBookingTextLbl";
            this.closedBookingTextLbl.Size = new System.Drawing.Size(113, 19);
            this.closedBookingTextLbl.TabIndex = 13;
            this.closedBookingTextLbl.Text = "Closed bookings";
            this.closedBookingTextLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullNameLbl
            // 
            this.fullNameLbl.AutoSize = true;
            this.fullNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.fullNameLbl.Font = new System.Drawing.Font("Carlito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.fullNameLbl.Location = new System.Drawing.Point(31, 118);
            this.fullNameLbl.Name = "fullNameLbl";
            this.fullNameLbl.Size = new System.Drawing.Size(84, 23);
            this.fullNameLbl.TabIndex = 12;
            this.fullNameLbl.Text = "Full name";
            // 
            // greetingLbl
            // 
            this.greetingLbl.AutoSize = true;
            this.greetingLbl.BackColor = System.Drawing.Color.Transparent;
            this.greetingLbl.Font = new System.Drawing.Font("Carlito", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.greetingLbl.Location = new System.Drawing.Point(25, 59);
            this.greetingLbl.Name = "greetingLbl";
            this.greetingLbl.Size = new System.Drawing.Size(225, 59);
            this.greetingLbl.TabIndex = 11;
            this.greetingLbl.Text = "Greetings,";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.DriverBtn);
            this.panel2.Controls.Add(this.BookingClosureBtn);
            this.panel2.Controls.Add(this.LongTourBookingsBtn);
            this.panel2.Controls.Add(this.PaymentBtn);
            this.panel2.Controls.Add(this.PackageTypeBtn);
            this.panel2.Controls.Add(this.LogOutBtn);
            this.panel2.Controls.Add(this.AccountBtn);
            this.panel2.Controls.Add(this.VehicleBtn);
            this.panel2.Controls.Add(this.VehicleTypeBtn);
            this.panel2.Controls.Add(this.CustomerBtn);
            this.panel2.Controls.Add(this.RentalBookingsBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 321);
            this.panel2.TabIndex = 2;
            // 
            // DriverBtn
            // 
            this.DriverBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.DriverBtn.BackgroundImage = global::AyuboDrive.Properties.Resources.DriverWhite64;
            this.DriverBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DriverBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DriverBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.DriverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DriverBtn.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.DriverBtn.Location = new System.Drawing.Point(353, 168);
            this.DriverBtn.Name = "DriverBtn";
            this.DriverBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.DriverBtn.Size = new System.Drawing.Size(160, 135);
            this.DriverBtn.TabIndex = 19;
            this.DriverBtn.Text = "Driver";
            this.DriverBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DriverBtn.UseVisualStyleBackColor = false;
            this.DriverBtn.Click += new System.EventHandler(this.DriverBtn_Click);
            this.DriverBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.DriverBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // BookingClosureBtn
            // 
            this.BookingClosureBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.BookingClosureBtn.BackgroundImage = global::AyuboDrive.Properties.Resources.EndWhite64;
            this.BookingClosureBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BookingClosureBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookingClosureBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.BookingClosureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookingClosureBtn.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingClosureBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.BookingClosureBtn.Location = new System.Drawing.Point(187, 168);
            this.BookingClosureBtn.Name = "BookingClosureBtn";
            this.BookingClosureBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.BookingClosureBtn.Size = new System.Drawing.Size(160, 135);
            this.BookingClosureBtn.TabIndex = 18;
            this.BookingClosureBtn.Text = "Booking Closure";
            this.BookingClosureBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BookingClosureBtn.UseVisualStyleBackColor = false;
            this.BookingClosureBtn.Click += new System.EventHandler(this.BookingClosureBtn_Click);
            this.BookingClosureBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.BookingClosureBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // LongTourBookingsBtn
            // 
            this.LongTourBookingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.LongTourBookingsBtn.BackgroundImage = global::AyuboDrive.Properties.Resources.HireWhite64;
            this.LongTourBookingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LongTourBookingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LongTourBookingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.LongTourBookingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LongTourBookingsBtn.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongTourBookingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.LongTourBookingsBtn.Location = new System.Drawing.Point(21, 168);
            this.LongTourBookingsBtn.Name = "LongTourBookingsBtn";
            this.LongTourBookingsBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.LongTourBookingsBtn.Size = new System.Drawing.Size(160, 135);
            this.LongTourBookingsBtn.TabIndex = 17;
            this.LongTourBookingsBtn.Text = "Long Tour Bookings";
            this.LongTourBookingsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LongTourBookingsBtn.UseVisualStyleBackColor = false;
            this.LongTourBookingsBtn.Click += new System.EventHandler(this.LongTourBookingsBtn_Click);
            this.LongTourBookingsBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.LongTourBookingsBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.PaymentBtn.BackgroundImage = global::AyuboDrive.Properties.Resources.PaymentWhite64;
            this.PaymentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PaymentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaymentBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.PaymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentBtn.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.PaymentBtn.Location = new System.Drawing.Point(353, 24);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.PaymentBtn.Size = new System.Drawing.Size(160, 135);
            this.PaymentBtn.TabIndex = 16;
            this.PaymentBtn.Text = "Payment";
            this.PaymentBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PaymentBtn.UseVisualStyleBackColor = false;
            this.PaymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);
            this.PaymentBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.PaymentBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // PackageTypeBtn
            // 
            this.PackageTypeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.PackageTypeBtn.BackgroundImage = global::AyuboDrive.Properties.Resources.PackageWhite64;
            this.PackageTypeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PackageTypeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PackageTypeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.PackageTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PackageTypeBtn.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackageTypeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.PackageTypeBtn.Location = new System.Drawing.Point(187, 24);
            this.PackageTypeBtn.Name = "PackageTypeBtn";
            this.PackageTypeBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.PackageTypeBtn.Size = new System.Drawing.Size(160, 135);
            this.PackageTypeBtn.TabIndex = 15;
            this.PackageTypeBtn.Text = "Package Type";
            this.PackageTypeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PackageTypeBtn.UseVisualStyleBackColor = false;
            this.PackageTypeBtn.Click += new System.EventHandler(this.PackageTypeBtn_Click);
            this.PackageTypeBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.PackageTypeBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogOutBtn.BackgroundImage = global::AyuboDrive.Properties.Resources.LogoutRed24;
            this.LogOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.LogOutBtn.Location = new System.Drawing.Point(602, 230);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(77, 73);
            this.LogOutBtn.TabIndex = 14;
            this.LogOutBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            this.LogOutBtn.MouseEnter += new System.EventHandler(this.LogOutBtn_MouseEnter);
            this.LogOutBtn.MouseLeave += new System.EventHandler(this.LogOutBtn_MouseLeave);
            // 
            // AccountBtn
            // 
            this.AccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.AccountBtn.BackgroundImage = global::AyuboDrive.Properties.Resources.AccountWhite24;
            this.AccountBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.AccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.AccountBtn.Location = new System.Drawing.Point(602, 151);
            this.AccountBtn.Name = "AccountBtn";
            this.AccountBtn.Size = new System.Drawing.Size(77, 73);
            this.AccountBtn.TabIndex = 13;
            this.AccountBtn.Text = "Account";
            this.AccountBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AccountBtn.UseVisualStyleBackColor = false;
            this.AccountBtn.Click += new System.EventHandler(this.AccountBtn_Click);
            this.AccountBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.AccountBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // VehicleBtn
            // 
            this.VehicleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.VehicleBtn.BackgroundImage = global::AyuboDrive.Properties.Resources.VehicleWhite24;
            this.VehicleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.VehicleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VehicleBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.VehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VehicleBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.VehicleBtn.Location = new System.Drawing.Point(519, 230);
            this.VehicleBtn.Name = "VehicleBtn";
            this.VehicleBtn.Size = new System.Drawing.Size(77, 73);
            this.VehicleBtn.TabIndex = 12;
            this.VehicleBtn.Text = "Vehicle";
            this.VehicleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VehicleBtn.UseVisualStyleBackColor = false;
            this.VehicleBtn.Click += new System.EventHandler(this.VehicleBtn_Click);
            this.VehicleBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.VehicleBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // VehicleTypeBtn
            // 
            this.VehicleTypeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.VehicleTypeBtn.BackgroundImage = global::AyuboDrive.Properties.Resources.VehicleTypeWhite24;
            this.VehicleTypeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.VehicleTypeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VehicleTypeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.VehicleTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VehicleTypeBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleTypeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.VehicleTypeBtn.Location = new System.Drawing.Point(519, 151);
            this.VehicleTypeBtn.Name = "VehicleTypeBtn";
            this.VehicleTypeBtn.Size = new System.Drawing.Size(77, 73);
            this.VehicleTypeBtn.TabIndex = 11;
            this.VehicleTypeBtn.Text = "Vehicle type";
            this.VehicleTypeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VehicleTypeBtn.UseVisualStyleBackColor = false;
            this.VehicleTypeBtn.Click += new System.EventHandler(this.VehicleTypeBtn_Click);
            this.VehicleTypeBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.VehicleTypeBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.CustomerBtn.BackgroundImage = global::AyuboDrive.Properties.Resources.CustomerWhite64;
            this.CustomerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.CustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerBtn.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.CustomerBtn.Location = new System.Drawing.Point(519, 24);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.CustomerBtn.Size = new System.Drawing.Size(160, 120);
            this.CustomerBtn.TabIndex = 10;
            this.CustomerBtn.Text = "Customer";
            this.CustomerBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CustomerBtn.UseVisualStyleBackColor = false;
            this.CustomerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            this.CustomerBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.CustomerBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // RentalBookingsBtn
            // 
            this.RentalBookingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.RentalBookingsBtn.BackgroundImage = global::AyuboDrive.Properties.Resources.RentalWhite64;
            this.RentalBookingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RentalBookingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RentalBookingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.RentalBookingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentalBookingsBtn.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalBookingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.RentalBookingsBtn.Location = new System.Drawing.Point(21, 25);
            this.RentalBookingsBtn.Name = "RentalBookingsBtn";
            this.RentalBookingsBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.RentalBookingsBtn.Size = new System.Drawing.Size(160, 135);
            this.RentalBookingsBtn.TabIndex = 9;
            this.RentalBookingsBtn.Text = "Rental Bookings";
            this.RentalBookingsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RentalBookingsBtn.UseVisualStyleBackColor = false;
            this.RentalBookingsBtn.Click += new System.EventHandler(this.RentalBookingsBtn_Click);
            this.RentalBookingsBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.RentalBookingsBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(700, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ongoingBookingsTextLbl;
        private System.Windows.Forms.Label closedBookingTextLbl;
        private System.Windows.Forms.Label fullNameLbl;
        private System.Windows.Forms.Label greetingLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closedBookingsValueLbl;
        private System.Windows.Forms.Label openBookingsValueLbl;
        private System.Windows.Forms.Panel userNamePanel;
        private System.Windows.Forms.Button RentalBookingsBtn;
        private System.Windows.Forms.Button VehicleTypeBtn;
        private System.Windows.Forms.Button CustomerBtn;
        private System.Windows.Forms.Button DriverBtn;
        private System.Windows.Forms.Button BookingClosureBtn;
        private System.Windows.Forms.Button LongTourBookingsBtn;
        private System.Windows.Forms.Button PaymentBtn;
        private System.Windows.Forms.Button PackageTypeBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button AccountBtn;
        private System.Windows.Forms.Button VehicleBtn;
    }
}