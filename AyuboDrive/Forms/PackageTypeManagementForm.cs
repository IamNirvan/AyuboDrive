using AyuboDrive.Enums;
using AyuboDrive.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive.Forms
{
    public partial class PackageTypeManagementForm : AyuboDriveTemplateForm
    {
        private static QueryHandler s_queryHandler = new QueryHandler();
        private DataViewer _dataViewer;
        private string _packageID;
        private string _initialPackageName;
        private bool _rowSelected = false;
        private Panel _selectedRow = null;
        private string _defaultQuery;

        public PackageTypeManagementForm(DashboardForm dashboardForm) : base(dashboardForm)
        {
            InitializeComponent();
            HandleTitleBar();
            DisplayTable();
            FillPackageStatusCmbBox();
        }
        //
        // Mouse event handlers
        //
        private void DeleteBtn_MouseEnter(object sender, EventArgs e)
        {
            DeleteBtn.BackColor = Properties.Settings.Default.RED;
            DeleteBtn.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void DeleteBtn_MouseLeave(object sender, EventArgs e)
        {
            DeleteBtn.BackColor = Properties.Settings.Default.TRANSPARENT;
            DeleteBtn.ForeColor = Properties.Settings.Default.RED;
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(((Label)sender).Name.Split('-')[1]);

            _rowSelected = true;
            Panel record = _dataViewer.GetRows()[index];
            AddData(index);

            if (_selectedRow != null)
            {
                _selectedRow.BackColor = Properties.Settings.Default.LIGHT_GRAY;
            }

            _selectedRow = record;
            record.BackColor = Properties.Settings.Default.LIGHTER_GRAY;
            ResetErrors();
        }

        private void Cell_MouseEnter(object sender, EventArgs e)
        {
            // Get the number associated with the label name. For example: panel-0
            int index = Int32.Parse(((Label)sender).Name.Split('-')[1]);

            if (index != 0)
            {
                if (!_rowSelected)
                {
                    Panel panel = _dataViewer.GetRows()[index]; // Access the label's record panel
                    panel.BackColor = Properties.Settings.Default.LIGHTER_GRAY;
                }

                Label[] subArray = _dataViewer.GetLabels()[index];

                for (int i = 0; i < subArray.Length; i++)
                {
                    subArray[i].ForeColor = Properties.Settings.Default.ENABLED_WHITE;
                }
            }
        }

        private void Cell_MouseLeave(object sender, EventArgs e)
        {
            // Get the number associated with the label name. For example: panel-0
            int index = Int32.Parse(((Label)sender).Name.Split('-')[1]);

            if (index != 0)
            {
                if (!_rowSelected)
                {
                    Panel panel = _dataViewer.GetRows()[index]; // Access the parent panel
                    panel.BackColor = Properties.Settings.Default.LIGHT_GRAY;
                }

                Label[] subArray = _dataViewer.GetLabels()[index];

                for (int i = 0; i < subArray.Length; i++)
                {
                    subArray[i].ForeColor = Properties.Settings.Default.DISABLED_WHITE;
                }
            }
        }
        //
        // Utility
        //
        private PackageStatus ConvertStringToPackageStatus(string packageStatusString)
        {
            if (packageStatusString.Equals("active"))
            {
                return PackageStatus.ACTIVE;
            }
            else if (packageStatusString.Equals("paused"))
            {
                return PackageStatus.PAUSED;
            }
            return PackageStatus.DISCONTINUED;
        }

        private void FillPackageStatusCmbBox()
        {
            PackageStatusCmbBox.Items.Add(PackageStatus.ACTIVE.ToString().ToLower());
            PackageStatusCmbBox.Items.Add(PackageStatus.PAUSED.ToString().ToLower());
            PackageStatusCmbBox.Items.Add(PackageStatus.DISCONTINUED.ToString().ToLower());
        }

        private void AddData(int index)
        {
            if (index != 0)
            {
                Label[] subArray = _dataViewer.GetLabels()[index];

                DataRow record = s_queryHandler.SelectQueryHandler(_defaultQuery).Rows[index - 1];

                _packageID = subArray[0].Text;
                PackageNameTxtBox.Text = subArray[1].Text;
                _initialPackageName = subArray[1].Text;
                MaxHourTxtBox.Text = subArray[2].Text;
                MaxKmTxtBox.Text = subArray[3].Text;
                ExtraHourRateTxtBox.Text = subArray[4].Text;
                ExtraKmRateTxtBox.Text = subArray[5].Text;
                PackageStatusCmbBox.Text = subArray[6].Text;
            }
        }

        private void ResetErrors()
        {
            PackageNameErrorLbl.Text = "";
            PackageNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            MaxHourErrorLbl.Text = "";
            MaxHourPnl.BackColor = Properties.Settings.Default.PURPLE;
            MaxKmErrorLbl.Text = "";
            MaxKmPnl.BackColor = Properties.Settings.Default.PURPLE;
            ExtraHourRateErrorLbl.Text = "";
            ExtraHourRatePnl.BackColor = Properties.Settings.Default.PURPLE;
            ExtraKmRateErrorLbl.Text = "";
            ExtraKmRatePnl.BackColor = Properties.Settings.Default.PURPLE;
            PackageStatusErrLbl.Text = "";
            PackageStatusPnl.BackColor = Properties.Settings.Default.PURPLE;
        }

        private void DisplayTable()
        {
            TablePanel.Controls.Clear();

            if (DiscontinuedPackagesRBtn.Checked)
            {
                _defaultQuery = "SELECT * FROM package  WHERE packageStatus = 'discontinued'";
            }
            else
            {
                _defaultQuery = "SELECT * from package WHERE packageStatus = 'active' OR packageStatus = 'paused'";
            }

            _dataViewer = new DataViewer(TablePanel, s_queryHandler.SelectQueryHandler(_defaultQuery));
            _dataViewer.DisplayTable();
            AddCellClickEvent(_dataViewer, Cell_Click, Cell_MouseEnter, Cell_MouseLeave);
        }

        private bool ValidateInput(string packageName, string maxHour, string maxKm, string extraHourRate, 
            string extraKmRate, string packageStatus, int packageStatusSelectedIndex)
        {
            bool validPackageName = false;
            bool validMaxHour = false;
            bool validMaxKm = false;
            bool validExtraHourRate = false;
            bool validExtraKmRate = false;
            bool validPackageStatus = false;

            if (ValidationHandler.ValidateInputLength(packageName))
            {
                validPackageName = true;
                PackageNameErrorLbl.Text = "";
                PackageNamePnl.BackColor = Properties.Settings.Default.PURPLE;

               if(!ValidationHandler.ValidatePackageName(packageName))
                {
                    validPackageName = false;
                    PackageNameErrorLbl.Text = "Package name already exists";
                    PackageNamePnl.BackColor = Properties.Settings.Default.RED;
                }
            }
            else
            {
                PackageNameErrorLbl.Text = "Invalid package name";
                PackageNamePnl.BackColor = Properties.Settings.Default.RED;
            }

            if (ValidationHandler.ValidateTimeInput(maxHour))
            {
                validMaxHour = true;
                MaxHourErrorLbl.Text = "";
                MaxHourPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                MaxHourErrorLbl.Text = "Invalid max hour";
                MaxHourPnl.BackColor = Properties.Settings.Default.RED;
            }

            if (ValidationHandler.ValidateDistanceInput(maxKm))
            {
                validMaxKm = true;
                MaxKmErrorLbl.Text = "";
                MaxKmPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                MaxKmErrorLbl.Text = "Invalid max Km";
                MaxKmPnl.BackColor = Properties.Settings.Default.RED;
            }

            if (ValidationHandler.ValidateDecimalInput(extraHourRate))
            {
                validExtraHourRate = true;
                ExtraHourRateErrorLbl.Text = "";
                ExtraHourRatePnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                ExtraHourRateErrorLbl.Text = "Invalid extra hour rate";
                ExtraHourRatePnl.BackColor = Properties.Settings.Default.RED;
            }
            if (ValidationHandler.ValidateDecimalInput(extraKmRate))
            {
                validExtraKmRate = true;
                ExtraKmRateErrorLbl.Text = "";
                ExtraKmRatePnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                ExtraKmRateErrorLbl.Text = "Invalid extra Km rate";
                ExtraKmRatePnl.BackColor = Properties.Settings.Default.RED;
            }

            if(ValidationHandler.ValidateInputLength(packageStatus))
            {
                validPackageStatus = true;
                PackageStatusPnl.BackColor = Properties.Settings.Default.PURPLE;
                PackageStatusErrLbl.Text = "";
            }
            else
            {
                PackageStatusErrLbl.Text = "Invalid package status";
                PackageStatusPnl.BackColor = Properties.Settings.Default.RED;
            }
            return validPackageName && validMaxHour && validMaxKm && validExtraHourRate && 
                validExtraKmRate && validPackageStatus;
        }

        private bool ValidateInputV2(string packageName, string maxHour, string maxKm, string extraHourRate, 
            string extraKmRate, string packageStatus, int packageStatusSelectedIndex)
        {
            bool validPackageName = false;
            bool validMaxHour = false;
            bool validMaxKm = false;
            bool validExtraHourRate = false;
            bool validExtraKmRate = false;
            bool validPackageStatus = false;

            if (_initialPackageName.Equals(packageName))
            {
                validPackageName = true;
                PackageNamePnl.BackColor = Properties.Settings.Default.PURPLE;
                PackageNameErrorLbl.Text = "";
            }
            else
            {
                if (!ValidationHandler.ValidatePackageName(packageName))
                {
                    PackageNamePnl.BackColor = Properties.Settings.Default.RED;
                    PackageNameErrorLbl.Text = "Invalid package name";
                }
                else
                {
                    validPackageName = true;
                }
            }

            if (ValidationHandler.ValidateTimeInput(maxHour))
            {
                validMaxHour = true;
                MaxHourErrorLbl.Text = "";
                MaxHourPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                MaxHourErrorLbl.Text = "Invalid max hour";
                MaxHourPnl.BackColor = Properties.Settings.Default.RED;
            }

            if (ValidationHandler.ValidateDistanceInput(maxKm))
            {
                validMaxKm = true;
                MaxKmErrorLbl.Text = "";
                MaxKmPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                MaxKmErrorLbl.Text = "Invalid max Km";
                MaxKmPnl.BackColor = Properties.Settings.Default.RED;
            }

            if (ValidationHandler.ValidateDecimalInput(extraHourRate))
            {
                validExtraHourRate = true;
                ExtraHourRateErrorLbl.Text = "";
                ExtraHourRatePnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                ExtraHourRateErrorLbl.Text = "Invalid extra hour rate";
                ExtraHourRatePnl.BackColor = Properties.Settings.Default.RED;
            }
            if (ValidationHandler.ValidateDecimalInput(extraKmRate))
            {
                validExtraKmRate = true;
                ExtraKmRateErrorLbl.Text = "";
                ExtraKmRatePnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                ExtraKmRateErrorLbl.Text = "Invalid extra Km rate";
                ExtraKmRatePnl.BackColor = Properties.Settings.Default.RED;
            }

            if(ValidationHandler.ValidateInputLength(packageStatus))
            {
                validPackageStatus = true;
                PackageStatusPnl.BackColor = Properties.Settings.Default.PURPLE;
                PackageStatusErrLbl.Text = "";
            }
            else
            {
                PackageStatusErrLbl.Text = "Invalid package status";
                PackageStatusPnl.BackColor = Properties.Settings.Default.RED;
            }
            return validPackageName && validMaxHour && validMaxKm && validExtraHourRate && 
                validExtraKmRate && validPackageStatus;
        }

        private void Reset()
        {
            PackageNameTxtBox.Text = "";
            MaxHourTxtBox.Text = "";
            MaxKmTxtBox.Text = "";
            ExtraHourRateTxtBox.Text = "";
            ExtraKmRateTxtBox.Text = "";
            PackageStatusCmbBox.Text = "";

            _rowSelected = false;
            if (_selectedRow != null)
            {
                _selectedRow.BackColor = Properties.Settings.Default.LIGHT_GRAY;
                _selectedRow = null;
            }
            _packageID = null;
        }
        //
        // Click event handlers
        //
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string packageName = PackageNameTxtBox.Text;
            string maxHour = MaxHourTxtBox.Text;
            string maxKm = MaxKmTxtBox.Text;
            string extraHourRate = ExtraHourRateTxtBox.Text;
            string extraKmRate = ExtraKmRateTxtBox.Text;
            PackageStatus packageStatus = ConvertStringToPackageStatus(PackageStatusCmbBox.Text);

            if (ValidateInput(packageName, maxHour, maxKm, extraHourRate, extraKmRate, packageStatus.ToString(),
                PackageStatusCmbBox.SelectedIndex))
            {
                Package package = new Package(packageName, int.Parse(maxHour), int.Parse(maxKm), 
                    decimal.Parse(extraHourRate), decimal.Parse(extraKmRate), packageStatus);

                if (package.Insert())
                {
                    MessagePrinter.PrintToMessageBox("Package details were successfully inserted", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTable();
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to insert package details", "Operation failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Reset();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            ResetErrors();

            if (!_rowSelected)
            {
                MessagePrinter.PrintToMessageBox("Please select a package record", "Select a record",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string packageName = PackageNameTxtBox.Text;
            string maxHour = MaxHourTxtBox.Text;
            string maxKm = MaxKmTxtBox.Text;
            string extraHourRate = ExtraHourRateTxtBox.Text;
            string extraKmRate = ExtraKmRateTxtBox.Text;
            PackageStatus packageStatus = ConvertStringToPackageStatus(PackageStatusCmbBox.Text);

            if (ValidateInputV2(packageName, maxHour, maxKm, extraHourRate, extraKmRate, packageStatus.ToString(),
                PackageStatusCmbBox.SelectedIndex))
            {
                Package package = new Package(packageName, int.Parse(maxHour), int.Parse(maxKm),
                    decimal.Parse(extraHourRate), decimal.Parse(extraKmRate), packageStatus);

                if (package.Update(_packageID))
                {
                    MessagePrinter.PrintToMessageBox("Package details were successfully updated", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTable();
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to update package details", "Operation failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Reset();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ResetErrors();

            if (!_rowSelected)
            {
                MessagePrinter.PrintToMessageBox("Please select a package record", "Select a record",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessagePrinter.PrintToMessageBoxV2("Are you sure you want to delete the record? Once deleted, " +
                "it cannot be recoverd.", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (Package.Delete(_packageID))
                {
                    MessagePrinter.PrintToMessageBox("Package details were successfully deleted", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to delete package details", "Operation failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DisplayTable();
                Reset();
            }
        }

        private void DiscontinueBtn_Click(object sender, EventArgs e)
        {
            ResetErrors();

            if (!_rowSelected)
            {
                MessagePrinter.PrintToMessageBox("Please select a package record", "Select a record",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessagePrinter.PrintToMessageBoxV2("Are you sure you want to discontinue this package?",
                "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                if(Package.Delete(_packageID))
                {
                    MessagePrinter.PrintToMessageBox("Package was successfully discontinued", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to delete the package." +
                        "\nOnly packages that are unused can be deleted. Try setting the package " +
                        "to discontinued instead", "Operation failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DisplayTable();
                Reset();
            }
        }
        //
        // Textbox event handlers
        //
        private void TextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }
        // 
        // Text box key press event handler
        //
        private void CharacterOnlyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // Discard the character by setting handled to true
                e.Handled = true;
            }
        }

        private void NumberOnlyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !e.KeyChar.Equals('.'))
            {
                // Discard the character by setting handled to true
                e.Handled = true;
            }
        }

        private void NoTyping_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void NumberOrCharacterOnlyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // Discard the character by setting handled to true
                e.Handled = true;
            }
        }
        //
        // Radio button check changed event handler
        //
        private void IncludeDiscontinuedPackagesRBtn_CheckedChanged(object sender, EventArgs e)
        {
            DisplayTable();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DisplayTable();
        }
    }
}
