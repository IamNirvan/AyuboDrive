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
    public partial class CustomerManagementForm : AyuboDriveTemplateForm
    {
        private static QueryHandler s_queryHandler = new QueryHandler();
        private DataViewer _dataViewer;
        private string _initialNIC;
        private string _initialContactNumber;
        private string _customerID = null;
        private bool _rowSelected = false;
        private Panel _selectedRow = null;

        public CustomerManagementForm(DashboardForm dashboardForm) : base(dashboardForm)
        {
            InitializeComponent();
            HandleTitleBar();
            FillGenderComboBox();
            DisplayTable();
        }
        //
        // Utility functions
        //
        public void FillGenderComboBox()
        {
            GenderCmbBox.Items.Add(GenderOptions.FEMALE.ToString().ToLower());
            GenderCmbBox.Items.Add(GenderOptions.MALE.ToString().ToLower());
            GenderCmbBox.Items.Add(GenderOptions.OTHER.ToString().ToLower());
        }

        private GenderOptions ConvertStringToGenderOption(string genderString)
        {
            if (genderString.Equals("male"))
            {
                return GenderOptions.MALE;
            }
            else if (genderString.Equals("female"))
            {
                return GenderOptions.FEMALE;
            }
            return GenderOptions.OTHER;
        }

        private bool ValidateInput(string NIC, string firstName, string lastName, string contactNumber, 
            string gender, int genderSelectedIndex)
        {
            bool validNIC = false;
            bool validFirstName = false;
            bool validLastName = false;
            bool validContactNumber = false;
            bool validGender = false;

            if(ValidationHandler.ValidateNIC(NIC, "customer", "customerNIC"))
            {
                validNIC = true;
                NICErrorLbl.Text = "";
                NICPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                NICErrorLbl.Text = "Invalid NIC";
                NICPnl.BackColor = Properties.Settings.Default.RED;
            }

            if (ValidationHandler.ValidateInputLength(firstName))
            {
                validFirstName = true;
                FirstNameErrorLbl.Text = "";
                FirstNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                FirstNameErrorLbl.Text = "Invalid first name";
                FirstNamePnl.BackColor = Properties.Settings.Default.RED;
            }

            if (ValidationHandler.ValidateInputLength(lastName))
            {
                validLastName = true;
                LastNameErrorLbl.Text = "";
                LastNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                LastNameErrorLbl.Text = "Invalid last name";
                LastNamePnl.BackColor = Properties.Settings.Default.RED;
            }

            if (ValidationHandler.ValidateContactNumber(contactNumber, "customer", "contactNumber"))
            {
                validContactNumber = true;
                ContactNumberErrLbl.Text = "";
                ContactNumberPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                ContactNumberErrLbl.Text = "Invalid contact number";
                ContactNumberPnl.BackColor = Properties.Settings.Default.RED;
            }

            if(ValidationHandler.ValidateComboBoxValue(gender, genderSelectedIndex))
            {
                validGender = true;
                GenderPnl.BackColor = Properties.Settings.Default.PURPLE;
                GenderErrLbl.Text = "";
            }
            else
            {
                GenderPnl.BackColor = Properties.Settings.Default.RED;
                GenderErrLbl.Text = "Invalid gender option";
            }
            return validNIC && validFirstName && validLastName && validContactNumber && validGender;
        }

        private bool ValidateInputV2(string NIC, string firstName, string lastName, string contactNumber, 
            string gender, int genderSelectedIndex)
        {
            bool validNIC = false;
            bool validFirstName = false;
            bool validLastName = false;
            bool validContactNumber = false;
            bool validGender = false;


            if (_initialNIC.Equals(NIC))
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

            if (ValidationHandler.ValidateInputLength(firstName))
            {
                validFirstName = true;
                FirstNameErrorLbl.Text = "";
                FirstNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                FirstNameErrorLbl.Text = "Invalid first name";
                FirstNamePnl.BackColor = Properties.Settings.Default.RED;
            }

            if (ValidationHandler.ValidateInputLength(lastName))
            {
                validLastName = true;
                LastNameErrorLbl.Text = "";
                LastNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                LastNameErrorLbl.Text = "Invalid last name";
                LastNamePnl.BackColor = Properties.Settings.Default.RED;
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

            if (ValidationHandler.ValidateComboBoxValue(gender, genderSelectedIndex))
            {
                validGender = true;
                GenderPnl.BackColor = Properties.Settings.Default.PURPLE;
                GenderErrLbl.Text = "";
            }
            else
            {
                GenderPnl.BackColor = Properties.Settings.Default.RED;
                GenderErrLbl.Text = "Invalid gender option";
            }
            return validNIC && validFirstName && validLastName && validContactNumber && validGender;
        }

        private void Reset()
        {
            NICTxtBox.Text = "";
            FirstNameTxtBox.Text = "";
            LastNameTxtBox.Text = "";
            ContactNumberTxtBox.Text = "";
            GenderCmbBox.Text = "";
            _rowSelected = false;
            _selectedRow.BackColor = Properties.Settings.Default.LIGHT_GRAY;
            _selectedRow = null;
            _customerID = null;
        }

        private void ResetErrors()
        {
            NICErrorLbl.Text = "";
            NICPnl.BackColor = Properties.Settings.Default.PURPLE;
            FirstNameErrorLbl.Text = "";
            FirstNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            LastNameErrorLbl.Text = "";
            LastNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            ContactNumberErrLbl.Text = "";
            ContactNumberPnl.BackColor = Properties.Settings.Default.PURPLE;
            GenderErrLbl.Text = "";
            GenderPnl.BackColor = Properties.Settings.Default.PURPLE;
        }

        private void AddData(int index)
        {
            if (index != 0)
            {
                //Label[] subArray = _dataViewer.GetLabels()[index];
                //_customerID = subArray[0].Text;
                //NICTxtBox.Text = subArray[1].Text;

                //FirstNameTxtBox.Text = subArray[2].Text;
                //LastNameTxtBox.Text = subArray[3].Text;
                //ContactNumberTxtBox.Text = subArray[4].Text;

                DataRow record = s_queryHandler.SelectQueryHandler("SELECT * FROM customer").Rows[index-1];
                _customerID = record[0].ToString();
                NICTxtBox.Text = record[1].ToString();
                _initialNIC = record[1].ToString();
                FirstNameTxtBox.Text = record[2].ToString();
                LastNameTxtBox.Text = record[3].ToString();
                ContactNumberTxtBox.Text = record[4].ToString();
                _initialContactNumber = record[4].ToString();
                GenderCmbBox.Text = record[5].ToString();
            }
        }

        private void DisplayTable()
        {
            TablePanel.Controls.Clear();
            _dataViewer = new DataViewer(TablePanel, s_queryHandler.SelectQueryHandler("SELECT * FROM customer"));
            _dataViewer.DisplayTable();
            AddCellClickEvent(_dataViewer, Cell_Click, Cell_MouseEnter, Cell_MouseLeave);
        }
        //
        // Mouse click event handlers
        //
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string NIC = NICTxtBox.Text;
            string firstName = FirstNameTxtBox.Text;
            string lastName = LastNameTxtBox.Text;
            string contactNumber = ContactNumberTxtBox.Text;
            GenderOptions gender = ConvertStringToGenderOption(GenderCmbBox.Text);

            if (ValidateInput(NIC, firstName, lastName, contactNumber, gender.ToString(), GenderCmbBox.SelectedIndex))
            {
                Customer customer = new Customer(NIC, firstName, lastName, contactNumber, gender);
                if (customer.Insert())
                {
                    MessagePrinter.PrintToMessageBox("Customer details were successfully inserted", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTable();
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to insert customer details", "Operation failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Reset();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if(!_rowSelected)
            {
                MessagePrinter.PrintToMessageBox("Please select a customer record", "Select a record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string NIC = NICTxtBox.Text;
            string firstName = FirstNameTxtBox.Text;
            string lastName = LastNameTxtBox.Text;
            string contactNumber = ContactNumberTxtBox.Text;
            string genderText = GenderCmbBox.Text.ToLower();
            GenderOptions gender = ConvertStringToGenderOption(GenderCmbBox.Text);

            if (ValidateInput(NIC, firstName, lastName, contactNumber, gender.ToString(), GenderCmbBox.SelectedIndex))
            {
                Customer customer = new Customer(NIC, firstName, lastName, contactNumber, gender);
                if (customer.Update(_customerID))
                {
                    MessagePrinter.PrintToMessageBox("Customer details were successfully updated", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTable();
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to update customer details", "Operation failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Reset();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ResetErrors();

            if(!_rowSelected)
            {
                MessagePrinter.PrintToMessageBox("Please select a customer record", "Select a record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessagePrinter.PrintToMessageBoxV2("Are you sure you want to delete the record? Once deleted, it cannot be recoverd.",
                "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if(Customer.Delete(_customerID))
                    {
                        MessagePrinter.PrintToMessageBox("Customer details were successfully deleted", "Operation successful", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    DisplayTable();
                    Reset();
                }
            }
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

            if(_selectedRow != null)
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
                if(!_rowSelected)
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
        // Text box event handlers
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
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
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
    }
}
