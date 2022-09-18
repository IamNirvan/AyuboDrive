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
    public partial class DriverManagementForm : AyuboDriveTemplateForm
    {
        private static QueryHandler s_queryHandler = new QueryHandler();
        private DataViewer _dataViewer;
        private string _initialNIC;
        private string _initialContactNumber;
        private string _driverID = null;
        private bool _rowSelected = false;
        private Panel _selectedRow = null;

        public DriverManagementForm(DashboardForm dashboardForm) : base(dashboardForm)
        {
            InitializeComponent();
            HandleTitleBar();
            FillDriverStatusCmbBox();
            DisplayTable();
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
                    Panel panel = _dataViewer.GetRows()[index];
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
                    Panel panel = _dataViewer.GetRows()[index];
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
        private void FillDriverStatusCmbBox()
        {
            DriverStatusCmbBox.Items.Add(DriverStatus.AVAILABLE.ToString().ToLower());
            DriverStatusCmbBox.Items.Add(DriverStatus.UNAVAILABLE.ToString().ToLower());
            DriverStatusCmbBox.Items.Add(DriverStatus.TERMINATED.ToString().ToLower());
        }

        private DriverStatus ConvertStringToDriverStatus(string driverStatusString)
        {
            if(driverStatusString.Equals("available"))
            {
                return DriverStatus.AVAILABLE;
            }
            else if (driverStatusString.Equals("unavailable"))
            {
                return DriverStatus.UNAVAILABLE;
            }
            return DriverStatus.TERMINATED;
        }
        
        private bool ValidateInput(string NIC, string firstName, string lastName, string contactNumber, string driverStatus, 
            int driverStatusSelectedRowIndex, string dailyRate, string overnightRate)
        {
            bool validNIC = false;
            bool validFirstName = false;
            bool validLastName = false;
            bool validContactNumber = false;
            bool validDriverStatus = false;
            bool validDailyRate = false;
            bool validOvernightRate = false;

            // Capture the initial NIC
            // Check if the newly entered NIC is not the initial NIC and it is not present in the database

            if(ValidationHandler.ValidateNIC(NIC, "driver", "driverNIC"))
            {
                validNIC = true;
                NICPnl.BackColor = Properties.Settings.Default.PURPLE;
                NICErrorLbl.Text = "";
            }
            else
            {
                NICPnl.BackColor = Properties.Settings.Default.RED;
                NICErrorLbl.Text = "Invalid NIC";
            }

            if(ValidationHandler.ValidateInputLength(firstName))
            {
                validFirstName = true;
                FirstNamePnl.BackColor = Properties.Settings.Default.PURPLE;
                FirstNameErrLbl.Text = "";
            }
            else
            {
                FirstNamePnl.BackColor = Properties.Settings.Default.RED;
                FirstNameErrLbl.Text = "Invalid first name";
            }

            if(ValidationHandler.ValidateInputLength(lastName))
            {
                validLastName = true;
                LastNamePnl.BackColor = Properties.Settings.Default.PURPLE;
                LastNameErrLbl.Text = "";
            }
            else
            {
                LastNamePnl.BackColor = Properties.Settings.Default.RED;
                LastNameErrLbl.Text = "Invalid last name";
            }

            if(ValidationHandler.ValidateContactNumber(contactNumber, "driver", "contactNumber"))
            {
                validContactNumber = true;
                ContactNumberPnl.BackColor = Properties.Settings.Default.PURPLE;
                ContactNumberErrLbl.Text = "";
            }
            else
            {
                ContactNumberPnl.BackColor = Properties.Settings.Default.RED;
                ContactNumberErrLbl.Text = "Invalid contact number";
            }
            
            if(ValidationHandler.ValidateInputLength(driverStatus))
            {
                validDriverStatus = true;
                DriverStatusPnl.BackColor = Properties.Settings.Default.PURPLE;
                DriverStatusErrLbl.Text = "";
            }
            else
            {
                DriverStatusPnl.BackColor = Properties.Settings.Default.RED;
                DriverStatusErrLbl.Text = "Invalid driver status";
            }

            if(ValidationHandler.ValidateDecimalInput(dailyRate))
            {
                validDailyRate = true;
                DailyRatePnl.BackColor = Properties.Settings.Default.PURPLE;
                DailyRateErrLbl.Text = "";
            }
            else
            {
                DailyRatePnl.BackColor = Properties.Settings.Default.RED;
                DailyRateErrLbl.Text = "Invalid daily rate";
            }

            if(ValidationHandler.ValidateDecimalInput(overnightRate))
            {
                validOvernightRate = true;
                OvernightRatePnl.BackColor = Properties.Settings.Default.PURPLE;
                OvernightRateErrLbl.Text = "";
            }
            else
            {
                OvernightRatePnl.BackColor = Properties.Settings.Default.RED;
                OvernightRateErrLbl.Text = "Invalid overnight rate";
            }
            return validNIC && validFirstName && validLastName && validContactNumber && validDriverStatus 
                && validDailyRate && validOvernightRate;
        }

        private bool ValidateInputV2(string NIC, string firstName, string lastName, string contactNumber, string driverStatus, 
            int driverStatusSelectedRowIndex, string dailyRate, string overnightRate)
        {
            bool validNIC = false;
            bool validFirstName = false;
            bool validLastName = false;
            bool validContactNumber = false;
            bool validDriverStatus = false;
            bool validDailyRate = false;
            bool validOvernightRate = false;

            if(_initialNIC.Equals(NIC))
            {
                validNIC = true;
                NICPnl.BackColor = Properties.Settings.Default.PURPLE;
                NICErrorLbl.Text = "";
            }
            else
            {
                if (!ValidationHandler.ValidateNIC(NIC, "driver", "driverNIC"))
                {
                    NICPnl.BackColor = Properties.Settings.Default.RED;
                    NICErrorLbl.Text = "Invalid NIC";
                }
                else
                {
                    validNIC = true;
                }
            }

            if(ValidationHandler.ValidateInputLength(firstName))
            {
                validFirstName = true;
                FirstNamePnl.BackColor = Properties.Settings.Default.PURPLE;
                FirstNameErrLbl.Text = "";
            }
            else
            {
                FirstNamePnl.BackColor = Properties.Settings.Default.RED;
                FirstNameErrLbl.Text = "Invalid first name";
            }

            if(ValidationHandler.ValidateInputLength(lastName))
            {
                validLastName = true;
                LastNamePnl.BackColor = Properties.Settings.Default.PURPLE;
                LastNameErrLbl.Text = "";
            }
            else
            {
                LastNamePnl.BackColor = Properties.Settings.Default.RED;
                LastNameErrLbl.Text = "Invalid last name";
            }
            
            if (_initialContactNumber.Equals(contactNumber))
            {
                validContactNumber = true;
                ContactNumberPnl.BackColor = Properties.Settings.Default.PURPLE;
                ContactNumberErrLbl.Text = "";
            }
            else
            {
                if (!ValidationHandler.ValidateContactNumber(contactNumber, "driver", "contactNumber"))
                {
                    ContactNumberPnl.BackColor = Properties.Settings.Default.RED;
                    ContactNumberErrLbl.Text = "Invalid contact number";
                }
                else
                {
                    validContactNumber = true;
                }
            }

            if (ValidationHandler.ValidateInputLength(driverStatus))
            {
                validDriverStatus = true;
                DriverStatusPnl.BackColor = Properties.Settings.Default.PURPLE;
                DriverStatusErrLbl.Text = "";
            }
            else
            {
                DriverStatusPnl.BackColor = Properties.Settings.Default.RED;
                DriverStatusErrLbl.Text = "Invalid driver status";
            }

            if(ValidationHandler.ValidateDecimalInput(dailyRate))
            {
                validDailyRate = true;
                DailyRatePnl.BackColor = Properties.Settings.Default.PURPLE;
                DailyRateErrLbl.Text = "";
            }
            else
            {
                DailyRatePnl.BackColor = Properties.Settings.Default.RED;
                DailyRateErrLbl.Text = "Invalid daily rate";
            }

            if(ValidationHandler.ValidateDecimalInput(overnightRate))
            {
                validOvernightRate = true;
                OvernightRatePnl.BackColor = Properties.Settings.Default.PURPLE;
                OvernightRateErrLbl.Text = "";
            }
            else
            {
                OvernightRatePnl.BackColor = Properties.Settings.Default.RED;
                OvernightRateErrLbl.Text = "Invalid overnight rate";
            }
            return validNIC && validFirstName && validLastName && validContactNumber && validDriverStatus 
                && validDailyRate && validOvernightRate;
        }

        private void Reset()
        {
            NICTxtBox.Text = "";
            FirstNameTxtBox.Text = "";
            LastNameErrLbl.Text = "";
            ContactNumberTxtBox.Text = "";
            DriverStatusCmbBox.Text = "";
            DailyRateTxtBox.Text = "";
            OvernightRateTxtBox.Text = "";

            _rowSelected = false;
            if (_selectedRow != null)
            {
                _selectedRow.BackColor = Properties.Settings.Default.LIGHT_GRAY;
                _selectedRow = null;
            }
            _driverID = null;
        }

        private void ResetErrors()
        {
            NICPnl.BackColor = Properties.Settings.Default.PURPLE;
            NICErrorLbl.Text = "";
            FirstNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            FirstNameErrLbl.Text = "";
            LastNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            LastNameErrLbl.Text = "";
            ContactNumberPnl.BackColor = Properties.Settings.Default.PURPLE;
            ContactNumberErrLbl.Text = "";
            DriverStatusPnl.BackColor = Properties.Settings.Default.PURPLE;
            DriverStatusErrLbl.Text = "";
            DailyRatePnl.BackColor = Properties.Settings.Default.PURPLE;
            DailyRateErrLbl.Text = "";
            OvernightRatePnl.BackColor = Properties.Settings.Default.PURPLE;
            OvernightRateErrLbl.Text = "";
        }

        private void AddData(int index)
        {
            if (index != 0)
            {
                DataRow record = s_queryHandler.SelectQueryHandler("SELECT * FROM driver").Rows[index-1];
                _driverID = record[0].ToString();
                NICTxtBox.Text = record[1].ToString();
                _initialNIC = record[1].ToString();
                FirstNameTxtBox.Text = record[2].ToString();
                LastNameTxtBox.Text = record[3].ToString();
                ContactNumberTxtBox.Text = record[4].ToString();
                _initialContactNumber = record[4].ToString();
                DriverStatusCmbBox.Text = record[5].ToString();
                DailyRateTxtBox.Text = record[6].ToString();
                OvernightRateTxtBox.Text = record[7].ToString();
            }
        }

        private void DisplayTable()
        {
            string query = "SELECT driverNIC as NIC, firstName, lastName, contactNumber as contact," +
                " driverStatus as Availability, dailyRate,  overnightRate FROM driver";
            TablePanel.Controls.Clear();
            _dataViewer = new DataViewer(TablePanel, s_queryHandler.SelectQueryHandler(query));
            _dataViewer.DisplayTable();
            AddCellClickEvent(_dataViewer, Cell_Click, Cell_MouseEnter, Cell_MouseLeave);
        }
        //
        // text box enter and leave event handlers
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
        // Click event handlers
        //
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string NIC = NICTxtBox.Text;
            string firstName = FirstNameTxtBox.Text;
            string lastName = LastNameTxtBox.Text;
            string contactNumber = ContactNumberTxtBox.Text;
            DriverStatus driverStatus = ConvertStringToDriverStatus(DriverStatusCmbBox.Text);
            string dailyRate = DailyRateTxtBox.Text;
            string overnightRate = OvernightRateTxtBox.Text;

            if (ValidateInput(NIC, firstName, lastName, contactNumber, driverStatus.ToString(), DriverStatusCmbBox.SelectedIndex, dailyRate, overnightRate))
            {
                Driver driver = new Driver(NIC, firstName, lastName, contactNumber, driverStatus, decimal.Parse(dailyRate), decimal.Parse(overnightRate));
                if (driver.Insert())
                {
                    MessagePrinter.PrintToMessageBox("Driver details were successfully inserted", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTable();
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to insert driver details", "Operation failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Reset();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!_rowSelected)
            {
                MessagePrinter.PrintToMessageBox("Please select a driver record", "Select a record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string NIC = NICTxtBox.Text;
            string firstName = FirstNameTxtBox.Text;
            string lastName = LastNameTxtBox.Text;
            string contactNumber = ContactNumberTxtBox.Text;
            DriverStatus driverStatus = ConvertStringToDriverStatus(DriverStatusCmbBox.Text);
            string dailyRate = DailyRateTxtBox.Text;
            string overnightRate = OvernightRateTxtBox.Text;

            if (ValidateInputV2(NIC, firstName, lastName, contactNumber, driverStatus.ToString(), DriverStatusCmbBox.SelectedIndex, dailyRate, overnightRate))
            {
                Driver driver = new Driver(NIC, firstName, lastName, contactNumber, driverStatus, decimal.Parse(dailyRate), decimal.Parse(overnightRate));
                if (driver.Update(_driverID))
                {
                    MessagePrinter.PrintToMessageBox("Driver details were successfully updated", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTable();
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to update driver details", "Operation failed",
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
                MessagePrinter.PrintToMessageBox("Please select a driver record", "Select a record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessagePrinter.PrintToMessageBoxV2("Are you sure you want to delete the record? Once deleted, it cannot be recoverd.",
                "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (Driver.Delete(_driverID))
                {
                    MessagePrinter.PrintToMessageBox("Driver details were successfully deleted", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DisplayTable();
                Reset();
            }
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

        private void NumberOrCharacterOnlyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Discard the character by setting handled to true
                e.Handled = true;
            }
        }

        private void NoTyping_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
