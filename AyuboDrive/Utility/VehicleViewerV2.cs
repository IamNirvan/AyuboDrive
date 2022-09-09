using AyuboDrive.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive.Utility
{
    public class VehicleViewerV2 : IVehicleViewer
    {
        private readonly int _minHeight;
        private readonly int _minWidth;
        private readonly int _rowCount;
        private readonly DataTable _dataTable;
        private Panel _container;
        private Panel[] _containers;
        private Panel[] _imagePanels;
        private Label[] _vehicleNames;
        private Label[] _interactiveLabels;
        private readonly string[] _imagePaths;

        public VehicleViewerV2(Panel container, DataTable dataTable, int minWidth, int minHeight, string[] images)
        {
            _container = container;
            _dataTable = dataTable;
            _minWidth = minWidth;
            _minHeight = minHeight;
            _imagePaths = images;
            _rowCount = _dataTable.Rows.Count;
            InitializeArrays();
        }

        public VehicleViewerV2(Panel container, DataTable dataTable, string[] images)
        {
            _container = container;
            _dataTable = dataTable;
            _minWidth = 150;
            _minHeight = 150;
            _imagePaths = images;
            _rowCount = _dataTable.Rows.Count;
            InitializeArrays();
        }

        public Label[] GetIteractiveLabels()
        {
            return _interactiveLabels;
        }

        public Label[] GetVehicleNames()
        {
            return _vehicleNames;
        }

        public Panel[] GetContainers()
        {
            return _containers;
        }

        public void AddContainers()
        {
            try
            {
                int panelWidth = _container.Width;
                int numOfAddedContiners = 0;
                int containersToBeAdded = panelWidth / _minWidth;
                decimal fractionalPart = (panelWidth / (decimal)_minWidth) % 1.0m;
                int xAxisOffset = ((int)(_minWidth * fractionalPart))/2;

                int containerPadding = xAxisOffset / containersToBeAdded;
                int xAxisPoint = xAxisOffset - containerPadding;
                int yAxisPoint = xAxisOffset - containerPadding;

                // This will add the containers horizontally
                for (int i = 0; i < containersToBeAdded; i++)
                {
                    Panel container = new Panel()
                    {
                        Size = new Size(_minWidth, _minHeight),
                        Location = new Point(xAxisPoint, yAxisPoint),
                        BackColor = Program.LIGHT_GRAY,
                        Name = $"Panel-{i}",
                        Cursor = Cursors.Hand
                    };

                    _container.Controls.Add(container);
                    _containers[numOfAddedContiners] = container;
                    numOfAddedContiners++;
                    // Add some space between each container
                    xAxisPoint += _minWidth+containerPadding;

                    // If the num of containers for the row has been maxed out,
                    // Then start adding the remaining containers into the next row. 
                    //(Increment YAxisPoint to do this)
                    if (i == (containersToBeAdded) - 1)
                    {
                        i = -1;
                        yAxisPoint += _minHeight+ containerPadding;
                        // Reset the x-axis coordinate
                        xAxisPoint = xAxisOffset- containerPadding; 
                    }

                    // Add a break condition
                    if(numOfAddedContiners == _rowCount)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occurred when adding the containers");
            }
        }

        public void AddImageLabels()
        {
            try
            {
                int columnCount = _dataTable.Columns.Count;
                int panelWidth = _container.Width;
                int index1 = 0;

                for (int i = 0; i < _rowCount; i++)
                {
                    Image image = Properties.Resources.defaultCar;
                    //if (File.Exists(_imagePaths[i]))
                    //{
                    //    image = Image.FromFile(_imagePaths[i]);
                    //}
                    //else
                    //{
                    //    // Load default image
                    //    image = Properties.Resources.defaultCar;
                    //}

                    Panel imagePanel = new Panel()
                    {
                        Size = new Size(_minWidth, (int)(_minHeight * 0.8)),
                        Location = new Point(0, 0),
                        BackColor = Properties.Settings.Default.TRANSPARENT,
                        BackgroundImage = image,
                        BackgroundImageLayout = ImageLayout.Zoom,
                        Name = $"imageLabel-{i}"
                    };

                    _containers[index1].Controls.Add(imagePanel);
                    _imagePanels[i] = imagePanel;
                    index1++;
                }
            }
            catch (Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occurred when adding the containers");
            }
        }

        public void AddVehicleNameLabels()
        {
            try
            {
                int columnCount = _dataTable.Columns.Count;
                int panelWidth = _container.Width;
                int index1 = 0;
                DataRow record;

                for (int i = 0; i < _rowCount; i++)
                {
                    record = _dataTable.Rows[i];

                    Label nameLabel = new Label()
                    {
                        Size = new Size(_minWidth, (_minHeight) - (int)(_minHeight * 0.8)),
                        Location = new Point(0, (int)(_minHeight * 0.8)),
                        Font = new Font("Carlito", 9),
                        BackColor = Properties.Settings.Default.LIGHTER_GRAY,
                        ForeColor = Properties.Settings.Default.DISABLED_WHITE,
                        Name = $"imageLabel-{i}",
                        TextAlign = ContentAlignment.MiddleCenter,
                        Text = $"{record[3].ToString()} {record[4].ToString()}"
                    };

                    _containers[index1].Controls.Add(nameLabel);
                    _vehicleNames[i] = nameLabel;
                    index1++;
                }
            }
            catch (Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occurred when adding the containers");
            }
        }

        private void AddIteractiveLabels()
        {
            for(int i = 0; i < _containers.Length; i ++)
            {
                Label interactiveLabel = new Label()
                {
                    Size = new Size(_minWidth, _minHeight),
                    Location = new Point(0, 0),
                    BackColor = Color.Transparent,
                    Name = $"Label-{i}"
                };
                _containers[i].Controls.Add(interactiveLabel);
                _interactiveLabels[i] = interactiveLabel;
                interactiveLabel.BringToFront();
            }
        }

        private void InitializeArrays()
        {
            _containers = new Panel[_rowCount];
            _imagePanels = new Panel[_rowCount];
            _vehicleNames = new Label[_rowCount];
            _interactiveLabels = new Label[_rowCount];
        }

        public void Display()
        {            
            AddContainers();
            AddImageLabels();
            AddVehicleNameLabels();
            //AddIteractiveLabels();
        }
    }
}
