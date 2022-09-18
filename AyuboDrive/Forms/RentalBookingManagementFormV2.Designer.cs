using AyuboDrive.Utility;

namespace AyuboDrive.Forms
{
    partial class RentalBookingManagementFormV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalBookingManagementFormV2));
            this.TablePnl = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.ManipulationPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.DriverCheckBox = new System.Windows.Forms.CheckBox();
            this.EndDateDTP = new System.Windows.Forms.DateTimePicker();
            this.StartDateDTP = new System.Windows.Forms.DateTimePicker();
            this.CustomerIDCmbBox = new System.Windows.Forms.ComboBox();
            this.DriverIDCmbBox = new System.Windows.Forms.ComboBox();
            this.VehicleIDCmbBox = new System.Windows.Forms.ComboBox();
            this.VehicleIDPnl = new System.Windows.Forms.Panel();
            this.VehicleIDLbl = new System.Windows.Forms.Label();
            this.VehicleIDErrLbl = new System.Windows.Forms.Label();
            this.VehicleTypeIDCmbBox = new System.Windows.Forms.ComboBox();
            this.EndDatePnl = new System.Windows.Forms.Panel();
            this.EndDateLbl = new System.Windows.Forms.Label();
            this.EndDateErrLbl = new System.Windows.Forms.Label();
            this.StartDatePnl = new System.Windows.Forms.Panel();
            this.StartDateLbl = new System.Windows.Forms.Label();
            this.StartDateErrLbl = new System.Windows.Forms.Label();
            this.CustomerIDPnl = new System.Windows.Forms.Panel();
            this.CustomerIDLbl = new System.Windows.Forms.Label();
            this.CustomerIDErrLbl = new System.Windows.Forms.Label();
            this.DriverIDPnl = new System.Windows.Forms.Panel();
            this.DriverIDLbl = new System.Windows.Forms.Label();
            this.DriverIDErrLbl = new System.Windows.Forms.Label();
            this.VehicleTypeIDPnl = new System.Windows.Forms.Panel();
            this.VehicleTypeIDLbl = new System.Windows.Forms.Label();
            this.VehicleTypeIDErrLbl = new System.Windows.Forms.Label();
            this.TableViewRBtn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BothViewRBtn = new System.Windows.Forms.RadioButton();
            this.VehiclePnl = new System.Windows.Forms.Panel();
            this.InsertBtn = new AyuboDrive.Utility.CustomButton();
            this.UpdateBtn = new AyuboDrive.Utility.CustomButton();
            this.DeleteBtn = new AyuboDrive.Utility.CustomButton();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.ManipulationPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablePnl
            // 
            this.TablePnl.AutoScroll = true;
            this.TablePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.TablePnl.Location = new System.Drawing.Point(12, 76);
            this.TablePnl.Name = "TablePnl";
            this.TablePnl.Size = new System.Drawing.Size(540, 412);
            this.TablePnl.TabIndex = 57;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(820, 30);
            this.flowLayoutPanel1.TabIndex = 58;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Carlito", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.TitleLbl.Location = new System.Drawing.Point(12, 34);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(393, 39);
            this.TitleLbl.TabIndex = 56;
            this.TitleLbl.Text = "Rental Booking Management";
            // 
            // ManipulationPanel
            // 
            this.ManipulationPanel.AutoScroll = true;
            this.ManipulationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.ManipulationPanel.Controls.Add(this.label7);
            this.ManipulationPanel.Controls.Add(this.DriverCheckBox);
            this.ManipulationPanel.Controls.Add(this.EndDateDTP);
            this.ManipulationPanel.Controls.Add(this.StartDateDTP);
            this.ManipulationPanel.Controls.Add(this.CustomerIDCmbBox);
            this.ManipulationPanel.Controls.Add(this.DriverIDCmbBox);
            this.ManipulationPanel.Controls.Add(this.VehicleIDCmbBox);
            this.ManipulationPanel.Controls.Add(this.VehicleIDPnl);
            this.ManipulationPanel.Controls.Add(this.VehicleIDLbl);
            this.ManipulationPanel.Controls.Add(this.VehicleIDErrLbl);
            this.ManipulationPanel.Controls.Add(this.VehicleTypeIDCmbBox);
            this.ManipulationPanel.Controls.Add(this.EndDatePnl);
            this.ManipulationPanel.Controls.Add(this.EndDateLbl);
            this.ManipulationPanel.Controls.Add(this.EndDateErrLbl);
            this.ManipulationPanel.Controls.Add(this.StartDatePnl);
            this.ManipulationPanel.Controls.Add(this.StartDateLbl);
            this.ManipulationPanel.Controls.Add(this.StartDateErrLbl);
            this.ManipulationPanel.Controls.Add(this.CustomerIDPnl);
            this.ManipulationPanel.Controls.Add(this.CustomerIDLbl);
            this.ManipulationPanel.Controls.Add(this.CustomerIDErrLbl);
            this.ManipulationPanel.Controls.Add(this.DriverIDPnl);
            this.ManipulationPanel.Controls.Add(this.DriverIDLbl);
            this.ManipulationPanel.Controls.Add(this.DriverIDErrLbl);
            this.ManipulationPanel.Controls.Add(this.VehicleTypeIDPnl);
            this.ManipulationPanel.Controls.Add(this.VehicleTypeIDLbl);
            this.ManipulationPanel.Controls.Add(this.VehicleTypeIDErrLbl);
            this.ManipulationPanel.Location = new System.Drawing.Point(558, 76);
            this.ManipulationPanel.Name = "ManipulationPanel";
            this.ManipulationPanel.Size = new System.Drawing.Size(250, 283);
            this.ManipulationPanel.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.label7.Location = new System.Drawing.Point(223, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 15);
            this.label7.TabIndex = 133;
            this.label7.Text = " ";
            // 
            // DriverCheckBox
            // 
            this.DriverCheckBox.AutoSize = true;
            this.DriverCheckBox.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.DriverCheckBox.Location = new System.Drawing.Point(21, 159);
            this.DriverCheckBox.Name = "DriverCheckBox";
            this.DriverCheckBox.Size = new System.Drawing.Size(100, 19);
            this.DriverCheckBox.TabIndex = 124;
            this.DriverCheckBox.Text = "Include driver";
            this.DriverCheckBox.UseVisualStyleBackColor = true;
            this.DriverCheckBox.CheckedChanged += new System.EventHandler(this.DriverCheckBox_CheckedChanged);
            // 
            // EndDateDTP
            // 
            this.EndDateDTP.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.EndDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDateDTP.Location = new System.Drawing.Point(21, 407);
            this.EndDateDTP.Name = "EndDateDTP";
            this.EndDateDTP.Size = new System.Drawing.Size(120, 26);
            this.EndDateDTP.TabIndex = 118;
            // 
            // StartDateDTP
            // 
            this.StartDateDTP.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.StartDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDateDTP.Location = new System.Drawing.Point(21, 337);
            this.StartDateDTP.Name = "StartDateDTP";
            this.StartDateDTP.Size = new System.Drawing.Size(120, 26);
            this.StartDateDTP.TabIndex = 117;
            // 
            // CustomerIDCmbBox
            // 
            this.CustomerIDCmbBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.CustomerIDCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerIDCmbBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.CustomerIDCmbBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CustomerIDCmbBox.FormattingEnabled = true;
            this.CustomerIDCmbBox.Location = new System.Drawing.Point(21, 264);
            this.CustomerIDCmbBox.Name = "CustomerIDCmbBox";
            this.CustomerIDCmbBox.Size = new System.Drawing.Size(188, 26);
            this.CustomerIDCmbBox.TabIndex = 116;
            this.CustomerIDCmbBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoTyping_KeyPress);
            // 
            // DriverIDCmbBox
            // 
            this.DriverIDCmbBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.DriverIDCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DriverIDCmbBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.DriverIDCmbBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DriverIDCmbBox.FormattingEnabled = true;
            this.DriverIDCmbBox.Location = new System.Drawing.Point(21, 195);
            this.DriverIDCmbBox.Name = "DriverIDCmbBox";
            this.DriverIDCmbBox.Size = new System.Drawing.Size(188, 26);
            this.DriverIDCmbBox.TabIndex = 115;
            this.DriverIDCmbBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoTyping_KeyPress);
            // 
            // VehicleIDCmbBox
            // 
            this.VehicleIDCmbBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.VehicleIDCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VehicleIDCmbBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.VehicleIDCmbBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.VehicleIDCmbBox.FormattingEnabled = true;
            this.VehicleIDCmbBox.Location = new System.Drawing.Point(21, 99);
            this.VehicleIDCmbBox.Name = "VehicleIDCmbBox";
            this.VehicleIDCmbBox.Size = new System.Drawing.Size(188, 26);
            this.VehicleIDCmbBox.TabIndex = 114;
            this.VehicleIDCmbBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoTyping_KeyPress);
            // 
            // VehicleIDPnl
            // 
            this.VehicleIDPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.VehicleIDPnl.Location = new System.Drawing.Point(21, 125);
            this.VehicleIDPnl.Name = "VehicleIDPnl";
            this.VehicleIDPnl.Size = new System.Drawing.Size(188, 2);
            this.VehicleIDPnl.TabIndex = 113;
            // 
            // VehicleIDLbl
            // 
            this.VehicleIDLbl.AutoSize = true;
            this.VehicleIDLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleIDLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.VehicleIDLbl.Location = new System.Drawing.Point(18, 85);
            this.VehicleIDLbl.Name = "VehicleIDLbl";
            this.VehicleIDLbl.Size = new System.Drawing.Size(58, 15);
            this.VehicleIDLbl.TabIndex = 111;
            this.VehicleIDLbl.Text = "Vehicle ID";
            // 
            // VehicleIDErrLbl
            // 
            this.VehicleIDErrLbl.AutoSize = true;
            this.VehicleIDErrLbl.BackColor = System.Drawing.Color.Transparent;
            this.VehicleIDErrLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleIDErrLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.VehicleIDErrLbl.Location = new System.Drawing.Point(18, 130);
            this.VehicleIDErrLbl.Name = "VehicleIDErrLbl";
            this.VehicleIDErrLbl.Size = new System.Drawing.Size(9, 13);
            this.VehicleIDErrLbl.TabIndex = 112;
            this.VehicleIDErrLbl.Text = " ";
            // 
            // VehicleTypeIDCmbBox
            // 
            this.VehicleTypeIDCmbBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.VehicleTypeIDCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VehicleTypeIDCmbBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.VehicleTypeIDCmbBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.VehicleTypeIDCmbBox.FormattingEnabled = true;
            this.VehicleTypeIDCmbBox.Location = new System.Drawing.Point(21, 29);
            this.VehicleTypeIDCmbBox.Name = "VehicleTypeIDCmbBox";
            this.VehicleTypeIDCmbBox.Size = new System.Drawing.Size(188, 26);
            this.VehicleTypeIDCmbBox.TabIndex = 0;
            this.VehicleTypeIDCmbBox.SelectedIndexChanged += new System.EventHandler(this.VehicleTypeIDCmbBox_SelectedIndexChanged);
            this.VehicleTypeIDCmbBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoTyping_KeyPress);
            // 
            // EndDatePnl
            // 
            this.EndDatePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.EndDatePnl.Location = new System.Drawing.Point(21, 433);
            this.EndDatePnl.Name = "EndDatePnl";
            this.EndDatePnl.Size = new System.Drawing.Size(120, 2);
            this.EndDatePnl.TabIndex = 63;
            // 
            // EndDateLbl
            // 
            this.EndDateLbl.AutoSize = true;
            this.EndDateLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.EndDateLbl.Location = new System.Drawing.Point(18, 393);
            this.EndDateLbl.Name = "EndDateLbl";
            this.EndDateLbl.Size = new System.Drawing.Size(53, 15);
            this.EndDateLbl.TabIndex = 61;
            this.EndDateLbl.Text = "End date";
            // 
            // EndDateErrLbl
            // 
            this.EndDateErrLbl.AutoSize = true;
            this.EndDateErrLbl.BackColor = System.Drawing.Color.Transparent;
            this.EndDateErrLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateErrLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.EndDateErrLbl.Location = new System.Drawing.Point(18, 438);
            this.EndDateErrLbl.Name = "EndDateErrLbl";
            this.EndDateErrLbl.Size = new System.Drawing.Size(9, 13);
            this.EndDateErrLbl.TabIndex = 62;
            this.EndDateErrLbl.Text = " ";
            // 
            // StartDatePnl
            // 
            this.StartDatePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.StartDatePnl.Location = new System.Drawing.Point(21, 363);
            this.StartDatePnl.Name = "StartDatePnl";
            this.StartDatePnl.Size = new System.Drawing.Size(120, 2);
            this.StartDatePnl.TabIndex = 59;
            // 
            // StartDateLbl
            // 
            this.StartDateLbl.AutoSize = true;
            this.StartDateLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.StartDateLbl.Location = new System.Drawing.Point(18, 323);
            this.StartDateLbl.Name = "StartDateLbl";
            this.StartDateLbl.Size = new System.Drawing.Size(58, 15);
            this.StartDateLbl.TabIndex = 57;
            this.StartDateLbl.Text = "Start date";
            // 
            // StartDateErrLbl
            // 
            this.StartDateErrLbl.AutoSize = true;
            this.StartDateErrLbl.BackColor = System.Drawing.Color.Transparent;
            this.StartDateErrLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateErrLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.StartDateErrLbl.Location = new System.Drawing.Point(18, 368);
            this.StartDateErrLbl.Name = "StartDateErrLbl";
            this.StartDateErrLbl.Size = new System.Drawing.Size(9, 13);
            this.StartDateErrLbl.TabIndex = 58;
            this.StartDateErrLbl.Text = " ";
            // 
            // CustomerIDPnl
            // 
            this.CustomerIDPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.CustomerIDPnl.Location = new System.Drawing.Point(21, 290);
            this.CustomerIDPnl.Name = "CustomerIDPnl";
            this.CustomerIDPnl.Size = new System.Drawing.Size(188, 2);
            this.CustomerIDPnl.TabIndex = 55;
            // 
            // CustomerIDLbl
            // 
            this.CustomerIDLbl.AutoSize = true;
            this.CustomerIDLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.CustomerIDLbl.Location = new System.Drawing.Point(18, 250);
            this.CustomerIDLbl.Name = "CustomerIDLbl";
            this.CustomerIDLbl.Size = new System.Drawing.Size(72, 15);
            this.CustomerIDLbl.TabIndex = 53;
            this.CustomerIDLbl.Text = "Customer ID";
            // 
            // CustomerIDErrLbl
            // 
            this.CustomerIDErrLbl.AutoSize = true;
            this.CustomerIDErrLbl.BackColor = System.Drawing.Color.Transparent;
            this.CustomerIDErrLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDErrLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.CustomerIDErrLbl.Location = new System.Drawing.Point(18, 295);
            this.CustomerIDErrLbl.Name = "CustomerIDErrLbl";
            this.CustomerIDErrLbl.Size = new System.Drawing.Size(9, 13);
            this.CustomerIDErrLbl.TabIndex = 54;
            this.CustomerIDErrLbl.Text = " ";
            // 
            // DriverIDPnl
            // 
            this.DriverIDPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.DriverIDPnl.Location = new System.Drawing.Point(21, 221);
            this.DriverIDPnl.Name = "DriverIDPnl";
            this.DriverIDPnl.Size = new System.Drawing.Size(188, 2);
            this.DriverIDPnl.TabIndex = 51;
            // 
            // DriverIDLbl
            // 
            this.DriverIDLbl.AutoSize = true;
            this.DriverIDLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverIDLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.DriverIDLbl.Location = new System.Drawing.Point(18, 181);
            this.DriverIDLbl.Name = "DriverIDLbl";
            this.DriverIDLbl.Size = new System.Drawing.Size(54, 15);
            this.DriverIDLbl.TabIndex = 49;
            this.DriverIDLbl.Text = "Driver ID";
            // 
            // DriverIDErrLbl
            // 
            this.DriverIDErrLbl.AutoSize = true;
            this.DriverIDErrLbl.BackColor = System.Drawing.Color.Transparent;
            this.DriverIDErrLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverIDErrLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DriverIDErrLbl.Location = new System.Drawing.Point(18, 225);
            this.DriverIDErrLbl.Name = "DriverIDErrLbl";
            this.DriverIDErrLbl.Size = new System.Drawing.Size(9, 13);
            this.DriverIDErrLbl.TabIndex = 50;
            this.DriverIDErrLbl.Text = " ";
            // 
            // VehicleTypeIDPnl
            // 
            this.VehicleTypeIDPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.VehicleTypeIDPnl.Location = new System.Drawing.Point(21, 55);
            this.VehicleTypeIDPnl.Name = "VehicleTypeIDPnl";
            this.VehicleTypeIDPnl.Size = new System.Drawing.Size(188, 2);
            this.VehicleTypeIDPnl.TabIndex = 40;
            // 
            // VehicleTypeIDLbl
            // 
            this.VehicleTypeIDLbl.AutoSize = true;
            this.VehicleTypeIDLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleTypeIDLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.VehicleTypeIDLbl.Location = new System.Drawing.Point(18, 15);
            this.VehicleTypeIDLbl.Name = "VehicleTypeIDLbl";
            this.VehicleTypeIDLbl.Size = new System.Drawing.Size(84, 15);
            this.VehicleTypeIDLbl.TabIndex = 33;
            this.VehicleTypeIDLbl.Text = "Vehicle type ID";
            // 
            // VehicleTypeIDErrLbl
            // 
            this.VehicleTypeIDErrLbl.AutoSize = true;
            this.VehicleTypeIDErrLbl.BackColor = System.Drawing.Color.Transparent;
            this.VehicleTypeIDErrLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleTypeIDErrLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.VehicleTypeIDErrLbl.Location = new System.Drawing.Point(18, 60);
            this.VehicleTypeIDErrLbl.Name = "VehicleTypeIDErrLbl";
            this.VehicleTypeIDErrLbl.Size = new System.Drawing.Size(9, 13);
            this.VehicleTypeIDErrLbl.TabIndex = 34;
            this.VehicleTypeIDErrLbl.Text = " ";
            // 
            // TableViewRBtn
            // 
            this.TableViewRBtn.AutoSize = true;
            this.TableViewRBtn.Checked = true;
            this.TableViewRBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.TableViewRBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableViewRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.TableViewRBtn.Location = new System.Drawing.Point(16, 8);
            this.TableViewRBtn.Name = "TableViewRBtn";
            this.TableViewRBtn.Size = new System.Drawing.Size(76, 17);
            this.TableViewRBtn.TabIndex = 21;
            this.TableViewRBtn.TabStop = true;
            this.TableViewRBtn.Text = "Table view";
            this.TableViewRBtn.UseVisualStyleBackColor = true;
            this.TableViewRBtn.CheckedChanged += new System.EventHandler(this.TableViewRBtn_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.BothViewRBtn);
            this.panel1.Controls.Add(this.TableViewRBtn);
            this.panel1.Location = new System.Drawing.Point(558, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 34);
            this.panel1.TabIndex = 72;
            // 
            // BothViewRBtn
            // 
            this.BothViewRBtn.AutoSize = true;
            this.BothViewRBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.BothViewRBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BothViewRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.BothViewRBtn.Location = new System.Drawing.Point(102, 8);
            this.BothViewRBtn.Name = "BothViewRBtn";
            this.BothViewRBtn.Size = new System.Drawing.Size(134, 17);
            this.BothViewRBtn.TabIndex = 22;
            this.BothViewRBtn.Text = "Table and vehicle view";
            this.BothViewRBtn.UseVisualStyleBackColor = true;
            this.BothViewRBtn.CheckedChanged += new System.EventHandler(this.BothViewRBtn_CheckedChanged);
            // 
            // VehiclePnl
            // 
            this.VehiclePnl.AutoScroll = true;
            this.VehiclePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.VehiclePnl.Location = new System.Drawing.Point(12, 285);
            this.VehiclePnl.Name = "VehiclePnl";
            this.VehiclePnl.Size = new System.Drawing.Size(540, 203);
            this.VehiclePnl.TabIndex = 58;
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.InsertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.InsertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.Location = new System.Drawing.Point(163, 12);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(76, 100);
            this.InsertBtn.TabIndex = 5;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(199)))), ((int)(((byte)(151)))));
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(199)))), ((int)(((byte)(151)))));
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(14, 12);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(138, 45);
            this.UpdateBtn.TabIndex = 6;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DeleteBtn.Location = new System.Drawing.Point(14, 67);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(138, 45);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            this.DeleteBtn.MouseEnter += new System.EventHandler(this.DeleteBtn_MouseEnter);
            this.DeleteBtn.MouseLeave += new System.EventHandler(this.DeleteBtn_MouseLeave);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.ButtonsPanel.Controls.Add(this.DeleteBtn);
            this.ButtonsPanel.Controls.Add(this.UpdateBtn);
            this.ButtonsPanel.Controls.Add(this.InsertBtn);
            this.ButtonsPanel.Location = new System.Drawing.Point(558, 365);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(250, 123);
            this.ButtonsPanel.TabIndex = 60;
            // 
            // RentalBookingManagementFormV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(820, 500);
            this.Controls.Add(this.TablePnl);
            this.Controls.Add(this.VehiclePnl);
            this.Controls.Add(this.ManipulationPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.TitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RentalBookingManagementFormV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentalBookingManagementFormV2";
            this.Load += new System.EventHandler(this.RentalBookingManagementFormV2_Load);
            this.ManipulationPanel.ResumeLayout(false);
            this.ManipulationPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel TablePnl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Panel ManipulationPanel;
        private System.Windows.Forms.Panel VehicleIDPnl;
        private System.Windows.Forms.Label VehicleIDLbl;
        private System.Windows.Forms.Label VehicleIDErrLbl;
        private System.Windows.Forms.ComboBox VehicleTypeIDCmbBox;
        private System.Windows.Forms.Panel EndDatePnl;
        private System.Windows.Forms.Label EndDateLbl;
        private System.Windows.Forms.Label EndDateErrLbl;
        private System.Windows.Forms.Panel StartDatePnl;
        private System.Windows.Forms.Label StartDateLbl;
        private System.Windows.Forms.Label StartDateErrLbl;
        private System.Windows.Forms.Panel CustomerIDPnl;
        private System.Windows.Forms.Label CustomerIDLbl;
        private System.Windows.Forms.Label CustomerIDErrLbl;
        private System.Windows.Forms.Panel DriverIDPnl;
        private System.Windows.Forms.Label DriverIDLbl;
        private System.Windows.Forms.Label DriverIDErrLbl;
        private System.Windows.Forms.Panel VehicleTypeIDPnl;
        private System.Windows.Forms.Label VehicleTypeIDLbl;
        private System.Windows.Forms.Label VehicleTypeIDErrLbl;
        private System.Windows.Forms.RadioButton TableViewRBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel VehiclePnl;
        private System.Windows.Forms.DateTimePicker EndDateDTP;
        private System.Windows.Forms.DateTimePicker StartDateDTP;
        private System.Windows.Forms.ComboBox CustomerIDCmbBox;
        private System.Windows.Forms.ComboBox DriverIDCmbBox;
        private System.Windows.Forms.ComboBox VehicleIDCmbBox;
        private System.Windows.Forms.RadioButton BothViewRBtn;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.CheckBox DriverCheckBox;
        private System.Windows.Forms.Label label7;
        private CustomButton InsertBtn;
        private CustomButton UpdateBtn;
        private CustomButton DeleteBtn;
    }
}