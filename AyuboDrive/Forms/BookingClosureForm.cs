﻿using AyuboDrive.Engines;
using AyuboDrive.Enums;
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
    public partial class BookingClosureForm : AyuboDriveTemplateForm
    {
        private static QueryHandler _queryHandler = new QueryHandler();
        private DataViewer _dataViewer;
        private string _bookingID = null;
        private string _driverID = null;
        private string _vehicleTypeID = null;
        private string _vehicleID = null;
        private string _customerID = null;
        private DateTime _startDate;
        private string _packageID = null;
        private bool _rowSelected = false;
        private bool _paid = false;
        private Panel _selectedRow = null;

        private static string _defaultLongTourQuery = "SELECT bookingID, vehicleID, driverID, " +
            "customerID, packageID, startDate, endDate FROM hireBooking WHERE hireType = 'Long' AND hireStatus = 'Open'";
        private static string _defaultDayTourQuery = "SELECT bookingID, vehicleID, driverID, " +
            "customerID, packageID, startDate, endDate FROM hireBooking WHERE hireType = 'Day' AND hireStatus = 'Open'";
        private static string _defaulRentalQuery = "SELECT bookingID, vehicleID, driverID, " +
            "customerID, startDate, endDate FROM rentalBooking WHERE rentalStatus = 'Open'";

        public BookingClosureForm(DashboardForm dashboardForm) : base(dashboardForm)
        {
            InitializeComponent();
            HandleTitleBar();
            DisplayLongTourTable();
        }

        //
        // Mouse event handlers
        //
        private void CloseBookingBtn_MouseEnter(object sender, EventArgs e)
        {
            CloseBookingBtn.BackColor = Properties.Settings.Default.RED;
            CloseBookingBtn.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void CloseBookingBtn_MouseLeave(object sender, EventArgs e)
        {
            CloseBookingBtn.BackColor = Properties.Settings.Default.TRANSPARENT;
            CloseBookingBtn.ForeColor = Properties.Settings.Default.RED;
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            Reset();
            _paid = false;
            int index = Int32.Parse(((Label)sender).Name.Split('-')[1]);

            _rowSelected = true;
            Panel record = _dataViewer.GetRows()[index];
            SetData(index);

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
        private void CalculateTotal(int mileage, DateTime returnDate)
        {
            if (LongTourRBtn.Checked)
            {
                decimal[] charges = LongTourHireCalculator.GetHireValue(_vehicleID, _driverID, _packageID, _startDate, returnDate, mileage);
                ValueLbl.Text = (charges[0] + charges[1] + charges[2]).ToString();
            }
            else if (DayTourRBtn.Checked)
            {
                decimal[] charges = DayTourHireCalculator.GetHireValue(_vehicleID, _driverID, _packageID, _startDate, returnDate, mileage);
                ValueLbl.Text = (charges[0] + charges[1] + charges[2]).ToString();
            }
            else
            {
                ValueLbl.Text = RentCalculator.GetRentValue(_vehicleID, _startDate, returnDate, _driverID).ToString();
            }
        }

        private bool ValidateInput(string mileage)
        {
            if (ValidationHandler.ValidateDecimalInput(mileage))
            {
                EndMileageErrLbl.Text = "";
                EndMileagePnl.BackColor = Properties.Settings.Default.PURPLE;
                return true;
            }
            else
            {
                EndMileageErrLbl.Text = "Invalid mileage";
                EndMileagePnl.BackColor = Properties.Settings.Default.RED;
                return false;
            }
        }

        private void Reset()
        {
            ReturnDateDTP.Value = DateTime.Now.Date;
            EndMileageTxtBox.Text = "";
            ValueLbl.Text = "0.0";
            StartDateValueLbl.Text = "";
            StartMileageValueLbl.Text = "";
            _paid = false;

            _rowSelected = false;
            if (_selectedRow != null)
            {
                _selectedRow.BackColor = Properties.Settings.Default.LIGHT_GRAY;
                _selectedRow = null;
            }
            _bookingID = null;
        }

        private void ResetErrors()
        {
            ReturnDateErrLbl.Text = "";
            ReturnDatePnl.BackColor = Properties.Settings.Default.PURPLE;
            EndMileageErrLbl.Text = "";
            EndMileagePnl.BackColor = Properties.Settings.Default.PURPLE;
        }

        private void SetData(int index)
        {
            if (index != 0)
            {
                // Rental booking query
                string query = _defaulRentalQuery;

                if (LongTourRBtn.Checked)
                {
                    query = _defaultLongTourQuery;
                }
                else if (DayTourRBtn.Checked)
                {
                    query = _defaultDayTourQuery;
                }

                DataRow record = _queryHandler.SelectQueryHandler(query).Rows[index - 1];
                _bookingID = record["bookingID"].ToString();
                //_vehicleTypeID = record["vehicleTypeID"].ToString();
                _vehicleID = record["vehicleID"].ToString();
                _customerID = record["customerID"].ToString(); 
                _startDate = DateTime.Parse(record["startDate"].ToString());

                // The following only applies to hire bookings
                if(!RentalRBtn.Checked)
                {
                    _packageID = record["packageID"].ToString();
                    _driverID = record["driverID"].ToString(); 
                }
                else
                {
                    // Set the driver ID to null, if a driver was not used...
                    string value = record[3].ToString();
                    Console.WriteLine($"The value is: {value}");
                    _driverID = value.Equals("") ? null : value;
                    Console.WriteLine($"The driver ID is: {_driverID}");
                }

                string mileageQuery = "SELECT mileage from vehicle WHERE vehicleID = '" + _vehicleID + "'";
                StartDateValueLbl.Text = _startDate.ToString("dd/MM/yyyy");
                StartMileageValueLbl.Text = _queryHandler.SelectQueryHandler(mileageQuery).Rows[0][0].ToString();
                ReturnDateDTP.Value = DateTime.Parse(record["endDate"].ToString());
            }
        }

        private void DisplayTable()
        {
            if(RentalRBtn.Checked)
            {
                DisplayRentTable();
            }
            else if(LongTourRBtn.Checked)
            {
                DisplayLongTourTable();
            }
            else
            {
                DisplayDayTourTable();
            }
        }

        private void DisplayLongTourTable()
        {
            string query = _defaultLongTourQuery;
            TablePnl.Controls.Clear();
            _dataViewer = new DataViewer(TablePnl, _queryHandler.SelectQueryHandler(query));
            _dataViewer.DisplayTable();
            AddCellClickEvent(_dataViewer, Cell_Click, Cell_MouseEnter, Cell_MouseLeave);
        }

        private void DisplayDayTourTable()
        {
            string query = _defaultDayTourQuery;
            TablePnl.Controls.Clear();
            _dataViewer = new DataViewer(TablePnl, _queryHandler.SelectQueryHandler(query));
            _dataViewer.DisplayTable();
            AddCellClickEvent(_dataViewer, Cell_Click, Cell_MouseEnter, Cell_MouseLeave);
        }

        private void DisplayRentTable()
        {
            string query = _defaulRentalQuery;
            TablePnl.Controls.Clear();
            _dataViewer = new DataViewer(TablePnl, _queryHandler.SelectQueryHandler(query), RentalBooking.NullValuePlaceHolder);
            _dataViewer.DisplayTable();
            AddCellClickEvent(_dataViewer, Cell_Click, Cell_MouseEnter, Cell_MouseLeave);
        }
        //
        // Radiobuttons checked changed
        //
        private void LongTourRBtn_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
            ResetErrors();

            if (LongTourRBtn.Checked)
            {
                DisplayLongTourTable();
            }
        }

        private void DayTourRBtn_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
            ResetErrors();

            if (DayTourRBtn.Checked)
            {
                DisplayDayTourTable();
            }
        }

        private void RentalRBtn_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
            ResetErrors();

            if (RentalRBtn.Checked)
            {
                DisplayRentTable();
            }
        }
        //
        // Click event handlers
        //
        private void MakePaymentBtn_Click(object sender, EventArgs e)
        {
            DateTime returnDate = DateTime.Parse(ReturnDateDTP.Text);
            string mileage = EndMileageTxtBox.Text;

            if(!_rowSelected)
            {
                MessagePrinter.PrintToMessageBox("Please select a record", "Invalid record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(ValidateInput(mileage))
            {
                CalculateTotal(int.Parse(mileage), returnDate);

                // Make a payment of the calculated amount for the selected booking

                decimal amountToPay = decimal.Parse(ValueLbl.Text);
                string hireBookingID = "";
                string rentBookingID = "";

                if (RentalRBtn.Checked)
                {
                    rentBookingID = _bookingID;

                    RentalPayment rentalPayment = new RentalPayment(rentBookingID, _customerID, returnDate, amountToPay);
                    if (rentalPayment.Insert())
                    {
                        MessagePrinter.PrintToMessageBox("Payment details successfully inserted", "Operation successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _paid = true;
                    }
                    else
                    {
                        MessagePrinter.PrintToMessageBox("Failed to enter payment details", "Operation failed",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    hireBookingID = _bookingID;
                    HirePayment hirePayment = new HirePayment(hireBookingID, _customerID, returnDate, amountToPay);
                    if (hirePayment.Insert())
                    {
                        MessagePrinter.PrintToMessageBox("Payment details successfully inserted", "Operation successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _paid = true;
                    }
                    else
                    {
                        MessagePrinter.PrintToMessageBox("Failed to enter payment details", "Operation failed",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //Payment payment = new Payment(hireBookingID, rentBookingID, _customerID, returnDate.ToString("yyyy/MM/dd"), amountToPay);
                //if (payment.Insert())
                //{
                //    MessagePrinter.PrintToMessageBox("Payment details successfully inserted", "Operation successful",
                //        MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    _paid = true;
                //}
                //else
                //{
                //    MessagePrinter.PrintToMessageBox("Failed to enter payment details", "Operation failed",
                //       MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            if (!_rowSelected)
            {
                MessagePrinter.PrintToMessageBox("Please select a record", "Invalid record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime returnDate = DateTime.Parse(ReturnDateDTP.Text);
            string mileage = EndMileageTxtBox.Text;

            if(ValidateInput(mileage))
            {
                CalculateTotal(int.Parse(mileage), returnDate);
            }
        }

        private void CloseBookingBtn_Click(object sender, EventArgs e)
        {
            DateTime returnDate = DateTime.Parse(ReturnDateDTP.Text);
            PaymentStatus paymentStatus = PaymentStatus.PENDING;
            HireType bookingType = HireType.LONG;
            bool bookingDetailsUpdated = false;
            bool driverDetailsUpdated = false;
            bool vehicleDetailsUpdated = false;
            bool proceed = false;

            if(!_rowSelected)
            {
                MessagePrinter.PrintToMessageBox("Please select a booking record", "Select a record",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string mileage = EndMileageTxtBox.Text;
            
            if(ValidateInput(mileage)) {

                if (_paid)
                {
                    paymentStatus = PaymentStatus.PAID;
                    proceed = true;
                } 
                else
                {
                    DialogResult dialogResult = MessagePrinter.PrintToMessageBoxV2("You are attempting to close a booking without making a payment. Are you sure you want to proceed?",
                    "Unpaid booking", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        proceed = true;
                    }
                }

                if(proceed)
                {
                    if (DayTourRBtn.Checked)
                    {
                        bookingType = HireType.DAY;
                    }

                    // Update the record details
                    //IDatabaseManipulator booking;
                    if (!RentalRBtn.Checked)
                    {
                        //booking = new HireBooking(_vehicleTypeID, _vehicleID, _driverID, _customerID, _packageID,
                        //    BookingStatus.CLOSED, bookingType, _startDate, returnDate, paymentStatus);

                        // Update the payment status and rental status of the booking
                        if (!HireBooking.UpdateBooking(_bookingID, returnDate, paymentStatus))
                        {
                            MessagePrinter.PrintToMessageBox("Failed to update booking details. Manual modification is required",
                                "Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            bookingDetailsUpdated = true;
                        }
                    }
                    else
                    {
                        //booking = new RentalBooking(_vehicleTypeID, _vehicleID, _driverID, _customerID, _startDate,
                        //    returnDate, BookingStatus.CLOSED, paymentStatus);

                        // Update the payment status and rental status of the booking
                        if (!RentalBooking.UpdateBooking(_bookingID, returnDate, paymentStatus))
                        {
                            MessagePrinter.PrintToMessageBox("Failed to update booking details. Manual modification is required",
                                "Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            bookingDetailsUpdated = true;
                        }
                    }
                    //bookingDetailsUpdated = booking.Update(_bookingID);

                    // Update driver details
                    if (_driverID != null)
                    {
                        driverDetailsUpdated = Driver.UpdateDriverAvailability(_driverID, DriverStatus.AVAILABLE);
                    }
                    else
                    {
                        driverDetailsUpdated = true;
                    }

                    // Update the vehicle details
                    vehicleDetailsUpdated = Vehicle.UpdateMileage(_vehicleID, int.Parse(mileage)) &&
                        Vehicle.UpdateAvailability(_vehicleID, Availability.AVAILABLE);

                    if (bookingDetailsUpdated && driverDetailsUpdated && vehicleDetailsUpdated)
                    {
                        MessagePrinter.PrintToMessageBox("Booking was successfully closed", "Operation successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayTable();
                        Reset();
                    }
                    else
                    {
                        MessagePrinter.PrintToMessageBox("Failed to close the booking", "Operation failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
        //
        // Textbox enter and leave event handler
        //
        private void TextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }
    } 
}
