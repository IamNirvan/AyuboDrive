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
            SetInfoLbls();
            greetingLbl.Text = GetGreeting();
            fullNameLbl.Text = $"{_firstName} {_lastName}";
        }

        public void SetInfoLbls()
        {
            SetClosedHireBookingsCount();
            SetOngoingHireBookingsCount();
            SetOngoingRentalBookingsCount();
            SetPendingPaymentsCount();
        }

        private void SetClosedHireBookingsCount()
        {
            int count = GetBookingsCount("SELECT COUNT(*) FROM hireBooking WHERE hireStatus = 'closed'");

            if (count >= 0)
            {
                ClosedBookingsCount.Text = count.ToString();

                if (count > 0)
                {
                    ClosedBookingsCount.ForeColor = Properties.Settings.Default.GREEN;
                }
                else
                {
                    ClosedBookingsCount.ForeColor = Properties.Settings.Default.RED;
                }
                return;
            }
            ClosedBookingsCount.Text = "N/A";
        }

        private void SetOngoingHireBookingsCount()
        {
            int count = GetBookingsCount("SELECT COUNT(*) FROM hireBooking WHERE hireStatus = 'open'");

            if (count >= 0)
            {
                OngoingBookingsCount.Text = count.ToString();

                if (count > 0)
                {
                    OngoingBookingsCount.ForeColor = Properties.Settings.Default.GREEN;
                }
                else
                {
                    OngoingBookingsCount.ForeColor = Properties.Settings.Default.RED;
                }
                return;
            }
            OngoingBookingsCount.Text = "N/A";
        }

        private void SetOngoingRentalBookingsCount()
        {
            int count = GetBookingsCount("SELECT COUNT(*) FROM rentalBooking WHERE rentalStatus = 'open'");

            if (count >= 0)
            {
                OngoingRentalsCount.Text = count.ToString();

                if (count > 0)
                {
                    OngoingRentalsCount.ForeColor = Properties.Settings.Default.GREEN;
                }
                else
                {
                    OngoingRentalsCount.ForeColor = Properties.Settings.Default.RED;
                }
                return;
            }
            OngoingBookingsCount.Text = "N/A";
        }

        private void SetPendingPaymentsCount()
        {
            int count1 = GetBookingsCount("SELECT COUNT(*) FROM hireBooking WHERE paymentStatus = 'pending'");
            int count2 = GetBookingsCount("SELECT COUNT(*) FROM rentalBooking WHERE paymentStatus = 'pending'");

            if (count1 >= 0 & count2 >= 0)
            {
                int total = (count1 + count2);
                PendingPaymentCount.Text = total.ToString();

                if(total > 0)
                {
                    PendingPaymentCount.ForeColor = Properties.Settings.Default.RED;
                }
                else
                {
                    PendingPaymentCount.ForeColor = Properties.Settings.Default.PURPLE;
                }
                return;
            }
            OngoingBookingsCount.Text = "N/A";
        }

        private int GetBookingsCount(string query)
        {
            DataTable dataTable = QueryHandler.SelectQueryHandler(query);

            if(dataTable != null)
            {
                return int.Parse(dataTable.Rows[0][0].ToString());
            }
            return -1;
        }
        
        private string GetGreeting()
        {
            int hour = DateTime.Now.Hour;

            Console.WriteLine($"The hour is: {hour}");

            if(hour > 19)
            {
                return "Hello,";
            }
            else if(hour == 19 || hour == 18)
            {
                return "Good evening,";
            }
            else if (hour <= 17 && hour >= 12)
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
