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
    // TODO: Add the manipulation event handlers
    public partial class VehicleManagementForm : AyuboDriveTemplateForm
    {
        private static QueryHandler _queryHandler = new QueryHandler();
        private VehicleViewerV2 _vehicleViewer;
        private DataViewer _dataViewer;
        private string _vehicleID;
        private bool _rowSelected = false;
        private Panel _selectedRow = null;

        public VehicleManagementForm(Form dashboardForm) : base(dashboardForm)
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

        private void VehiclesCell_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(((Label)sender).Name.Split('-')[1]);
            _rowSelected = true;

            Panel container = _vehicleViewer.GetContainers()[index];
            AddData(index);

            if (_selectedRow != null)
            {
                _selectedRow.BackColor = Properties.Settings.Default.LIGHT_GRAY;
            }

            _selectedRow = container;
            container.BackColor = Program.LIGHT_GRAY;
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
                panel.BackColor = Program.LIGHT_GRAY;
            }

            _vehicleViewer.GetVehicleNames()[index].ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }

        private void TableCell_Click(object sender, EventArgs e)
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

        private void TableCell_MouseEnter(object sender, EventArgs e)
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

        private void TableCell_MouseLeave(object sender, EventArgs e)
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

        private bool ValidateInput(
            string vehicleTypeID, int vehicleTypeIDSelectedIndex, string VIN, string manufacturer, string model, 
            string seatingCapacity, string mileage, string gearBoxType, int gearBoxTypeSelectedIndex,
            string torque, string horsepower, string trunkVolume, string color, string dailyRate, string weeklyRate,
            string monthlyRate, string overnightRate, string standardPackageRate, string imagePath)
        {
            bool validVehicleTypeID = false;
            bool validVIN = false;
            bool validManufacturer = false;
            bool validModel = false;
            bool validSeatingCapacity = false;
            bool validMileage = false;
            bool validGearBoxType = false;
            bool validTorque = false;
            bool validHorsepower = false;
            bool validTrunkVolume = false;
            bool validColor = false;
            bool validDailyrate = false;
            bool validWeeklyRate = false;
            bool validMonthlyRate = false;
            bool validOvernightRate = false;
            bool validStandardPackageRate = false;
            bool validImagePath = false;

            if(vehicleTypeID.Length != 0 && vehicleTypeIDSelectedIndex >= 0)
            {
                validVehicleTypeID = true;
                VehicleTypeIDErrorLbl.Text = "";
                VehicleTypeIDPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                VehicleTypeIDErrorLbl.Text = "Invalid vehicle type ID";
                VehicleTypeIDPnl.BackColor = Properties.Settings.Default.RED;
            }

            if (VIN.Length == 17)
            {
                validVIN = true;
                VINErrorLbl.Text = "";
                VINPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                VINErrorLbl.Text = "Invalid VIN";
                VINPnl.BackColor = Properties.Settings.Default.RED;
            }

            if(manufacturer.Length != 0)
            {
                validManufacturer = true;
                ManufacturerErrorLbl.Text = "";
                ManufacturerPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                ManufacturerErrorLbl.Text = "Invalid manufacturer";
                ManufacturerPnl.BackColor = Properties.Settings.Default.RED;
            }

            if (model.Length != 0)
            {
                validModel = true;
                ModelErrorLbl.Text = "";
                ModelPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                ModelErrorLbl.Text = "Invalid model";
                ModelPnl.BackColor = Properties.Settings.Default.RED;
            }

            if (seatingCapacity.Length != 0 && int.Parse(seatingCapacity) >= 1)
            {
                validModel = true;
                SeatingCapacityErrorLbl.Text = "";
                SeatingCapacityPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                SeatingCapacityErrorLbl.Text = "Invalid seating capaity";
                SeatingCapacityPnl.BackColor = Properties.Settings.Default.RED;
            }

            if (mileage.Length != 0 && int.Parse(mileage) >= 5)
            {
                validMileage = true;
                MileageErrorLbl.Text = "";
                MileagePnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                MileageErrorLbl.Text = "Invalid mileage";
                MileagePnl.BackColor = Properties.Settings.Default.RED;
            }

            if (gearBoxType.Length != 0 && gearBoxTypeSelectedIndex >= 0)
            {
                validGearBoxType = true;
                GearboxErrorLbl.Text = "";
                GearBoxPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                GearboxErrorLbl.Text = "Invalid gearbox";
                GearBoxPnl.BackColor = Properties.Settings.Default.RED;
            }

            if (torque.Length != 0 && int.Parse(torque) >= 10)
            {
                validTorque = true;
                TorqueErrorLbl.Text = "";
                TorquePnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                TorqueErrorLbl.Text = "Invalid torque";
                TorquePnl.BackColor = Properties.Settings.Default.RED;
            }

            if (horsepower.Length != 0 && int.Parse(horsepower) >= 10)
            {
                validHorsepower = true;
                HorsepowerErrorLbl.Text = "";
                HorsepowerPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                HorsepowerErrorLbl.Text = "Invalid horsepower";
                HorsepowerPnl.BackColor = Properties.Settings.Default.RED;
            }

            if (trunkVolume.Length != 0 && int.Parse(trunkVolume) >= 1)
            {
                validTrunkVolume = true;
                TrunkVolumeErrorLbl.Text = "";
                TrunkVolumePnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                TrunkVolumeErrorLbl.Text = "Invalid trunk volume";
                TrunkVolumePnl.BackColor = Properties.Settings.Default.RED;
            }

            if (color.Length != 0)
            {
                validColor = true;
                ColorErrorLbl.Text = "";
                ColorPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                ColorErrorLbl.Text = "Invalid color";
                ColorPnl.BackColor = Properties.Settings.Default.RED;
            }

            if (dailyRate.Length != 0 && double.Parse(dailyRate) >= 100)
            {
                validDailyrate = true;
                DailyRateErrorLbl.Text = "";
                DailyRatePnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                DailyRateErrorLbl.Text = "Invalid daily rate";
                DailyRatePnl.BackColor = Properties.Settings.Default.RED;
            }

            if (weeklyRate.Length != 0 && double.Parse(weeklyRate) >= 100)
            {
                validWeeklyRate = true;
                WeeklyRateErrorLbl.Text = "";
                WeeklyRatePnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                WeeklyRateErrorLbl.Text = "Invalid weekly rate";
                WeeklyRatePnl.BackColor = Properties.Settings.Default.RED;
            }

            if (monthlyRate.Length != 0 && double.Parse(monthlyRate) >= 100)
            {
                validMonthlyRate = true;
                MonthlyRateErrorLbl.Text = "";
                MonthlyRatePnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                MonthlyRateErrorLbl.Text = "Invalid monthly rate";
                MonthlyRatePnl.BackColor = Properties.Settings.Default.RED;
            }

            if (overnightRate.Length != 0 && double.Parse(overnightRate) >= 100)
            {
                validOvernightRate = true;
                OvernightRateErrorLbl.Text = "";
                OvernightRatePnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                OvernightRateErrorLbl.Text = "Invalid overnight rate";
                OvernightRatePnl.BackColor = Properties.Settings.Default.RED;
            }

            if (standardPackageRate.Length != 0 && double.Parse(standardPackageRate) >= 100)
            {
                validStandardPackageRate = true;
                StandardPackageRateErrorLbl.Text = "";
                StandardPackageRatePnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                StandardPackageRateErrorLbl.Text = "Invalid standard package rate";
                StandardPackageRatePnl.BackColor = Properties.Settings.Default.RED;
            }

            if (imagePath.Length != 0)
            {
                validImagePath = true;
                ImagePathErrorLbl.Text = "";
                ImagePathPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                ImagePathErrorLbl.Text = "Invalid image path";
                ImagePathPnl.BackColor = Properties.Settings.Default.RED;
            }

            return validVehicleTypeID && validVIN && validManufacturer && validModel && validSeatingCapacity
                && validMileage && validGearBoxType && validTorque && validHorsepower && validTrunkVolume 
                && validColor && validDailyrate && validWeeklyRate && validMonthlyRate && validOvernightRate
                && validStandardPackageRate && validImagePath;
        }
        //
        // Utility
        //
        private void FillVehicleTypeIDComboBox()
        {
            foreach(DataRow row in _queryHandler.SelectQueryHandler("SELECT * FROM vehicleType").Rows)
            {
                VehicleTypeIDCmbBox.Items.Add($"{row[0]}-{row[1]}");
            }
        }

        private void FillGearBoxTypeComboBox()
        {
            GearBoxCmbBox.Items.Add("Manual");
            GearBoxCmbBox.Items.Add("Automatic");
            GearBoxCmbBox.Items.Add("Semi-automatic");
            GearBoxCmbBox.Items.Add("CVT");
        }

        private void AddData(int index)
        {
            //if (index != 0)
            //{
            //    Label[] subArray = _vehicleViewer.GetLabels()[index];
            //    _packageID = subArray[0].Text;
                //PackageNameTxtBox.Text = subArray[1].Text;
                //MaxHourTxtBox.Text = subArray[2].Text;
                //MaxKmTxtBox.Text = subArray[3].Text;
                //ExtraHourRateTxtBox.Text = subArray[4].Text;
                //ExtraKmRateTxtBox.Text = subArray[5].Text;
            //}
        }

        private void ResetErrors()
        {
            //PackageNameErrorLbl.Text = "";
            //PackageNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            //MaxHourErrorLbl.Text = "";
            //MaxHourPnl.BackColor = Properties.Settings.Default.PURPLE;
            //MaxKmErrorLbl.Text = "";
            //MaxKmPnl.BackColor = Properties.Settings.Default.PURPLE;
            //ExtraHourRateErrorLbl.Text = "";
            //ExtraHourRatePnl.BackColor = Properties.Settings.Default.PURPLE;
            //ExtraKmRateErrorLbl.Text = "";
            //ExtraKmRatePnl.BackColor = Properties.Settings.Default.PURPLE;
        }

        private void DisplayTable()
        {
            string query = "SELECT vehicleID, manufacturer, model, seatingCapacity, mileage, torque, horsepower from vehicle";
            DataPnl.Controls.Clear();
            _dataViewer = new DataViewer(DataPnl, _queryHandler.SelectQueryHandler(query));
            _dataViewer.DisplayTable();
            AddVehicleCellClickEvent(_vehicleViewer, TableCell_Click, TableCell_MouseEnter, TableCell_MouseLeave);
        }

        private void DisplayVehicles()
        {
            string query = "SELECT * from vehicle";
            DataPnl.Controls.Clear();
            _vehicleViewer = new VehicleViewerV2(DataPnl, _queryHandler.SelectQueryHandler(query), 140, 140, null);
            _vehicleViewer.Display();
            AddVehicleCellClickEvent(_vehicleViewer, VehiclesCell_Click, VehiclesCell_MouseEnter, VehiclesCell_MouseLeave);
        }

        private void Reset()
        {
            VehicleTypeIDCmbBox.Text = "";
            VINTxtBox.Text = "";
            ManufacturerTxtBox.Text = "";
            ModelTxtBox.Text = "";
            SeatingCapacityTxtBox.Text = "";
            MileageTxtBox.Text = "";
            GearBoxCmbBox.Text = "";
            TorqueTxtBox.Text = "";
            HorsepowerTxtBox.Text = "";
            TrunkVolumeTxtBox.Text = "";
            ColorTxtBox.Text = "";
            DailyRateTxtBox.Text = "";
            WeeklyRateTxtBox.Text = "";
            MonthlyRateTxtBox.Text = "";
            OvernightRateTxtBox.Text = "";
            StandardPackageRateTxtBox.Text = "";
            ImagePathTxtBox.Text = "";

            _rowSelected = false;
            if (_selectedRow != null)
            {
                _selectedRow.BackColor = Properties.Settings.Default.LIGHT_GRAY;
                _selectedRow = null;
            }
            _vehicleID = null;
        }
        //
        // Data manipulation event handlers
        //
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string vehicleTypeID = VehicleTypeIDCmbBox.Text.Split('-')[0];
            string VIN = VINTxtBox.Text;
            string manufacturer = ManufacturerTxtBox.Text;
            string model = ModelTxtBox.Text;
            string seatingCapacity = SeatingCapacityTxtBox.Text;
            string mileage = MileageTxtBox.Text;
            string gearboxType = GearBoxCmbBox.Text;
            string torque = TorqueTxtBox.Text;
            string horsepower = HorsepowerTxtBox.Text;
            string trunkVolume = TrunkVolumeTxtBox.Text;
            string color = ColorTxtBox.Text;
            string dailyRate = DailyRateTxtBox.Text;
            string weeklyRate = WeeklyRateTxtBox.Text;
            string monthlyRate = MonthlyRateTxtBox.Text;
            string overnightRate = OvernightRateTxtBox.Text;
            string standardPackageRate = StandardPackageRateTxtBox.Text;
            string imagePath = ImagePathTxtBox.Text;


            if (ValidateInput(
                vehicleTypeID, VehicleTypeIDCmbBox.SelectedIndex, VIN, manufacturer, model,
                seatingCapacity, mileage, gearboxType, GearBoxCmbBox.SelectedIndex, torque,
                horsepower, trunkVolume, color, dailyRate, weeklyRate, monthlyRate, overnightRate,
                standardPackageRate, imagePath))
            {
                Vehicle vehicle = new Vehicle(VIN, vehicleTypeID, manufacturer, model, int.Parse(seatingCapacity), int.Parse(mileage), int.Parse(torque),
                    int.Parse(horsepower), double.Parse(dailyRate), double.Parse(weeklyRate), double.Parse(monthlyRate), double.Parse(overnightRate),
                    double.Parse(standardPackageRate), Enums.Availability.AVAILABLE, imagePath);

                if (vehicle.Insert())
                {
                    MessagePrinter.PrintToMessageBox("Vehicle details were successfully inserted", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTable();
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to insert vehicle details", "Operation failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Reset();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string vehicleTypeID = VehicleTypeIDCmbBox.Text.Split('-')[0];
            string VIN = VINTxtBox.Text;
            string manufacturer = ManufacturerTxtBox.Text;
            string model = ModelTxtBox.Text;
            string seatingCapacity = SeatingCapacityTxtBox.Text;
            string mileage = MileageTxtBox.Text;
            string gearboxType = GearBoxCmbBox.Text;
            string torque = TorqueTxtBox.Text;
            string horsepower = HorsepowerTxtBox.Text;
            string trunkVolume = TrunkVolumeTxtBox.Text;
            string color = ColorTxtBox.Text;
            string dailyRate = DailyRateTxtBox.Text;
            string weeklyRate = WeeklyRateTxtBox.Text;
            string monthlyRate = MonthlyRateTxtBox.Text;
            string overnightRate = OvernightRateTxtBox.Text;
            string standardPackageRate = StandardPackageRateTxtBox.Text;
            string imagePath = ImagePathTxtBox.Text;


            if (ValidateInput(
                vehicleTypeID, VehicleTypeIDCmbBox.SelectedIndex, VIN, manufacturer, model,
                seatingCapacity, mileage, gearboxType, GearBoxCmbBox.SelectedIndex, torque,
                horsepower, trunkVolume, color, dailyRate, weeklyRate, monthlyRate, overnightRate,
                standardPackageRate, imagePath))
            {
                Vehicle vehicle = new Vehicle(VIN, vehicleTypeID, manufacturer, model, int.Parse(seatingCapacity), int.Parse(mileage), int.Parse(torque),
                    int.Parse(horsepower), double.Parse(dailyRate), double.Parse(weeklyRate), double.Parse(monthlyRate), double.Parse(overnightRate),
                    double.Parse(standardPackageRate), Enums.Availability.AVAILABLE, imagePath);

                if (vehicle.Update(_vehicleID))
                {
                    MessagePrinter.PrintToMessageBox("Vehicle details were successfully updated", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTable();
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to update vehicle details", "Operation failed",
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
                MessagePrinter.PrintToMessageBox("Please select a vehicle", "Select a record",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessagePrinter.PrintToMessageBoxV2("Are you sure you want to delete the record? Once deleted, " +
                    "it cannot be recoverd.", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (Vehicle.Delete(_vehicleID))
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
        // Form load
        //
        private void VehicleManagementForm_Load(object sender, EventArgs e)
        {
            DisplayVehicles();
            FillVehicleTypeIDComboBox();
            FillGearBoxTypeComboBox();
        }

        private void VehiclesViewRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(VehiclesViewRBtn.Checked)
            {
                DisplayVehicles();
            }
        }

        private void TableViewRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(TableViewRBtn.Checked)
            {
                DisplayTable();
            }
        }
    }
}
