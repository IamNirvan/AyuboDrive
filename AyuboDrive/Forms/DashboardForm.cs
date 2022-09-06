using AyuboDrive.Enums;
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
    public partial class DashboardForm : Form
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly QueryHandler _queryHandler = new QueryHandler();

        public DashboardForm(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            InitializeComponent();
            HandleTitleBar();
        }

        // -- TITLE BAR BUTTON FUNCTIONALITY --

        private void ExitBtn_MouseClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_MouseClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // -- END OF TITLE BAR BUTTON FUNCTIONALITY --

        private void HandleTitleBar()
        {
            CustomTitleBar customTitleBar = new CustomTitleBar(this, 30, Properties.Settings.Default.LIGHT_GRAY);
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

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            closedBookingsValueLbl.Text = GetBookingsCount("SELECT COUNT(*) FROM hireBooking WHERE hireStatus = 'Closed'").ToString();

            int openBookings = GetBookingsCount("SELECT COUNT(*) FROM hireBooking WHERE hireStatus = 'Open'");

            openBookingsValueLbl.ForeColor = Properties.Settings.Default.RED;

            if (openBookings >= 1 && openBookings <= 10)
            {
                openBookingsValueLbl.ForeColor = Properties.Settings.Default.PURPLE;
            }
            else if(openBookings > 10)
            {
                openBookingsValueLbl.ForeColor = Properties.Settings.Default.GREEN;
            }

            openBookingsValueLbl.Text = openBookings.ToString();
            greetingLbl.Text = GetGreeting();
            fullNameLbl.Text = $"{_firstName} {_lastName}";
        }

        private int GetBookingsCount(string query)
        {
            DataTable dataTable = _queryHandler.SelectQueryHandler(query);

            if(dataTable != null)
            {
                foreach (DataRow record in dataTable.Rows)
                {
                    return (int)record[0];
                }
            }
            return 0;
        }
        
        private string GetGreeting()
        {
            int hour = DateTime.Now.Hour;

            if(hour > 19)
            {
                return "Hello,";
            }
            else if(hour == 18 || hour == 19)
            {
                return "Good evening,";
            }
            else if (hour == 12 || hour <= 17)
            {
                return "Good afternoon,";
            }
            return "Good morning,";
        }

        private void RentalBookingLbl_Click(object sender, EventArgs e)
        {
            new RentalBooking().Show();
            Hide();
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

        }

        private void LogoutLbl_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, LogoutLbl.DisplayRectangle, 
                Properties.Settings.Default.RED, ButtonBorderStyle.Solid);
        }

        private void RentalBookingLbl_MouseEnter(object sender, EventArgs e)
        {
            RentalBookingLbl.BackColor = Properties.Settings.Default.LIGHTER_GRAY;
        }

        private void RentalBookingLbl_MouseLeave(object sender, EventArgs e)
        {
            RentalBookingLbl.BackColor = Properties.Settings.Default.LIGHT_GRAY;
        }

        private void PackageTypeLbl_Click(object sender, EventArgs e)
        {

        }

        private void PackageTypeLbl_MouseEnter(object sender, EventArgs e)
        {
            PackageTypeLbl.BackColor = Properties.Settings.Default.LIGHTER_GRAY;
        }

        private void PackageTypeLbl_MouseLeave(object sender, EventArgs e)
        {
            PackageTypeLbl.BackColor = Properties.Settings.Default.LIGHT_GRAY;
        }

        private void LongTourBookingsLbl_Click(object sender, EventArgs e)
        {

        }

        private void LongTourBookingsLbl_MouseLeave(object sender, EventArgs e)
        {
            LongTourBookingsLbl.BackColor = Properties.Settings.Default.LIGHT_GRAY;
        }

        private void LongTourBookingsLbl_MouseEnter(object sender, EventArgs e)
        {
            LongTourBookingsLbl.BackColor = Properties.Settings.Default.LIGHTER_GRAY;
            
        }

        private void DayTourBookingsLbl_Click(object sender, EventArgs e)
        {

        }

        private void DayTourBookingsLbl_MouseEnter(object sender, EventArgs e)
        {
            DayTourBookingsLbl.BackColor = Properties.Settings.Default.LIGHTER_GRAY;
        }

        private void DayTourBookingsLbl_MouseLeave(object sender, EventArgs e)
        {
            DayTourBookingsLbl.BackColor = Properties.Settings.Default.LIGHT_GRAY;
        }

        private void VehicleManagementLbk_Click(object sender, EventArgs e)
        {

        }

        private void VehicleManagementLbk_MouseEnter(object sender, EventArgs e)
        {
            VehicleManagementLbk.BackColor = Properties.Settings.Default.LIGHTER_GRAY;
        }

        private void VehicleManagementLbk_MouseLeave(object sender, EventArgs e)
        {
            VehicleManagementLbk.BackColor = Properties.Settings.Default.LIGHT_GRAY;
        }

        private void VehicleTypeManagement_Click(object sender, EventArgs e)
        {

        }

        private void VehicleTypeManagement_MouseEnter(object sender, EventArgs e)
        {
            VehicleTypeManagement.BackColor = Properties.Settings.Default.LIGHTER_GRAY;
        }

        private void VehicleTypeManagement_MouseLeave(object sender, EventArgs e)
        {
            VehicleTypeManagement.BackColor = Properties.Settings.Default.LIGHT_GRAY;
        }

        private void CustomerManagement_Click(object sender, EventArgs e)
        {

        }

        private void CustomerManagement_MouseEnter(object sender, EventArgs e)
        {
            CustomerManagement.BackColor = Properties.Settings.Default.LIGHTER_GRAY;
        }

        private void CustomerManagement_MouseLeave(object sender, EventArgs e)
        {
            CustomerManagement.BackColor = Properties.Settings.Default.LIGHT_GRAY;
        }

        private void AccountLbl_Click(object sender, EventArgs e)
        {

        }

        private void AccountLbl_MouseEnter(object sender, EventArgs e)
        {
            AccountLbl.BackColor = Properties.Settings.Default.LIGHTER_GRAY;
        }

        private void AccountLbl_MouseLeave(object sender, EventArgs e)
        {
            AccountLbl.BackColor = Properties.Settings.Default.LIGHT_GRAY;
        }

        private void LogoutLbl_Click(object sender, EventArgs e)
        {

        }

        private void LogoutLbl_MouseEnter(object sender, EventArgs e)
        {
            LogoutLbl.BackColor = Properties.Settings.Default.RED;
            LogoutLbl.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void LogoutLbl_MouseLeave(object sender, EventArgs e)
        {
            LogoutLbl.BackColor = Properties.Settings.Default.TRANSPARENT;
            LogoutLbl.ForeColor = Properties.Settings.Default.RED;
        }
    }
}
