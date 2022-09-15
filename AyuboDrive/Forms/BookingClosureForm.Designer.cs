namespace AyuboDrive.Forms
{
    partial class BookingClosureForm
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
            this.EndMileageTxtBox = new System.Windows.Forms.TextBox();
            this.ManipulationPanel = new System.Windows.Forms.Panel();
            this.StartMileageValueLbl = new System.Windows.Forms.Label();
            this.StartMileageLbl = new System.Windows.Forms.Label();
            this.EndMileagePnl = new System.Windows.Forms.Panel();
            this.EndMileageErrLbl = new System.Windows.Forms.Label();
            this.EndMileageLbl = new System.Windows.Forms.Label();
            this.StartDateValueLbl = new System.Windows.Forms.Label();
            this.StartDateLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ValueLbl = new System.Windows.Forms.Label();
            this.EstimatedRentValueLbl = new System.Windows.Forms.Label();
            this.ReturnDateDTP = new System.Windows.Forms.DateTimePicker();
            this.ReturnDatePnl = new System.Windows.Forms.Panel();
            this.ReturnDateLbl = new System.Windows.Forms.Label();
            this.ReturnDateErrLbl = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.TablePnl = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TableControlPnl = new System.Windows.Forms.Panel();
            this.RentalRBtn = new System.Windows.Forms.RadioButton();
            this.DayTourRBtn = new System.Windows.Forms.RadioButton();
            this.LongTourRBtn = new System.Windows.Forms.RadioButton();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.CloseBookingBtn = new System.Windows.Forms.Button();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.MakePaymentBtn = new System.Windows.Forms.Button();
            this.ManipulationPanel.SuspendLayout();
            this.TableControlPnl.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EndMileageTxtBox
            // 
            this.EndMileageTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.EndMileageTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EndMileageTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.EndMileageTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.EndMileageTxtBox.Location = new System.Drawing.Point(25, 195);
            this.EndMileageTxtBox.Name = "EndMileageTxtBox";
            this.EndMileageTxtBox.Size = new System.Drawing.Size(188, 19);
            this.EndMileageTxtBox.TabIndex = 60;
            this.EndMileageTxtBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.EndMileageTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnlyTextBox_KeyPress);
            this.EndMileageTxtBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // ManipulationPanel
            // 
            this.ManipulationPanel.AutoScroll = true;
            this.ManipulationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.ManipulationPanel.Controls.Add(this.StartMileageValueLbl);
            this.ManipulationPanel.Controls.Add(this.StartMileageLbl);
            this.ManipulationPanel.Controls.Add(this.EndMileagePnl);
            this.ManipulationPanel.Controls.Add(this.EndMileageErrLbl);
            this.ManipulationPanel.Controls.Add(this.EndMileageTxtBox);
            this.ManipulationPanel.Controls.Add(this.EndMileageLbl);
            this.ManipulationPanel.Controls.Add(this.StartDateValueLbl);
            this.ManipulationPanel.Controls.Add(this.StartDateLbl);
            this.ManipulationPanel.Controls.Add(this.label3);
            this.ManipulationPanel.Controls.Add(this.ValueLbl);
            this.ManipulationPanel.Controls.Add(this.EstimatedRentValueLbl);
            this.ManipulationPanel.Controls.Add(this.ReturnDateDTP);
            this.ManipulationPanel.Controls.Add(this.ReturnDatePnl);
            this.ManipulationPanel.Controls.Add(this.ReturnDateLbl);
            this.ManipulationPanel.Controls.Add(this.ReturnDateErrLbl);
            this.ManipulationPanel.Location = new System.Drawing.Point(608, 119);
            this.ManipulationPanel.Name = "ManipulationPanel";
            this.ManipulationPanel.Size = new System.Drawing.Size(250, 265);
            this.ManipulationPanel.TabIndex = 64;
            // 
            // StartMileageValueLbl
            // 
            this.StartMileageValueLbl.AutoSize = true;
            this.StartMileageValueLbl.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.StartMileageValueLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.StartMileageValueLbl.Location = new System.Drawing.Point(22, 146);
            this.StartMileageValueLbl.Name = "StartMileageValueLbl";
            this.StartMileageValueLbl.Size = new System.Drawing.Size(11, 18);
            this.StartMileageValueLbl.TabIndex = 136;
            this.StartMileageValueLbl.Text = " ";
            // 
            // StartMileageLbl
            // 
            this.StartMileageLbl.AutoSize = true;
            this.StartMileageLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartMileageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.StartMileageLbl.Location = new System.Drawing.Point(22, 131);
            this.StartMileageLbl.Name = "StartMileageLbl";
            this.StartMileageLbl.Size = new System.Drawing.Size(103, 15);
            this.StartMileageLbl.TabIndex = 135;
            this.StartMileageLbl.Text = "Start mileage (Km)";
            // 
            // EndMileagePnl
            // 
            this.EndMileagePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.EndMileagePnl.Location = new System.Drawing.Point(25, 215);
            this.EndMileagePnl.Name = "EndMileagePnl";
            this.EndMileagePnl.Size = new System.Drawing.Size(188, 2);
            this.EndMileagePnl.TabIndex = 127;
            // 
            // EndMileageErrLbl
            // 
            this.EndMileageErrLbl.AutoSize = true;
            this.EndMileageErrLbl.BackColor = System.Drawing.Color.Transparent;
            this.EndMileageErrLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndMileageErrLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.EndMileageErrLbl.Location = new System.Drawing.Point(22, 220);
            this.EndMileageErrLbl.Name = "EndMileageErrLbl";
            this.EndMileageErrLbl.Size = new System.Drawing.Size(9, 13);
            this.EndMileageErrLbl.TabIndex = 61;
            this.EndMileageErrLbl.Text = " ";
            // 
            // EndMileageLbl
            // 
            this.EndMileageLbl.AutoSize = true;
            this.EndMileageLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndMileageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.EndMileageLbl.Location = new System.Drawing.Point(22, 175);
            this.EndMileageLbl.Name = "EndMileageLbl";
            this.EndMileageLbl.Size = new System.Drawing.Size(98, 15);
            this.EndMileageLbl.TabIndex = 30;
            this.EndMileageLbl.Text = "End mileage (Km)";
            // 
            // StartDateValueLbl
            // 
            this.StartDateValueLbl.AutoSize = true;
            this.StartDateValueLbl.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.StartDateValueLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.StartDateValueLbl.Location = new System.Drawing.Point(22, 31);
            this.StartDateValueLbl.Name = "StartDateValueLbl";
            this.StartDateValueLbl.Size = new System.Drawing.Size(11, 18);
            this.StartDateValueLbl.TabIndex = 132;
            this.StartDateValueLbl.Text = " ";
            // 
            // StartDateLbl
            // 
            this.StartDateLbl.AutoSize = true;
            this.StartDateLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.StartDateLbl.Location = new System.Drawing.Point(22, 16);
            this.StartDateLbl.Name = "StartDateLbl";
            this.StartDateLbl.Size = new System.Drawing.Size(58, 15);
            this.StartDateLbl.TabIndex = 131;
            this.StartDateLbl.Text = "Start date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.label3.Location = new System.Drawing.Point(222, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 15);
            this.label3.TabIndex = 130;
            this.label3.Text = " ";
            // 
            // ValueLbl
            // 
            this.ValueLbl.AutoSize = true;
            this.ValueLbl.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.ValueLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.ValueLbl.Location = new System.Drawing.Point(22, 263);
            this.ValueLbl.Name = "ValueLbl";
            this.ValueLbl.Size = new System.Drawing.Size(31, 18);
            this.ValueLbl.TabIndex = 129;
            this.ValueLbl.Text = " 0.0";
            // 
            // EstimatedRentValueLbl
            // 
            this.EstimatedRentValueLbl.AutoSize = true;
            this.EstimatedRentValueLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstimatedRentValueLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.EstimatedRentValueLbl.Location = new System.Drawing.Point(22, 248);
            this.EstimatedRentValueLbl.Name = "EstimatedRentValueLbl";
            this.EstimatedRentValueLbl.Size = new System.Drawing.Size(144, 15);
            this.EstimatedRentValueLbl.TabIndex = 128;
            this.EstimatedRentValueLbl.Text = "Estimated rent value (LKR)";
            // 
            // ReturnDateDTP
            // 
            this.ReturnDateDTP.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.ReturnDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnDateDTP.Location = new System.Drawing.Point(25, 77);
            this.ReturnDateDTP.Name = "ReturnDateDTP";
            this.ReturnDateDTP.Size = new System.Drawing.Size(120, 26);
            this.ReturnDateDTP.TabIndex = 127;
            // 
            // ReturnDatePnl
            // 
            this.ReturnDatePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.ReturnDatePnl.Location = new System.Drawing.Point(25, 100);
            this.ReturnDatePnl.Name = "ReturnDatePnl";
            this.ReturnDatePnl.Size = new System.Drawing.Size(120, 2);
            this.ReturnDatePnl.TabIndex = 126;
            // 
            // ReturnDateLbl
            // 
            this.ReturnDateLbl.AutoSize = true;
            this.ReturnDateLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.ReturnDateLbl.Location = new System.Drawing.Point(22, 60);
            this.ReturnDateLbl.Name = "ReturnDateLbl";
            this.ReturnDateLbl.Size = new System.Drawing.Size(69, 15);
            this.ReturnDateLbl.TabIndex = 124;
            this.ReturnDateLbl.Text = "Return date";
            // 
            // ReturnDateErrLbl
            // 
            this.ReturnDateErrLbl.AutoSize = true;
            this.ReturnDateErrLbl.BackColor = System.Drawing.Color.Transparent;
            this.ReturnDateErrLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDateErrLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ReturnDateErrLbl.Location = new System.Drawing.Point(22, 105);
            this.ReturnDateErrLbl.Name = "ReturnDateErrLbl";
            this.ReturnDateErrLbl.Size = new System.Drawing.Size(9, 13);
            this.ReturnDateErrLbl.TabIndex = 125;
            this.ReturnDateErrLbl.Text = " ";
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Carlito", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.TitleLbl.Location = new System.Drawing.Point(12, 34);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(227, 39);
            this.TitleLbl.TabIndex = 61;
            this.TitleLbl.Text = "Booking Closure";
            // 
            // TablePnl
            // 
            this.TablePnl.AutoScroll = true;
            this.TablePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.TablePnl.Location = new System.Drawing.Point(9, 76);
            this.TablePnl.Name = "TablePnl";
            this.TablePnl.Size = new System.Drawing.Size(593, 384);
            this.TablePnl.TabIndex = 62;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(870, 30);
            this.flowLayoutPanel1.TabIndex = 63;
            // 
            // TableControlPnl
            // 
            this.TableControlPnl.AutoScroll = true;
            this.TableControlPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.TableControlPnl.Controls.Add(this.RentalRBtn);
            this.TableControlPnl.Controls.Add(this.DayTourRBtn);
            this.TableControlPnl.Controls.Add(this.LongTourRBtn);
            this.TableControlPnl.Location = new System.Drawing.Point(608, 76);
            this.TableControlPnl.Name = "TableControlPnl";
            this.TableControlPnl.Size = new System.Drawing.Size(250, 37);
            this.TableControlPnl.TabIndex = 82;
            // 
            // RentalRBtn
            // 
            this.RentalRBtn.AutoSize = true;
            this.RentalRBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.RentalRBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentalRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.RentalRBtn.Location = new System.Drawing.Point(168, 11);
            this.RentalRBtn.Name = "RentalRBtn";
            this.RentalRBtn.Size = new System.Drawing.Size(60, 17);
            this.RentalRBtn.TabIndex = 23;
            this.RentalRBtn.Text = "Rentals";
            this.RentalRBtn.UseVisualStyleBackColor = true;
            this.RentalRBtn.CheckedChanged += new System.EventHandler(this.RentalRBtn_CheckedChanged);
            // 
            // DayTourRBtn
            // 
            this.DayTourRBtn.AutoSize = true;
            this.DayTourRBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.DayTourRBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DayTourRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.DayTourRBtn.Location = new System.Drawing.Point(98, 11);
            this.DayTourRBtn.Name = "DayTourRBtn";
            this.DayTourRBtn.Size = new System.Drawing.Size(64, 17);
            this.DayTourRBtn.TabIndex = 22;
            this.DayTourRBtn.Text = "Day tour";
            this.DayTourRBtn.UseVisualStyleBackColor = true;
            this.DayTourRBtn.CheckedChanged += new System.EventHandler(this.DayTourRBtn_CheckedChanged);
            // 
            // LongTourRBtn
            // 
            this.LongTourRBtn.AutoSize = true;
            this.LongTourRBtn.Checked = true;
            this.LongTourRBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.LongTourRBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LongTourRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.LongTourRBtn.Location = new System.Drawing.Point(23, 11);
            this.LongTourRBtn.Name = "LongTourRBtn";
            this.LongTourRBtn.Size = new System.Drawing.Size(69, 17);
            this.LongTourRBtn.TabIndex = 21;
            this.LongTourRBtn.TabStop = true;
            this.LongTourRBtn.Text = "Long tour";
            this.LongTourRBtn.UseVisualStyleBackColor = true;
            this.LongTourRBtn.CheckedChanged += new System.EventHandler(this.LongTourRBtn_CheckedChanged);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.ButtonsPanel.Controls.Add(this.CloseBookingBtn);
            this.ButtonsPanel.Controls.Add(this.CalculateBtn);
            this.ButtonsPanel.Controls.Add(this.MakePaymentBtn);
            this.ButtonsPanel.Location = new System.Drawing.Point(608, 390);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(250, 68);
            this.ButtonsPanel.TabIndex = 80;
            // 
            // CloseBookingBtn
            // 
            this.CloseBookingBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBookingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBookingBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.CloseBookingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBookingBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBookingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.CloseBookingBtn.Location = new System.Drawing.Point(169, 9);
            this.CloseBookingBtn.Name = "CloseBookingBtn";
            this.CloseBookingBtn.Size = new System.Drawing.Size(75, 51);
            this.CloseBookingBtn.TabIndex = 9;
            this.CloseBookingBtn.Text = "Close";
            this.CloseBookingBtn.UseVisualStyleBackColor = false;
            this.CloseBookingBtn.Click += new System.EventHandler(this.CloseBookingBtn_Click);
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.CalculateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.CalculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CalculateBtn.Location = new System.Drawing.Point(7, 9);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(75, 51);
            this.CalculateBtn.TabIndex = 8;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = false;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // MakePaymentBtn
            // 
            this.MakePaymentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(199)))), ((int)(((byte)(151)))));
            this.MakePaymentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MakePaymentBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(199)))), ((int)(((byte)(151)))));
            this.MakePaymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakePaymentBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakePaymentBtn.Location = new System.Drawing.Point(88, 9);
            this.MakePaymentBtn.Name = "MakePaymentBtn";
            this.MakePaymentBtn.Size = new System.Drawing.Size(75, 51);
            this.MakePaymentBtn.TabIndex = 6;
            this.MakePaymentBtn.Text = "Pay";
            this.MakePaymentBtn.UseVisualStyleBackColor = false;
            this.MakePaymentBtn.Click += new System.EventHandler(this.MakePaymentBtn_Click);
            // 
            // BookingClosureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(870, 470);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.TableControlPnl);
            this.Controls.Add(this.ManipulationPanel);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.TablePnl);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookingClosureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingClosureForm";
            this.Load += new System.EventHandler(this.BookingClosureForm_Load);
            this.ManipulationPanel.ResumeLayout(false);
            this.ManipulationPanel.PerformLayout();
            this.TableControlPnl.ResumeLayout(false);
            this.TableControlPnl.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EndMileageTxtBox;
        private System.Windows.Forms.Panel ManipulationPanel;
        private System.Windows.Forms.Label EndMileageLbl;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Panel TablePnl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel TableControlPnl;
        private System.Windows.Forms.RadioButton RentalRBtn;
        private System.Windows.Forms.RadioButton DayTourRBtn;
        private System.Windows.Forms.RadioButton LongTourRBtn;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Button MakePaymentBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ValueLbl;
        private System.Windows.Forms.Label EstimatedRentValueLbl;
        private System.Windows.Forms.DateTimePicker ReturnDateDTP;
        private System.Windows.Forms.Panel ReturnDatePnl;
        private System.Windows.Forms.Label ReturnDateLbl;
        private System.Windows.Forms.Label ReturnDateErrLbl;
        private System.Windows.Forms.Label EndMileageErrLbl;
        private System.Windows.Forms.Button CloseBookingBtn;
        private System.Windows.Forms.Label StartDateValueLbl;
        private System.Windows.Forms.Label StartDateLbl;
        private System.Windows.Forms.Label StartMileageValueLbl;
        private System.Windows.Forms.Label StartMileageLbl;
        private System.Windows.Forms.Panel EndMileagePnl;
    }
}