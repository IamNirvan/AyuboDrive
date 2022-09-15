namespace AyuboDrive.Forms
{
    partial class VehicleTypeManagementForm
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
            this.TypeNamePnl = new System.Windows.Forms.Panel();
            this.TypeNameLbl = new System.Windows.Forms.Label();
            this.TypeNameErrorLbl = new System.Windows.Forms.Label();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ManipulationPanel = new System.Windows.Forms.Panel();
            this.TypeNameTxtBox = new System.Windows.Forms.TextBox();
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
            this.TablePanel.Size = new System.Drawing.Size(470, 384);
            this.TablePanel.TabIndex = 57;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(750, 30);
            this.flowLayoutPanel1.TabIndex = 58;
            // 
            // TypeNamePnl
            // 
            this.TypeNamePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.TypeNamePnl.Location = new System.Drawing.Point(33, 57);
            this.TypeNamePnl.Name = "TypeNamePnl";
            this.TypeNamePnl.Size = new System.Drawing.Size(188, 2);
            this.TypeNamePnl.TabIndex = 40;
            // 
            // TypeNameLbl
            // 
            this.TypeNameLbl.AutoSize = true;
            this.TypeNameLbl.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.TypeNameLbl.Location = new System.Drawing.Point(30, 17);
            this.TypeNameLbl.Name = "TypeNameLbl";
            this.TypeNameLbl.Size = new System.Drawing.Size(63, 15);
            this.TypeNameLbl.TabIndex = 33;
            this.TypeNameLbl.Text = "Type name";
            // 
            // TypeNameErrorLbl
            // 
            this.TypeNameErrorLbl.AutoSize = true;
            this.TypeNameErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.TypeNameErrorLbl.Font = new System.Drawing.Font("Carlito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeNameErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.TypeNameErrorLbl.Location = new System.Drawing.Point(30, 62);
            this.TypeNameErrorLbl.Name = "TypeNameErrorLbl";
            this.TypeNameErrorLbl.Size = new System.Drawing.Size(9, 13);
            this.TypeNameErrorLbl.TabIndex = 34;
            this.TypeNameErrorLbl.Text = " ";
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
            this.ButtonsPanel.Location = new System.Drawing.Point(488, 169);
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
            this.ManipulationPanel.Controls.Add(this.TypeNameTxtBox);
            this.ManipulationPanel.Controls.Add(this.TypeNamePnl);
            this.ManipulationPanel.Controls.Add(this.TypeNameLbl);
            this.ManipulationPanel.Controls.Add(this.TypeNameErrorLbl);
            this.ManipulationPanel.Location = new System.Drawing.Point(488, 76);
            this.ManipulationPanel.Name = "ManipulationPanel";
            this.ManipulationPanel.Size = new System.Drawing.Size(250, 87);
            this.ManipulationPanel.TabIndex = 59;
            // 
            // TypeNameTxtBox
            // 
            this.TypeNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.TypeNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TypeNameTxtBox.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.TypeNameTxtBox.Location = new System.Drawing.Point(33, 39);
            this.TypeNameTxtBox.Name = "TypeNameTxtBox";
            this.TypeNameTxtBox.Size = new System.Drawing.Size(188, 19);
            this.TypeNameTxtBox.TabIndex = 48;
            this.TypeNameTxtBox.Enter += new System.EventHandler(this.TypeNameTxtBox_Enter);
            this.TypeNameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharacterOnlyTextBox_KeyPress);
            this.TypeNameTxtBox.Leave += new System.EventHandler(this.TypeNameTxtBox_Leave);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Carlito", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.TitleLbl.Location = new System.Drawing.Point(12, 34);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(361, 39);
            this.TitleLbl.TabIndex = 56;
            this.TitleLbl.Text = "Vehicle Type Management";
            // 
            // VehicleTypeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(750, 470);
            this.Controls.Add(this.TablePanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.ManipulationPanel);
            this.Controls.Add(this.TitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VehicleTypeManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VehicleTypeManagementForm";
            this.Load += new System.EventHandler(this.VehicleTypeManagementForm_Load);
            this.ButtonsPanel.ResumeLayout(false);
            this.ManipulationPanel.ResumeLayout(false);
            this.ManipulationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel TablePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel TypeNamePnl;
        private System.Windows.Forms.Label TypeNameLbl;
        private System.Windows.Forms.Label TypeNameErrorLbl;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Panel ManipulationPanel;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.TextBox TypeNameTxtBox;
    }
}