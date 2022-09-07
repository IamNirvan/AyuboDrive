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
    public partial class RentalBooking : Form
    {
        private readonly QueryHandler queryHandler = new QueryHandler();
        private Label[] _manufacturerLabels;
        private DataTable _dataTable;
        public RentalBooking()
        {
            InitializeComponent();
            HandleTitleBar();

            _dataTable = queryHandler.SelectQueryHandler("SELECT * FROM vehicle WHERE vehicleStatus = 'Available'");

            VehicleViewer vehicleViewer = new VehicleViewer(vehiclePanel, _dataTable);

            vehicleViewer.Display(GetImagePaths());
            _manufacturerLabels = vehicleViewer.GetManufacturerLabels();
            AddClickEventHandler();
        }

        // -- TITLE BAR BUTTON FUNCTIONALITY --

        private void ExitBtn_MouseClick(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void AddClickEventHandler()
        {
            foreach(Label imageLabel in _manufacturerLabels)
            {
                imageLabel.Click += new EventHandler(ImageLabel_Click);
            }
        }

        private void ImageLabel_Click(object sender, EventArgs e)
        {
            int index = int.Parse(((Label)sender).Name.Split('-')[1]);
            DataRow record = _dataTable.Rows[index];


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


        //private void ShowVehicles()
        //{
        //    // Query to get data about each vehicle
        //    string query = "SELECT * FROM Customer";

        //    DataTable dataTable =  queryHandler.SelectQueryHandler(query);

        //    if(dataTable != null)
        //    {
        //        int rowCount = dataTable.Rows.Count, columnCount = dataTable.Columns.Count;
        //        int panelWidth = vehiclePanel.Width;
        //        int yAxisPoint = 10;

        //        recordPanels = new Panel[rowCount];
        //        imageLabels = new Label[rowCount];
        //        modelLabels = new Label[rowCount];
        //        VINLabels = new Label[rowCount];

        //        Font font = new Font("Carlito", 10);

        //        // Make the record panels
        //        for (int i = 0; i < rowCount; i++)
        //        {
        //            Panel recordPanel = new Panel()
        //            {
        //                Size = new Size(panelWidth - 40, 300),
        //                Location = new Point(10, yAxisPoint),
        //                BackColor = Program.LIGHTER_GRAY,
        //                Name = $"Panel-{i}",
        //                Cursor = Cursors.Hand
        //            };

        //            vehiclePanel.Controls.Add(recordPanel);
        //            recordPanels[i] = recordPanel;

        //            yAxisPoint += 310;
        //        }

        //        int index1 = 0;
        //        yAxisPoint = 0;
        //        // Add the imageLabel
        //        for (int i = 0; i < rowCount; i++)
        //        {
        //            Label imageLabel = new Label()
        //            {
        //                Size = new Size(panelWidth - 40, 240),
        //                Location = new Point(0, yAxisPoint),
        //                BackColor = Program.DARK_GRAY,
        //                Name = $"imageLabel-{i}"
        //            };

        //            recordPanels[index1].Controls.Add(imageLabel);
        //            imageLabels[i] = imageLabel;

        //            Label modelLabel = new Label()
        //            {
        //                Size = new Size(panelWidth - 40, 30),
        //                Location = new Point(0, imageLabel.Location.Y + 240),
        //                BackColor = Program.RED,
        //                Font = font,
        //                Text = "Model: ",
        //                TextAlign = ContentAlignment.MiddleCenter,
        //                Name = $"modelLabel-{i}"
        //            };

        //            recordPanels[index1].Controls.Add(modelLabel);
        //            modelLabels[i] = modelLabel;

        //            Label VINLabel = new Label()
        //            {
        //                Size = new Size(panelWidth - 40, 30),
        //                Location = new Point(0, 270),
        //                BackColor = Program.GREEN,
        //                Font = font,
        //                Text = "VIN: ",
        //                TextAlign = ContentAlignment.MiddleCenter,
        //                Name = $"VINLabel-{i}"
        //            };

        //            recordPanels[index1].Controls.Add(VINLabel);
        //            VINLabels[i] = VINLabel;
        //            index1++;
        //        }
        //    }

        //}

        private void RentalBooking_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
