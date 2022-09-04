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
        private readonly User user;
        private readonly QueryHandler queryHandler = new QueryHandler();

        public DashboardForm(User userAccount = null)
        {
            InitializeComponent();
            user = userAccount;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            closedBookingsValueLbl.Text = getBookingsCount("SELECT COUNT FROM HireBookings WHERE bookingStatus = closed").ToString();

            int openBookings = getBookingsCount("SELECT COUNT FROM HireBookings WHERE bookingStatus = open");

            openBookingsValueLbl.ForeColor = Program.RED;

            if (openBookings >= 1)
            {
                openBookingsValueLbl.ForeColor = Program.GREEN;
            }
            openBookingsValueLbl.Text = openBookings.ToString();

            greetingLbl.Text = GetGreeting(); // Display an appropriate greeting.
            //fullNameLbl.Text = $"{user.FirstName} {user.LastName}"; // Display the user's first name
        }

        private int getBookingsCount(string query)
        {
            DataTable dataTable = queryHandler.SelectQueryHandler(query);

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

            if(hour == 18 || hour == 19)
            {
                return "Hello,";
            } else if(hour == 18 || hour == 19)
            {
                return "Good evening,";
            } else if (hour == 12 || hour <= 17)
            {
                return "Good afternoon,";
            }
            return "Good morning";
        }

        private void customerManagementBtn_Click(object sender, EventArgs e)
        {
            new DataViewForm(this, Program.CUSTOMER_MANAGEMENT, FormType.CUSTOMER_MANAGEMENT, Program.CUSTOMER_MANAGEMENT_POSITIONS, "SELECT * FROM Customer").Show();
            this.Hide();
        }

        private void vehicleManagementBtn_Click(object sender, EventArgs e)
        {
            new DataViewForm(this, Program.VEHICLE_MANAGEMENT, FormType.VEHICLE_MANAGEMENT, Program.VEHICLE_MANAGEMENT_POSITIONS, "SELECT * FROM Vehicle").Show();
            this.Hide();
        }

        private void vehicleTypeManagementBtn_Click(object sender, EventArgs e)
        {
            new DataViewForm(this, Program.VEHICLE_TYPE_MANAGEMENT, FormType.VEHICLE_TYPE_MANAGEMENT, Program.VEHICLE_TYPE_MANAGEMENT_POSITIONS, "SELECT * FROM VehicleType").Show();
            this.Hide();
        }

        private void packageTypeManagementBtn_Click(object sender, EventArgs e)
        {
            new DataViewForm(this, Program.PACKAGE_TYPE_MANAGEMENT, FormType.PACKAGE_TYPE_MANAGEMENT, Program.PACKAGE_TYPE_MANAGEMENT_POSITIONS, "SELECT * FROM PackageType").Show();
            this.Hide();
            
        }

        private void longTourBookingsBtn_Click(object sender, EventArgs e)
        {
            new DataViewForm(this, Program.LONG_TOUR_HIRE_BOOKINGS_MANAGEMENT, FormType.LONG_TOUR_HIRE_BOOKINGS_MANAGEMENT, Program.LONG_TOUR_HIRE_BOOKINGS_MANAGEMENT_POSITIONS, "SELECT * FROM HireBookings WHERE hireType = Long").Show();
            this.Hide();
        }

        private void dayTourBookingsBtn_Click(object sender, EventArgs e)
        {
            new DataViewForm(this, Program.DAY_TOUR_HIRE_BOOKINGS_MANAGEMENT, FormType.DAY_TOUR_HIRE_BOOKINGS_MANAGEMENT, Program.DAY_TOUR_HIRE_BOOKINGS_MANAGEMENT_POSITIONS, "SELECT * FROM HireBookings WHERE hireType = Day").Show();
            this.Hide();
        }

        private void rentalBookingsBtn_Click(object sender, EventArgs e)
        {
            new DataViewForm(this, Program.RENTAL_BOOKINGS_MANAGEMENT, FormType.RENTAL_BOOKINGS_MANAGEMENT, Program.RENTAL_BOOKINGS_MANAGEMENT_POSITIONS, "SELECT * FROM RentalBookings").Show();
            this.Hide();
        }

        private void logoutBtn_MouseEnter(object sender, EventArgs e)
        {
            logoutBtn.BackColor = Program.RED;
            logoutBtn.ForeColor = Program.ENABLED_WHITE;

        }

        private void logoutBtn_MouseLeave(object sender, EventArgs e)
        {
            logoutBtn.BackColor = Program.TRANSPARENT;
            logoutBtn.ForeColor = Program.RED;
        }

        private void closedBookingsValueLbl_Click(object sender, EventArgs e)
        {

        }

        private void closedBookingTextLbl_Click(object sender, EventArgs e)
        {

        }

        private void ongoingBookingsTextLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
