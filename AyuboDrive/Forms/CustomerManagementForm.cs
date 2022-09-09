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
        private static QueryHandler _queryHandler = new QueryHandler();
        private DataViewer _dataViewer;
        private string _customerID = null;
        private bool _rowSelected = false;
        private Panel _selectedRow = null;

        public CustomerManagementForm(Form dashboardForm) : base(dashboardForm)
        {
            InitializeComponent();
            HandleTitleBar();
        }
        //
        // Utility functions
        //
        private bool ValidateInput(string NIC, string firstName, string lastName, string contactNumber)
        {
            bool validNIC = false;
            bool validFirstName = false;
            bool validLastName = false;
            bool validContactNumber = false;

            if(NIC.Length == 12)
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

            if (firstName.Length != 0)
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

            if (lastName.Length != 0)
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

            if (contactNumber.Length == 10)
            {
                validContactNumber = true;
                ContactNumberErrorLbl.Text = "";
                ContactNumberPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                ContactNumberErrorLbl.Text = "Invalid contact number";
                ContactNumberPnl.BackColor = Properties.Settings.Default.RED;
            }
            return validNIC && validFirstName && validLastName && validContactNumber;
        }

        private void Reset()
        {
            NICTxtBox.Text = "";
            FirstNameTxtBox.Text = "";
            LastNameTxtBox.Text = "";
            ContactNumberTxtBox.Text = "";
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
            ContactNumberErrorLbl.Text = "";
            ContactNumberPnl.BackColor = Properties.Settings.Default.PURPLE;
        }

        private void AddData(int index)
        {
            if (index != 0)
            {
                Label[] subArray = _dataViewer.GetLabels()[index];
                _customerID = subArray[0].Text;
                NICTxtBox.Text = subArray[1].Text;
                FirstNameTxtBox.Text = subArray[2].Text;
                LastNameTxtBox.Text = subArray[3].Text;
                ContactNumberTxtBox.Text = subArray[4].Text;
            }
        }

        private void AddCellClickEvent()
        {
            try
            {
                foreach (Label[] cells in _dataViewer.GetLabels())
                {
                    foreach (Label cell in cells)
                    {
                        if (cell != null)
                        {
                            cell.Click += new EventHandler(Cell_Click);
                            cell.MouseEnter += new EventHandler(Cell_MouseEnter);
                            cell.MouseLeave += new EventHandler(Cell_MouseLeave);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occurred when adding the event handlers");
            }
        }

        private void DisplayTable()
        {
            TablePanel.Controls.Clear();
            _dataViewer = new DataViewer(TablePanel, _queryHandler.SelectQueryHandler("SELECT * FROM customer"));
            _dataViewer.DisplayTable();
            AddCellClickEvent();
        }
        //
        // Data manipulation event handlers
        //
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string NIC = NICTxtBox.Text;
            string firstName = FirstNameTxtBox.Text;
            string lastName = LastNameTxtBox.Text;
            string contactNumber = ContactNumberTxtBox.Text;

            if (ValidateInput(NIC, firstName, lastName, contactNumber))
            {
                Customer customer = new Customer(NIC, firstName, lastName, contactNumber);
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
            string NIC = NICTxtBox.Text;
            string firstName = FirstNameTxtBox.Text;
            string lastName = LastNameTxtBox.Text;
            string contactNumber = ContactNumberTxtBox.Text;

            if (ValidateInput(NIC, firstName, lastName, contactNumber))
            {
                Customer customer = new Customer(NIC, firstName, lastName, contactNumber);
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
        // Form load handler
        //
        private void CustomerManagementForm_Load(object sender, EventArgs e)
        {
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
        private void NICTxtBox_Enter(object sender, EventArgs e)
        {
            NICTxtBox.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void NICTxtBox_Leave(object sender, EventArgs e)
        {
            NICTxtBox.ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }

        private void FirstNameTxtBox_Enter(object sender, EventArgs e)
        {
            FirstNameTxtBox.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void FirstNameTxtBox_Leave(object sender, EventArgs e)
        {
            FirstNameTxtBox.ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }

        private void LastNameTxtBox_Enter(object sender, EventArgs e)
        {
            LastNameTxtBox.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void LastNameTxtBox_Leave(object sender, EventArgs e)
        {
            LastNameTxtBox.ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }

        private void ContactNumberTxtBox_Enter(object sender, EventArgs e)
        {
            ContactNumberTxtBox.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void ContactNumberTxtBox_Leave(object sender, EventArgs e)
        {
            ContactNumberTxtBox.ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }
    }
}
