using AyuboDrive.Engines;
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
    public partial class RentalBookingManagementFormV2 : AyuboDriveTemplateForm
    {
        private static QueryHandler s_queryHandler = new QueryHandler();
        private VehicleViewerV2 _vehicleViewer;
        private DataViewer _dataViewer;
        private DataTable _dataTable;
        private string _bookingID;
        private string _initialVehicleID;
        private string _driverID;
        private string _rentalStatus;
        private bool _rowSelected = false;
        private Panel _selectedRow = null;
        private bool handlingMouseClick = false;
        private int _tablePnlMinHeight = 203;
        private int _tablePnlMaxHeight = 412;

        public RentalBookingManagementFormV2(DashboardForm dashboardForm) : base(dashboardForm)
        {
            InitializeComponent();
            HandleTitleBar();
            HideVehicleObjects();
            DisableDriverObjects();
            FillVechicleTypeIDCbmBox();
            FillVehicleIDCmbBox(false);
            FillDriverIDCmbBox();
            FillCustomerIDCmbBox();
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

        private void VehiclesCell_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(((Label)sender).Name.Split('-')[1]);
            _rowSelected = true;
            handlingMouseClick = true;

            Panel container = _vehicleViewer.GetContainers()[index];
            AddDataVehicleView(index);

            if (_selectedRow != null)
            {
                _selectedRow.BackColor = Properties.Settings.Default.LIGHT_GRAY;
            }

            _selectedRow = container;
            container.BackColor = Properties.Settings.Default.LIGHTER_GRAY;
            ResetErrors();
        }

        private void VehiclesCell_MouseEnter(object sender, EventArgs e)
        {
            // Get the number associated with the interactive label name.
            int index = Int32.Parse(((Label)sender).Name.Split('-')[1]);

            if (!_rowSelected)
            {
                Panel panel = _vehicleViewer.GetContainers()[index]; // Access the label's container
                panel.BackColor = Properties.Settings.Default.LIGHTER_GRAY;
            }

            _vehicleViewer.GetVehicleNames()[index].ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void VehiclesCell_MouseLeave(object sender, EventArgs e)
        {
            // Get the number associated with the label name. For example: panel-0
            int index = Int32.Parse(((Label)sender).Name.Split('-')[1]);

            if (!_rowSelected)
            {
                Panel panel = _vehicleViewer.GetContainers()[index]; // Access the parent panel
                panel.BackColor = Properties.Settings.Default.LIGHT_GRAY;
            }

            _vehicleViewer.GetVehicleNames()[index].ForeColor = Properties.Settings.Default.DISABLED_WHITE;
            handlingMouseClick = false;
        }

        private void TableCell_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(((Label)sender).Name.Split('-')[1]);
            Reset();

            _rowSelected = true;
            Panel record = _dataViewer.GetRows()[index];
            AddDataTableView(index);

            if (_selectedRow != null)
            {
                _selectedRow.BackColor = Properties.Settings.Default.LIGHT_GRAY;
            }

            _selectedRow = record;
            record.BackColor = Properties.Settings.Default.LIGHTER_GRAY;
            ResetErrors();
        }

        private void TableCell_MouseEnter(object sender, EventArgs e)
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

        private void TableCell_MouseLeave(object sender, EventArgs e)
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
        private void Reset()
        {
            VehicleTypeIDCmbBox.Text = "";
            VehicleIDCmbBox.Text = "";
            DriverIDCmbBox.Text = "";
            CustomerIDCmbBox.Text = "";
            StartDateDTP.Value = DateTime.Now.Date;
            EndDateDTP.Value = DateTime.Now.Date;

            _rowSelected = false;
            if (_selectedRow != null)
            {
                _selectedRow.BackColor = Properties.Settings.Default.LIGHT_GRAY;
                _selectedRow = null;
            }
            _bookingID = null;
        }

        private bool ValidateInput(string vehicleTypeID, string vehicleID, int vehicleIDSelectedIndex,
            string driverID, int driverIDSelectedIndex, string customerID, DateTime startDate, DateTime endDate)
        {
            bool validVehicleTypeID = false;
            bool validVehicleID = false;
            bool validDriverID = false;
            bool validCustomerID = false;
            bool validDate = false;

            if (ValidationHandler.ValidateInputLength(vehicleTypeID))
            {
                validVehicleTypeID = true;
                VehicleTypeIDPnl.BackColor = Properties.Settings.Default.PURPLE;
                VehicleTypeIDErrLbl.Text = "";
            }
            else
            {
                VehicleTypeIDPnl.BackColor = Properties.Settings.Default.RED;
                VehicleTypeIDErrLbl.Text = "Invalid vehicle type ID";
            }

            if (ValidationHandler.ValidateComboBoxValue(vehicleID, vehicleIDSelectedIndex))
            {
                validVehicleID = true;
                VehicleIDPnl.BackColor = Properties.Settings.Default.PURPLE;
                VehicleIDErrLbl.Text = "";
            }
            else
            {
                VehicleIDPnl.BackColor = Properties.Settings.Default.RED;
                VehicleIDErrLbl.Text = "Invalid vehicle ID";
            }

            if(driverID == null)
            {
                validDriverID = true;
                DriverIDPnl.BackColor = Properties.Settings.Default.PURPLE;
                DriverIDErrLbl.Text = "";
            }
            else if (ValidationHandler.ValidateComboBoxValue(driverID, driverIDSelectedIndex))
            {
                validDriverID = true;
                DriverIDPnl.BackColor = Properties.Settings.Default.PURPLE;
                DriverIDErrLbl.Text = "";
            }
            else
            {
                DriverIDPnl.BackColor = Properties.Settings.Default.RED;
                DriverIDErrLbl.Text = "Invalid driver ID";
            }

            if (ValidationHandler.ValidateInputLength(customerID))
            {
                validCustomerID = true;
                CustomerIDPnl.BackColor = Properties.Settings.Default.PURPLE;
                CustomerIDErrLbl.Text = "";
            }
            else
            {
                CustomerIDPnl.BackColor = Properties.Settings.Default.RED;
                CustomerIDErrLbl.Text = "Invalid customer ID";
            }
            
            if(ValidationHandler.ValidateDate(startDate, endDate))
            {
                validDate = true;
                EndDateErrLbl.Text = "";
                EndDatePnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                EndDateErrLbl.Text = "Invalid end date";
                EndDatePnl.BackColor = Properties.Settings.Default.RED;
            }
            return validVehicleTypeID && validVehicleID && validDriverID && validCustomerID && validDate;
        }

        private BookingStatus ConvertStringToBookingStatus(string bookingStatusString)
        {
            if (bookingStatusString.Equals("open"))
            {
                return BookingStatus.OPEN;
            }
            return BookingStatus.CLOSED;
        }

        private PaymentStatus ConvertStringToPaymentStatus(string paymentStatusString)
        {
            if (paymentStatusString.Equals("pending"))
            {
                return PaymentStatus.PENDING;
            }
            return PaymentStatus.PAID;
        }

        private void DisableDriverObjects()
        {
            DriverIDCmbBox.Enabled = false;
            DriverIDErrLbl.Text = "";
            DriverIDPnl.BackColor = Properties.Settings.Default.DISABLED_WHITE;
        }

        private void EnableDriverObjects()
        {
            DriverIDCmbBox.Enabled = true;
            DriverIDErrLbl.Text = "";
            DriverIDPnl.BackColor = Properties.Settings.Default.PURPLE;
        }

        private void HideVehicleObjects()
        {
            VehiclePnl.Visible = false;
        }

        private void ShowVehicleObjects()
        {
            VehiclePnl.Visible = true;
        }

        private void AddDataVehicleView(int index)
        {
            DataRow record = s_queryHandler.SelectQueryHandler("SELECT * from vehicle WHERE vehicleStatus = 'Available'").Rows[index];

            DataRow vehicleTypeRecord = s_queryHandler.SelectQueryHandler("SELECT typeName from vehicleType WHERE vehicleTypeID = '" +
                record[2].ToString() + "'").Rows[0];

            VehicleIDCmbBox.Text = $"{record[0].ToString()}-{record[3].ToString()} {record[4].ToString()}";
            VehicleTypeIDCmbBox.Text = $"{record[2].ToString()}-{vehicleTypeRecord[0]}";
        }

        private void AddDataTableView(int index)
        {
            if (index != 0)
            {
                DataRow record = s_queryHandler.SelectQueryHandler("SELECT * FROM rentalBooking").Rows[index - 1];

                DataRow vehicleTypeRecord = s_queryHandler.SelectQueryHandler("SELECT typeName from vehicleType WHERE vehicleTypeID = '" +
                    record[1].ToString() + "'").Rows[0];

                DataRow vehicleRecord = s_queryHandler.SelectQueryHandler("SELECT manufacturer, model from vehicle WHERE vehicleID = '" +
                    record[2].ToString() + "'").Rows[0];

                // Handle records that don't have a driver ID. Also check if the chekcbox is selected.
                if (record[3].ToString() != "" && DriverCheckBox.Checked)
                {
                    DataRow driverRecord = s_queryHandler.SelectQueryHandler("SELECT firstName, lastName from driver WHERE driverID = '" +
                        record[3].ToString() + "'").Rows[0];
                    DriverIDCmbBox.Text = $"{record[3].ToString()}-{driverRecord[0]} {driverRecord[1]}";
                }
                else
                {
                    DriverIDCmbBox.Text = "";
                }

                DataRow customerRecord = s_queryHandler.SelectQueryHandler("SELECT firstName, lastName from customer WHERE customerID = '" +
                    record[4].ToString() + "'").Rows[0];

                _bookingID = record[0].ToString();
                VehicleTypeIDCmbBox.Text = $"{record[1].ToString()}-{vehicleTypeRecord[0]}";
                VehicleIDCmbBox.Text = $"{record[2].ToString()}-{vehicleRecord[0]} {vehicleRecord[1]}";
                _initialVehicleID = record[2].ToString();

                string value = record[3].ToString();
                _driverID = value.Equals("") ? null : value;

                CustomerIDCmbBox.Text = $"{record[4].ToString()}-{customerRecord[0]} {customerRecord[1]}";
                StartDateDTP.Text = record[5].ToString();
                EndDateDTP.Text = record[6].ToString();
                _rentalStatus = record[7].ToString();
            }
        }

        private void ResetErrors()
        {
            VehicleTypeIDErrLbl.Text = "";
            VehicleIDErrLbl.Text = "";
            DriverIDErrLbl.Text = "";
            CustomerIDErrLbl.Text = "";
            StartDateErrLbl.Text = "";
            EndDateErrLbl.Text = "";

            VehicleTypeIDPnl.BackColor = Properties.Settings.Default.PURPLE;
            VehicleIDPnl.BackColor = Properties.Settings.Default.PURPLE;
            DriverIDPnl.BackColor = DriverCheckBox.Checked ? Properties.Settings.Default.PURPLE : Properties.Settings.Default.DISABLED_WHITE;
            CustomerIDPnl.BackColor = Properties.Settings.Default.PURPLE;
            StartDatePnl.BackColor = Properties.Settings.Default.PURPLE;
            EndDatePnl.BackColor = Properties.Settings.Default.PURPLE;
        }

        private void DisplayTable(string query = "SELECT * FROM rentalBooking")
        {
            _dataTable = s_queryHandler.SelectQueryHandler(query);
            TablePnl.Controls.Clear();
            _dataViewer = new DataViewer(TablePnl, _dataTable);
            _dataViewer.DisplayTable();
            AddCellClickEvent(_dataViewer, TableCell_Click, TableCell_MouseEnter, TableCell_MouseLeave);
        }

        private void DisplayVehicles(bool invokedByType = false)
        {
            string query = "SELECT * FROM vehicle WHERE vehicleStatus = 'Available'";

            if (invokedByType)
            {
                string vehicleTypeID = VehicleTypeIDCmbBox.Text.Split('-')[0];
                query = "SELECT * FROM vehicle WHERE vehicleStatus = " +
                    "'Available' AND vehicleTypeID = '" + vehicleTypeID + "'";
            }

            _dataTable = s_queryHandler.SelectQueryHandler(query);
            VehiclePnl.Controls.Clear();

            _vehicleViewer = new VehicleViewerV2(VehiclePnl, _dataTable, 120, 120, null);
            _vehicleViewer.Display();
            AddVehicleCellClickEvent(_vehicleViewer, VehiclesCell_Click, VehiclesCell_MouseEnter, VehiclesCell_MouseLeave);
        }

        private void FillVechicleTypeIDCbmBox()
        {
            VehicleTypeIDCmbBox.Items.Clear();
            foreach (DataRow record in s_queryHandler.SelectQueryHandler("SELECT * FROM vehicleType").Rows)
            {
                // Format: {typeID}-{typeName}
                VehicleTypeIDCmbBox.Items.Add($"{record[0]}-{record[1]}");
            }
        }

        /// <summary>
        /// This method will be invoked whenever the user selects a vehicle type ID, 
        /// to only include vehicles that match that vehicle type ID. If a vehicle type ID is not selected,
        /// then it will display vehicle IDs for all the available vehicles.
        /// </summary>
        /// <param name="invokedByType">Determines whether this function executed as a result of changing 
        /// the vehicle type ID. If it is the inital fill when the form loads, this will be false</param>
        private void FillVehicleIDCmbBox(bool invokedByType = false)
        {
            VehicleIDCmbBox.Items.Clear();
            VehicleIDCmbBox.Text = "";
            string query = "SELECT vehicleID, manufacturer, model FROM vehicle WHERE vehicleStatus = 'available'";
            // If a vehicle type ID is chosen, filter the vehicle IDs based on the selected vehicle type ID
            // Otherwise show the vehicle IDs of every available vehicle.
            if (invokedByType)
            {
                string vehicleTypeID = VehicleTypeIDCmbBox.Text.Split('-')[0];
                query = "SELECT vehicleID, manufacturer, model FROM vehicle WHERE vehicleStatus = " +
                    "'available' AND vehicleTypeID = '" + vehicleTypeID + "'";
            }

            foreach (DataRow record in s_queryHandler.SelectQueryHandler(query).Rows)
            {
                // Format: {vehicleID}-{manufacturer} {model}
                VehicleIDCmbBox.Items.Add($"{record[0]}-{record[1]} {record[2]}");
            }
        }

        private void FillDriverIDCmbBox()
        {
            DriverIDCmbBox.Items.Clear();
            string query = "SELECT driverID, firstName, lastName from driver WHERE driverStatus = 'Available'";

            foreach (DataRow record in s_queryHandler.SelectQueryHandler(query).Rows)
            {
                // Format: {driverID}-{first name} {last name}
                DriverIDCmbBox.Items.Add($"{record[0]}-{record[1]} {record[2]}");
            }
        }

        private void FillCustomerIDCmbBox()
        {
            CustomerIDCmbBox.Items.Clear();
            string query = "SELECT customerID, firstName, lastName from customer";

            foreach (DataRow record in s_queryHandler.SelectQueryHandler(query).Rows)
            {
                // Format: {customerID}-{first name} {last name}
                CustomerIDCmbBox.Items.Add($"{record[0]}-{record[1]} {record[2]}");
            }
        }
        //
        // Combo box selected index changed event handler
        //
        private void VehicleTypeIDCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!handlingMouseClick)
            {
                DisplayVehicles(true);
            }
            FillVehicleIDCmbBox(true);
        }
        //
        // Form load event handler
        //
        private void RentalBookingManagementFormV2_Load(object sender, EventArgs e)
        {
            DisplayTable();
        }
        //
        // Radio button check changed
        //
        private void BothViewRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (BothViewRBtn.Checked)
            {
                TablePnl.Height = _tablePnlMinHeight;
                ShowVehicleObjects();
                DisplayVehicles(false);
            }
        }

        private void TableViewRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (TableViewRBtn.Checked)
            {
                TablePnl.Height = _tablePnlMaxHeight;
                HideVehicleObjects();
            }
        }
        //
        // Check box check changed
        //
        private void DriverCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DriverCheckBox.Checked)
            {
                EnableDriverObjects();
            }
            else
            {
                DisableDriverObjects();
            }
        }
        //
        // Click event handlers
        //
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            if (VehicleTypeIDCmbBox.SelectedIndex >= 0)
            {
                DisplayVehicles(true);
            }
            else
            {
                DisplayVehicles();
            }
        }
        //
        // Data manipulation button functionality
        //
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string vehicleTypeID = VehicleTypeIDCmbBox.Text;
            string vehicleID = VehicleIDCmbBox.Text;
            string driverID = DriverCheckBox.Checked ? DriverIDCmbBox.Text : null;
            string customerID = CustomerIDCmbBox.Text;
            DateTime startDate = DateTime.Parse(StartDateDTP.Text);
            DateTime endDate = DateTime.Parse(EndDateDTP.Text);

            if (ValidateInput(vehicleTypeID, vehicleID, VehicleIDCmbBox.SelectedIndex,
                driverID, DriverIDCmbBox.SelectedIndex, customerID, startDate, endDate))
            {
                vehicleTypeID = vehicleTypeID.Split('-')[0];
                vehicleID = vehicleID.Split('-')[0];
                driverID = driverID == null ? null : driverID.Split('-')[0];
                customerID = customerID.Split('-')[0];

                if (Vehicle.UpdateAvailability(vehicleID, Availability.UNAVAILABLE))
                {
                    if (driverID != null)
                    {
                        if ( Driver.UpdateDriverAvailability(driverID, Availability.UNAVAILABLE))
                        {
                            RentalBooking rentalBooking = new RentalBooking(vehicleTypeID, vehicleID, driverID, customerID, startDate,
                            endDate, BookingStatus.OPEN, PaymentStatus.PENDING);
                            if (rentalBooking.Insert())
                            {
                                MessagePrinter.PrintToMessageBox("Rental booking details were successfully inserted", "Operation successful",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DisplayTable();
                                Reset();
                                FillVehicleIDCmbBox();
                            }
                            else
                            {
                                MessagePrinter.PrintToMessageBox("Failed to insert rental booking details", "Operation failed",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessagePrinter.PrintToMessageBox("Failed to update driver availabiliy", "Operation failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        RentalBooking rentalBooking = new RentalBooking(vehicleTypeID, vehicleID, driverID, customerID, startDate,
                           endDate, BookingStatus.OPEN, PaymentStatus.PENDING);
                        if (rentalBooking.Insert())
                        {
                            MessagePrinter.PrintToMessageBox("Rental booking details were successfully inserted", "Operation successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DisplayTable();
                            Reset();
                            FillVehicleIDCmbBox();
                        }
                        else
                        {
                            MessagePrinter.PrintToMessageBox("Failed to insert rental booking details", "Operation failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to update vehicle availabiliy", "Operation failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            ResetErrors();

            if (!_rowSelected)
            {
                MessagePrinter.PrintToMessageBox("Please select a rental booking record", "Select a record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(!_rentalStatus.Equals("closed"))
            {
                MessagePrinter.PrintToMessageBox("You cannot update an ongoing booking",
                    "Select a closed booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string vehicleTypeID = VehicleTypeIDCmbBox.Text;
            string vehicleID = VehicleIDCmbBox.Text;
            string driverID = DriverCheckBox.Checked ? DriverIDCmbBox.Text : null;
            string customerID = CustomerIDCmbBox.Text;
            DateTime startDate = DateTime.Parse(StartDateDTP.Text);
            DateTime endDate = DateTime.Parse(EndDateDTP.Text);

            if (ValidateInput(vehicleTypeID, vehicleID, VehicleIDCmbBox.SelectedIndex,
                driverID, DriverIDCmbBox.SelectedIndex, customerID, startDate, endDate))
            {
                vehicleTypeID = vehicleTypeID.Split('-')[0];
                vehicleID = vehicleID.Split('-')[0];
                driverID = driverID == null ? null : driverID.Split('-')[0];
                customerID = customerID.Split('-')[0];

                RentalBooking rentalBooking = new RentalBooking(vehicleTypeID, vehicleID, driverID, customerID, startDate,
                    endDate, BookingStatus.OPEN, PaymentStatus.PENDING);

                if (rentalBooking.Update(_bookingID))
                {
                    MessagePrinter.PrintToMessageBox("Rental booking details were successfully updated", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTable();
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to rental booking details", "Operation failed",
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
                MessagePrinter.PrintToMessageBox("Please select a rental booking record", 
                    "Select a record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string vehicleID = VehicleIDCmbBox.Text.Split('-')[0];
            string driverID = DriverIDCmbBox.Text.Split('-')[0];

            DialogResult result = MessagePrinter.PrintToMessageBoxV2("Are you sure you want to delete the record? Once deleted, it cannot be recoverd.",
            "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // If the booking is an ongoing booking, then set the vehicle and availability to available.
                // there is no need to expell resources in a closed booking since all the resources would
                // have been expelled when the booking was closed.
                if (!_rentalStatus.Equals("closed"))
                {
                    ExpellResources(driverID, vehicleID);
                }

                if (RentalBooking.Delete(_bookingID))
                {
                    MessagePrinter.PrintToMessageBox("Rental booking details were successfully deleted", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to delete rental booking", "Operation failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DisplayTable();
                Reset();
            }
        }
        //
        // Key press event handler
        //
        private void NoTyping_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
