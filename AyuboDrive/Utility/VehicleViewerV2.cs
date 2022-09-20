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
        protected Panel[] _containers;
        private Panel[] _imagePanels;
        private Label[] _vehicleNames;
        private readonly string _imageQuery;
        private readonly string _vehicleQuery;
        private static readonly QueryHandler _queryHandler = new QueryHandler();
        DataRowCollection rows;

        public VehicleViewerV2(Panel container, DataTable dataTable, int minWidth, int minHeight, string query, string vehicleQuery)
        {
            _container = container;
            _dataTable = dataTable;
            _minWidth = minWidth;
            _minHeight = minHeight;
            _imageQuery = query;
            _vehicleQuery = vehicleQuery;
            _rowCount = _dataTable.Rows.Count;
            InitializeArrays();
            rows = _queryHandler.SelectQueryHandler(_vehicleQuery).Rows;
        }

        public VehicleViewerV2(Panel container, DataTable dataTable, string query)
        {
            _container = container;
            _dataTable = dataTable;
            _minWidth = 150;
            _minHeight = 150;
            _imageQuery = query;
            _rowCount = _dataTable.Rows.Count;
            InitializeArrays();
            rows = _queryHandler.SelectQueryHandler(_vehicleQuery).Rows;
        }

        public Label[] GetVehicleNames()
        {
            return _vehicleNames;
        }

        public Panel[] GetImagePanels()
        {
            return _imagePanels;
        }

        public Panel[] GetContainers()
        {
            return _containers;
        }

        protected void AddCover()
        {
            Panel panel = new Panel
            {
                BackColor = Properties.Settings.Default.LIGHT_GRAY,
                Location = new Point(0, 0),
                Size = new Size(_container.Size.Width, _container.Size.Height)
                
            };
            _container.Controls.Add(panel);
            panel.BringToFront();

            Label label = new Label() {
                Text = "No data to display",
                Size = new Size(100, 100),
                ForeColor = Properties.Settings.Default.ENABLED_WHITE,
                BackColor = Properties.Settings.Default.TRANSPARENT,
                Location = new Point((panel.Width/2)-50, (panel.Height/2))
            };
            panel.Controls.Add(label);
        }

        public virtual void AddContainers()
        {
            try
            {
                bool addContainers = _rowCount >= 1;

                int panelWidth = _container.Width;
                int numOfAddedContiners = 0;
                int containersToBeAdded = panelWidth / _minWidth;
                decimal fractionalPart = (panelWidth / (decimal)_minWidth) % 1.0m;
                int xAxisOffset = ((int)(_minWidth * fractionalPart)) / 2;

                int containerPadding = xAxisOffset / containersToBeAdded;
                int xAxisPoint = xAxisOffset - containerPadding;
                int yAxisPoint = xAxisOffset - containerPadding;

                // This will add the containers horizontally
                for (int i = 0; i < containersToBeAdded && addContainers; i++)
                {
                    Panel container = new Panel()
                    {
                        Size = new Size(_minWidth, _minHeight),
                        Location = new Point(xAxisPoint, yAxisPoint),
                        BackColor = Properties.Settings.Default.LIGHT_GRAY,
                        Name = $"Panel-{rows[i][0]}",
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

        public virtual void AddImageLabels()
        {
            string[] imagePaths = ImagePathsRetriever.GetVehicleImagePaths(_imageQuery);

            try
            {
                int columnCount = _dataTable.Columns.Count;
                int panelWidth = _container.Width;
                int index1 = 0;

                for (int i = 0; i < _rowCount; i++)
                {
                    Image image;

                    // Don't attempt to access the array if it is null.
                    if (imagePaths != null && File.Exists(imagePaths[i]))
                    {
                        //image = Image.FromFile(imagePaths[i]);
                        image = Image.FromFile(imagePaths[i]);
                    }
                    else
                    {
                        image = Properties.Resources.defaultCar;
                    }

                    Panel imagePanel = new Panel()
                    {
                        Size = new Size(_minWidth, (int)(_minHeight * 0.8)),
                        Location = new Point(0, 0),
                        BackColor = Properties.Settings.Default.TRANSPARENT,
                        BackgroundImage = image,
                        BackgroundImageLayout = ImageLayout.Zoom,
                        Name = $"imageLabel-{rows[i][0]}"
                    };

                    _containers[index1].Controls.Add(imagePanel);
                    _imagePanels[i] = imagePanel;
                    index1++;
                }
            }
            catch (Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occurred when adding the image labels");
            }
        }

        public virtual void AddVehicleNameLabels()
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
                        //Name = $"imageLabel-{i}",
                        Name = $"imageLabel-{rows[i][0]}",
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

        protected void InitializeArrays()
        {
            _containers = new Panel[_rowCount];
            _imagePanels = new Panel[_rowCount];
            _vehicleNames = new Label[_rowCount];
        }

        public virtual void Display()
        {            
            if(_dataTable.Rows.Count == 0)
            {
                AddCover();
                return;
            }
            AddContainers();
            AddImageLabels();
            AddVehicleNameLabels();
        }
    }
}
