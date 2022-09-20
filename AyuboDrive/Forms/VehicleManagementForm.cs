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
    // TODO: Add the manipulation event handlers
    public partial class VehicleManagementForm : AyuboDriveTemplateForm
    {
        private static QueryHandler s_queryHandler = new QueryHandler();
        private VehicleViewerV2 _vehicleViewer;
        private DataViewer _dataViewer;
        private DataTable _dataTable;
        private string _vehicleID;
        private string _initialVIN;
        private string _intialTypeID;
        private bool _rowSelected = false;
        private Panel _selectedRow = null;
        private string _imagePath = "";

        public VehicleManagementForm(DashboardForm dashboardForm) : base(dashboardForm)
        {
            InitializeComponent();
            HandleTitleBar();
            DisplayTable();
            FillVehicleTypeIDComboBox();
            FillGearBoxTypeComboBox();
            FillAvailabilityComboBox();
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
        private bool ValidateInput(
            string vehicleTypeID, int vehicleTypeIDSelectedIndex, string VIN, string manufacturer, string model, 
            string seatingCapacity, string mileage, string gearBoxType, int gearBoxTypeSelectedIndex,
            string torque, string horsepower, string trunkVolume, string color, string dailyRate, string weeklyRate,
            string monthlyRate, string overnightRate, string standardPackageRate, string imagePath, string availability,
            int availabilitySelectedIndex)
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
            bool validAvailability = false;

            if(ValidationHandler.ValidateInputLength(vehicleTypeID))
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

            if (ValidationHandler.ValidateVIN(VIN))
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

            if(ValidationHandler.ValidateInputLength(manufacturer))
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

            if (ValidationHandler.ValidateInputLength(model))
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
                validSeatingCapacity = true;
                SeatingCapacityErrorLbl.Text = "";
                SeatingCapacityPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                SeatingCapacityErrorLbl.Text = "Invalid seating capaity";
                SeatingCapacityPnl.BackColor = Properties.Settings.Default.RED;
            }

            if (ValidationHandler.ValidateDistanceInput(mileage))
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

            if (ValidationHandler.ValidateInputLength(gearBoxType))
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

            if (trunkVolume.Length != 0 && decimal.Parse(trunkVolume) >= 1)
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

            if (ValidationHandler.ValidateInputLength(color))
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

            if (ValidationHandler.ValidateDecimalInput(dailyRate))
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

            if (ValidationHandler.ValidateDecimalInput(weeklyRate))
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

            if (ValidationHandler.ValidateDecimalInput(monthlyRate))
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

            if (ValidationHandler.ValidateDecimalInput(overnightRate))
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

            if (ValidationHandler.ValidateDecimalInput(standardPackageRate))
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

            if (ValidationHandler.ValidateFilePath(imagePath))
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

            if(ValidationHandler.ValidateComboBoxValue(availability, availabilitySelectedIndex))
            {
                validAvailability = true;
                AvailabilityErrLbl.Text = "";
                AvailabilityPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                AvailabilityErrLbl.Text = "Invalid availability";
                AvailabilityPnl.BackColor = Properties.Settings.Default.RED;
            }

            return validVehicleTypeID && validVIN && validManufacturer && validModel && validSeatingCapacity
                && validMileage && validGearBoxType && validTorque && validHorsepower && validTrunkVolume 
                && validColor && validDailyrate && validWeeklyRate && validMonthlyRate && validOvernightRate
                && validStandardPackageRate && validImagePath && validAvailability;
        }

        private bool ValidateInputV2(
            string vehicleTypeID, int vehicleTypeIDSelectedIndex, string VIN, string manufacturer, string model, 
            string seatingCapacity, string mileage, string gearBoxType, int gearBoxTypeSelectedIndex,
            string torque, string horsepower, string trunkVolume, string color, string dailyRate, string weeklyRate,
            string monthlyRate, string overnightRate, string standardPackageRate, string imagePath, string availability,
            int availabilitySelectedIndex)
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
            bool validAvailability = false;

            if (ValidationHandler.ValidateInputLength(vehicleTypeID))
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

            if (ValidationHandler.ValidateVIN(VIN))
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

            if (_initialVIN.Equals(VIN))
            {
                validVIN = true;
                VINPnl.BackColor = Properties.Settings.Default.PURPLE;
                VINErrorLbl.Text = "";
            }
            else
            {
                if (!ValidationHandler.ValidateNIC(VIN, "driver", "driverNIC"))
                {
                    VINPnl.BackColor = Properties.Settings.Default.RED;
                    VINErrorLbl.Text = "Invalid VIN";
                }
                else
                {
                    validVIN = true;
                }
            }

            if (ValidationHandler.ValidateInputLength(manufacturer))
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

            if (ValidationHandler.ValidateInputLength(model))
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
                validSeatingCapacity = true;
                SeatingCapacityErrorLbl.Text = "";
                SeatingCapacityPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                SeatingCapacityErrorLbl.Text = "Invalid seating capaity";
                SeatingCapacityPnl.BackColor = Properties.Settings.Default.RED;
            }

            if (ValidationHandler.ValidateDistanceInput(mileage))
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

            if (ValidationHandler.ValidateInputLength(gearBoxType))
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

            if (trunkVolume.Length != 0 && decimal.Parse(trunkVolume) >= 1)
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

            if (ValidationHandler.ValidateInputLength(color))
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

            if (ValidationHandler.ValidateDecimalInput(dailyRate))
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

            if (ValidationHandler.ValidateDecimalInput(weeklyRate))
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

            if (ValidationHandler.ValidateDecimalInput(monthlyRate))
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

            if (ValidationHandler.ValidateDecimalInput(overnightRate))
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

            if (ValidationHandler.ValidateDecimalInput(standardPackageRate))
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

            if (ValidationHandler.ValidateFilePath(imagePath))
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

            if(ValidationHandler.ValidateComboBoxValue(availability, availabilitySelectedIndex))
            {
                validAvailability = true;
                AvailabilityErrLbl.Text = "";
                AvailabilityPnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                AvailabilityErrLbl.Text = "Invalid availability";
                AvailabilityPnl.BackColor = Properties.Settings.Default.RED;
            }

            return validVehicleTypeID && validVIN && validManufacturer && validModel && validSeatingCapacity
                && validMileage && validGearBoxType && validTorque && validHorsepower && validTrunkVolume 
                && validColor && validDailyrate && validWeeklyRate && validMonthlyRate && validOvernightRate
                && validStandardPackageRate && validImagePath && validAvailability;
        }

        private void FillVehicleTypeIDComboBox()
        {
            foreach(DataRow row in s_queryHandler.SelectQueryHandler("SELECT * FROM vehicleType").Rows)
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

        private void FillAvailabilityComboBox()
        {
            AvailabilityCmbBox.Items.Add(VehicleStatus.AVAILABLE.ToString().ToLower());
            AvailabilityCmbBox.Items.Add(VehicleStatus.UNAVAILABLE.ToString().ToLower());
            AvailabilityCmbBox.Items.Add(VehicleStatus.UNUSABLE.ToString().ToLower());

        }

        private void AddDataVehicleView(int vehicleID)
        {
            DataRow record = s_queryHandler.SelectQueryHandler($"SELECT * FROM vehicle WHERE vehicleID = {vehicleID}").Rows[0];
            DataRow vehicleTypeName = s_queryHandler.SelectQueryHandler("SELECT typeName from vehicleType WHERE vehicleTypeID = '" +
                record[2].ToString() + "'").Rows[0];
            _vehicleID = record[0].ToString();
            VINTxtBox.Text = record[1].ToString();
            _initialVIN = record[1].ToString();
            VehicleTypeIDCmbBox.Text = $"{record[2].ToString()}-{vehicleTypeName[0]}";
            _intialTypeID = record[2].ToString();
            ManufacturerTxtBox.Text = record[3].ToString();
            ModelTxtBox.Text = record[4].ToString();
            SeatingCapacityTxtBox.Text = record[5].ToString();
            MileageTxtBox.Text = record[6].ToString();
            GearBoxCmbBox.Text = record[7].ToString();
            TorqueTxtBox.Text = record[8].ToString();
            HorsepowerTxtBox.Text = record[9].ToString();
            TrunkVolumeTxtBox.Text = record[10].ToString();
            ColorTxtBox.Text = record[11].ToString();
            DailyRateTxtBox.Text = record[12].ToString();
            WeeklyRateTxtBox.Text = record[13].ToString();
            MonthlyRateTxtBox.Text = record[14].ToString();
            OvernightRateTxtBox.Text = record[15].ToString();
            AvailabilityCmbBox.Text = record[16].ToString();
            ImagePathTxtBox.Text = record[17].ToString();
            StandardPackageRateTxtBox.Text = record[18].ToString();
        }

        private void AddDataTableView(int index)
        {
            if(index != 0)
            {
                DataRow record = s_queryHandler.SelectQueryHandler("SELECT * FROM vehicle").Rows[index-1];
                DataRow vehicleTypeName = s_queryHandler.SelectQueryHandler("SELECT typeName from vehicleType WHERE vehicleTypeID = '" +
                    record[2].ToString() + "'").Rows[0];
                _vehicleID = record[0].ToString();
                VINTxtBox.Text = record[1].ToString();
                _initialVIN = record[1].ToString();
                VehicleTypeIDCmbBox.Text = $"{record[2].ToString()}-{vehicleTypeName[0]}";
                ManufacturerTxtBox.Text = record[3].ToString();
                ModelTxtBox.Text = record[4].ToString();
                SeatingCapacityTxtBox.Text = record[5].ToString();
                MileageTxtBox.Text = record[6].ToString();
                GearBoxCmbBox.Text = record[7].ToString();
                TorqueTxtBox.Text = record[8].ToString();
                HorsepowerTxtBox.Text = record[9].ToString();
                TrunkVolumeTxtBox.Text = record[10].ToString();
                ColorTxtBox.Text = record[11].ToString();
                DailyRateTxtBox.Text = record[12].ToString();
                WeeklyRateTxtBox.Text = record[13].ToString();
                MonthlyRateTxtBox.Text = record[14].ToString();
                OvernightRateTxtBox.Text = record[15].ToString();
                AvailabilityCmbBox.Text = record[16].ToString();
                ImagePathTxtBox.Text = record[17].ToString();
                StandardPackageRateTxtBox.Text = record[18].ToString();
            }
        }

        private void ResetErrors()
        {
            VINErrorLbl.Text = "";
            VehicleTypeIDErrorLbl.Text = "";
            ManufacturerErrorLbl.Text = "";
            ModelErrorLbl.Text = "";
            ModelErrorLbl.Text = "";
            SeatingCapacityErrorLbl.Text = "";
            MileageErrorLbl.Text = "";
            GearboxErrorLbl.Text = "";
            TorqueErrorLbl.Text = "";
            HorsepowerErrorLbl.Text = "";
            TrunkVolumeErrorLbl.Text = "";
            ColorErrorLbl.Text = "";
            DailyRateErrorLbl.Text = "";
            WeeklyRateErrorLbl.Text = "";
            MonthlyRateErrorLbl.Text = "";
            OvernightRateErrorLbl.Text = "";
            ImagePathErrorLbl.Text = "";
            StandardPackageRateErrorLbl.Text = "";
            AvailabilityErrLbl.Text = "";

            VINPnl.BackColor = Properties.Settings.Default.PURPLE;
            VehicleTypeIDPnl.BackColor = Properties.Settings.Default.PURPLE;
            ManufacturerPnl.BackColor = Properties.Settings.Default.PURPLE;
            ModelPnl.BackColor = Properties.Settings.Default.PURPLE;
            SeatingCapacityPnl.BackColor = Properties.Settings.Default.PURPLE;
            MileagePnl.BackColor = Properties.Settings.Default.PURPLE;
            GearBoxPnl.BackColor = Properties.Settings.Default.PURPLE;
            TorquePnl.BackColor = Properties.Settings.Default.PURPLE;
            HorsepowerPnl.BackColor = Properties.Settings.Default.PURPLE;
            TrunkVolumePnl.BackColor = Properties.Settings.Default.PURPLE;
            ColorPnl.BackColor = Properties.Settings.Default.PURPLE;
            DailyRatePnl.BackColor = Properties.Settings.Default.PURPLE;
            WeeklyRatePnl.BackColor = Properties.Settings.Default.PURPLE;
            MonthlyRatePnl.BackColor = Properties.Settings.Default.PURPLE;
            OvernightRatePnl.BackColor = Properties.Settings.Default.PURPLE;
            ImagePathPnl.BackColor = Properties.Settings.Default.PURPLE;
            StandardPackageRatePnl.BackColor = Properties.Settings.Default.PURPLE;
            AvailabilityPnl.BackColor = Properties.Settings.Default.PURPLE;
        }

        private void DisplayTable()
        {
            string query = "SELECT vehicleID, manufacturer, model, seatingCapacity, " +
                "torque, horsepower, vehicleStatus as availability from vehicle";
            _dataTable = s_queryHandler.SelectQueryHandler(query);
            TablePnl.Controls.Clear();
            _dataViewer = new DataViewer(TablePnl, _dataTable);
            _dataViewer.DisplayTable();
            AddCellClickEvent(_dataViewer, TableCell_Click, TableCell_MouseEnter, TableCell_MouseLeave);
            VehiclePnl.Visible = false;
            TablePnl.Visible = true;
        }

        private void DisplayVehicles()
        {
            string query = "SELECT * from vehicle";
            string imageQuery = "SELECT imagePath from vehicle";
            _dataTable = s_queryHandler.SelectQueryHandler(query);
            VehiclePnl.Controls.Clear();
            _vehicleViewer = new VehicleViewerV2(VehiclePnl, _dataTable, 200, 150, imageQuery, query);
            _vehicleViewer.Display();
            AddVehicleCellClickEvent(_vehicleViewer, VehiclesCell_Click);
            
            TablePnl.Visible = false;
            VehiclePnl.Visible = true;
        }

        private VehicleStatus ConvertStringToVehicleStatus(string vehicleStatusString)
        {
            if (vehicleStatusString.Equals("available"))
            {
                return VehicleStatus.AVAILABLE;
            }
            else if (vehicleStatusString.Equals("unavailable"))
            {
                return VehicleStatus.UNAVAILABLE;
            }
            return VehicleStatus.UNUSABLE;
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
            AvailabilityCmbBox.Text = "";

            _rowSelected = false;
            if (_selectedRow != null)
            {
                _selectedRow.BackColor = Properties.Settings.Default.LIGHT_GRAY;
                _selectedRow = null;
            }
            _vehicleID = null;
        }
        
        //
        // Click event handlers
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
            VehicleStatus availability = ConvertStringToVehicleStatus(AvailabilityCmbBox.Text);
            string imagePath = ImagePathTxtBox.Text;


            if (ValidateInput(
                vehicleTypeID, VehicleTypeIDCmbBox.SelectedIndex, VIN, manufacturer, model,
                seatingCapacity, mileage, gearboxType, GearBoxCmbBox.SelectedIndex, torque,
                horsepower, trunkVolume, color, dailyRate, weeklyRate, monthlyRate, overnightRate,
                standardPackageRate, imagePath, availability.ToString(), AvailabilityCmbBox.SelectedIndex))
            {
                Vehicle vehicle = new Vehicle(VIN, vehicleTypeID, manufacturer, model, int.Parse(seatingCapacity), int.Parse(mileage), gearboxType,
                    int.Parse(torque), int.Parse(horsepower), decimal.Parse(trunkVolume), color, decimal.Parse(dailyRate), 
                    decimal.Parse(weeklyRate), decimal.Parse(monthlyRate), decimal.Parse(overnightRate), decimal.Parse(standardPackageRate),
                    availability, imagePath);

                if (vehicle.Insert())
                {
                    MessagePrinter.PrintToMessageBox("Vehicle details were successfully inserted", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!VehiclesViewRBtn.Checked)
                    {
                        DisplayTable();
                    }
                    else
                    {
                        DisplayVehicles();
                    }
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
            ResetErrors();

            if (!_rowSelected)
            {
                MessagePrinter.PrintToMessageBox("Please select a vehicle", "Select a record",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
            VehicleStatus availability = ConvertStringToVehicleStatus(AvailabilityCmbBox.Text);
            string imagePath = ImagePathTxtBox.Text;

            if (ValidateInputV2(
                vehicleTypeID, VehicleTypeIDCmbBox.SelectedIndex, VIN, manufacturer, model,
                seatingCapacity, mileage, gearboxType, GearBoxCmbBox.SelectedIndex, torque,
                horsepower, trunkVolume, color, dailyRate, weeklyRate, monthlyRate, overnightRate,
                standardPackageRate, imagePath, availability.ToString(), AvailabilityCmbBox.SelectedIndex))
            {
                Vehicle vehicle = new Vehicle(VIN, vehicleTypeID, manufacturer, model, int.Parse(seatingCapacity), int.Parse(mileage), gearboxType,
                    int.Parse(torque), int.Parse(horsepower), decimal.Parse(trunkVolume), color, decimal.Parse(dailyRate),
                    decimal.Parse(weeklyRate), decimal.Parse(monthlyRate), decimal.Parse(overnightRate), decimal.Parse(standardPackageRate),
                    availability, imagePath);

                // If the type ID was modified, reflect those changes in all of the appropriate booking records
                if(vehicleTypeID != _intialTypeID)
                {
                    if(!HireBooking.UpdateBooking(_vehicleID, vehicleTypeID))
                    {
                        MessagePrinter.PrintToMessageBox("Failed to update vehicle type details in hire booking(s)", 
                            "Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if(!RentalBooking.UpdateBooking(_vehicleID, vehicleTypeID))
                    {
                        MessagePrinter.PrintToMessageBox("Failed to update vehicle details in rental booking(s)", 
                            "Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (vehicle.Update(_vehicleID))
                {
                    MessagePrinter.PrintToMessageBox("Vehicle details were successfully updated", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!VehiclesViewRBtn.Checked)
                    {
                        DisplayTable();
                    }
                    else
                    {
                        DisplayVehicles();
                    }
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
                return;
            }
            DialogResult result = MessagePrinter.PrintToMessageBoxV2("Are you sure you want to delete the record? Once deleted, " +
                "it cannot be recovered.", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (Vehicle.Delete(_vehicleID))
                {
                    MessagePrinter.PrintToMessageBox("Vehicle details were successfully deleted", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to delete vehicle details." +
                        "Only vehicles that have not been included in bookings can be deleted.\n\n" +
                        "Try setting the availability \"Unused\" instead", "Operation failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!VehiclesViewRBtn.Checked)
                {
                    DisplayTable();
                }
                else
                {
                    DisplayVehicles();
                }
                Reset();
            }
        }

        private void ImagePathBtn_Click(object sender, EventArgs e)
        {
            _imagePath = FileRetriever.GetFilePath();
            ImagePathTxtBox.Text = _imagePath;
        }
        //
        // Form load
        //
        private void VehicleManagementForm_Load(object sender, EventArgs e)
        {

        }
        //
        // Radiobuttons check changed
        //
        private void VehiclesViewRBtn_CheckedChanged(object sender, EventArgs e)
        {
            ResetErrors();

            if (VehiclesViewRBtn.Checked)
            {
                DisplayVehicles();
            }
        }

        private void TableViewRBtn_CheckedChanged(object sender, EventArgs e)
        {
            ResetErrors();

            if(TableViewRBtn.Checked)
            {
                DisplayTable();
            }
        }
        //
        // Text box enter and leave event handlers
        //
        private void TxtBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void TxtBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Properties.Settings.Default.DISABLED_WHITE;
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
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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
