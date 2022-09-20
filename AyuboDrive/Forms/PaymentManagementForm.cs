using AyuboDrive.Interfaces;
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
        private DataViewer _dataViewer;
        private string _query;
        private string _paymentID = null;
        private string _rentalBookingID = null;
        private string _hireBookingID = null;
        private bool _rowSelected = false;
        private Panel _selectedRow = null;

        public PaymentManagementForm(DashboardForm dashboardForm) : base(dashboardForm)
        {
            InitializeComponent();
            HandleTitleBar();
            FillRentalBookingIDComboBox();
            FillCustomerIDComboBox();
            DisplayTable();
            _query = "SELECT paymentID, rentalBookingID, customerID, dateOfPayment, " +
                    "amountPaid FROM rentalPayment";
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
            else if (ValidationHandler.ValidateInputLength(hireBookingID))
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
            else if (ValidationHandler.ValidateInputLength(rentalBookingID))
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

            if (ValidationHandler.ValidateComboBoxValue(customerID, customerIDSelectedIndex))
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

            if(ValidationHandler.ValidateDecimalInput(amountPaid))
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
                //Label[] subArray = _dataViewer.GetLabels()[index];
                DataRow record = QueryHandler.SelectQueryHandler(_query).Rows[index-1];
                _paymentID = record[0].ToString();

                if(HireBookingsRBtn.Checked)
                {
                    HireBookingIDCmbBox.Text = $"Hire booking ID-{record[1].ToString()}";
                    _hireBookingID = record[1].ToString();
                }
                else
                {
                    RentalBookingIDCmbBox.Text = $"Rental booking ID-{record[1].ToString()}";
                    _rentalBookingID = record[1].ToString();
                }

                DataRow customerRecord = QueryHandler.SelectQueryHandler("SELECT firstName, " +
                    "lastName FROM customer WHERE customerID = '"+ record[2].ToString() + "'").Rows[0];
                CustomerIDCmbBox.Text = $"{record[2].ToString()}-{customerRecord[0]} {customerRecord[1]}";
                DateOfPaymentDTP.Text = record[3].ToString();
                AmountPaidTxtBox.Text = record[4].ToString();
            }
        }
        
        private void DisplayTable()
        {
            if(RentalBookingsRBtn.Checked)
            {
                _query = "SELECT paymentID, rentalBookingID, customerID, dateOfPayment, " +
                    "amountPaid FROM rentalPayment";
            }
            else
            {
                _query = "SELECT paymentID, hireBookingID, customerID, dateOfPayment, " +
                    "amountPaid FROM hirePayment";
            }

            TablePanel.Controls.Clear();
            DataTable dataTable = QueryHandler.SelectQueryHandler(_query);

            if(dataTable != null)
            {
                _dataViewer = new DataViewer(TablePanel, dataTable);
                _dataViewer.DisplayTable();
                AddCellClickEvent(_dataViewer, Cell_Click, Cell_MouseEnter, Cell_MouseLeave);
            }
        }

        private void EnableRentalBookingObjects()
        {
            RentalBookingIDLbl.Visible = true;
            RentalBookingIDCmbBox.Visible = true;
            RentalBookingIDPnl.Visible = true;
            RentalBookingIDErrorLbl.Visible = true;
        }

        private void DisableRentalBookingObjects()
        {
            RentalBookingIDLbl.Visible = false;
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
            foreach (DataRow row in QueryHandler.SelectQueryHandler("SELECT bookingID FROM hireBooking  WHERE paymentStatus = 'pending'").Rows)
            {
                HireBookingIDCmbBox.Items.Add($"Hire booking ID-{row[0]}");
            }
        }

        private void FillCustomerIDComboBox()
        {
            CustomerIDCmbBox.Items.Clear();
            CustomerIDCmbBox.Text = "";
            string query = "SELECT customerID, firstName, lastName FROM customer";

            foreach (DataRow row in QueryHandler.SelectQueryHandler(query).Rows)
            {
                CustomerIDCmbBox.Items.Add($"{row[0]}-{row[1]} {row[2]}");
            }
        }

        private void FillRentalBookingIDComboBox()
        {
            RentalBookingIDCmbBox.Items.Clear();
            foreach (DataRow row in QueryHandler.SelectQueryHandler("SELECT bookingID FROM rentalBooking WHERE paymentStatus = 'pending'").Rows)
            {
                RentalBookingIDCmbBox.Items.Add($"Rental booking ID-{row[0]}");
            }
        }

        /// <summary>
        /// Sets the customer ID of a particular booking 
        /// record when the booking ID is selected
        /// </summary>
        private void SetCustomerID()
        {
            string query;

            if(RentalBookingsRBtn.Checked)
            {
                string rentalBookingID = RentalBookingIDCmbBox.Text.Split('-')[1];
                string customerID = QueryHandler.SelectQueryHandler("SELECT customerID from " +
                    $"rentalBooking where bookingID = '{rentalBookingID}'").Rows[0][0].ToString();

                query = $"SELECT customerID, firstName, lastName FROM customer WHERE " +
                    $"customerID = '{customerID}'";
            }
            else
            {
                string hireBookingID = HireBookingIDCmbBox.Text.Split('-')[1];
                string customerID = QueryHandler.SelectQueryHandler("SELECT customerID from " +
                    $"hireBooking where bookingID = '{hireBookingID}'").Rows[0][0].ToString();

                query = $"SELECT customerID, firstName, lastName FROM customer WHERE " +
                    $"customerID = '{customerID}'";
            }

            DataRow record = QueryHandler.SelectQueryHandler(query).Rows[0];
            CustomerIDCmbBox.Text = $"{record[0]}-{record[1]} {record[2]}";
        }
        //
        // Click event handlers
        //
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string hireBookingID = HireBookingIDCmbBox.Text;
            string rentalBookingID = RentalBookingIDCmbBox.Text;
            string customerID = CustomerIDCmbBox.Text;
            DateTime dateOfPayment = DateTime.Parse(DateOfPaymentDTP.Text);
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

                // Identify what table the record must be inserted into
                // Make an instance of an approrpiate payment class (HirePayment or RentalPayment)
                // and insert the new record
                IDatabaseManipulator payment;
                if(RentalBookingsRBtn.Checked)
                {
                    payment = new RentalPayment(rentalBookingID, customerID, 
                        dateOfPayment, decimal.Parse(amountPaid));

                    // Update the payment status and rental status of the booking
                    if(!RentalBooking.UpdateBooking(rentalBookingID))
                    {
                        MessagePrinter.PrintToMessageBox("Failed to update booking details. Manual modification is required", 
                            "Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    payment = new HirePayment(hireBookingID, customerID,
                        dateOfPayment, decimal.Parse(amountPaid));

                    // Update the payment status and rental status of the booking
                    if (!HireBooking.UpdateBooking(hireBookingID))
                    {
                        MessagePrinter.PrintToMessageBox("Failed to update booking details. Manual modification is required",
                            "Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

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
                DisplayTable();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string hireBookingID = HireBookingIDCmbBox.Text;
            string rentalBookingID = RentalBookingIDCmbBox.Text;
            string customerID = CustomerIDCmbBox.Text;
            DateTime dateOfPayment = DateTime.Parse(DateOfPaymentDTP.Text);
            string amountPaid = AmountPaidTxtBox.Text;

            if (ValidateInput(hireBookingID, HireBookingIDCmbBox.SelectedIndex,
                rentalBookingID, RentalBookingIDCmbBox.SelectedIndex,
                customerID, CustomerIDCmbBox.SelectedIndex, amountPaid))
            {
                if (HireBookingsRBtn.Checked)
                {
                    hireBookingID = hireBookingID.Split('-')[1];
                    _hireBookingID = hireBookingID;
                    _rentalBookingID = null;
                }
                else
                {
                    rentalBookingID = rentalBookingID.Split('-')[1];
                    _rentalBookingID = rentalBookingID;
                    _hireBookingID = null;
                }

                customerID = CustomerIDCmbBox.Text.Split('-')[0];
                IDatabaseManipulator payment;
                if (RentalBookingsRBtn.Checked)
                {
                    payment = new RentalPayment(rentalBookingID, customerID,
                        dateOfPayment, decimal.Parse(amountPaid));
                }
                else
                {
                    payment = new HirePayment(hireBookingID, customerID,
                        dateOfPayment, decimal.Parse(amountPaid));
                }

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
                return;
            }
            DialogResult result = MessagePrinter.PrintToMessageBoxV2("Are you sure you want to delete the record? Once deleted, it cannot be recoverd.",
            "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if(RentalBookingsRBtn.Checked)
                {
                    // Change the pending status to pending if the record is deleted
                    if(!RentalBooking.UpdateBooking(_rentalBookingID, Enums.PaymentStatus.PENDING))
                    {
                        MessagePrinter.PrintToMessageBox("Failed to update rental booking details", "Operation failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if(!RentalPayment.Delete(_paymentID)) {
                        MessagePrinter.PrintToMessageBox("Failed to delete rental payment details", "Operation failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    // Change the pending status to pending if the record is deleted
                    if (!HireBooking.UpdateBooking(_hireBookingID, Enums.PaymentStatus.PENDING))
                    {
                        MessagePrinter.PrintToMessageBox("Failed to update hire booking details", "Operation failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!HirePayment.Delete(_paymentID))
                    {
                        MessagePrinter.PrintToMessageBox("Failed to delete hire payment details", "Operation failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                MessagePrinter.PrintToMessageBox("Payment details were successfully deleted", "Operation successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayTable();
                Reset();
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
        // Radio buttons check changed handler
        //
        private void HireBookingsRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (HireBookingsRBtn.Checked)
            {
                Reset();
                FillHireBookingIDComboBox();
                DisableRentalBookingObjects();
                EnableHireBookingObjects();
                
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
        // 
        // Text box key press event handler
        //
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

        private void RentalBookingIDCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(RentalBookingIDCmbBox.SelectedIndex >= 0)
            {
                SetCustomerID();
            }
        }

        private void HireBookingIDCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(HireBookingIDCmbBox.SelectedIndex >= 0)
            {
                SetCustomerID();
            }
        }
    }
}
