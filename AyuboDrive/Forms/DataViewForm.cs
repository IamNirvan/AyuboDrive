using AyuboDrive.Forms;
using AyuboDrive.Utility;
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
        private Panel[] panels;
        private Label[][] labels;

        public DataViewForm(DashboardForm dashboard, string title, FormType type, int[] positions, string selectQuery = null)
        {
            InitializeComponent();
            dashboardForm = dashboard;
            query = selectQuery;
            formType = type;
            formTitle = title;
            inputTypePositions = positions;
            EnableButtons(false);
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

        // TODO: Rename to DisplayRows
        private void DisplayRows()
        {
            DataTable dataTable = queryHandler.SelectQueryHandler(query);

            HighlightButton();
            dataPanel.Controls.Clear();
            //PlaceObjects(dataTable);


            int rowCount = dataTable.Rows.Count, columnCount = dataTable.Columns.Count;
            int panelWidth = dataPanel.Width - 40, panelHeight = 50;
            int yAxisPoint = 10;
            recordPanels = new Panel[rowCount+1]; // +1 to include the header
            labels = new Label[rowCount+1][];

            for(int i = 0; i < rowCount+1; i ++)
            {
                labels[i] = new Label[columnCount];
            }

            // Create recordPanels (records)
            // recordPanels[0] is the header
            for (int i = 0; i <= rowCount; i++)
            {
                Panel recordPanel = new Panel()
                {
                    Size = new Size(panelWidth, panelHeight),
                    Location = new Point(15, yAxisPoint),
                    Name = $"Panel-{i}",
                    BackColor = Program.LIGHT_GRAY,
                    Cursor = Cursors.Hand
                };

                if (i == 0) { recordPanel.BackColor = Program.PURPLE; }

                dataPanel.Controls.Add(recordPanel);
                recordPanels[i] = recordPanel;
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
                    Name = $"cellLabel-{index1}",
                    ForeColor = Program.DISABLED_WHITE,
                    BackColor = Program.TRANSPARENT
                };

                if(index1 == 0) { label.ForeColor = Program.ENABLED_WHITE; }

                recordPanels[index1].Controls.Add(label);
                //labels[index1, i] = label;
                label.MouseEnter += new EventHandler(this.Cell_MouseEnter);
                label.MouseLeave += new EventHandler(this.Cell_MouseLeave);
                label.Click += new EventHandler(this.Cell_Click);
                labels[index1][i] = label;
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

            try
            {
                int index2 = 0;

                // Add the values into each label
                for (int i = 0; i < columnCount; i++)
                {
                    if (index2 == 0)
                    {
                        // Set the column name as the label's text
                        labels[0][i].Text = dataTable.Columns[i].ColumnName;
                    }
                    else
                    {
                        // Get the text of a specific cell and set it as the label's text
                        labels[index2][i].Text = (dataTable.Rows[index2 - 1][i]).ToString();
                    }

                    if (i == columnCount - 1)
                    {
                        i = -1;
                        index2 += 1;
                    }

                    if (index2 == rowCount + 1) { break; }
                }

            } catch (Exception e)
            {
                MessageBox.Show($"An exception occurred: {e}", "Exception when generating records", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlaceObjects(DataTable dataTable)
        {
            manipulationPanel.Controls.Clear();

            //DataTable dataTable = queryHandler.SelectQueryHandler(query);
            int yAxisPoint = 30, xAxisPoint = 20;
            int textBoxesIndex = 0, comboBoxesIndex = 0;
            int panelWidth = manipulationPanel.Width, panelHeight = manipulationPanel.Height;

            panels = new Panel[inputTypePositions.Length];
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
                        BorderStyle = BorderStyle.None,
                        Enabled = enableManipulationsCheckBox.Checked ? true : false
                    };

                    // Set the event handlers for the enter and leave events.
                    textBox.Enter += new EventHandler(this.TextBox_Enter);
                    textBox.Leave += new EventHandler(this.TextBox_Leave);
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
                        FlatStyle = FlatStyle.Flat,
                        Enabled = enableManipulationsCheckBox.Checked ? true : false
                    };

                    // Set the event handlers for the enter and leave events.
                    comboBox.Enter += new EventHandler(this.ComboBox_Enter);
                    comboBox.Leave += new EventHandler(this.ComboBox_Leave);
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

        private void Cell_MouseEnter(object sender, EventArgs e)
        {
            //((Panel)sender).BackColor = Program.LIGHT_GRAY;

            // Get the number associated with the label name. For example: panel-0
            int index = Int32.Parse(((Label)sender).Name.Split('-')[1]);

            if (index != 0)
            {
                Panel panel = recordPanels[index]; // Access the parent panel
                panel.BackColor = Program.LIGHTER_GRAY;

                Label[] subArray = labels[index];

                for (int i = 0; i < subArray.Length; i++)
                {
                    subArray[i].ForeColor = Program.ENABLED_WHITE;
                }
            }
        }

        private void Cell_MouseLeave(object sender, EventArgs e)
        {
            // Get the number associated with the label name. For example: panel-0
            int index = Int32.Parse(((Label)sender).Name.Split('-')[1]);
            Panel panel = recordPanels[index]; // Access the parent panel

            if (index != 0)
            {
                panel.BackColor = Program.LIGHT_GRAY;

                Label[] subArray = labels[index];

                for (int i = 0; i < subArray.Length; i++)
                {
                    subArray[i].ForeColor = Program.DISABLED_WHITE;
                }
            }
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(((Label)sender).Name.Split('-')[1]);
            AddData(index);
        }

        private void AddData(int index)
        {
            Label[] subArray = labels[index];

            for (int i = 0; i < subArray.Length; i++)
            {
                if(inputTypePositions[i] == 0)
                {
                    textboxes[i].Text = subArray[i].Text;
                } else
                {
                    // For comboboxes, add the text and provide alternative options
                    comboBoxes[i].Text = subArray[i].Text;
                }
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Program.ENABLED_WHITE;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Program.DISABLED_WHITE;
        }


        private void DataViewForm_Load(object sender, EventArgs e)
        {
            headingLbl.Text = formTitle;
            //DisplayRows();

            //new DataViewer(dataPanel, queryHandler.SelectQueryHandler(query)).DisplayTable();
        }




        private void DataViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dashboardForm.Show();
        }

        private void ComboBox_Enter(object sender, EventArgs e)
        {
            ((ComboBox)sender).ForeColor = Program.ENABLED_WHITE;
        }

        private void ComboBox_Leave(object sender, EventArgs e)
        {
            ((ComboBox)sender).ForeColor = Program.DISABLED_WHITE;
        }

        private void customerManagementBtn_Click(object sender, EventArgs e)
        {
            formType = FormType.CUSTOMER_MANAGEMENT;
            headingLbl.Text = Program.CUSTOMER_MANAGEMENT;
            query = "SELECT * FROM Customer";
            inputTypePositions = Program.CUSTOMER_MANAGEMENT_POSITIONS;
            DisplayRows();
        }

        private void vehicleManagementBtn_Click(object sender, EventArgs e)
        {
            formType = FormType.VEHICLE_MANAGEMENT;
            headingLbl.Text = Program.VEHICLE_MANAGEMENT;
            query = "SELECT * FROM Vehicle";
            inputTypePositions = Program.VEHICLE_MANAGEMENT_POSITIONS;
            DisplayRows();
        }

        private void vehicleTypeManagementBtn_Click(object sender, EventArgs e)
        {
            formType = FormType.VEHICLE_TYPE_MANAGEMENT;
            headingLbl.Text = Program.VEHICLE_TYPE_MANAGEMENT;
            query = "SELECT * FROM VehicleType";
            inputTypePositions = Program.VEHICLE_TYPE_MANAGEMENT_POSITIONS;
            DisplayRows();
        }

        private void packageTypeBookingsBtn_Click(object sender, EventArgs e)
        {
            formType = FormType.PACKAGE_TYPE_MANAGEMENT;
            headingLbl.Text = Program.PACKAGE_TYPE_MANAGEMENT;
            query = "SELECT * FROM PackageType";
            inputTypePositions = Program.PACKAGE_TYPE_MANAGEMENT_POSITIONS;
            DisplayRows();
        }

        // The long tour data will be shown by default at 
        private void hireBookingsBtn_Click(object sender, EventArgs e)
        {
            formType = FormType.LONG_TOUR_HIRE_BOOKINGS_MANAGEMENT;
            headingLbl.Text = Program.HIRE_BOOKINGS_MANAGEMENT;
            query = "SELECT * FROM HireBookings WHERE hireType = Long";
            inputTypePositions = Program.HIRE_BOOKINGS_MANAGEMENT_POSITIONS;
            DisplayRows();
        }

        private void rentalBookingsBtn_Click(object sender, EventArgs e)
        {
            formType = FormType.RENTAL_BOOKINGS_MANAGEMENT;
            headingLbl.Text = Program.RENTAL_BOOKINGS_MANAGEMENT;
            query = "SELECT * FROM RentalBookings";
            inputTypePositions = Program.RENTAL_BOOKINGS_MANAGEMENT_POSITIONS;
            DisplayRows();
        }

        private void enableManipulationsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(enableManipulationsCheckBox.Checked)
            {
                EnableButtons(true);

                // Enable text boxes
                for (int i = 0; i < textboxes.Length; i++)
                {
                    if (textboxes[i] != null)
                    {
                        textboxes[i].Enabled = true;
                    }
                }

                // Enable combo boxes
                for (int i = 0; i < comboBoxes.Length; i++)
                {
                    if (comboBoxes[i] != null)
                    {
                        comboBoxes[i].Enabled = true;
                    }
                }
            } else
            {
                EnableButtons(false);

                for (int i = 0; i < textboxes.Length; i++)
                {
                    if (textboxes[i] != null)
                    {
                        textboxes[i].Enabled = false;
                    }
                }

                for (int i = 0; i < comboBoxes.Length; i++)
                {
                    if (comboBoxes[i] != null)
                    {
                        comboBoxes[i].Enabled = false;
                    }
                }
            }
        }

        private void insertBtn_EnabledChanged(object sender, EventArgs e)
        {
            if (insertBtn.Enabled)
            {
                insertBtn.ForeColor = Program.ENABLED_WHITE;
                insertBtn.BackColor = Program.PURPLE;
                insertBtn.FlatAppearance.BorderColor = Program.PURPLE;
            }
            else
            {
                insertBtn.ForeColor = Program.DISABLED_WHITE;
                insertBtn.BackColor = Program.LIGHTER_GRAY;
                insertBtn.FlatAppearance.BorderColor = Program.LIGHTER_GRAY;
            }
        }

        private void deleteBtn_EnabledChanged(object sender, EventArgs e)
        {
            if(deleteBtn.Enabled)
            {
                deleteBtn.ForeColor = Program.RED;
                deleteBtn.BackColor = Program.TRANSPARENT;
                deleteBtn.FlatAppearance.BorderColor = Program.RED;
            } else
            {
                deleteBtn.ForeColor = Program.DISABLED_WHITE;
                deleteBtn.BackColor = Program.LIGHTER_GRAY;
                deleteBtn.FlatAppearance.BorderColor = Program.LIGHTER_GRAY;
            }
        }

        private void updateBtn_EnabledChanged(object sender, EventArgs e)
        {
            if (updateBtn.Enabled)
            {
                updateBtn.ForeColor = Program.ENABLED_WHITE;
                updateBtn.BackColor = Program.GREEN;
                updateBtn.FlatAppearance.BorderColor = Program.GREEN;
            }
            else
            {
                updateBtn.ForeColor = Program.DISABLED_WHITE;
                updateBtn.BackColor = Program.LIGHTER_GRAY;
                updateBtn.FlatAppearance.BorderColor = Program.LIGHTER_GRAY;
            }
        }

        private void EnableButtons(bool value)
        {
            deleteBtn.Enabled = value;
            insertBtn.Enabled = value;
            updateBtn.Enabled = value;
        }

        private void deleteBtn_MouseEnter(object sender, EventArgs e)
        {
            deleteBtn.ForeColor = Program.ENABLED_WHITE;
            deleteBtn.BackColor = Program.RED;
        }

        private void deleteBtn_MouseLeave(object sender, EventArgs e)
        {
            deleteBtn.ForeColor = Program.RED;
            deleteBtn.BackColor = Program.TRANSPARENT;
        }

        private void searchBar_Enter(object sender, EventArgs e)
        {
            searchBar.ForeColor = Program.ENABLED_WHITE;
            searchBar.Text = "";
        }

        private void searchBar_Leave(object sender, EventArgs e)
        {
            searchBar.ForeColor = Program.DISABLED_WHITE;
            searchBar.Text = "Search by Primary Key";
        }
    }
}
