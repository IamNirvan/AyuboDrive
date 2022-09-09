using AyuboDrive.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive.Forms
{
    public class AyuboDriveTemplateForm : Form
    {
        private readonly Form _dashboardForm;
        private readonly Color _taskBarBackColor;
        private readonly int _width;
        //
        // Constructors
        //
        public AyuboDriveTemplateForm(Form form, Color taskBarBackColor, int taskBarWidth)
        {
            _dashboardForm = form;
            _taskBarBackColor = taskBarBackColor;
            _width = taskBarWidth;
        }

        public AyuboDriveTemplateForm(Form form)
        {
            _dashboardForm = form;
            _taskBarBackColor = Properties.Settings.Default.DARK_GRAY;
            _width = 30;
        }

        public AyuboDriveTemplateForm(Color taskBarColor)
        {
            _dashboardForm = null;
            _taskBarBackColor = taskBarColor;
            _width = 30;
        }

        public AyuboDriveTemplateForm()
        {
            _dashboardForm = null;
            _taskBarBackColor = Properties.Settings.Default.DARK_GRAY;
            _width = 30;
        }
        //
        // Title bar
        //
        private void ExitBtn_MouseClick(object sender, EventArgs e)
        {
            if(_dashboardForm == null)
            {
                Application.Exit();
            }
            else
            {
                _dashboardForm.Show();
                Hide();
            }
        }

        private void MinimizeBtn_MouseClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// This method creates a title bar, places the exit and minimize buttons and sets the 
        /// MouseClick event handlers for the exit and minimize buttons. 
        /// It also handles the dragging functionality which allows the form to be dragged.
        /// </summary>
        protected void HandleTitleBar()
        {
            CustomTitleBar customTitleBar = new CustomTitleBar(this, _width, _taskBarBackColor);
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
        //
        // Cell click event handler
        //
        protected void AddCellClickEvent(DataViewer dataViewer, 
            Action<object, EventArgs> Cell_Click, 
            Action<object, EventArgs> Cell_MouseEnter, 
            Action<object, EventArgs> Cell_MouseLeave)
        {
            try
            {
                foreach (Label[] cells in dataViewer.GetLabels())
                {
                    foreach (Label cell in cells)
                    {
                        if (cell != null)
                        {
                            cell.Click += new EventHandler(Cell_Click);
                            cell.MouseEnter += new EventHandler(Cell_MouseEnter);
                            cell.MouseLeave += new EventHandler(Cell_MouseLeave);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occurred when adding the event handlers");
            }
        }

        protected void AddVehicleCellClickEvent(VehicleViewerV2 vehicleViewer,
            Action<object, EventArgs> Cell_Click,
            Action<object, EventArgs> Cell_MouseEnter,
            Action<object, EventArgs> Cell_MouseLeave)
        {
            try
            {
                foreach (Label cell in vehicleViewer.GetVehicleNames())
                {
                    if (cell != null)
                    {
                        cell.Click += new EventHandler(Cell_Click);
                        cell.MouseEnter += new EventHandler(Cell_MouseEnter);
                        cell.MouseLeave += new EventHandler(Cell_MouseLeave);
                    }
                }
            }
            catch (Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occurred when adding the event handlers");
            }
        }
    }
}
