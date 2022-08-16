﻿using System;
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

        public DashboardForm(User userAccount = null)
        {
            InitializeComponent();
            user = userAccount;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Modify the closed and ongoing booking lables
            //closedBookingsValueLbl = 0;
            //openBookingsValueLbl = 0;


            greetingLbl.Text = GetGreeting(); // Display an appropriate greeting.
            //fullNameLbl.Text = $"{user.FirstName} + {user.LastName}"; // Display the user's first name
            fullNameLbl.Text = "John Doe"; // Display the user's first name
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

        private void button4_Click(object sender, EventArgs e)
        {
            new DataViewForm("SELECT * FROM Customer").Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new DataViewForm("SELECT * FROM Vehicle").Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new DataViewForm("SELECT * FROM VehicleType").Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new DataViewForm("SELECT * FROM PackageType").Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DataViewForm("SELECT * FROM HireBookings WHERE hireType = Day").Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new DataViewForm("SELECT * FROM HireBookings WHERE hireType = Long").Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new DataViewForm("SELECT * FROM RentalBookings").Show();
            this.Hide();
        }
    }
}