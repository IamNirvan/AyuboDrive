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
    public partial class RentalBookingManagementForm : Form
    {
        private readonly QueryHandler queryHandler = new QueryHandler();
        private DataTable _dataTable;
        private bool _includeDriver = false;
        private string _vehicleID;
        private Form _dashboardForm;

        public RentalBookingManagementForm(Form dashboardForm)
        {
            InitializeComponent();
            HandleTitleBar();
            _dashboardForm = dashboardForm;
        }
        //
        // Title bar functionality
        //
        private void ExitBtn_MouseClick(object sender, EventArgs e)
        {
            _dashboardForm.Show();
            this.Hide();
        }

        private void MinimizeBtn_MouseClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HandleTitleBar()
        {
            CustomTitleBar customTitleBar = new CustomTitleBar(this, 30, Properties.Settings.Default.DARK_GRAY);
            customTitleBar.CreateExitButton(Properties.Settings.Default.TRANSPARENT,
                Properties.Settings.Default.ENABLED_WHITE);
            customTitleBar.CreateMinimizeButton(Properties.Settings.Default.TRANSPARENT,
                Properties.Settings.Default.DISABLED_WHITE);
            Panel titleBar = customTitleBar.GetTitleBar();
            Button exitButton = customTitleBar.GetExitButton();
            Button minimizeButton = customTitleBar.GetMinimizeButton();
            Controls.Add(titleBar);
            titleBar.BringToFront();
            exitButton.MouseClick += new MouseEventHandler(ExitBtn_MouseClick);
            minimizeButton.MouseClick += new MouseEventHandler(MinimizeBtn_MouseClick);
        }

        private string[] GetImagePaths()
        {
            DataTable dataTable = queryHandler.SelectQueryHandler("SELECT imagePath FROM vehicle");
            string[] result = new string[dataTable.Rows.Count];
            int index = 0;

            foreach (DataRow record in dataTable.Rows)
            {
                result[index] = record["imagePath"].ToString();
                index++;
            }
            return result;
        }

        private void AddClickEventHandler(Label[] labels)
        {
            foreach (Label imageLabel in labels)
            {
                imageLabel.Click += new EventHandler(ImageLabel_Click);
            }
        }

        private void ImageLabel_Click(object sender, EventArgs e)
        {
            vehicleDecriptionPnlCover1.Visible = false;
            vehicleDecriptionPnlCover2.Visible = false;
            int index = int.Parse(((Label)sender).Name.Split('-')[1]);
            DataRow record = _dataTable.Rows[index];

            // Get the vehicle type name before adding it to the vehicle type combo box
            DataTable vehicleTypeName = queryHandler.SelectQueryHandler("SELECT typeName FROM vehicleType WHERE vehicleTypeID = '" 
                + record[2].ToString() + "'");

            _vehicleID = record[0].ToString();
            VINValueLabel.Text = record[1].ToString();
            vehicleTypeComboBox.Text = $"{record[2].ToString()}-{vehicleTypeName.Rows[0][0].ToString()}";
            manufacturerValueLbl.Text = record[3].ToString();
            modelValueLabel.Text = record[4].ToString();
            seatingCapacityValueLabel.Text = record[5].ToString();
            mileageValueLabel.Text = record[6].ToString();
            TorqueValueLbl.Text = record[7].ToString();
            HorsepowerValueLbl.Text = record[8].ToString();
            dailyRateValueLabel.Text = record[9].ToString();
            weeklyRateValueLabel.Text = record[10].ToString();
            monthlyRateValueLabel.Text = record[11].ToString();
        }
        //
        // Combo box functionality
        //

        // FIX THIS BUG
        // Occurs when a vehicle is selected.
        private void vehicleTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string vehicleTypeID = vehicleTypeComboBox.Text.Split('-')[0];
                string query = "SELECT * FROM vehicle WHERE vehicleTypeID = '" + vehicleTypeID +
                "' AND vehicleStatus = 'Available'";
                _dataTable = queryHandler.SelectQueryHandler(query);
                vehiclePanel.Controls.Clear();
                VehicleViewer vehicleViewer = new VehicleViewer(vehiclePanel, _dataTable);
                vehicleViewer.Display();
                AddClickEventHandler(vehicleViewer.GetManufacturerLabels());
                vehicleDecriptionPnlCover1.Visible = true;
                vehicleDecriptionPnlCover2.Visible = true;
            }
            catch (Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occured when selecting a vehicle type");
            }
        }

        private void FillVehicleTypeComboBox(DataTable dataTable)
        {
            foreach (DataRow record in dataTable.Rows)
            {
                vehicleTypeComboBox.Items.Add($"{record[0]}-{record[1]}");
            }
        }

        private void FillDriverComboBox(DataTable dataTable)
        {
            foreach (DataRow record in dataTable.Rows)
            {
                DriverIDCmbBox.Items.Add($"{record[0]}-{record[2]} {record[3]}");
            }
        }

        private void FillCustomerComboBox(DataTable dataTable)
        {
            foreach (DataRow record in dataTable.Rows)
            {
                CustomerIDCmbBox.Items.Add($"{record[0]}-{record[2]} {record[3]}");
            }
        }

        // REFINE THIS:
        private void makeBookingBtn_Click(object sender, EventArgs e)
        {

            string customerID = CustomerIDCmbBox.Text.Split('-')[0];
            string vehicleTypeID = vehicleTypeComboBox.Text.Split('-')[0];
            string startDate = startDTP.Text;
            string returnDate = returnDTP.Text;

            Console.WriteLine($"The selected index is: {vehicleTypeComboBox.SelectedIndex}");

            string driverID;
            if (_includeDriver)
            {
                driverID = DriverIDCmbBox.Text.Split('-')[0];
            }
            else
            {
                driverID = null;
            }

            if (ValidateInput(customerID, CustomerIDCmbBox.SelectedIndex, 
                vehicleTypeID, vehicleTypeComboBox.SelectedIndex,
                driverID, DriverIDCmbBox.SelectedIndex))
            {
                RentalBooking rentalBooking = new RentalBooking(vehicleTypeID, _vehicleID, driverID,
                    customerID, startDate, returnDate);
                if(rentalBooking.Insert())
                {
                    MessagePrinter.PrintToMessageBox("Rental booking details was successfully inserted", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to insert rental booking details", "Operation failed",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput(string customerID, int customerIDSelectedIndex, 
            string vehicleTypeID, int vehicleTypeIDSelectedIndex, 
            string driverID, int driverIDSelectedIndex)
        {
            bool validCustomerID = false;
            bool validVehicleTypeID = false;
            bool validDriverID = false;

            try
            {
                if (customerID.Length != 0 && customerIDSelectedIndex >= 0)
                {
                    validCustomerID = true;
                    CustomerIDErrorLbl.Text = "";
                }
                else
                {
                    CustomerIDErrorLbl.Text = "Invalid customer ID";
                }

                if (vehicleTypeID.Length != 0 && vehicleTypeIDSelectedIndex >= 0)
                {
                    validVehicleTypeID = true;
                    VehicleTypeErrorLbl.Text = "";
                }
                else
                {
                    VehicleTypeErrorLbl.Text = "Invalid vehicle type";
                }

                if (driverID == null)
                {
                    validDriverID = true;
                    DriverIDErrorLbl.Text = "";
                }
                else if (driverID != null && driverID.Length != 0 && driverIDSelectedIndex >= 0)
                {
                    validDriverID = true;
                    DriverIDErrorLbl.Text = "";
                }
                else
                {
                    DriverIDErrorLbl.Text = "Invalid driver";
                }
                return validCustomerID && validDriverID && validVehicleTypeID;
            }
            catch (Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occurred when validating the input");
            }
            return false;
        }

        private void includeDriverCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (includeDriverCheckBox.Checked)
            {
                DriverIDLbl.Visible = true;
                DriverIDCmbBox.Visible = true;
                DriverIDErrorLbl.Visible = true;
                _includeDriver = true;
            }
            else
            {
                DriverIDLbl.Visible = false;
                DriverIDCmbBox.Visible = false;
                DriverIDErrorLbl.Visible = false;
                DriverIDErrorLbl.Text = "";
                _includeDriver = false;
            }
        }

        private void RentalBookingManagementForm_Load(object sender, EventArgs e)
        {
            _dataTable = queryHandler.SelectQueryHandler("SELECT * FROM vehicle WHERE vehicleStatus = 'Available'");
            VehicleViewer vehicleViewer = new VehicleViewer(vehiclePanel, _dataTable);
            vehicleViewer.Display();
            //vehicleViewer.Display(GetImagePaths());
            AddClickEventHandler(vehicleViewer.GetManufacturerLabels());

            FillVehicleTypeComboBox(queryHandler.SelectQueryHandler("SELECT * FROM vehicleType"));
            FillDriverComboBox(queryHandler.SelectQueryHandler("SELECT * FROM driver"));
            FillCustomerComboBox(queryHandler.SelectQueryHandler("SELECT * FROM customer"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vehiclePanel.Controls.Clear();
            vehiclePanel.Height = 463;
            DataViewer dataViewer = new DataViewer(vehiclePanel, queryHandler.SelectQueryHandler("SELECT * FROM rentalBooking"));
            dataViewer.DisplayTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vehiclePanel.Controls.Clear();
            vehiclePanel.Height = 364;
            VehicleViewer vehicleViewer = new VehicleViewer(vehiclePanel, queryHandler.SelectQueryHandler("SELECT * FROM vehicle"));
            vehicleViewer.Display();
            AddClickEventHandler(vehicleViewer.GetManufacturerLabels());

        }
    }
}
