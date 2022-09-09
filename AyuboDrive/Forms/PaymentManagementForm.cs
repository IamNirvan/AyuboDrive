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
    public partial class PaymentManagementForm : AyuboDriveTemplateForm
    {
        private static QueryHandler _queryHandler = new QueryHandler();
        private DataViewer _dataViewer;
        private string _paymentID = null;
        private bool _rowSelected = false;
        private Panel _selectedRow = null;

        public PaymentManagementForm(Form dashboardForm) : base(dashboardForm)
        {
            InitializeComponent();
            HandleTitleBar();
        }
        //
        // Utility
        //
        private bool ValidateInput(string hireBookingID, int hireBookingIDSelectedIndex, 
            string rentalBookingID, int rentalBookingIDSelectedIndex, 
            string customerID, int customerIDSelectedIndex, string amountPaid)
        {
            bool validHireBookingID = false;
            bool validRentalBookingID = false;
            bool validCustomerID = false;
            bool validAmountPaid = false;

            if(!HireBookingsRBtn.Checked)
            {
                validHireBookingID = true;
                HireBookingIDErrorLbl.Text = "";
                HireBookingIDPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else if (hireBookingID.Length != 0 && hireBookingIDSelectedIndex >= 0)
            {
                validHireBookingID = true;
                HireBookingIDErrorLbl.Text = "";
                HireBookingIDPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                HireBookingIDErrorLbl.Text = "Invalid hire booking ID";
                HireBookingIDPnl.BackColor = Properties.Settings.Default.RED;
            }

            if(!RentalBookingsRBtn.Checked)
            {
                validRentalBookingID = true;
                RentalBookingIDErrorLbl.Text = "";
                RentalBookingIDPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else if (rentalBookingID.Length != 0 && rentalBookingIDSelectedIndex >= 0)
            {
                validRentalBookingID = true;
                RentalBookingIDErrorLbl.Text = "";
                RentalBookingIDPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                RentalBookingIDErrorLbl.Text = "Invalid rental booking ID";
                RentalBookingIDPnl.BackColor = Properties.Settings.Default.RED;
            }

            if (customerID.Length != 0 && customerIDSelectedIndex >= 0)
            {
                validCustomerID = true;
                CustomerIDErrorLbl.Text = "";
                CustomerIDPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                CustomerIDErrorLbl.Text = "Invalid customer ID";
                CustomerIDPnl.BackColor = Properties.Settings.Default.RED;
            }

            if(amountPaid.Length != 0 && double.Parse(amountPaid) >= 0)
            {
                validAmountPaid = true;
                AmountPaidErrorLbl.Text = "";
                AmountPaidPnl.BackColor = Properties.Settings.Default.PURPLE; ;
            }
            else
            {
                AmountPaidErrorLbl.Text = "Invalid payment value";
                AmountPaidPnl.BackColor = Properties.Settings.Default.RED;
            }
            return validHireBookingID && validRentalBookingID && validCustomerID && validAmountPaid;
        }

        private void Reset()
        {
            HireBookingIDCmbBox.Text = "";
            RentalBookingIDCmbBox.Text = "";
            CustomerIDCmbBox.Text = "";
            DateOfPaymentDTP.Text = "";
            AmountPaidTxtBox.Text = "";

            _rowSelected = false;
            if(_selectedRow != null)
            {
                _selectedRow.BackColor = Properties.Settings.Default.LIGHT_GRAY;
                _selectedRow = null;
            }
            _paymentID = null;
        }

        private void ResetErrors()
        {
            HireBookingIDErrorLbl.Text = "";
            HireBookingIDPnl.BackColor = Properties.Settings.Default.PURPLE;
            RentalBookingIDErrorLbl.Text = "";
            RentalBookingIDPnl.BackColor = Properties.Settings.Default.PURPLE;
            CustomerIDErrorLbl.Text = "";
            CustomerIDPnl.BackColor = Properties.Settings.Default.PURPLE;
            DateOfPaymentErrorLbl.Text = "";
            DateOfPaymentPnl.BackColor = Properties.Settings.Default.PURPLE;
            AmountPaidErrorLbl.Text = "";
            AmountPaidPnl.BackColor = Properties.Settings.Default.PURPLE;
        }

        private void AddData(int index)
        {
            if (index != 0)
            {
                Label[] subArray = _dataViewer.GetLabels()[index];
                _paymentID = subArray[0].Text;

                if(HireBookingsRBtn.Checked)
                {
                    HireBookingIDCmbBox.Text = $"Hire booking ID-{subArray[1].Text}";
                }
                else
                {
                    RentalBookingIDCmbBox.Text = $"Rental booking ID-{subArray[1].Text}";
                }

                DataRow customerRecord = _queryHandler.SelectQueryHandler("SELECT firstName, " +
                    "lastName FROM customer WHERE customerID = '"+ subArray[2].Text + "'").Rows[0];
                CustomerIDCmbBox.Text = $"{subArray[2].Text}-{customerRecord[0]} {customerRecord[1]}";
                DateOfPaymentDTP.Text = subArray[3].Text;
                AmountPaidTxtBox.Text = subArray[4].Text;
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
            string query;

            if(RentalBookingsRBtn.Checked)
            {
                query = "SELECT paymentID, rentalBookingID, customerID, dateOfPayment, " +
                    "amountPaid FROM payment WHERE rentalBookingID IS NOT NULL";
            }
            else
            {
                query = "SELECT paymentID, hireBookingID, customerID, dateOfPayment, " +
                    "amountPaid FROM payment WHERE hireBookingID IS NOT NULL";
            }

            TablePanel.Controls.Clear();
            _dataViewer = new DataViewer(TablePanel, _queryHandler.SelectQueryHandler(query));
            _dataViewer.DisplayTable();
            AddCellClickEvent();
        }
        //
        // Click event handlers
        //
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string hireBookingID = HireBookingIDCmbBox.Text;
            string rentalBookingID = RentalBookingIDCmbBox.Text;
            string customerID = CustomerIDCmbBox.Text;
            string dateOfPayment = DateOfPaymentDTP.Text;
            string amountPaid = AmountPaidTxtBox.Text;

            if (ValidateInput(hireBookingID, HireBookingIDCmbBox.SelectedIndex,
                rentalBookingID, RentalBookingIDCmbBox.SelectedIndex,
                customerID, CustomerIDCmbBox.SelectedIndex, amountPaid))
            {
                if (HireBookingsRBtn.Checked)
                {
                    hireBookingID = HireBookingIDCmbBox.Text.Split('-')[1];
                    rentalBookingID = null;

                }
                else
                {
                    rentalBookingID = RentalBookingIDCmbBox.Text.Split('-')[1];
                    hireBookingID = null;
                }

                customerID = CustomerIDCmbBox.Text.Split('-')[0];

                Payment payment = new Payment(hireBookingID, rentalBookingID, customerID, dateOfPayment, double.Parse(amountPaid));
                if (payment.Insert())
                {
                    MessagePrinter.PrintToMessageBox("Payment details were successfully inserted", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTable();
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to insert payment details", "Operation failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Reset();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string hireBookingID = HireBookingIDCmbBox.Text;
            string rentalBookingID = RentalBookingIDCmbBox.Text; ;
            string customerID = CustomerIDCmbBox.Text;
            string dateOfPayment = DateOfPaymentDTP.Text;
            string amountPaid = AmountPaidTxtBox.Text;

            if (ValidateInput(hireBookingID, HireBookingIDCmbBox.SelectedIndex,
                rentalBookingID, RentalBookingIDCmbBox.SelectedIndex,
                customerID, CustomerIDCmbBox.SelectedIndex, amountPaid))
            {
                if (HireBookingsRBtn.Checked)
                {
                    hireBookingID = HireBookingIDCmbBox.Text.Split('-')[1];
                    rentalBookingID = null;

                }
                else
                {
                    rentalBookingID = RentalBookingIDCmbBox.Text.Split('-')[1];
                    hireBookingID = null;
                }

                customerID = CustomerIDCmbBox.Text.Split('-')[0];
                Payment payment = new Payment(hireBookingID, rentalBookingID, customerID, dateOfPayment, double.Parse(amountPaid));
                if (payment.Update(_paymentID))
                {
                    MessagePrinter.PrintToMessageBox("Payment details were successfully updated", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTable();
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to update payment details", "Operation failed",
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
                MessagePrinter.PrintToMessageBox("Please select a payment record", "Select a record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessagePrinter.PrintToMessageBoxV2("Are you sure you want to delete the record? Once deleted, it cannot be recoverd.",
                "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (Payment.Delete(_paymentID))
                    {
                        MessagePrinter.PrintToMessageBox("Payment details were successfully deleted", "Operation successful",
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
                    Panel panel = _dataViewer.GetRows()[index];
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
                    Panel panel = _dataViewer.GetRows()[index];
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
        private void EnableRentalBookingObjects()
        {
            RentalBookingIDCmbBox.Visible = true;
            RentalBookingIDCmbBox.Visible = true;
            RentalBookingIDPnl.Visible = true;
            RentalBookingIDErrorLbl.Visible = true;
        }

        private void DisableRentalBookingObjects()
        {
            RentalBookingIDCmbBox.Visible = false;
            RentalBookingIDCmbBox.Visible = false;
            RentalBookingIDPnl.Visible = false;
            RentalBookingIDErrorLbl.Visible = false;
        }

        private void EnableHireBookingObjects()
        {
            HireBookingIDLbl.Visible = true;
            HireBookingIDCmbBox.Visible = true;
            HireBookingIDPnl.Visible = true;
            HireBookingIDErrorLbl.Visible = true;
        }

        private void DisableHireBookingObjects()
        {
            HireBookingIDLbl.Visible = false;
            HireBookingIDCmbBox.Visible = false;
            HireBookingIDPnl.Visible = false;
            HireBookingIDErrorLbl.Visible = false;
        }

        private void FillHireBookingIDComboBox()
        {
            HireBookingIDCmbBox.Items.Clear();
            foreach (DataRow row in _queryHandler.SelectQueryHandler("SELECT bookingID FROM hireBooking").Rows)
            {
                HireBookingIDCmbBox.Items.Add($"Hire booking ID-{row[0]}");
            }
            
        }

        private void FillCustomerIDComboBox()
        {
            HireBookingIDCmbBox.Items.Clear();
            foreach (DataRow row in _queryHandler.SelectQueryHandler("SELECT customerID, firstName, lastName FROM customer").Rows)
            {
                CustomerIDCmbBox.Items.Add($"{row[0]}-{row[1]} {row[2]}");
            }
        }

        private void FillRentalBookingIDComboBox()
        {
            RentalBookingIDCmbBox.Items.Clear();
            foreach (DataRow row in _queryHandler.SelectQueryHandler("SELECT bookingID FROM rentalBooking").Rows)
            {
                RentalBookingIDCmbBox.Items.Add($"Rental booking ID-{row[0]}");
            }
        }
        //
        // Radio buttons check changed handler
        //
        private void HireBookingsRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (HireBookingsRBtn.Checked)
            {
                Reset();
                FillHireBookingIDComboBox();
                EnableHireBookingObjects();
                DisableRentalBookingObjects();
                DisplayTable();
            }
            else
            {
                DisableHireBookingObjects();
            }
        }

        private void RentalBookingsRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(RentalBookingsRBtn.Checked)
            {
                Reset();
                FillRentalBookingIDComboBox();
                EnableRentalBookingObjects();
                DisableHireBookingObjects();
                DisplayTable();
            }
            else
            {
                DisableRentalBookingObjects();
            }
        }
        //
        // Form load event handler
        //
        private void PaymentManagementForm_Load(object sender, EventArgs e)
        {
            DisplayTable();
            FillRentalBookingIDComboBox();
            FillCustomerIDComboBox();
        }
        //
        // Textbox event handler
        //
        private void AmountPaidTxtBox_Leave(object sender, EventArgs e)
        {
            AmountPaidTxtBox.ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }

        private void AmountPaidTxtBox_Enter(object sender, EventArgs e)
        {
            AmountPaidTxtBox.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }
    }
}
