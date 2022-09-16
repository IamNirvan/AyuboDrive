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
    public partial class DashboardForm : AyuboDriveTemplateForm
    {
        public User User { get; set; }
        private readonly string _userName;
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly QueryHandler _queryHandler = new QueryHandler();

        public DashboardForm(string firstName, string lastName, string userName) : base(Properties.Settings.Default.LIGHT_GRAY)
        {
            _firstName = firstName;
            _lastName = lastName;
            _userName = userName;
            InitializeComponent();
            HandleTitleBar();
        }

        public DashboardForm(User user) : base(Properties.Settings.Default.LIGHT_GRAY)
        {
            User = user;
            _firstName = user.FirstName;
            _lastName = user.LastName;
            _userName = user.UserName;
            InitializeComponent();
            HandleTitleBar();
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
            else if (hour <= 17|| hour >= 12)
            {
                return "Good afternoon,";
            }
            return "Good morning,";
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).FlatAppearance.BorderColor = Properties.Settings.Default.PURPLE;
            ((Button)sender).BackColor = Properties.Settings.Default.PURPLE;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).FlatAppearance.BorderColor = Properties.Settings.Default.LIGHTER_GRAY;
            ((Button)sender).BackColor = Properties.Settings.Default.LIGHTER_GRAY;
        }

        private void LogOutBtn_MouseEnter(object sender, EventArgs e)
        {
            LogOutBtn.BackColor = Properties.Settings.Default.RED;
            LogOutBtn.BackgroundImage = Properties.Resources.LogOutWhite24;
        }

        private void LogOutBtn_MouseLeave(object sender, EventArgs e)
        {
            LogOutBtn.BackColor = Properties.Settings.Default.TRANSPARENT;
            LogOutBtn.BackgroundImage = Properties.Resources.LogoutRed24;
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            new CustomerManagementForm(this).Show();
            Hide();
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            new PaymentManagementForm(this).Show();
            Hide();
        }

        private void VehicleTypeBtn_Click(object sender, EventArgs e)
        {
            new VehicleTypeManagementForm(this).Show();
            Hide();
        }

        private void VehicleBtn_Click(object sender, EventArgs e)
        {
            new VehicleManagementForm(this).Show();
            Hide();
        }

        private void PackageTypeBtn_Click(object sender, EventArgs e)
        {
            new PackageTypeManagementForm(this).Show();
            Hide();
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            new AccountManagement(this, _userName).Show();
            Hide();
        }

        private void DriverBtn_Click(object sender, EventArgs e)
        {
            new DriverManagementForm(this).Show();
            Hide();
        }

        private void RentalBookingsBtn_Click(object sender, EventArgs e)
        {
            new RentalBookingManagementFormV2(this).Show();
            Hide();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            new LoginFormV2().Show();
            Hide();
        }

        private void BookingClosureBtn_Click(object sender, EventArgs e)
        {
            new BookingClosureForm(this).Show();
            Hide();
        }

        private void LongTourBookingsBtn_Click(object sender, EventArgs e)
        {
            new HireManagementForm(this).Show();
            Hide();
        }
    }
}
