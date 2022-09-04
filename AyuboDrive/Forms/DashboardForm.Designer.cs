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
            this.accountBtn = new System.Windows.Forms.Button();
            this.packageTypeManagementBtn = new System.Windows.Forms.Button();
            this.rentalBookingsBtn = new System.Windows.Forms.Button();
            this.dayTourBookingsBtn = new System.Windows.Forms.Button();
            this.longTourBookingsBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.vehicleTypeManagementBtn = new System.Windows.Forms.Button();
            this.customerManagementBtn = new System.Windows.Forms.Button();
            this.vehicleManagementBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
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
            this.panel1.Size = new System.Drawing.Size(684, 168);
            this.panel1.TabIndex = 1;
            // 
            // userNamePanel
            // 
            this.userNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.userNamePanel.Location = new System.Drawing.Point(0, 166);
            this.userNamePanel.Name = "userNamePanel";
            this.userNamePanel.Size = new System.Drawing.Size(684, 2);
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
            this.closedBookingsValueLbl.Location = new System.Drawing.Point(387, 47);
            this.closedBookingsValueLbl.Name = "closedBookingsValueLbl";
            this.closedBookingsValueLbl.Size = new System.Drawing.Size(33, 39);
            this.closedBookingsValueLbl.TabIndex = 5;
            this.closedBookingsValueLbl.Text = "#\r\n";
            this.closedBookingsValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closedBookingsValueLbl.Click += new System.EventHandler(this.closedBookingsValueLbl_Click);
            // 
            // openBookingsValueLbl
            // 
            this.openBookingsValueLbl.AutoSize = true;
            this.openBookingsValueLbl.BackColor = System.Drawing.Color.Transparent;
            this.openBookingsValueLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openBookingsValueLbl.Font = new System.Drawing.Font("Carlito", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBookingsValueLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.openBookingsValueLbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.openBookingsValueLbl.Location = new System.Drawing.Point(554, 47);
            this.openBookingsValueLbl.Name = "openBookingsValueLbl";
            this.openBookingsValueLbl.Size = new System.Drawing.Size(33, 39);
            this.openBookingsValueLbl.TabIndex = 4;
            this.openBookingsValueLbl.Text = "#\r\n";
            this.openBookingsValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ongoingBookingsTextLbl
            // 
            this.ongoingBookingsTextLbl.AutoSize = true;
            this.ongoingBookingsTextLbl.BackColor = System.Drawing.Color.Transparent;
            this.ongoingBookingsTextLbl.Font = new System.Drawing.Font("Carlito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ongoingBookingsTextLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.ongoingBookingsTextLbl.Location = new System.Drawing.Point(490, 90);
            this.ongoingBookingsTextLbl.Name = "ongoingBookingsTextLbl";
            this.ongoingBookingsTextLbl.Size = new System.Drawing.Size(148, 23);
            this.ongoingBookingsTextLbl.TabIndex = 3;
            this.ongoingBookingsTextLbl.Text = "Ongoing bookings";
            this.ongoingBookingsTextLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ongoingBookingsTextLbl.Click += new System.EventHandler(this.ongoingBookingsTextLbl_Click);
            // 
            // closedBookingTextLbl
            // 
            this.closedBookingTextLbl.AutoSize = true;
            this.closedBookingTextLbl.BackColor = System.Drawing.Color.Transparent;
            this.closedBookingTextLbl.Font = new System.Drawing.Font("Carlito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closedBookingTextLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.closedBookingTextLbl.Location = new System.Drawing.Point(334, 90);
            this.closedBookingTextLbl.Name = "closedBookingTextLbl";
            this.closedBookingTextLbl.Size = new System.Drawing.Size(133, 23);
            this.closedBookingTextLbl.TabIndex = 2;
            this.closedBookingTextLbl.Text = "Closed bookings";
            this.closedBookingTextLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closedBookingTextLbl.Click += new System.EventHandler(this.closedBookingTextLbl_Click);
            // 
            // fullNameLbl
            // 
            this.fullNameLbl.AutoSize = true;
            this.fullNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.fullNameLbl.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.fullNameLbl.Location = new System.Drawing.Point(24, 85);
            this.fullNameLbl.Name = "fullNameLbl";
            this.fullNameLbl.Size = new System.Drawing.Size(110, 29);
            this.fullNameLbl.TabIndex = 1;
            this.fullNameLbl.Text = "Full name";
            // 
            // greetingLbl
            // 
            this.greetingLbl.AutoSize = true;
            this.greetingLbl.BackColor = System.Drawing.Color.Transparent;
            this.greetingLbl.Font = new System.Drawing.Font("Carlito", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.greetingLbl.Location = new System.Drawing.Point(21, 40);
            this.greetingLbl.Name = "greetingLbl";
            this.greetingLbl.Size = new System.Drawing.Size(172, 45);
            this.greetingLbl.TabIndex = 0;
            this.greetingLbl.Text = "Greetings,";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.accountBtn);
            this.panel2.Controls.Add(this.packageTypeManagementBtn);
            this.panel2.Controls.Add(this.rentalBookingsBtn);
            this.panel2.Controls.Add(this.dayTourBookingsBtn);
            this.panel2.Controls.Add(this.longTourBookingsBtn);
            this.panel2.Controls.Add(this.logoutBtn);
            this.panel2.Controls.Add(this.vehicleTypeManagementBtn);
            this.panel2.Controls.Add(this.customerManagementBtn);
            this.panel2.Controls.Add(this.vehicleManagementBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 292);
            this.panel2.TabIndex = 2;
            // 
            // accountBtn
            // 
            this.accountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.accountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.accountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.accountBtn.Location = new System.Drawing.Point(500, 213);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(87, 56);
            this.accountBtn.TabIndex = 12;
            this.accountBtn.TabStop = false;
            this.accountBtn.Text = "Account";
            this.accountBtn.UseVisualStyleBackColor = false;
            // 
            // packageTypeManagementBtn
            // 
            this.packageTypeManagementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.packageTypeManagementBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.packageTypeManagementBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.packageTypeManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.packageTypeManagementBtn.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageTypeManagementBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.packageTypeManagementBtn.Location = new System.Drawing.Point(188, 23);
            this.packageTypeManagementBtn.Name = "packageTypeManagementBtn";
            this.packageTypeManagementBtn.Size = new System.Drawing.Size(150, 120);
            this.packageTypeManagementBtn.TabIndex = 11;
            this.packageTypeManagementBtn.TabStop = false;
            this.packageTypeManagementBtn.Text = "Package type management";
            this.packageTypeManagementBtn.UseVisualStyleBackColor = false;
            this.packageTypeManagementBtn.Click += new System.EventHandler(this.packageTypeManagementBtn_Click);
            // 
            // rentalBookingsBtn
            // 
            this.rentalBookingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.rentalBookingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rentalBookingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.rentalBookingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentalBookingsBtn.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalBookingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.rentalBookingsBtn.Location = new System.Drawing.Point(32, 23);
            this.rentalBookingsBtn.Name = "rentalBookingsBtn";
            this.rentalBookingsBtn.Size = new System.Drawing.Size(150, 120);
            this.rentalBookingsBtn.TabIndex = 10;
            this.rentalBookingsBtn.TabStop = false;
            this.rentalBookingsBtn.Text = "Rental bookings";
            this.rentalBookingsBtn.UseVisualStyleBackColor = false;
            this.rentalBookingsBtn.Click += new System.EventHandler(this.rentalBookingsBtn_Click);
            // 
            // dayTourBookingsBtn
            // 
            this.dayTourBookingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.dayTourBookingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dayTourBookingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.dayTourBookingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayTourBookingsBtn.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayTourBookingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.dayTourBookingsBtn.Location = new System.Drawing.Point(188, 149);
            this.dayTourBookingsBtn.Name = "dayTourBookingsBtn";
            this.dayTourBookingsBtn.Size = new System.Drawing.Size(150, 120);
            this.dayTourBookingsBtn.TabIndex = 9;
            this.dayTourBookingsBtn.TabStop = false;
            this.dayTourBookingsBtn.Text = "Day tour bookings";
            this.dayTourBookingsBtn.UseVisualStyleBackColor = false;
            this.dayTourBookingsBtn.Click += new System.EventHandler(this.dayTourBookingsBtn_Click);
            // 
            // longTourBookingsBtn
            // 
            this.longTourBookingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.longTourBookingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.longTourBookingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.longTourBookingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.longTourBookingsBtn.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longTourBookingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.longTourBookingsBtn.Location = new System.Drawing.Point(32, 149);
            this.longTourBookingsBtn.Name = "longTourBookingsBtn";
            this.longTourBookingsBtn.Size = new System.Drawing.Size(150, 120);
            this.longTourBookingsBtn.TabIndex = 8;
            this.longTourBookingsBtn.TabStop = false;
            this.longTourBookingsBtn.Text = "Long tour bookings";
            this.longTourBookingsBtn.UseVisualStyleBackColor = false;
            this.longTourBookingsBtn.Click += new System.EventHandler(this.longTourBookingsBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.logoutBtn.Location = new System.Drawing.Point(593, 213);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(57, 56);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.TabStop = false;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.MouseEnter += new System.EventHandler(this.logoutBtn_MouseEnter);
            this.logoutBtn.MouseLeave += new System.EventHandler(this.logoutBtn_MouseLeave);
            // 
            // vehicleTypeManagementBtn
            // 
            this.vehicleTypeManagementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.vehicleTypeManagementBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vehicleTypeManagementBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.vehicleTypeManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicleTypeManagementBtn.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleTypeManagementBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.vehicleTypeManagementBtn.Location = new System.Drawing.Point(344, 149);
            this.vehicleTypeManagementBtn.Name = "vehicleTypeManagementBtn";
            this.vehicleTypeManagementBtn.Size = new System.Drawing.Size(150, 120);
            this.vehicleTypeManagementBtn.TabIndex = 6;
            this.vehicleTypeManagementBtn.TabStop = false;
            this.vehicleTypeManagementBtn.Text = "Vehicle type management";
            this.vehicleTypeManagementBtn.UseVisualStyleBackColor = false;
            this.vehicleTypeManagementBtn.Click += new System.EventHandler(this.vehicleTypeManagementBtn_Click);
            // 
            // customerManagementBtn
            // 
            this.customerManagementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.customerManagementBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerManagementBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.customerManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerManagementBtn.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerManagementBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.customerManagementBtn.Location = new System.Drawing.Point(500, 23);
            this.customerManagementBtn.Name = "customerManagementBtn";
            this.customerManagementBtn.Size = new System.Drawing.Size(150, 184);
            this.customerManagementBtn.TabIndex = 3;
            this.customerManagementBtn.TabStop = false;
            this.customerManagementBtn.Text = "Customer management";
            this.customerManagementBtn.UseVisualStyleBackColor = false;
            this.customerManagementBtn.Click += new System.EventHandler(this.customerManagementBtn_Click);
            // 
            // vehicleManagementBtn
            // 
            this.vehicleManagementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.vehicleManagementBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vehicleManagementBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.vehicleManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicleManagementBtn.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleManagementBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.vehicleManagementBtn.Location = new System.Drawing.Point(344, 23);
            this.vehicleManagementBtn.Name = "vehicleManagementBtn";
            this.vehicleManagementBtn.Size = new System.Drawing.Size(150, 120);
            this.vehicleManagementBtn.TabIndex = 2;
            this.vehicleManagementBtn.TabStop = false;
            this.vehicleManagementBtn.Text = "Vehicle management";
            this.vehicleManagementBtn.UseVisualStyleBackColor = false;
            this.vehicleManagementBtn.Click += new System.EventHandler(this.vehicleManagementBtn_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.Button packageTypeManagementBtn;
        private System.Windows.Forms.Button rentalBookingsBtn;
        private System.Windows.Forms.Button dayTourBookingsBtn;
        private System.Windows.Forms.Button longTourBookingsBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button vehicleTypeManagementBtn;
        private System.Windows.Forms.Button customerManagementBtn;
        private System.Windows.Forms.Button vehicleManagementBtn;
        private System.Windows.Forms.Button accountBtn;
        private System.Windows.Forms.Label closedBookingsValueLbl;
        private System.Windows.Forms.Label openBookingsValueLbl;
        private System.Windows.Forms.Panel userNamePanel;
    }
}