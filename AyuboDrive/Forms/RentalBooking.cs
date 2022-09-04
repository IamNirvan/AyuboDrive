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
        private Panel[] recordPanels;
        private Label[] imageLabels;
        private Label[] modelLabels;
        private Label[] VINLabels;

        public RentalBooking()
        {
            InitializeComponent();
            ShowVehicles();
        }


        private void ShowVehicles()
        {
            // Query to get data about each vehicle
            string query = "SELECT * FROM Customer";

            DataTable dataTable =  queryHandler.SelectQueryHandler(query);

            if(dataTable != null)
            {
                int rowCount = dataTable.Rows.Count, columnCount = dataTable.Columns.Count;
                int panelWidth = vehiclePanel.Width;
                int yAxisPoint = 10;

                recordPanels = new Panel[rowCount];
                imageLabels = new Label[rowCount];
                modelLabels = new Label[rowCount];
                VINLabels = new Label[rowCount];

                Font font = new Font("Carlito", 10);

                // Make the record panels
                for (int i = 0; i < rowCount; i++)
                {
                    Panel recordPanel = new Panel()
                    {
                        Size = new Size(panelWidth - 40, 300),
                        Location = new Point(10, yAxisPoint),
                        BackColor = Program.LIGHTER_GRAY,
                        Name = $"Panel-{i}",
                        Cursor = Cursors.Hand
                    };

                    vehiclePanel.Controls.Add(recordPanel);
                    recordPanels[i] = recordPanel;

                    yAxisPoint += 310;
                }

                int index1 = 0;
                yAxisPoint = 0;
                // Add the imageLabel
                for (int i = 0; i < rowCount; i++)
                {
                    Label imageLabel = new Label()
                    {
                        Size = new Size(panelWidth - 40, 240),
                        Location = new Point(0, yAxisPoint),
                        BackColor = Program.DARK_GRAY,
                        Name = $"imageLabel-{i}"
                    };

                    recordPanels[index1].Controls.Add(imageLabel);
                    imageLabels[i] = imageLabel;

                    Label modelLabel = new Label()
                    {
                        Size = new Size(panelWidth - 40, 30),
                        Location = new Point(0, imageLabel.Location.Y + 240),
                        BackColor = Program.RED,
                        Font = font,
                        Text = "Model: ",
                        TextAlign = ContentAlignment.MiddleCenter,
                        Name = $"modelLabel-{i}"
                    };

                    recordPanels[index1].Controls.Add(modelLabel);
                    modelLabels[i] = modelLabel;

                    Label VINLabel = new Label()
                    {
                        Size = new Size(panelWidth - 40, 30),
                        Location = new Point(0, 270),
                        BackColor = Program.GREEN,
                        Font = font,
                        Text = "VIN: ",
                        TextAlign = ContentAlignment.MiddleCenter,
                        Name = $"VINLabel-{i}"
                    };

                    recordPanels[index1].Controls.Add(VINLabel);
                    VINLabels[i] = VINLabel;
                    index1++;
                }
            }

        }

        private void RentalBooking_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
