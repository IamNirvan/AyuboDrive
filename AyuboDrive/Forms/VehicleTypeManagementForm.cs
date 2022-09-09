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
    public partial class VehicleTypeManagementForm : AyuboDriveTemplateForm
    {
        private static QueryHandler _queryHandler = new QueryHandler();
        private DataViewer _dataViewer;
        private string _vehicleTypeID;
        private bool _rowSelected = false;
        private Panel _selectedRow = null;

        public VehicleTypeManagementForm(Form dashboardForm) : base(dashboardForm)
        {
            InitializeComponent();
            HandleTitleBar();
        }
        //
        // Mouse event handlers
        //
        private void DeleteBtn_MouseEnter(object sender, EventArgs e)
        {
            DeleteBtn.BackColor = Properties.Settings.Default.RED;
            DeleteBtn.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void DeleteBtn_MouseLeave(object sender, EventArgs e)
        {
            DeleteBtn.BackColor = Properties.Settings.Default.TRANSPARENT;
            DeleteBtn.ForeColor = Properties.Settings.Default.RED;
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(((Label)sender).Name.Split('-')[1]);

            _rowSelected = true;
            Panel record = _dataViewer.GetRows()[index];
            AddData(index);

            if (_selectedRow != null)
            {
                _selectedRow.BackColor = Properties.Settings.Default.LIGHT_GRAY;
            }

            _selectedRow = record;
            record.BackColor = Program.LIGHTER_GRAY;
            ResetErrors();
        }

        private void Cell_MouseEnter(object sender, EventArgs e)
        {
            // Get the number associated with the label name. For example: panel-0
            int index = Int32.Parse(((Label)sender).Name.Split('-')[1]);

            if (index != 0)
            {
                if (!_rowSelected)
                {
                    Panel panel = _dataViewer.GetRows()[index]; // Access the label's record panel
                    panel.BackColor = Program.LIGHTER_GRAY;
                }

                Label[] subArray = _dataViewer.GetLabels()[index];

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

            if (index != 0)
            {
                if (!_rowSelected)
                {
                    Panel panel = _dataViewer.GetRows()[index]; // Access the parent panel
                    panel.BackColor = Program.LIGHT_GRAY;
                }

                Label[] subArray = _dataViewer.GetLabels()[index];

                for (int i = 0; i < subArray.Length; i++)
                {
                    subArray[i].ForeColor = Program.DISABLED_WHITE;
                }
            }
        }
        //
        // Utility
        //
        private void AddData(int index)
        {
            if (index != 0)
            {
                Label[] subArray = _dataViewer.GetLabels()[index];
                _vehicleTypeID = subArray[0].Text;
                TypeNameTxtBox.Text = subArray[1].Text;
            }
        }

        private void ResetErrors()
        {
            TypeNameErrorLbl.Text = "";
            TypeNamePnl.BackColor = Properties.Settings.Default.PURPLE;
        }

        private void DisplayTable()
        {
            string query = "SELECT * from vehicleType";
            TablePanel.Controls.Clear();
            _dataViewer = new DataViewer(TablePanel, _queryHandler.SelectQueryHandler(query));
            _dataViewer.DisplayTable();
            AddCellClickEvent(_dataViewer, Cell_Click, Cell_MouseEnter, Cell_MouseLeave);
        }

        private bool ValidateInput(string typeName)
        {
            bool validTypeName = false;

            if(typeName.Length > 0)
            {
                validTypeName = true;
                TypeNameErrorLbl.Text = "";
                TypeNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            }
            else
            {
                TypeNameErrorLbl.Text = "Invalid type name";
                TypeNamePnl.BackColor = Properties.Settings.Default.RED;
            }
            return validTypeName;
        }

        private void Reset()
        {
            TypeNameTxtBox.Text = "";

            _rowSelected = false;
            if (_selectedRow != null)
            {
                _selectedRow.BackColor = Properties.Settings.Default.LIGHT_GRAY;
                _selectedRow = null;
            }
            _vehicleTypeID = null;
        }
        //
        // Data manipulation event handlers
        //
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string typeName = TypeNameTxtBox.Text;

            if (ValidateInput(typeName))
            {

                VehicleType vehicleType = new VehicleType(typeName);
                if (vehicleType.Insert())
                {
                    MessagePrinter.PrintToMessageBox("Vehicle type details were successfully inserted", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTable();
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to insert vehicle type details", "Operation failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Reset();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string typeName = TypeNameTxtBox.Text;

            if (ValidateInput(typeName))
            {

                VehicleType vehicleType = new VehicleType(typeName);
                if (vehicleType.Update(_vehicleTypeID))
                {
                    MessagePrinter.PrintToMessageBox("Vehicle type details were successfully updated", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTable();
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to update vehicle type details", "Operation failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Reset();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ResetErrors();

            if (!_rowSelected)
            {
                MessagePrinter.PrintToMessageBox("Please select a vehicle type record", "Select a record", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessagePrinter.PrintToMessageBoxV2("Are you sure you want to delete the record? Once deleted, " +
                    "it cannot be recoverd.", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (VehicleType.Delete(_vehicleTypeID))
                    {
                        MessagePrinter.PrintToMessageBox("Vehicle type details were successfully deleted", "Operation successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    DisplayTable();
                    Reset();
                }
            }
        }
        //
        // Form load event handler
        //
        private void VehicleTypeManagementForm_Load(object sender, EventArgs e)
        {
            DisplayTable();   
        }
        //
        // textbox event handlers
        //
        private void TypeNameTxtBox_Enter(object sender, EventArgs e)
        {
            TypeNameTxtBox.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void TypeNameTxtBox_Leave(object sender, EventArgs e)
        {
            TypeNameTxtBox.ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }
    }
}
