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
    public partial class RentalBookingManipulationForm : Form
    {
        private readonly QueryHandler queryHandler = new QueryHandler();
        //private Label[] _manufacturerLabels;
        private DataTable _dataTable;
        private bool _includeDriver = false;
        private string _vehicleID;
        private Form _dashboardForm;


        public RentalBookingManipulationForm(Form dashboardForm)
        {
            InitializeComponent();
            HandleTitleBar();
            _dashboardForm = dashboardForm;
        }

        // -- TITLE BAR BUTTON FUNCTIONALITY --

        private void ExitBtn_MouseClick(object sender, EventArgs e)
        {
            _dashboardForm.Show();
            this.Hide();
        }

        private void MinimizeBtn_MouseClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // -- END OF TITLE BAR BUTTON FUNCTIONALITY --

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
            foreach(Label imageLabel in labels)
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

            _vehicleID = record[0].ToString();
            VINValueLabel.Text = record[1].ToString();
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

        private void vehicleTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (vehicleTypeComboBox.SelectedIndex >= 0)
                {
                    string vehicleTypeID = vehicleTypeComboBox.Text.Split('-')[0];
                    string query = "SELECT * FROM vehicle WHERE vehicleTypeID = '" + vehicleTypeID + 
                    "' AND vehicleStatus = 'Available'";
                    _dataTable = queryHandler.SelectQueryHandler(query);
                    vehiclePanel.Controls.Clear();
                    VehicleViewer vehicleViewer = new VehicleViewer(vehiclePanel, _dataTable);
                    //vehicleViewer.Display(GetImagePaths());
                    vehicleViewer.Display();
                    AddClickEventHandler(vehicleViewer.GetManufacturerLabels());
                    vehicleDecriptionPnlCover1.Visible = true;
                    vehicleDecriptionPnlCover2.Visible = true;
                }
                //else
                //{
                //    MessagePrinter.PrintToMessageBox("Please select a valid vehicle type ID", "Invalid vehicle type ID",
                //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
            }
            catch(Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occured when selecting a vehicle type");
            }
        }

        private void FillVehicleTypeComboBox(DataTable dataTable)
        {
            foreach(DataRow record in dataTable.Rows)
            {
                vehicleTypeComboBox.Items.Add($"{record[0]}-{record[1]}");
            }
        }

        private void FillDriverComboBox(DataTable dataTable)
        {
            foreach(DataRow record in dataTable.Rows)
            {
                DriverIDCmbBox.Items.Add($"{record[0]}-{record[2]} {record[3]}");
            }
        }

        private void FillCustomerComboBox(DataTable dataTable)
        {
            foreach(DataRow record in dataTable.Rows)
            {
                CustomerIDCmbBox.Items.Add($"{record[0]}-{record[2]} {record[3]}");
            }
        }

        private void RentalBooking_Load(object sender, EventArgs e)
        {
            _dataTable = queryHandler.SelectQueryHandler("SELECT * FROM vehicle WHERE vehicleStatus = 'Available'");
            VehicleViewer vehicleViewer = new VehicleViewer(vehiclePanel, _dataTable);
            //vehicleViewer.Display(GetImagePaths());
            vehicleViewer.Display();
            AddClickEventHandler(vehicleViewer.GetManufacturerLabels());

            FillVehicleTypeComboBox(queryHandler.SelectQueryHandler("SELECT * FROM vehicleType"));
            FillDriverComboBox(queryHandler.SelectQueryHandler("SELECT * FROM driver"));
            FillCustomerComboBox(queryHandler.SelectQueryHandler("SELECT * FROM customer"));
        }

        private void makeBookingBtn_Click(object sender, EventArgs e)
        {
           
            string customerID = CustomerIDCmbBox.Text.Split('-')[0];
            string vehicleTypeID = vehicleTypeComboBox.Text.Split('-')[0];
            string startDate = startDTP.Text;
            string returnDate = returnDTP.Text;

            string driverID;
            if (_includeDriver)
            {
                driverID = DriverIDCmbBox.Text.Split('-')[0];
            }
            else
            {
                driverID = null;
            }

            if(ValidateInput(customerID, CustomerIDCmbBox.SelectedIndex, vehicleTypeID, vehicleTypeComboBox.SelectedIndex, 
                driverID, DriverIDCmbBox.SelectedIndex))
            {
                RentalBooking rentalBooking = new RentalBooking(vehicleTypeID, _vehicleID, driverID,
                    customerID, startDate, returnDate);
                rentalBooking.Insert();
            }
            else
            {
                MessagePrinter.PrintToMessageBox("Please enter valid input(s)", "Invalid input(s)", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput(string customerID, int customerSelectedIndex, string vehicleTypeID, int vehicleTypeSelectedIndex, 
            string driverID, int driverSelectedIndex)
        {
            bool validCustomerID = false;
            bool validVehicleTypeID = false;
            bool validDriverID = false;
         
            try
            {
                if (customerID.Length != 0 && customerSelectedIndex >= 0)
                {
                    validCustomerID = true;
                }
                else
                {
                    // Error label message
                }

                if (vehicleTypeID.Length != 0 && vehicleTypeSelectedIndex >= 0)
                {
                    validVehicleTypeID = true;
                }
                else
                {
                    // Error label message
                }

                if (driverID == null)
                {
                    validDriverID = true;
                }
                else if(driverID != null && driverID.Length != 0 && driverSelectedIndex >= 0)
                {
                    validDriverID = true;
                }
                else
                {
                    // Error label message
                }
                return validCustomerID && validDriverID && validVehicleTypeID;
            }
            catch(Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occurred when validating the input");
            }
            return false;
        }

        private void includeDriverCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(includeDriverCheckBox.Checked)
            {
                DriverIDLbl.Visible = true;
                DriverIDCmbBox.Visible = true;
                _includeDriver = true;
            }
            else
            {
                DriverIDLbl.Visible = false;
                DriverIDCmbBox.Visible = false;
                _includeDriver = false;
            }
        }
    }
}
