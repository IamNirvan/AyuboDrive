using AyuboDrive.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// TODO: Make an enum of form names for the heading label

namespace AyuboDrive
{
    public partial class DataViewForm : Form
    {
        private string query;
        private readonly DashboardForm dashboardForm;
        private FormType formType;
        private Panel[] recordPanels;
        private readonly QueryHandler queryHandler = new QueryHandler();
        private string formTitle;
        private int[] inputTypePositions;
        private TextBox[] textboxes;
        private ComboBox[] comboBoxes;

        public DataViewForm(DashboardForm dashboard, string title, FormType type, int[] positions, string selectQuery = null)
        {
            InitializeComponent();
            dashboardForm = dashboard;
            query = selectQuery;
            formType = type;
            formTitle = title;
            inputTypePositions = positions;
        }

        private void HighlightButton()
        {
            if (formType == FormType.CUSTOMER_MANAGEMENT)
            {
                customerManagementBtn.BackColor = Program.LIGHTER_GRAY;
                customerManagementBtn.ForeColor = Program.ENABLED_WHITE;
            } else
            {
                customerManagementBtn.BackColor = Program.LIGHT_GRAY;
                customerManagementBtn.ForeColor = Program.DISABLED_WHITE;
            }

            if (formType == FormType.VEHICLE_TYPE_MANAGEMENT)
            {
                vehicleTypeManagementBtn.BackColor = Program.LIGHTER_GRAY;
                vehicleTypeManagementBtn.ForeColor = Program.ENABLED_WHITE;
            } else
            {
                vehicleTypeManagementBtn.BackColor = Program.LIGHT_GRAY;
                vehicleTypeManagementBtn.ForeColor = Program.DISABLED_WHITE;
            }

            if (formType == FormType.VEHICLE_MANAGEMENT)
            {
                vehicleManagementBtn.BackColor = Program.LIGHTER_GRAY;
                vehicleManagementBtn.ForeColor = Program.ENABLED_WHITE;
            } else
            {
                vehicleManagementBtn.BackColor = Program.LIGHT_GRAY;
                vehicleManagementBtn.ForeColor = Program.DISABLED_WHITE;
            }

            if (formType == FormType.PACKAGE_TYPE_MANAGEMENT)
            {
                packageTypeManagementBtn.BackColor = Program.LIGHTER_GRAY;
                packageTypeManagementBtn.ForeColor = Program.ENABLED_WHITE;
            } else
            {
                packageTypeManagementBtn.BackColor = Program.LIGHT_GRAY;
                packageTypeManagementBtn.ForeColor = Program.DISABLED_WHITE;
            }

            if (formType == FormType.LONG_TOUR_HIRE_BOOKINGS_MANAGEMENT || formType == FormType.DAY_TOUR_HIRE_BOOKINGS_MANAGEMENT)
            {
                hireBookingsBtn.BackColor = Program.LIGHTER_GRAY;
                hireBookingsBtn.ForeColor = Program.ENABLED_WHITE;
            } else
            {
                hireBookingsBtn.BackColor = Program.LIGHT_GRAY;
                hireBookingsBtn.ForeColor = Program.DISABLED_WHITE;
            }

            if (formType == FormType.RENTAL_BOOKINGS_MANAGEMENT)
            {
                rentalBookingsManagementBtn.BackColor = Program.LIGHTER_GRAY;
                rentalBookingsManagementBtn.ForeColor = Program.ENABLED_WHITE;
            } else
            {
                rentalBookingsManagementBtn.BackColor = Program.LIGHT_GRAY;
                rentalBookingsManagementBtn.ForeColor = Program.DISABLED_WHITE;
            }
        }

        private void LoadData()
        {
            HighlightButton();
            headingLbl.Text = formTitle;
            dataPanel.Controls.Clear();
        
            DataTable dataTable = queryHandler.SelectQueryHandler(query);
            PlaceObjects();

            int rowCount = dataTable.Rows.Count, columnCount = dataTable.Columns.Count;
            int panelWidth = dataPanel.Width - 40, panelHeight = 50;
            int yAxisPoint = 10;
            recordPanels = new Panel[rowCount+1]; // +1 to include the header
            Label[,] labels = new Label[rowCount+1, columnCount];

            // Create recordPanels (records)
            // recordPanels[0] is the header
            for (int i = 0; i <= rowCount; i++)
            {
                Panel panel = new Panel()
                {
                    Size = new Size(panelWidth, panelHeight),
                    Location = new Point(15, yAxisPoint),
                    Name = $"Panel {i}",
                    BackColor = Program.LIGHT_GRAY
                };

                if (i == 0) { panel.BackColor = Program.TRANSPARENT; }

                dataPanel.Controls.Add(panel);
                recordPanels[i] = panel;
                yAxisPoint += 53;
            }

            int labelWidth = (panelWidth / columnCount);
            int index1 = 0;
            int completedRows = 0;
            int xAxisPoint = 0;

            // Add the labels into each panel
            for (int i = 0; i < columnCount; i++)
            {
                Label label = new Label
                {
                    Location = new Point(xAxisPoint, 0),
                    Font = new Font("Carlito", 10),
                    Text = "Text",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(labelWidth, panelHeight),
                    Name = $"cellLabel{i}",
                    ForeColor = Program.DISABLED_WHITE
                };

                recordPanels[index1].Controls.Add(label);
                labels[index1, i] = label;
                xAxisPoint += labelWidth;

                if (i == columnCount -1)
                {
                    completedRows++;
                    // Set i to -1 because when the for loop condition is executed, 'i' will increment to 1. 
                    //Therefore, 1 cell will be missed
                    i = -1;
                    index1++;
                    xAxisPoint = 0; // Reset the x-axis point
                }
                if (index1 == rowCount+1) { break; }
            }

            int index2 = 0;
            
            // Add the values into each label
            for (int i = 0; i < columnCount; i++)
            {
                if(index2 == 0)
                {
                    // Set the column name as the label's text
                    labels[0, i].Text = dataTable.Columns[i].ColumnName;
                } else
                {
                    // Get the text of a specific cell and set it as the label's text
                    labels[index2, i].Text = (dataTable.Rows[index2-1][i]).ToString();
                }

                if (i == columnCount - 1)
                {
                    i = -1;
                    index2 += 1;
                }

                if (index2 == rowCount+1) { break; }
            }
        }

        private void PlaceObjects()
        {
            manipulationPanel.Controls.Clear();

            DataTable dataTable = queryHandler.SelectQueryHandler(query);
            int yAxisPoint = 30, xAxisPoint = 20;
            int textBoxesIndex = 0, comboBoxesIndex = 0;
            int panelWidth = manipulationPanel.Width, panelHeight = manipulationPanel.Height;

            Panel[] panels = new Panel[inputTypePositions.Length];
            Label[] labels = new Label[dataTable.Columns.Count];
            textboxes = new TextBox[inputTypePositions.Length];
            comboBoxes = new ComboBox[inputTypePositions.Length];

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                // Add the label and set the text property to the column name
                Label label = new Label
                {
                    Location = new Point(xAxisPoint, yAxisPoint),
                    Font = new Font("Carlito", 10),
                    Text = dataTable.Columns[i].ToString(),
                    Size = new Size(200, 20),
                    BackColor = Program.TRANSPARENT,
                    ForeColor = Program.DISABLED_WHITE
                };

                if (i != 0)
                {
                    // Add the label and set the text property to the column name
                    label.Location = new Point(xAxisPoint, yAxisPoint);
                }

                manipulationPanel.Controls.Add(label);
                labels[i] = label;
                yAxisPoint += 30;

                // Determine the input object (textbox, combo box, etc...)
                // 0 = textbox
                // 1 = combo box
                if (inputTypePositions[i] == 0)
                {
                    TextBox textBox = new TextBox()
                    {
                        Location = new Point(xAxisPoint, yAxisPoint - 5),
                        Font = new Font("Carlito", 10),
                        Size = new Size(panelWidth - 45, 30),
                        BackColor = Program.LIGHT_GRAY,
                        ForeColor = Program.ENABLED_WHITE,
                        BorderStyle = BorderStyle.None
                    };

                    manipulationPanel.Controls.Add(textBox);
                    textboxes[textBoxesIndex] = textBox;
                    textBoxesIndex++;

                } else
                {
                    ComboBox comboBox = new ComboBox()
                    {
                        Location = new Point(xAxisPoint, yAxisPoint - 5),
                        Font = new Font("Carlito", 10),
                        Size = new Size(panelWidth - 45, 30),
                        BackColor = Program.LIGHT_GRAY,
                        ForeColor = Program.ENABLED_WHITE,
                        FlatStyle = FlatStyle.Flat
                    };

                    manipulationPanel.Controls.Add(comboBox);
                    comboBoxes[comboBoxesIndex] = comboBox;
                    comboBoxesIndex++;
                }

                Panel panel = new Panel()
                {
                    Size = new Size(panelWidth - 45, 2),
                    BackColor = Program.PURPLE,
                    Location = new Point(xAxisPoint, yAxisPoint+15)
                };

                manipulationPanel.Controls.Add(panel);
                panels[i] = panel;
                yAxisPoint += 30;
            }
        }

        private void DataViewForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DataViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dashboardForm.Show();
        }

        private void customerManagementBtn_Click(object sender, EventArgs e)
        {
            formType = FormType.CUSTOMER_MANAGEMENT;
            formTitle = Program.CUSTOMER_MANAGEMENT;
            query = "SELECT * FROM Customer";
            inputTypePositions = Program.CUSTOMER_MANAGEMENT_POSITIONS;
            LoadData();
        }

        private void vehicleManagementBtn_Click(object sender, EventArgs e)
        {
            formType = FormType.VEHICLE_MANAGEMENT;
            formTitle = Program.VEHICLE_MANAGEMENT;
            query = "SELECT * FROM Vehicle";
            inputTypePositions = Program.VEHICLE_MANAGEMENT_POSITIONS;
            LoadData();
        }

        private void vehicleTypeManagementBtn_Click(object sender, EventArgs e)
        {
            formType = FormType.VEHICLE_TYPE_MANAGEMENT;
            formTitle = Program.VEHICLE_TYPE_MANAGEMENT;
            query = "SELECT * FROM VehicleType";
            inputTypePositions = Program.VEHICLE_TYPE_MANAGEMENT_POSITIONS;
            LoadData();
        }

        private void packageTypeBookingsBtn_Click(object sender, EventArgs e)
        {
            formType = FormType.PACKAGE_TYPE_MANAGEMENT;
            formTitle = Program.PACKAGE_TYPE_MANAGEMENT;
            query = "SELECT * FROM PackageType";
            inputTypePositions = Program.PACKAGE_TYPE_MANAGEMENT_POSITIONS;
            LoadData();
        }

        // The long tour data will be shown by default at 
        private void hireBookingsBtn_Click(object sender, EventArgs e)
        {
            formType = FormType.LONG_TOUR_HIRE_BOOKINGS_MANAGEMENT;
            formTitle = Program.HIRE_BOOKINGS_MANAGEMENT;
            query = "SELECT * FROM HireBookings WHERE hireType = Long";
            inputTypePositions = Program.HIRE_BOOKINGS_MANAGEMENT_POSITIONS;
            LoadData();
        }

        private void rentalBookingsBtn_Click(object sender, EventArgs e)
        {
            formType = FormType.RENTAL_BOOKINGS_MANAGEMENT;
            formTitle = Program.RENTAL_BOOKINGS_MANAGEMENT;
            query = "SELECT * FROM RentalBookings";
            inputTypePositions = Program.RENTAL_BOOKINGS_MANAGEMENT_POSITIONS;
            LoadData();
        }
    }
}
