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
    public partial class HireManagementForm : AyuboDriveTemplateForm
    {
        private static QueryHandler s_queryHandler = new QueryHandler();
        private VehicleViewerV2 _vehicleViewer;
        private DataViewer _dataViewer;
        private DataTable _dataTable;
        private string _bookingID;
        private string _hireStatus;
        private bool _rowSelected = false;
        private Panel _selectedRow = null;
        private int _tablePnlMinHeight = 203;
        private int _tablePnlMaxHeight = 412;
        public readonly static string _defaultLongTourQuery = "SELECT bookingID, vehicleID, driverID, customerID, packageID, " +
            "hireStatus as status, startDate, endDate as returned from hireBooking WHERE hiretype = 'Long'";
        public readonly static string _defaultDayTourQuery = "SELECT bookingID, vehicleID, driverID, customerID, packageID, " +
            "hireStatus as status, startDate, endDate as returned from hireBooking WHERE hiretype = 'Day'";

        public HireManagementForm(DashboardForm dashboardForm) : base(dashboardForm)
        {
            InitializeComponent();
            HandleTitleBar();
            HideVehicleObjects();
            FillVechicleTypeIDCbmBox();
            FillVehicleIDCmbBox(false);
            FillDriverIDCmbBox();
            FillCustomerIDCmbBox();
            FillPackageIDCmbBox();
            DisplayLongTourTable();
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
            AddDataVehicleView(index);
            ResetErrors();
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
        private HireType ConvertStringToHireType(string hireTypeString)
        {
            if (hireTypeString.ToLower().Equals("long"))
            {
                return HireType.LONG;
            }
            return HireType.DAY;
        }

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

        private bool ValidateInput(string vehicleTypeID, int vehicleTypeIDSelectedIndex, string vehicleID, int vehicleIDSelectedIndex,
            string driverID, int driverIDSelectedIndex, string customerID, int customerIDSelectedIndex,
            string packageID, int packageIDSelectedIndex)
        {
            bool validVehicleTypeID = false;
            bool validVehicleID = false;
            bool validDriverID = false;
            bool validCustomerID = false;
            bool validPackageID = false;

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

            if (ValidationHandler.ValidateInputLength(vehicleID))
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

            if (ValidationHandler.ValidateInputLength(driverID))
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

            if (ValidationHandler.ValidateInputLength(packageID))
            {
                validPackageID = true;
                PackageIDPnl.BackColor = Properties.Settings.Default.PURPLE;
                PackageIDErrLbl.Text = "";
            }
            else
            {
                PackageIDPnl.BackColor = Properties.Settings.Default.RED;
                PackageIDErrLbl.Text = "Invalid package ID";
            }
            return validVehicleTypeID && validVehicleID && validDriverID && validCustomerID && validPackageID;
        }

        private bool ValidateInput(string vehicleTypeID, int vehicleTypeIDSelectedIndex, string vehicleID, int vehicleIDSelectedIndex,
            string driverID, int driverIDSelectedIndex, string customerID, int customerIDSelectedIndex,
            string packageID, int packageIDSelectedIndex, DateTime startDate, DateTime returnDate)
        {
            bool validVehicleTypeID = false;
            bool validVehicleID = false;
            bool validDriverID = false;
            bool validCustomerID = false;
            bool validPackageID = false;
            bool validReturnDate = false;

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

            if (ValidationHandler.ValidateComboBoxValue(driverID, driverIDSelectedIndex))
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

            if (ValidationHandler.ValidateInputLength(packageID))
            {
                validPackageID = true;
                PackageIDPnl.BackColor = Properties.Settings.Default.PURPLE;
                PackageIDErrLbl.Text = "";
            }
            else
            {
                PackageIDPnl.BackColor = Properties.Settings.Default.RED;
                PackageIDErrLbl.Text = "Invalid package ID";
            }

            if (ValidationHandler.ValidateDate(startDate, returnDate))
            {
                validReturnDate = true;
                EndDatePnl.BackColor = Properties.Settings.Default.PURPLE;
                EndDateErrLbl.Text = "";
            }
            else
            {
                EndDatePnl.BackColor = Properties.Settings.Default.RED;
                EndDateErrLbl.Text = "Invalid return date";
            }
            return validVehicleTypeID && validVehicleID && validDriverID && validCustomerID 
                && validPackageID && validReturnDate;
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

        private void AddDataVehicleView(int vehicleID)
        {
            DataRow record = s_queryHandler.SelectQueryHandler($"SELECT * from vehicle WHERE vehicleID = '{vehicleID}'").Rows[0];

            DataRow vehicleTypeRecord = s_queryHandler.SelectQueryHandler("SELECT typeName from vehicleType WHERE vehicleTypeID = '" +
                record[2].ToString() + "'").Rows[0];
            VehicleTypeIDCmbBox.Text = $"{record[2].ToString()}-{vehicleTypeRecord[0]}";
            _hireStatus = record[6].ToString();
            VehicleIDCmbBox.Text = $"{record[0].ToString()}-{record[3].ToString()} {record[4].ToString()}";
        }

        private void AddDataTableView(int index)
        {
            if (index != 0)
            {
                DataTable dataTable = DayTourRBtn.Checked ? s_queryHandler.SelectQueryHandler("SELECT * FROM hireBooking WHERE hireType = 'Day'") :
                    s_queryHandler.SelectQueryHandler("SELECT * FROM hireBooking WHERE hireType = 'Long'");

                if (dataTable != null)
                {
                    DataRow record = dataTable.Rows[index - 1];

                    if (DayTourRBtn.Checked)
                    {
                        record = s_queryHandler.SelectQueryHandler("SELECT * FROM hireBooking WHERE hireType = 'day'").Rows[index - 1];
                    }

                    DataRow vehicleTypeRecord = s_queryHandler.SelectQueryHandler("SELECT typeName from vehicleType WHERE vehicleTypeID = '" +
                        record[1].ToString() + "'").Rows[0];

                    DataRow vehicleRecord = s_queryHandler.SelectQueryHandler("SELECT manufacturer, model from vehicle WHERE vehicleID = '" +
                        record[2].ToString() + "'").Rows[0];

                    DataRow driverRecord = s_queryHandler.SelectQueryHandler("SELECT firstName, lastName from driver WHERE driverID = '" +
                        record[3].ToString() + "'").Rows[0];

                    DataRow customerRecord = s_queryHandler.SelectQueryHandler("SELECT firstName, lastName from customer WHERE customerID = '" +
                        record[4].ToString() + "'").Rows[0];

                    DataRow packageRecord = s_queryHandler.SelectQueryHandler("SELECT packageName from package WHERE packageID = '" +
                        record[5].ToString() + "'").Rows[0];

                    _bookingID = record[0].ToString();
                    VehicleTypeIDCmbBox.Text = $"{record[1].ToString()}-{vehicleTypeRecord[0]}";
                    VehicleIDCmbBox.Text = $"{record[2].ToString()}-{vehicleRecord[0]} {vehicleRecord[1]}";
                    DriverIDCmbBox.Text = $"{record[3].ToString()}-{driverRecord[0]} {driverRecord[1]}";
                    CustomerIDCmbBox.Text = $"{record[4].ToString()}-{customerRecord[0]} {customerRecord[1]}";
                    PackageIDCmbBox.Text = $"{record[5].ToString()}-{packageRecord[0]}";
                    _hireStatus = record[6].ToString();
                    StartDateDTP.Text = record[8].ToString();
                    EndDateDTP.Text = record[9].ToString();
                }
            }
        }

        private void ResetErrors()
        {
            VehicleTypeIDErrLbl.Text = "";
            VehicleIDErrLbl.Text = "";
            DriverIDErrLbl.Text = "";
            CustomerIDErrLbl.Text = "";
            PackageIDErrLbl.Text = "";
            StartDateErrLbl.Text = "";
            EndDateErrLbl.Text = "";

            VehicleTypeIDPnl.BackColor = Properties.Settings.Default.PURPLE;
            VehicleIDPnl.BackColor = Properties.Settings.Default.PURPLE;
            DriverIDPnl.BackColor = Properties.Settings.Default.PURPLE;
            CustomerIDPnl.BackColor = Properties.Settings.Default.PURPLE;
            PackageIDPnl.BackColor = Properties.Settings.Default.PURPLE;
            StartDatePnl.BackColor = Properties.Settings.Default.PURPLE;
            EndDatePnl.BackColor = Properties.Settings.Default.PURPLE;
        }

        private void DisplayLongTourTable()
        {
            _dataTable = s_queryHandler.SelectQueryHandler(_defaultLongTourQuery);
            TablePnl.Controls.Clear();
            _dataViewer = new DataViewer(TablePnl, _dataTable);
            _dataViewer.DisplayTable();
            AddCellClickEvent(_dataViewer, TableCell_Click, TableCell_MouseEnter, TableCell_MouseLeave);
        }

        private void DisplayDayTourTable()
        {
            _dataTable = s_queryHandler.SelectQueryHandler(_defaultDayTourQuery);
            TablePnl.Controls.Clear();
            _dataViewer = new DataViewer(TablePnl, _dataTable);
            _dataViewer.DisplayTable();
            AddCellClickEvent(_dataViewer, TableCell_Click, TableCell_MouseEnter, TableCell_MouseLeave);
        }

        private void DisplayVehicles(bool invokedByType = false)
        {
            string query = "SELECT * FROM vehicle WHERE vehicleStatus = 'available'";
            string imagePathQuery = "SELECT imagePath from vehicle WHERE vehicleStatus = 'available'";

            if (invokedByType)
            {
                string vehicleTypeID = VehicleTypeIDCmbBox.Text.Split('-')[0];
                query = $"SELECT * FROM vehicle WHERE vehicleStatus = " +
                    $"'Available' AND vehicleTypeID = '{vehicleTypeID} '";
                imagePathQuery = $"SELECT imagePath FROM vehicle WHERE " +
                    $"vehicleStatus = 'Available' AND vehicleTypeID = '{vehicleTypeID}'";
            }

            _dataTable = s_queryHandler.SelectQueryHandler(query);
            VehiclePnl.Controls.Clear();
            _vehicleViewer = new VehicleViewerV2(VehiclePnl, _dataTable, 130, 130, imagePathQuery, query);
            _vehicleViewer.Display();
            AddVehicleCellClickEvent(_vehicleViewer, VehiclesCell_Click);
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
            string query = "SELECT vehicleID, manufacturer, model FROM vehicle WHERE vehicleStatus = 'Available'";
            // If a vehicle type ID is chosen, filter the vehicle IDs based on the selected vehicle type ID
            // Otherwise show the vehicle IDs of every available vehicle.
            if (invokedByType)
            {
                string vehicleTypeID = VehicleTypeIDCmbBox.Text.Split('-')[0];
                query = "SELECT vehicleID, manufacturer, model FROM vehicle WHERE vehicleStatus = " +
                    "'Available' AND vehicleTypeID = '" + vehicleTypeID + "'";
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
            string query = "SELECT driverID, firstName, lastName from driver WHERE driverStatus = 'available'";

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
        
        private void FillPackageIDCmbBox()
        {
            PackageIDCmbBox.Items.Clear();
            string query = "SELECT packageID, packageName from package WHERE NOT packageStatus = 'discontinued'";

            foreach (DataRow record in s_queryHandler.SelectQueryHandler(query).Rows)
            {
                // Format: {packageID}-{package name}
                PackageIDCmbBox.Items.Add($"{record[0]}-{record[1]}");
            }
        }
        //
        // Combo box selected index changed event handler
        //
        private void VehicleTypeIDCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayVehicles(true);
            FillVehicleIDCmbBox(true);
        }
        //
        // Radio button check changed
        //
        private void AvailableVehiclesRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (AvailableVehiclesRBtn.Checked)
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

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string vehicleTypeID = VehicleTypeIDCmbBox.Text;
            string vehicleID = VehicleIDCmbBox.Text;
            string driverID = DriverIDCmbBox.Text;
            string customerID = CustomerIDCmbBox.Text;
            string packageID = PackageIDCmbBox.Text;
            DateTime startDate = DateTime.Parse(StartDateDTP.Text);
            DateTime endDate = DateTime.Parse(EndDateDTP.Text);
            
            if (ValidateInput(vehicleTypeID, VehicleTypeIDCmbBox.SelectedIndex, vehicleID, VehicleIDCmbBox.SelectedIndex,
                driverID, DriverIDCmbBox.SelectedIndex, customerID, CustomerIDCmbBox.SelectedIndex, packageID, PackageIDCmbBox.SelectedIndex, 
                startDate, endDate))
            {
                vehicleTypeID = vehicleTypeID.Split('-')[0];
                vehicleID = vehicleID.Split('-')[0];
                driverID = driverID.Split('-')[0];
                customerID = customerID.Split('-')[0];
                packageID = packageID.Split('-')[0];


                if (Vehicle.UpdateAvailability(vehicleID, Availability.UNAVAILABLE))
                {
                    if (Driver.UpdateDriverAvailability(driverID, DriverStatus.UNAVAILABLE))
                    {
                        HireType hireType = DayTourRBtn.Checked ? ConvertStringToHireType("day") : ConvertStringToHireType("long");

                        HireBooking hireBooking = new HireBooking(vehicleTypeID, vehicleID, driverID, customerID, packageID, BookingStatus.OPEN, 
                            hireType, startDate, endDate, PaymentStatus.PENDING);
                        if (hireBooking.Insert())
                        {
                            MessagePrinter.PrintToMessageBox("Hire booking details were successfully inserted", "Operation successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (DayTourRBtn.Checked)
                            {
                                DisplayDayTourTable();
                            }
                            else
                            {
                                DisplayLongTourTable();
                            }
                        }
                        else
                        {
                            MessagePrinter.PrintToMessageBox("Failed to insert hire booking details", "Operation failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Reset();
                    }
                    else
                    {
                        MessagePrinter.PrintToMessageBox("Failed to update driver availabiliy", "Operation failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!_rowSelected)
            {
                MessagePrinter.PrintToMessageBox("Please select a hire booking record", "Select a record", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!_hireStatus.Equals("closed"))
            {
                MessagePrinter.PrintToMessageBox("You cannot update an ongoing booking",
                    "Select a closed booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string vehicleTypeID = VehicleTypeIDCmbBox.Text;
            string vehicleID = VehicleIDCmbBox.Text;
            string driverID = DriverIDCmbBox.Text;
            string customerID = CustomerIDCmbBox.Text;
            string packageID = PackageIDCmbBox.Text;
            DateTime startDate = DateTime.Parse(StartDateDTP.Text);
            DateTime endDate = DateTime.Parse(EndDateDTP.Text);

            if (ValidateInput(vehicleTypeID, VehicleTypeIDCmbBox.SelectedIndex, vehicleID, VehicleIDCmbBox.SelectedIndex,
                driverID, DriverIDCmbBox.SelectedIndex, customerID, CustomerIDCmbBox.SelectedIndex, packageID, 
                PackageIDCmbBox.SelectedIndex, startDate, endDate))
            {
                vehicleTypeID = vehicleTypeID.Split('-')[0];
                vehicleID = vehicleID.Split('-')[0];
                driverID = driverID.Split('-')[0];
                customerID = customerID.Split('-')[0];
                packageID = packageID.Split('-')[0];

                HireType hireType = DayTourRBtn.Checked ? ConvertStringToHireType("day") : ConvertStringToHireType("long");

                HireBooking hireBooking = new HireBooking(vehicleTypeID, vehicleID, driverID, customerID, packageID, BookingStatus.OPEN, hireType, startDate, endDate, PaymentStatus.PENDING);
                if (hireBooking.Update(_bookingID))
                {
                    MessagePrinter.PrintToMessageBox("Hire booking details were successfully updated", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (DayTourRBtn.Checked)
                    {
                        DisplayDayTourTable();
                    }
                    else
                    {
                        DisplayLongTourTable();
                    }
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to Hire booking details", "Operation failed",
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
                MessagePrinter.PrintToMessageBox("Please select a hire booking record", "Select a record", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string vehicleID = VehicleIDCmbBox.Text.Split('-')[0];
            string driverID = DriverIDCmbBox.Text.Split('-')[0];

            DialogResult result = MessagePrinter.PrintToMessageBoxV2("Are you sure you want to delete the record? Once deleted, it cannot be recoverd.",
            "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Only expell the resources in an open booking
                if (!_hireStatus.Equals("closed"))
                {
                    ExpellResources(driverID, vehicleID);
                }

                if (HireBooking.Delete(_bookingID))
                {
                    MessagePrinter.PrintToMessageBox("Hire booking details were successfully deleted", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to delete hire booking", "Operation failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (DayTourRBtn.Checked)
                {
                    DisplayDayTourTable();
                }
                else
                {
                    DisplayLongTourTable();
                }
                Reset();
            }
        }

        private void DayTourRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(DayTourRBtn.Checked)
            {
                DisplayDayTourTable();
            }
        }

        private void LongTourRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(LongTourRBtn.Checked)
            {
                DisplayLongTourTable();
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
