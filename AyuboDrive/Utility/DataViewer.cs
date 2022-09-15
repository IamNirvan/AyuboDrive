using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive.Utility
{
    public class DataViewer
    {
        private Panel _container;
        private DataTable _dataTable;
        private Panel[] _rows;
        private Label[][] _labels;
        private Font _font;
        private int _rowWidth;
        private int _rowHeight;
        private int _rowCount;
        private int _columnCount;
        private string _nullValuePlaceHolder;
        //
        // Constructors
        //
        public DataViewer(Panel container, DataTable dataTable, Font font, string nullValuePlaceHolder)
        {
            _container = container;
            _dataTable = dataTable;
            _font = font;
            _rowCount = _dataTable.Rows.Count + 1;
            _columnCount = _dataTable.Columns.Count;
            _nullValuePlaceHolder = nullValuePlaceHolder;
        }

        public DataViewer(Panel container, DataTable dataTable, string nullValuePlaceHolder)
        {
            _container = container;
            _dataTable = dataTable;
            _font = new Font("Carlito", 9);
            _rowCount = _dataTable.Rows.Count + 1;
            _columnCount = _dataTable.Columns.Count;
            _nullValuePlaceHolder = nullValuePlaceHolder;
        }

        public DataViewer(Panel container, DataTable dataTable)
        {
            _container = container;
            _dataTable = dataTable;
            _font = new Font("Carlito", 9);
            _rowCount = _dataTable.Rows.Count + 1;
            _columnCount = _dataTable.Columns.Count;
            _nullValuePlaceHolder = "Null";
        }
        //
        // Utility
        //
        public Panel[] GetRows()
        {
            return _rows;
        }

        public Label[][] GetLabels()
        {
            return _labels;
        }

        private void Initialize2DArray()
        {
            _labels = new Label[_rowCount + 1][];

            for (int i = 0; i < _rowCount + 1; i++)
            {
                _labels[i] = new Label[_columnCount];
            }
        }
        //
        // Table related
        //
        private void AddTableStruture()
        {
            try
            {
                // Rows.Count+1 to include the header row
                //_rowWidth = _container.Width - 40;
                _rowWidth = _container.Width - 20;
                _rowHeight = 40;
                int yAxisPoint = 10;

                _rows = new Panel[_rowCount];

                for (int i = 0; i < _rowCount; i++)
                {
                    Panel row = new Panel()
                    {
                        Name = $"Panel-{i}",
                        Size = new Size(_rowWidth, _rowHeight),
                        //Location = new Point(20, yAxisPoint),
                        Location = new Point(0, yAxisPoint),
                    };

                    // Only make the header row purple and set the default cursor.
                    if (i == 0)
                    {
                        row.BackColor = Properties.Settings.Default.PURPLE;
                        row.Cursor = Cursors.Default;
                    }
                    else
                    {
                        row.BackColor = Properties.Settings.Default.LIGHT_GRAY;
                        row.Cursor = Cursors.Hand;
                    }

                    _container.Controls.Add(row);
                    _rows[i] = row;
                    yAxisPoint += 42;
                }
            }
            catch (Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occurred when adding the table structure");
            }
        }

        private void PopulateTable()
        {
            try
            {
                Initialize2DArray();
                int labelWidth = _rowWidth / _columnCount;
                int currentRowIndex = 0;
                int xAxisPoint = 0;

                string cellValue;

                for (int i = 0; i < _columnCount; i++)
                {
                    Label label = new Label()
                    {
                        Name = $"Label-{currentRowIndex}",
                        Font = _font,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Size = new Size(labelWidth, _rowHeight),
                        Location = new Point(xAxisPoint, 0),
                    };

                    // Only affects the header
                    if (currentRowIndex == 0)
                    {
                        label.BackColor = Properties.Settings.Default.PURPLE;
                        label.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
                        label.Text = _dataTable.Columns[i].ColumnName;
                    }
                    else
                    {
                        label.ForeColor = Properties.Settings.Default.DISABLED_WHITE;
                        label.BackColor = Properties.Settings.Default.TRANSPARENT;
                        cellValue = _dataTable.Rows[currentRowIndex - 1][i].ToString();
                        label.Text = cellValue.Equals("") ? _nullValuePlaceHolder : cellValue;
                    }
                    
                    _rows[currentRowIndex].Controls.Add(label);
                    _labels[currentRowIndex][i] = label;
                    xAxisPoint += labelWidth;

                    if (i == _columnCount - 1)
                    {
                        // Set i to -1 because when the for loop condition is executed, 'i' will increment to 1. 
                        //Therefore, 1 cell will be missed
                        i = -1;
                        currentRowIndex++;
                        xAxisPoint = 0;
                    }

                    if (currentRowIndex == _rowCount)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occurred when populating the table");
            }
        }
        
        public void DisplayTable()
        {
            AddTableStruture();
            PopulateTable();
        }
    }
}
