using AyuboDrive.Utility;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.OngoingRentalsCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.PendingPaymentCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.OngoingBookingsCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ClosedBookingsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fullNameLbl = new System.Windows.Forms.Label();
            this.greetingLbl = new System.Windows.Forms.Label();
            this.userNamePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DriverBtn = new AyuboDrive.Utility.CustomButton();
            this.BookingClosureBtn = new AyuboDrive.Utility.CustomButton();
            this.LongTourBookingsBtn = new AyuboDrive.Utility.CustomButton();
            this.PaymentBtn = new AyuboDrive.Utility.CustomButton();
            this.PackageTypeBtn = new AyuboDrive.Utility.CustomButton();
            this.LogOutBtn = new AyuboDrive.Utility.CustomButton();
            this.AccountBtn = new AyuboDrive.Utility.CustomButton();
            this.VehicleBtn = new AyuboDrive.Utility.CustomButton();
            this.VehicleTypeBtn = new AyuboDrive.Utility.CustomButton();
            this.CustomerBtn = new AyuboDrive.Utility.CustomButton();
            this.RentalBookingsBtn = new AyuboDrive.Utility.CustomButton();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.fullNameLbl);
            this.panel1.Controls.Add(this.greetingLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 234);
            this.panel1.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Location = new System.Drawing.Point(470, 134);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(191, 38);
            this.panel9.TabIndex = 32;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.panel10.Controls.Add(this.OngoingRentalsCount);
            this.panel10.Location = new System.Drawing.Point(144, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(42, 30);
            this.panel10.TabIndex = 28;
            // 
            // OngoingRentalsCount
            // 
            this.OngoingRentalsCount.AutoSize = true;
            this.OngoingRentalsCount.BackColor = System.Drawing.Color.Transparent;
            this.OngoingRentalsCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.OngoingRentalsCount.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OngoingRentalsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.OngoingRentalsCount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.OngoingRentalsCount.Location = new System.Drawing.Point(9, 7);
            this.OngoingRentalsCount.Name = "OngoingRentalsCount";
            this.OngoingRentalsCount.Size = new System.Drawing.Size(25, 15);
            this.OngoingRentalsCount.TabIndex = 27;
            this.OngoingRentalsCount.Text = "###";
            this.OngoingRentalsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(8, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Ongoing rentals";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(673, 30);
            this.panel11.TabIndex = 29;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(470, 178);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(191, 38);
            this.panel7.TabIndex = 30;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.panel8.Controls.Add(this.PendingPaymentCount);
            this.panel8.Location = new System.Drawing.Point(144, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(42, 30);
            this.panel8.TabIndex = 28;
            // 
            // PendingPaymentCount
            // 
            this.PendingPaymentCount.AutoSize = true;
            this.PendingPaymentCount.BackColor = System.Drawing.Color.Transparent;
            this.PendingPaymentCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.PendingPaymentCount.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingPaymentCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.PendingPaymentCount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PendingPaymentCount.Location = new System.Drawing.Point(9, 7);
            this.PendingPaymentCount.Name = "PendingPaymentCount";
            this.PendingPaymentCount.Size = new System.Drawing.Size(25, 15);
            this.PendingPaymentCount.TabIndex = 27;
            this.PendingPaymentCount.Text = "###";
            this.PendingPaymentCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(8, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Pending payments";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(470, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(191, 38);
            this.panel5.TabIndex = 29;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.panel6.Controls.Add(this.OngoingBookingsCount);
            this.panel6.Location = new System.Drawing.Point(144, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(42, 30);
            this.panel6.TabIndex = 28;
            // 
            // OngoingBookingsCount
            // 
            this.OngoingBookingsCount.AutoSize = true;
            this.OngoingBookingsCount.BackColor = System.Drawing.Color.Transparent;
            this.OngoingBookingsCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.OngoingBookingsCount.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OngoingBookingsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.OngoingBookingsCount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.OngoingBookingsCount.Location = new System.Drawing.Point(9, 7);
            this.OngoingBookingsCount.Name = "OngoingBookingsCount";
            this.OngoingBookingsCount.Size = new System.Drawing.Size(25, 15);
            this.OngoingBookingsCount.TabIndex = 27;
            this.OngoingBookingsCount.Text = "###";
            this.OngoingBookingsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(8, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ongoing hire bookings";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(470, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 38);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.panel4.Controls.Add(this.ClosedBookingsCount);
            this.panel4.Location = new System.Drawing.Point(144, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(42, 30);
            this.panel4.TabIndex = 28;
            // 
            // ClosedBookingsCount
            // 
            this.ClosedBookingsCount.AutoSize = true;
            this.ClosedBookingsCount.BackColor = System.Drawing.Color.Transparent;
            this.ClosedBookingsCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClosedBookingsCount.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClosedBookingsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(67)))), ((int)(((byte)(214)))));
            this.ClosedBookingsCount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ClosedBookingsCount.Location = new System.Drawing.Point(9, 7);
            this.ClosedBookingsCount.Name = "ClosedBookingsCount";
            this.ClosedBookingsCount.Size = new System.Drawing.Size(25, 15);
            this.ClosedBookingsCount.TabIndex = 27;
            this.ClosedBookingsCount.Text = "###";
            this.ClosedBookingsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Closed hire bookings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullNameLbl
            // 
            this.fullNameLbl.AutoSize = true;
            this.fullNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.fullNameLbl.Font = new System.Drawing.Font("Carlito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.fullNameLbl.Location = new System.Drawing.Point(18, 105);
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
            this.greetingLbl.Location = new System.Drawing.Point(12, 46);
            this.greetingLbl.Name = "greetingLbl";
            this.greetingLbl.Size = new System.Drawing.Size(225, 59);
            this.greetingLbl.TabIndex = 11;
            this.greetingLbl.Text = "Greetings,";
            // 
            // userNamePanel
            // 
            this.userNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(67)))), ((int)(((byte)(214)))));
            this.userNamePanel.Location = new System.Drawing.Point(0, 235);
            this.userNamePanel.Name = "userNamePanel";
            this.userNamePanel.Size = new System.Drawing.Size(673, 1);
            this.userNamePanel.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
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
            this.panel2.Location = new System.Drawing.Point(0, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 292);
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
            this.DriverBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.DriverBtn.Location = new System.Drawing.Point(339, 150);
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
            this.BookingClosureBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingClosureBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.BookingClosureBtn.Location = new System.Drawing.Point(173, 150);
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
            this.LongTourBookingsBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongTourBookingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.LongTourBookingsBtn.Location = new System.Drawing.Point(7, 150);
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
            this.PaymentBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.PaymentBtn.Location = new System.Drawing.Point(339, 7);
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
            this.PackageTypeBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackageTypeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.PackageTypeBtn.Location = new System.Drawing.Point(173, 7);
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
            this.LogOutBtn.Location = new System.Drawing.Point(588, 212);
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
            this.AccountBtn.Location = new System.Drawing.Point(588, 133);
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
            this.VehicleBtn.Location = new System.Drawing.Point(505, 212);
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
            this.VehicleTypeBtn.Location = new System.Drawing.Point(505, 133);
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
            this.CustomerBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.CustomerBtn.Location = new System.Drawing.Point(505, 7);
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
            this.RentalBookingsBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalBookingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.RentalBookingsBtn.Location = new System.Drawing.Point(7, 7);
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
            this.ClientSize = new System.Drawing.Size(673, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userNamePanel);
            this.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fullNameLbl;
        private System.Windows.Forms.Label greetingLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel userNamePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label PendingPaymentCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label OngoingBookingsCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ClosedBookingsCount;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label OngoingRentalsCount;
        private System.Windows.Forms.Label label8;
        private CustomButton RentalBookingsBtn;
        private CustomButton VehicleTypeBtn;
        private CustomButton CustomerBtn;
        private CustomButton DriverBtn;
        private CustomButton BookingClosureBtn;
        private CustomButton LongTourBookingsBtn;
        private CustomButton PaymentBtn;
        private CustomButton PackageTypeBtn;
        private CustomButton LogOutBtn;
        private CustomButton AccountBtn;
        private CustomButton VehicleBtn;
    }
}