﻿namespace AyuboDrive.Forms
{
    partial class PackageTypeManagementForm
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
            this.PackageNamePnl = new System.Windows.Forms.Panel();
            this.PackageNameLbl = new System.Windows.Forms.Label();
            this.PackageNameErrorLbl = new System.Windows.Forms.Label();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ManipulationPanel = new System.Windows.Forms.Panel();
            this.ExtraKmRateTxtBox = new System.Windows.Forms.TextBox();
            this.ExtraKmRatePnl = new System.Windows.Forms.Panel();
            this.ExtraKmRateLbl = new System.Windows.Forms.Label();
            this.ExtraKmRateErrorLbl = new System.Windows.Forms.Label();
            this.ExtraHourRateTxtBox = new System.Windows.Forms.TextBox();
            this.ExtraHourRatePnl = new System.Windows.Forms.Panel();
            this.ExtraHourRateLbl = new System.Windows.Forms.Label();
            this.ExtraHourRateErrorLbl = new System.Windows.Forms.Label();
            this.MaxKmTxtBox = new System.Windows.Forms.TextBox();
            this.MaxKmPnl = new System.Windows.Forms.Panel();
            this.MaxKmLbl = new System.Windows.Forms.Label();
            this.MaxKmErrorLbl = new System.Windows.Forms.Label();
            this.MaxHourTxtBox = new System.Windows.Forms.TextBox();
            this.MaxHourPnl = new System.Windows.Forms.Panel();
            this.MaxHourLbl = new System.Windows.Forms.Label();
            this.MaxHourErrorLbl = new System.Windows.Forms.Label();
            this.PackageNameTxtBox = new System.Windows.Forms.TextBox();
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
            this.TablePanel.Size = new System.Drawing.Size(523, 384);
            this.TablePanel.TabIndex = 62;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 30);
            this.flowLayoutPanel1.TabIndex = 63;
            // 
            // PackageNamePnl
            // 
            this.PackageNamePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.PackageNamePnl.Location = new System.Drawing.Point(23, 57);
            this.PackageNamePnl.Name = "PackageNamePnl";
            this.PackageNamePnl.Size = new System.Drawing.Size(188, 2);
            this.PackageNamePnl.TabIndex = 40;
            // 
            // PackageNameLbl
            // 
            this.PackageNameLbl.AutoSize = true;
            this.PackageNameLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackageNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.PackageNameLbl.Location = new System.Drawing.Point(20, 17);
            this.PackageNameLbl.Name = "PackageNameLbl";
            this.PackageNameLbl.Size = new System.Drawing.Size(82, 15);
            this.PackageNameLbl.TabIndex = 33;
            this.PackageNameLbl.Text = "Package name";
            // 
            // PackageNameErrorLbl
            // 
            this.PackageNameErrorLbl.AutoSize = true;
            this.PackageNameErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.PackageNameErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackageNameErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.PackageNameErrorLbl.Location = new System.Drawing.Point(20, 62);
            this.PackageNameErrorLbl.Name = "PackageNameErrorLbl";
            this.PackageNameErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.PackageNameErrorLbl.TabIndex = 34;
            this.PackageNameErrorLbl.Text = " ";
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
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.ButtonsPanel.Controls.Add(this.DeleteBtn);
            this.ButtonsPanel.Controls.Add(this.UpdateBtn);
            this.ButtonsPanel.Controls.Add(this.InsertBtn);
            this.ButtonsPanel.Location = new System.Drawing.Point(538, 337);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(250, 123);
            this.ButtonsPanel.TabIndex = 65;
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
            this.ManipulationPanel.Controls.Add(this.ExtraKmRateTxtBox);
            this.ManipulationPanel.Controls.Add(this.ExtraKmRatePnl);
            this.ManipulationPanel.Controls.Add(this.ExtraKmRateLbl);
            this.ManipulationPanel.Controls.Add(this.ExtraKmRateErrorLbl);
            this.ManipulationPanel.Controls.Add(this.ExtraHourRateTxtBox);
            this.ManipulationPanel.Controls.Add(this.ExtraHourRatePnl);
            this.ManipulationPanel.Controls.Add(this.ExtraHourRateLbl);
            this.ManipulationPanel.Controls.Add(this.ExtraHourRateErrorLbl);
            this.ManipulationPanel.Controls.Add(this.MaxKmTxtBox);
            this.ManipulationPanel.Controls.Add(this.MaxKmPnl);
            this.ManipulationPanel.Controls.Add(this.MaxKmLbl);
            this.ManipulationPanel.Controls.Add(this.MaxKmErrorLbl);
            this.ManipulationPanel.Controls.Add(this.MaxHourTxtBox);
            this.ManipulationPanel.Controls.Add(this.MaxHourPnl);
            this.ManipulationPanel.Controls.Add(this.MaxHourLbl);
            this.ManipulationPanel.Controls.Add(this.MaxHourErrorLbl);
            this.ManipulationPanel.Controls.Add(this.PackageNameTxtBox);
            this.ManipulationPanel.Controls.Add(this.PackageNamePnl);
            this.ManipulationPanel.Controls.Add(this.PackageNameLbl);
            this.ManipulationPanel.Controls.Add(this.PackageNameErrorLbl);
            this.ManipulationPanel.Location = new System.Drawing.Point(538, 76);
            this.ManipulationPanel.Name = "ManipulationPanel";
            this.ManipulationPanel.Size = new System.Drawing.Size(250, 255);
            this.ManipulationPanel.TabIndex = 64;
            // 
            // ExtraKmRateTxtBox
            // 
            this.ExtraKmRateTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.ExtraKmRateTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExtraKmRateTxtBox.Font = new System.Drawing.Font("Carlito", 9.75F);
            this.ExtraKmRateTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.ExtraKmRateTxtBox.Location = new System.Drawing.Point(23, 319);
            this.ExtraKmRateTxtBox.Name = "ExtraKmRateTxtBox";
            this.ExtraKmRateTxtBox.Size = new System.Drawing.Size(188, 16);
            this.ExtraKmRateTxtBox.TabIndex = 64;
            this.ExtraKmRateTxtBox.Enter += new System.EventHandler(this.ExtraKmRateTxtBox_Enter);
            this.ExtraKmRateTxtBox.Leave += new System.EventHandler(this.ExtraKmRateTxtBox_Leave);
            // 
            // ExtraKmRatePnl
            // 
            this.ExtraKmRatePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.ExtraKmRatePnl.Location = new System.Drawing.Point(23, 336);
            this.ExtraKmRatePnl.Name = "ExtraKmRatePnl";
            this.ExtraKmRatePnl.Size = new System.Drawing.Size(188, 2);
            this.ExtraKmRatePnl.TabIndex = 63;
            // 
            // ExtraKmRateLbl
            // 
            this.ExtraKmRateLbl.AutoSize = true;
            this.ExtraKmRateLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraKmRateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.ExtraKmRateLbl.Location = new System.Drawing.Point(20, 296);
            this.ExtraKmRateLbl.Name = "ExtraKmRateLbl";
            this.ExtraKmRateLbl.Size = new System.Drawing.Size(144, 15);
            this.ExtraKmRateLbl.TabIndex = 61;
            this.ExtraKmRateLbl.Text = "Extra Kilometre Rate (LKR)";
            // 
            // ExtraKmRateErrorLbl
            // 
            this.ExtraKmRateErrorLbl.AutoSize = true;
            this.ExtraKmRateErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.ExtraKmRateErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraKmRateErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ExtraKmRateErrorLbl.Location = new System.Drawing.Point(20, 341);
            this.ExtraKmRateErrorLbl.Name = "ExtraKmRateErrorLbl";
            this.ExtraKmRateErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.ExtraKmRateErrorLbl.TabIndex = 62;
            this.ExtraKmRateErrorLbl.Text = " ";
            // 
            // ExtraHourRateTxtBox
            // 
            this.ExtraHourRateTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.ExtraHourRateTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExtraHourRateTxtBox.Font = new System.Drawing.Font("Carlito", 9.75F);
            this.ExtraHourRateTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.ExtraHourRateTxtBox.Location = new System.Drawing.Point(23, 249);
            this.ExtraHourRateTxtBox.Name = "ExtraHourRateTxtBox";
            this.ExtraHourRateTxtBox.Size = new System.Drawing.Size(188, 16);
            this.ExtraHourRateTxtBox.TabIndex = 60;
            this.ExtraHourRateTxtBox.Enter += new System.EventHandler(this.ExtraHourRateTxtBox_Enter);
            this.ExtraHourRateTxtBox.Leave += new System.EventHandler(this.ExtraHourRateTxtBox_Leave);
            // 
            // ExtraHourRatePnl
            // 
            this.ExtraHourRatePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.ExtraHourRatePnl.Location = new System.Drawing.Point(23, 266);
            this.ExtraHourRatePnl.Name = "ExtraHourRatePnl";
            this.ExtraHourRatePnl.Size = new System.Drawing.Size(188, 2);
            this.ExtraHourRatePnl.TabIndex = 59;
            // 
            // ExtraHourRateLbl
            // 
            this.ExtraHourRateLbl.AutoSize = true;
            this.ExtraHourRateLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraHourRateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.ExtraHourRateLbl.Location = new System.Drawing.Point(20, 226);
            this.ExtraHourRateLbl.Name = "ExtraHourRateLbl";
            this.ExtraHourRateLbl.Size = new System.Drawing.Size(117, 15);
            this.ExtraHourRateLbl.TabIndex = 57;
            this.ExtraHourRateLbl.Text = "Extra hour rate (LKR)";
            // 
            // ExtraHourRateErrorLbl
            // 
            this.ExtraHourRateErrorLbl.AutoSize = true;
            this.ExtraHourRateErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.ExtraHourRateErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraHourRateErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ExtraHourRateErrorLbl.Location = new System.Drawing.Point(20, 271);
            this.ExtraHourRateErrorLbl.Name = "ExtraHourRateErrorLbl";
            this.ExtraHourRateErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.ExtraHourRateErrorLbl.TabIndex = 58;
            this.ExtraHourRateErrorLbl.Text = " ";
            // 
            // MaxKmTxtBox
            // 
            this.MaxKmTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.MaxKmTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaxKmTxtBox.Font = new System.Drawing.Font("Carlito", 9.75F);
            this.MaxKmTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.MaxKmTxtBox.Location = new System.Drawing.Point(23, 180);
            this.MaxKmTxtBox.Name = "MaxKmTxtBox";
            this.MaxKmTxtBox.Size = new System.Drawing.Size(188, 16);
            this.MaxKmTxtBox.TabIndex = 56;
            this.MaxKmTxtBox.Enter += new System.EventHandler(this.MaxKmTxtBox_Enter);
            this.MaxKmTxtBox.Leave += new System.EventHandler(this.MaxKmTxtBox_Leave);
            // 
            // MaxKmPnl
            // 
            this.MaxKmPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.MaxKmPnl.Location = new System.Drawing.Point(23, 197);
            this.MaxKmPnl.Name = "MaxKmPnl";
            this.MaxKmPnl.Size = new System.Drawing.Size(188, 2);
            this.MaxKmPnl.TabIndex = 55;
            // 
            // MaxKmLbl
            // 
            this.MaxKmLbl.AutoSize = true;
            this.MaxKmLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxKmLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.MaxKmLbl.Location = new System.Drawing.Point(20, 157);
            this.MaxKmLbl.Name = "MaxKmLbl";
            this.MaxKmLbl.Size = new System.Drawing.Size(114, 15);
            this.MaxKmLbl.TabIndex = 53;
            this.MaxKmLbl.Text = "Maximum Kilometre";
            // 
            // MaxKmErrorLbl
            // 
            this.MaxKmErrorLbl.AutoSize = true;
            this.MaxKmErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.MaxKmErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxKmErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.MaxKmErrorLbl.Location = new System.Drawing.Point(20, 202);
            this.MaxKmErrorLbl.Name = "MaxKmErrorLbl";
            this.MaxKmErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.MaxKmErrorLbl.TabIndex = 54;
            this.MaxKmErrorLbl.Text = " ";
            // 
            // MaxHourTxtBox
            // 
            this.MaxHourTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.MaxHourTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaxHourTxtBox.Font = new System.Drawing.Font("Carlito", 9.75F);
            this.MaxHourTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.MaxHourTxtBox.Location = new System.Drawing.Point(23, 111);
            this.MaxHourTxtBox.Name = "MaxHourTxtBox";
            this.MaxHourTxtBox.Size = new System.Drawing.Size(188, 16);
            this.MaxHourTxtBox.TabIndex = 52;
            this.MaxHourTxtBox.Enter += new System.EventHandler(this.MaxHourTxtBox_Enter);
            this.MaxHourTxtBox.Leave += new System.EventHandler(this.MaxHourTxtBox_Leave);
            // 
            // MaxHourPnl
            // 
            this.MaxHourPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.MaxHourPnl.Location = new System.Drawing.Point(23, 128);
            this.MaxHourPnl.Name = "MaxHourPnl";
            this.MaxHourPnl.Size = new System.Drawing.Size(188, 2);
            this.MaxHourPnl.TabIndex = 51;
            // 
            // MaxHourLbl
            // 
            this.MaxHourLbl.AutoSize = true;
            this.MaxHourLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxHourLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.MaxHourLbl.Location = new System.Drawing.Point(20, 88);
            this.MaxHourLbl.Name = "MaxHourLbl";
            this.MaxHourLbl.Size = new System.Drawing.Size(89, 15);
            this.MaxHourLbl.TabIndex = 49;
            this.MaxHourLbl.Text = "Maximum hour";
            // 
            // MaxHourErrorLbl
            // 
            this.MaxHourErrorLbl.AutoSize = true;
            this.MaxHourErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.MaxHourErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxHourErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.MaxHourErrorLbl.Location = new System.Drawing.Point(20, 133);
            this.MaxHourErrorLbl.Name = "MaxHourErrorLbl";
            this.MaxHourErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.MaxHourErrorLbl.TabIndex = 50;
            this.MaxHourErrorLbl.Text = " ";
            // 
            // PackageNameTxtBox
            // 
            this.PackageNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.PackageNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PackageNameTxtBox.Font = new System.Drawing.Font("Carlito", 9.75F);
            this.PackageNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.PackageNameTxtBox.Location = new System.Drawing.Point(23, 40);
            this.PackageNameTxtBox.Name = "PackageNameTxtBox";
            this.PackageNameTxtBox.Size = new System.Drawing.Size(188, 16);
            this.PackageNameTxtBox.TabIndex = 48;
            this.PackageNameTxtBox.Enter += new System.EventHandler(this.PackageNameTxtBox_Enter);
            this.PackageNameTxtBox.Leave += new System.EventHandler(this.PackageNameTxtBox_Leave);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Carlito", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.TitleLbl.Location = new System.Drawing.Point(12, 34);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(373, 39);
            this.TitleLbl.TabIndex = 61;
            this.TitleLbl.Text = "Package Type Management";
            // 
            // PackageTypeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.ManipulationPanel);
            this.Controls.Add(this.TablePanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.TitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PackageTypeManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PackageTypeManagement";
            this.Load += new System.EventHandler(this.PackageTypeManagementForm_Load);
            this.ButtonsPanel.ResumeLayout(false);
            this.ManipulationPanel.ResumeLayout(false);
            this.ManipulationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TablePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel PackageNamePnl;
        private System.Windows.Forms.Label PackageNameLbl;
        private System.Windows.Forms.Label PackageNameErrorLbl;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Panel ManipulationPanel;
        private System.Windows.Forms.TextBox PackageNameTxtBox;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.TextBox ExtraKmRateTxtBox;
        private System.Windows.Forms.Panel ExtraKmRatePnl;
        private System.Windows.Forms.Label ExtraKmRateLbl;
        private System.Windows.Forms.Label ExtraKmRateErrorLbl;
        private System.Windows.Forms.TextBox ExtraHourRateTxtBox;
        private System.Windows.Forms.Panel ExtraHourRatePnl;
        private System.Windows.Forms.Label ExtraHourRateLbl;
        private System.Windows.Forms.Label ExtraHourRateErrorLbl;
        private System.Windows.Forms.TextBox MaxKmTxtBox;
        private System.Windows.Forms.Panel MaxKmPnl;
        private System.Windows.Forms.Label MaxKmLbl;
        private System.Windows.Forms.Label MaxKmErrorLbl;
        private System.Windows.Forms.TextBox MaxHourTxtBox;
        private System.Windows.Forms.Panel MaxHourPnl;
        private System.Windows.Forms.Label MaxHourLbl;
        private System.Windows.Forms.Label MaxHourErrorLbl;
    }
}