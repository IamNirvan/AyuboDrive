using AyuboDrive.Utility;

namespace AyuboDrive.Forms
{
    partial class HireManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HireManagementForm));
            this.AvailableVehiclesRBtn = new System.Windows.Forms.RadioButton();
            this.TableViewRBtn = new System.Windows.Forms.RadioButton();
            this.VehiclePnl = new System.Windows.Forms.Panel();
            this.InsertBtn = new AyuboDrive.Utility.CustomButton();
            this.label3 = new System.Windows.Forms.Label();
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
            this.DeleteBtn = new AyuboDrive.Utility.CustomButton();
            this.UpdateBtn = new AyuboDrive.Utility.CustomButton();
            this.ViewControlPnl = new System.Windows.Forms.Panel();
            this.DayTourRBtn = new System.Windows.Forms.RadioButton();
            this.LongTourRBtn = new System.Windows.Forms.RadioButton();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.StartDatePnl = new System.Windows.Forms.Panel();
            this.StartDateLbl = new System.Windows.Forms.Label();
            this.StartDateErrLbl = new System.Windows.Forms.Label();
            this.CustomerIDPnl = new System.Windows.Forms.Panel();
            this.CustomerIDLbl = new System.Windows.Forms.Label();
            this.DriverIDPnl = new System.Windows.Forms.Panel();
            this.DriverIDLbl = new System.Windows.Forms.Label();
            this.DriverIDErrLbl = new System.Windows.Forms.Label();
            this.VehicleTypeIDPnl = new System.Windows.Forms.Panel();
            this.VehicleTypeIDLbl = new System.Windows.Forms.Label();
            this.VehicleTypeIDErrLbl = new System.Windows.Forms.Label();
            this.ManipulationPanel = new System.Windows.Forms.Panel();
            this.PackageIDCmbBox = new System.Windows.Forms.ComboBox();
            this.PackageIDPnl = new System.Windows.Forms.Panel();
            this.PackageIDLbl = new System.Windows.Forms.Label();
            this.PackageIDErrLbl = new System.Windows.Forms.Label();
            this.CustomerIDErrLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.TablePnl = new System.Windows.Forms.Panel();
            this.TableControlPnl = new System.Windows.Forms.Panel();
            this.ViewControlPnl.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.ManipulationPanel.SuspendLayout();
            this.TableControlPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // AvailableVehiclesRBtn
            // 
            this.AvailableVehiclesRBtn.AutoSize = true;
            this.AvailableVehiclesRBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.AvailableVehiclesRBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvailableVehiclesRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.AvailableVehiclesRBtn.Location = new System.Drawing.Point(102, 10);
            this.AvailableVehiclesRBtn.Name = "AvailableVehiclesRBtn";
            this.AvailableVehiclesRBtn.Size = new System.Drawing.Size(138, 17);
            this.AvailableVehiclesRBtn.TabIndex = 22;
            this.AvailableVehiclesRBtn.Text = "Show available vehicles";
            this.AvailableVehiclesRBtn.UseVisualStyleBackColor = true;
            this.AvailableVehiclesRBtn.CheckedChanged += new System.EventHandler(this.AvailableVehiclesRBtn_CheckedChanged);
            // 
            // TableViewRBtn
            // 
            this.TableViewRBtn.AutoSize = true;
            this.TableViewRBtn.Checked = true;
            this.TableViewRBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.TableViewRBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableViewRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.TableViewRBtn.Location = new System.Drawing.Point(18, 10);
            this.TableViewRBtn.Name = "TableViewRBtn";
            this.TableViewRBtn.Size = new System.Drawing.Size(76, 17);
            this.TableViewRBtn.TabIndex = 21;
            this.TableViewRBtn.TabStop = true;
            this.TableViewRBtn.Text = "Table view";
            this.TableViewRBtn.UseVisualStyleBackColor = true;
            this.TableViewRBtn.CheckedChanged += new System.EventHandler(this.TableViewRBtn_CheckedChanged);
            // 
            // VehiclePnl
            // 
            this.VehiclePnl.AutoScroll = true;
            this.VehiclePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.VehiclePnl.Location = new System.Drawing.Point(12, 285);
            this.VehiclePnl.Name = "VehiclePnl";
            this.VehiclePnl.Size = new System.Drawing.Size(620, 203);
            this.VehiclePnl.TabIndex = 77;
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(67)))), ((int)(((byte)(214)))));
            this.InsertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(67)))), ((int)(((byte)(214)))));
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.label3.Location = new System.Drawing.Point(220, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 15);
            this.label3.TabIndex = 123;
            this.label3.Text = " ";
            // 
            // EndDateDTP
            // 
            this.EndDateDTP.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.EndDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDateDTP.Location = new System.Drawing.Point(21, 453);
            this.EndDateDTP.Name = "EndDateDTP";
            this.EndDateDTP.Size = new System.Drawing.Size(120, 26);
            this.EndDateDTP.TabIndex = 118;
            // 
            // StartDateDTP
            // 
            this.StartDateDTP.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.StartDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDateDTP.Location = new System.Drawing.Point(21, 383);
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
            this.CustomerIDCmbBox.Location = new System.Drawing.Point(21, 243);
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
            this.DriverIDCmbBox.Location = new System.Drawing.Point(21, 174);
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
            this.VehicleIDCmbBox.Location = new System.Drawing.Point(21, 103);
            this.VehicleIDCmbBox.Name = "VehicleIDCmbBox";
            this.VehicleIDCmbBox.Size = new System.Drawing.Size(188, 26);
            this.VehicleIDCmbBox.TabIndex = 114;
            this.VehicleIDCmbBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoTyping_KeyPress);
            // 
            // VehicleIDPnl
            // 
            this.VehicleIDPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(67)))), ((int)(((byte)(214)))));
            this.VehicleIDPnl.Location = new System.Drawing.Point(21, 130);
            this.VehicleIDPnl.Name = "VehicleIDPnl";
            this.VehicleIDPnl.Size = new System.Drawing.Size(188, 1);
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
            this.VehicleIDErrLbl.Location = new System.Drawing.Point(18, 135);
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
            this.VehicleTypeIDCmbBox.Location = new System.Drawing.Point(21, 33);
            this.VehicleTypeIDCmbBox.Name = "VehicleTypeIDCmbBox";
            this.VehicleTypeIDCmbBox.Size = new System.Drawing.Size(188, 26);
            this.VehicleTypeIDCmbBox.TabIndex = 0;
            this.VehicleTypeIDCmbBox.SelectedIndexChanged += new System.EventHandler(this.VehicleTypeIDCmbBox_SelectedIndexChanged);
            this.VehicleTypeIDCmbBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoTyping_KeyPress);
            // 
            // EndDatePnl
            // 
            this.EndDatePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(67)))), ((int)(((byte)(214)))));
            this.EndDatePnl.Location = new System.Drawing.Point(21, 480);
            this.EndDatePnl.Name = "EndDatePnl";
            this.EndDatePnl.Size = new System.Drawing.Size(120, 1);
            this.EndDatePnl.TabIndex = 63;
            // 
            // EndDateLbl
            // 
            this.EndDateLbl.AutoSize = true;
            this.EndDateLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.EndDateLbl.Location = new System.Drawing.Point(18, 435);
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
            this.EndDateErrLbl.Location = new System.Drawing.Point(18, 481);
            this.EndDateErrLbl.Name = "EndDateErrLbl";
            this.EndDateErrLbl.Size = new System.Drawing.Size(9, 13);
            this.EndDateErrLbl.TabIndex = 62;
            this.EndDateErrLbl.Text = " ";
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
            // ViewControlPnl
            // 
            this.ViewControlPnl.AutoScroll = true;
            this.ViewControlPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.ViewControlPnl.Controls.Add(this.AvailableVehiclesRBtn);
            this.ViewControlPnl.Controls.Add(this.TableViewRBtn);
            this.ViewControlPnl.Location = new System.Drawing.Point(638, 36);
            this.ViewControlPnl.Name = "ViewControlPnl";
            this.ViewControlPnl.Size = new System.Drawing.Size(250, 37);
            this.ViewControlPnl.TabIndex = 80;
            // 
            // DayTourRBtn
            // 
            this.DayTourRBtn.AutoSize = true;
            this.DayTourRBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.DayTourRBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DayTourRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.DayTourRBtn.Location = new System.Drawing.Point(104, 9);
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
            this.LongTourRBtn.Location = new System.Drawing.Point(18, 9);
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
            this.ButtonsPanel.Controls.Add(this.DeleteBtn);
            this.ButtonsPanel.Controls.Add(this.UpdateBtn);
            this.ButtonsPanel.Controls.Add(this.InsertBtn);
            this.ButtonsPanel.Location = new System.Drawing.Point(638, 365);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(250, 123);
            this.ButtonsPanel.TabIndex = 79;
            // 
            // StartDatePnl
            // 
            this.StartDatePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(67)))), ((int)(((byte)(214)))));
            this.StartDatePnl.Location = new System.Drawing.Point(21, 410);
            this.StartDatePnl.Name = "StartDatePnl";
            this.StartDatePnl.Size = new System.Drawing.Size(120, 1);
            this.StartDatePnl.TabIndex = 59;
            // 
            // StartDateLbl
            // 
            this.StartDateLbl.AutoSize = true;
            this.StartDateLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.StartDateLbl.Location = new System.Drawing.Point(18, 365);
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
            this.StartDateErrLbl.Location = new System.Drawing.Point(18, 415);
            this.StartDateErrLbl.Name = "StartDateErrLbl";
            this.StartDateErrLbl.Size = new System.Drawing.Size(9, 13);
            this.StartDateErrLbl.TabIndex = 58;
            this.StartDateErrLbl.Text = " ";
            // 
            // CustomerIDPnl
            // 
            this.CustomerIDPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(67)))), ((int)(((byte)(214)))));
            this.CustomerIDPnl.Location = new System.Drawing.Point(21, 270);
            this.CustomerIDPnl.Name = "CustomerIDPnl";
            this.CustomerIDPnl.Size = new System.Drawing.Size(188, 1);
            this.CustomerIDPnl.TabIndex = 55;
            // 
            // CustomerIDLbl
            // 
            this.CustomerIDLbl.AutoSize = true;
            this.CustomerIDLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.CustomerIDLbl.Location = new System.Drawing.Point(18, 225);
            this.CustomerIDLbl.Name = "CustomerIDLbl";
            this.CustomerIDLbl.Size = new System.Drawing.Size(72, 15);
            this.CustomerIDLbl.TabIndex = 53;
            this.CustomerIDLbl.Text = "Customer ID";
            // 
            // DriverIDPnl
            // 
            this.DriverIDPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(67)))), ((int)(((byte)(214)))));
            this.DriverIDPnl.Location = new System.Drawing.Point(21, 201);
            this.DriverIDPnl.Name = "DriverIDPnl";
            this.DriverIDPnl.Size = new System.Drawing.Size(188, 1);
            this.DriverIDPnl.TabIndex = 51;
            // 
            // DriverIDLbl
            // 
            this.DriverIDLbl.AutoSize = true;
            this.DriverIDLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverIDLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.DriverIDLbl.Location = new System.Drawing.Point(18, 156);
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
            this.DriverIDErrLbl.Location = new System.Drawing.Point(18, 206);
            this.DriverIDErrLbl.Name = "DriverIDErrLbl";
            this.DriverIDErrLbl.Size = new System.Drawing.Size(9, 13);
            this.DriverIDErrLbl.TabIndex = 50;
            this.DriverIDErrLbl.Text = " ";
            // 
            // VehicleTypeIDPnl
            // 
            this.VehicleTypeIDPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(67)))), ((int)(((byte)(214)))));
            this.VehicleTypeIDPnl.Location = new System.Drawing.Point(21, 60);
            this.VehicleTypeIDPnl.Name = "VehicleTypeIDPnl";
            this.VehicleTypeIDPnl.Size = new System.Drawing.Size(188, 1);
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
            this.VehicleTypeIDErrLbl.Location = new System.Drawing.Point(18, 65);
            this.VehicleTypeIDErrLbl.Name = "VehicleTypeIDErrLbl";
            this.VehicleTypeIDErrLbl.Size = new System.Drawing.Size(9, 13);
            this.VehicleTypeIDErrLbl.TabIndex = 34;
            this.VehicleTypeIDErrLbl.Text = " ";
            // 
            // ManipulationPanel
            // 
            this.ManipulationPanel.AutoScroll = true;
            this.ManipulationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.ManipulationPanel.Controls.Add(this.PackageIDCmbBox);
            this.ManipulationPanel.Controls.Add(this.PackageIDPnl);
            this.ManipulationPanel.Controls.Add(this.PackageIDLbl);
            this.ManipulationPanel.Controls.Add(this.PackageIDErrLbl);
            this.ManipulationPanel.Controls.Add(this.label3);
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
            this.ManipulationPanel.Location = new System.Drawing.Point(638, 116);
            this.ManipulationPanel.Name = "ManipulationPanel";
            this.ManipulationPanel.Size = new System.Drawing.Size(250, 243);
            this.ManipulationPanel.TabIndex = 81;
            // 
            // PackageIDCmbBox
            // 
            this.PackageIDCmbBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.PackageIDCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PackageIDCmbBox.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.PackageIDCmbBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PackageIDCmbBox.FormattingEnabled = true;
            this.PackageIDCmbBox.Location = new System.Drawing.Point(21, 313);
            this.PackageIDCmbBox.Name = "PackageIDCmbBox";
            this.PackageIDCmbBox.Size = new System.Drawing.Size(188, 26);
            this.PackageIDCmbBox.TabIndex = 128;
            this.PackageIDCmbBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoTyping_KeyPress);
            // 
            // PackageIDPnl
            // 
            this.PackageIDPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(67)))), ((int)(((byte)(214)))));
            this.PackageIDPnl.Location = new System.Drawing.Point(21, 340);
            this.PackageIDPnl.Name = "PackageIDPnl";
            this.PackageIDPnl.Size = new System.Drawing.Size(188, 1);
            this.PackageIDPnl.TabIndex = 127;
            // 
            // PackageIDLbl
            // 
            this.PackageIDLbl.AutoSize = true;
            this.PackageIDLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackageIDLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.PackageIDLbl.Location = new System.Drawing.Point(18, 295);
            this.PackageIDLbl.Name = "PackageIDLbl";
            this.PackageIDLbl.Size = new System.Drawing.Size(64, 15);
            this.PackageIDLbl.TabIndex = 125;
            this.PackageIDLbl.Text = "Package ID";
            // 
            // PackageIDErrLbl
            // 
            this.PackageIDErrLbl.AutoSize = true;
            this.PackageIDErrLbl.BackColor = System.Drawing.Color.Transparent;
            this.PackageIDErrLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackageIDErrLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.PackageIDErrLbl.Location = new System.Drawing.Point(18, 343);
            this.PackageIDErrLbl.Name = "PackageIDErrLbl";
            this.PackageIDErrLbl.Size = new System.Drawing.Size(9, 13);
            this.PackageIDErrLbl.TabIndex = 126;
            this.PackageIDErrLbl.Text = " ";
            // 
            // CustomerIDErrLbl
            // 
            this.CustomerIDErrLbl.AutoSize = true;
            this.CustomerIDErrLbl.BackColor = System.Drawing.Color.Transparent;
            this.CustomerIDErrLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDErrLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.CustomerIDErrLbl.Location = new System.Drawing.Point(18, 275);
            this.CustomerIDErrLbl.Name = "CustomerIDErrLbl";
            this.CustomerIDErrLbl.Size = new System.Drawing.Size(9, 13);
            this.CustomerIDErrLbl.TabIndex = 54;
            this.CustomerIDErrLbl.Text = " ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(900, 30);
            this.flowLayoutPanel1.TabIndex = 78;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Carlito", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.TitleLbl.Location = new System.Drawing.Point(12, 34);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(365, 39);
            this.TitleLbl.TabIndex = 75;
            this.TitleLbl.Text = "Hire Booking Management";
            // 
            // TablePnl
            // 
            this.TablePnl.AutoScroll = true;
            this.TablePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.TablePnl.Location = new System.Drawing.Point(12, 79);
            this.TablePnl.Name = "TablePnl";
            this.TablePnl.Size = new System.Drawing.Size(620, 409);
            this.TablePnl.TabIndex = 76;
            // 
            // TableControlPnl
            // 
            this.TableControlPnl.AutoScroll = true;
            this.TableControlPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.TableControlPnl.Controls.Add(this.DayTourRBtn);
            this.TableControlPnl.Controls.Add(this.LongTourRBtn);
            this.TableControlPnl.Location = new System.Drawing.Point(638, 73);
            this.TableControlPnl.Name = "TableControlPnl";
            this.TableControlPnl.Size = new System.Drawing.Size(250, 37);
            this.TableControlPnl.TabIndex = 81;
            // 
            // HireManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.TableControlPnl);
            this.Controls.Add(this.TablePnl);
            this.Controls.Add(this.VehiclePnl);
            this.Controls.Add(this.ViewControlPnl);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.ManipulationPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.TitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HireManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HireManagement";
            this.ViewControlPnl.ResumeLayout(false);
            this.ViewControlPnl.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.ManipulationPanel.ResumeLayout(false);
            this.ManipulationPanel.PerformLayout();
            this.TableControlPnl.ResumeLayout(false);
            this.TableControlPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton AvailableVehiclesRBtn;
        private System.Windows.Forms.RadioButton TableViewRBtn;
        private System.Windows.Forms.Panel VehiclePnl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker EndDateDTP;
        private System.Windows.Forms.DateTimePicker StartDateDTP;
        private System.Windows.Forms.ComboBox CustomerIDCmbBox;
        private System.Windows.Forms.ComboBox DriverIDCmbBox;
        private System.Windows.Forms.ComboBox VehicleIDCmbBox;
        private System.Windows.Forms.Panel VehicleIDPnl;
        private System.Windows.Forms.Label VehicleIDLbl;
        private System.Windows.Forms.Label VehicleIDErrLbl;
        private System.Windows.Forms.ComboBox VehicleTypeIDCmbBox;
        private System.Windows.Forms.Panel EndDatePnl;
        private System.Windows.Forms.Label EndDateLbl;
        private System.Windows.Forms.Label EndDateErrLbl;
        private System.Windows.Forms.Panel ViewControlPnl;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Panel StartDatePnl;
        private System.Windows.Forms.Label StartDateLbl;
        private System.Windows.Forms.Label StartDateErrLbl;
        private System.Windows.Forms.Panel CustomerIDPnl;
        private System.Windows.Forms.Label CustomerIDLbl;
        private System.Windows.Forms.Panel DriverIDPnl;
        private System.Windows.Forms.Label DriverIDLbl;
        private System.Windows.Forms.Label DriverIDErrLbl;
        private System.Windows.Forms.Panel VehicleTypeIDPnl;
        private System.Windows.Forms.Label VehicleTypeIDLbl;
        private System.Windows.Forms.Label VehicleTypeIDErrLbl;
        private System.Windows.Forms.Panel ManipulationPanel;
        private System.Windows.Forms.Label CustomerIDErrLbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Panel TablePnl;
        private System.Windows.Forms.Panel TableControlPnl;
        private System.Windows.Forms.RadioButton DayTourRBtn;
        private System.Windows.Forms.RadioButton LongTourRBtn;
        private System.Windows.Forms.ComboBox PackageIDCmbBox;
        private System.Windows.Forms.Panel PackageIDPnl;
        private System.Windows.Forms.Label PackageIDLbl;
        private System.Windows.Forms.Label PackageIDErrLbl;
        private CustomButton InsertBtn;
        private CustomButton DeleteBtn;
        private CustomButton UpdateBtn;
    }
}