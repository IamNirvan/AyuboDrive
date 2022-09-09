using AyuboDrive.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive.Utility
{
    public class VehicleViewer : IVehicleViewer
    {
        protected Panel _container;
        protected Panel[] _recordPanels;
        protected Panel[] _imagePanels;
        protected Label[] _manufacturerLabels;
        protected readonly DataTable _dataTable;
        protected int _rowCount;

        public Label[] GetManufacturerLabels()
        {
            return _manufacturerLabels;
        }

        public VehicleViewer(Panel parentPanel, DataTable dataTable)
        {
            _container = parentPanel;
            _dataTable = dataTable;
            _rowCount = _dataTable.Rows.Count;
        }

        public virtual void Display()
        {
            InitializeArrays();
            AddContainers();
            AddImageLabels();
            AddVehicleNameLabels();
        }

        protected void InitializeArrays()
        {
            _recordPanels = new Panel[_rowCount];
            _imagePanels = new Panel[_rowCount];
            _manufacturerLabels = new Label[_rowCount];
        }

        public virtual void AddContainers()
        {
            try
            {
                int columnCount = _dataTable.Columns.Count;
                int panelWidth = _container.Width;
                int yAxisPoint = 10;

                for (int i = 0; i < _rowCount; i++)
                {
                    Panel recordPanel = new Panel()
                    {
                        Size = new Size(panelWidth - 40, 300),
                        Location = new Point(10, yAxisPoint),
                        BackColor = Program.LIGHTER_GRAY,
                        Name = $"Panel-{i}",
                        Cursor = Cursors.Hand
                    };

                    _container.Controls.Add(recordPanel);
                    _recordPanels[i] = recordPanel;
                    yAxisPoint += 310;
                }
            }
            catch(Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occurred when adding the containers");
            }
        }

        public virtual void AddImageLabels()
        {
            try
            {
                int columnCount = _dataTable.Columns.Count;
                int panelWidth = _container.Width;
                int index1 = 0;

                for (int i = 0; i < _rowCount; i++)
                {
                    Panel imagePanel = new Panel()
                    {
                        Size = new Size(panelWidth, 250),
                        Location = new Point(0, 0),
                        BackColor = Program.DARK_GRAY,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Name = $"imageLabel-{i}"
                    };

                    _recordPanels[index1].Controls.Add(imagePanel);
                    _imagePanels[i] = imagePanel;
                    index1++;
                }
            }
            catch (Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occurred when adding the containers");
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

                    Label manufacturerLabel = new Label()
                    {
                        Size = new Size(panelWidth - 40, 50),
                        Location = new Point(0, _imagePanels[i].Size.Height),
                        Font = new Font("Carlito", 10),
                        BackColor = Program.RED,
                        Name = $"imageLabel-{i}",
                        TextAlign = ContentAlignment.MiddleCenter,
                        Text = $"{record[3].ToString()} {record[4].ToString()}"
                    };

                    _recordPanels[index1].Controls.Add(manufacturerLabel);
                    _manufacturerLabels[i] = manufacturerLabel;
                    index1++;
                }
            }
            catch (Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occurred when adding the containers");
            }
        }
    }
}
