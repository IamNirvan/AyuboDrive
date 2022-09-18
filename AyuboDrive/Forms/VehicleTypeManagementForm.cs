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
        private static QueryHandler s_queryHandler = new QueryHandler();
        private DataViewer _dataViewer;
        private string _vehicleTypeID;
        private string _initialTypeName;
        private bool _rowSelected = false;
        private Panel _selectedRow = null;

        public VehicleTypeManagementForm(DashboardForm dashboardForm) : base(dashboardForm)
        {
            InitializeComponent();
            HandleTitleBar();
            DisplayTable();
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
            record.BackColor = Properties.Settings.Default.LIGHTER_GRAY;
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
                    panel.BackColor = Properties.Settings.Default.LIGHTER_GRAY;
                }

                Label[] subArray = _dataViewer.GetLabels()[index];

                for (int i = 0; i < subArray.Length; i++)
                {
                    subArray[i].ForeColor = Properties.Settings.Default.ENABLED_WHITE;
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
                    panel.BackColor = Properties.Settings.Default.LIGHT_GRAY;
                }

                Label[] subArray = _dataViewer.GetLabels()[index];

                for (int i = 0; i < subArray.Length; i++)
                {
                    subArray[i].ForeColor = Properties.Settings.Default.DISABLED_WHITE;
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
                DataRow record = s_queryHandler.SelectQueryHandler("SELECT * FROM vehicleType").Rows[index - 1];
                _vehicleTypeID = record[0].ToString();
                TypeNameTxtBox.Text = record[1].ToString();
                _initialTypeName = record[1].ToString();
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
            _dataViewer = new DataViewer(TablePanel, s_queryHandler.SelectQueryHandler(query));
            _dataViewer.DisplayTable();
            AddCellClickEvent(_dataViewer, Cell_Click, Cell_MouseEnter, Cell_MouseLeave);
        }

        private bool ValidateInput(string typeName)
        {
            if(ValidationHandler.ValidateVehicleTypeName(typeName))
            {
                TypeNameErrorLbl.Text = "";
                TypeNamePnl.BackColor = Properties.Settings.Default.PURPLE;
                return true;
            }
            else
            {
                TypeNameErrorLbl.Text = "Invalid type name";
                TypeNamePnl.BackColor = Properties.Settings.Default.RED;
                return false;
            }
        }

        private bool ValidateInputV2(string typeName)
        {
            if (_initialTypeName.Equals(typeName))
            {
                TypeNamePnl.BackColor = Properties.Settings.Default.PURPLE;
                TypeNameErrorLbl.Text = "";
                return true;
            }
            else
            {
                if (!ValidationHandler.ValidateVehicleTypeName(typeName))
                {
                    TypeNamePnl.BackColor = Properties.Settings.Default.RED;
                    TypeNameErrorLbl.Text = "Invalid type name";
                    return false;
                }
                return true;
            }
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
        // Mouse click event handlers
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
            ResetErrors();

            if (!_rowSelected)
            {
                MessagePrinter.PrintToMessageBox("Please select a vehicle type record", "Select a record",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string typeName = TypeNameTxtBox.Text;

            if (ValidateInputV2(typeName))
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
                return;
            }
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
        //
        // Form load event handler
        //
        private void VehicleTypeManagementForm_Load(object sender, EventArgs e)
        {
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
        // 
        // Text box key press event handler
        //
        private void CharacterOnlyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // Discard the character by setting handled to true
                e.Handled = true;
            }
        }
    }
}
