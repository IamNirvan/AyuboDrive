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
        private static QueryHandler _queryHandler = new QueryHandler();
        private DataViewer _dataViewer;
        private string _packageID;
        private bool _rowSelected = false;
        private Panel _selectedRow = null;

        public PackageTypeManagementForm(Form dashboardForm) : base(dashboardForm)
        {
            InitializeComponent();
            HandleTitleBar();
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
            record.BackColor = Program.LIGHTER_GRAY;
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
                    panel.BackColor = Program.LIGHTER_GRAY;
                }

                Label[] subArray = _dataViewer.GetLabels()[index];

                for (int i = 0; i < subArray.Length; i++)
                {
                    subArray[i].ForeColor = Program.ENABLED_WHITE;
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
                    panel.BackColor = Program.LIGHT_GRAY;
                }

                Label[] subArray = _dataViewer.GetLabels()[index];

                for (int i = 0; i < subArray.Length; i++)
                {
                    subArray[i].ForeColor = Program.DISABLED_WHITE;
                }
            }
        }
        //
        // Utility
        //
        private void AddData(int index)
        {
            if (index != 0)
            {
                Label[] subArray = _dataViewer.GetLabels()[index];
                _packageID = subArray[0].Text;
                PackageNameTxtBox.Text = subArray[1].Text;
                MaxHourTxtBox.Text = subArray[2].Text;
                MaxKmTxtBox.Text = subArray[3].Text;
                ExtraHourRateTxtBox.Text = subArray[4].Text;
                ExtraKmRateTxtBox.Text = subArray[5].Text;
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
        }

        private void DisplayTable()
        {
            string query = "SELECT * from package";
            TablePanel.Controls.Clear();
            _dataViewer = new DataViewer(TablePanel, _queryHandler.SelectQueryHandler(query));
            _dataViewer.DisplayTable();
            AddCellClickEvent(_dataViewer, Cell_Click, Cell_MouseEnter, Cell_MouseLeave);
        }

        private bool ValidateInput(string packageName, string maxHour, string maxKm, string extraHourRate, string extraKmRate)
        {
            bool validPackageName = false;
            bool validMaxHour = false;
            bool validMaxKm = false;
            bool validExtraHourRate = false;
            bool validExtraKmRate = false;

            if (packageName.Length > 0)
            {
                validPackageName = true;
                PackageNameErrorLbl.Text = "";
                PackageNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                PackageNameErrorLbl.Text = "Invalid package name";
                PackageNamePnl.BackColor = Properties.Settings.Default.RED;
            }

            if (maxHour.Length > 0 && int.Parse(maxHour) > 0)
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

            if (maxKm.Length > 0 && int.Parse(maxKm) > 0)
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

            if (extraHourRate.Length > 0 && double.Parse(extraHourRate) > 0)
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
            if (extraKmRate.Length > 0 && double.Parse(extraKmRate) > 0)
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
            return validPackageName && validMaxHour && validMaxKm && validExtraHourRate && validExtraKmRate;
        }

        private void Reset()
        {
            PackageNameTxtBox.Text = "";
            MaxHourTxtBox.Text = "";
            MaxKmTxtBox.Text = "";
            ExtraHourRateTxtBox.Text = "";
            ExtraKmRateTxtBox.Text = "";

            _rowSelected = false;
            if (_selectedRow != null)
            {
                _selectedRow.BackColor = Properties.Settings.Default.LIGHT_GRAY;
                _selectedRow = null;
            }
            _packageID = null;
        }
        //
        // Data manipulation event handlers
        //
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string packageName = PackageNameTxtBox.Text;
            string maxHour = MaxHourTxtBox.Text;
            string maxKm = MaxKmTxtBox.Text;
            string extraHourRate = ExtraHourRateTxtBox.Text;
            string extraKmRate = ExtraKmRateTxtBox.Text;

            if (ValidateInput(packageName, maxHour, maxKm, extraHourRate, extraKmRate))
            {
                Package package = new Package(packageName, int.Parse(maxHour), int.Parse(maxKm), 
                    double.Parse(extraHourRate), double.Parse(extraKmRate));

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
            string packageName = PackageNameTxtBox.Text;
            string maxHour = MaxHourTxtBox.Text;
            string maxKm = MaxKmTxtBox.Text;
            string extraHourRate = ExtraHourRateTxtBox.Text;
            string extraKmRate = ExtraKmRateTxtBox.Text;

            if (ValidateInput(packageName, maxHour, maxKm, extraHourRate, extraKmRate))
            {
                Package package = new Package(packageName, int.Parse(maxHour), int.Parse(maxKm),
                    double.Parse(extraHourRate), double.Parse(extraKmRate));

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
            }
            else
            {
                DialogResult result = MessagePrinter.PrintToMessageBoxV2("Are you sure you want to delete the record? Once deleted, " +
                    "it cannot be recoverd.", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (Package.Delete(_packageID))
                    {
                        MessagePrinter.PrintToMessageBox("Package details were successfully deleted", "Operation successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    DisplayTable();
                    Reset();
                }
            }
        }
        //
        // Form load event handler
        //
        private void PackageTypeManagementForm_Load(object sender, EventArgs e)
        {
            DisplayTable();
        }
        //
        // Textbox event handlers
        //
        private void PackageNameTxtBox_Enter(object sender, EventArgs e)
        {
            PackageNameTxtBox.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void PackageNameTxtBox_Leave(object sender, EventArgs e)
        {
            PackageNameTxtBox.ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }

        private void MaxHourTxtBox_Enter(object sender, EventArgs e)
        {
            MaxHourTxtBox.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void MaxHourTxtBox_Leave(object sender, EventArgs e)
        {
            MaxHourTxtBox.ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }

        private void MaxKmTxtBox_Enter(object sender, EventArgs e)
        {
            MaxKmTxtBox.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void MaxKmTxtBox_Leave(object sender, EventArgs e)
        {
            MaxKmTxtBox.ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }

        private void ExtraHourRateTxtBox_Enter(object sender, EventArgs e)
        {
            ExtraHourRateTxtBox.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void ExtraHourRateTxtBox_Leave(object sender, EventArgs e)
        {
            ExtraHourRateTxtBox.ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }

        private void ExtraKmRateTxtBox_Enter(object sender, EventArgs e)
        {
            ExtraKmRateTxtBox.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void ExtraKmRateTxtBox_Leave(object sender, EventArgs e)
        {
            ExtraKmRateTxtBox.ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }
    }
}
