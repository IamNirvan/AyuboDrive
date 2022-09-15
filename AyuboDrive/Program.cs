using AyuboDrive.Engines;
using AyuboDrive.Forms;
using AyuboDrive.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    static class Program
    { 
        public readonly static Color DARK_GRAY = Color.FromArgb(29, 35, 49); // #1D2331
        public readonly static Color LIGHT_GRAY = Color.FromArgb(40, 48, 66);
        public readonly static Color LIGHTER_GRAY = Color.FromArgb(47, 58, 77);
        public readonly static Color GREEN = Color.FromArgb(70, 199, 151);
        public readonly static Color RED = Color.FromArgb(240, 69, 69); // #F04545
        public readonly static Color PURPLE = Color.FromArgb(103, 96, 250);
        public readonly static Color LIGHT_PURPLE = Color.FromArgb(138, 132, 251);
        public readonly static Color ENABLED_WHITE = Color.FromArgb(252, 254, 255); // #fcfeff
        public readonly static Color DISABLED_WHITE = Color.FromArgb(130, 142, 163);
        public readonly static Color TRANSPARENT = Color.FromArgb(0, 0, 0, 0);
        public readonly static Color PARTIALLY_TRANSPARENT = Color.FromArgb(30, 0, 0, 0);

        public readonly static string RENTAL_BOOKINGS_MANAGEMENT = "Rental Bookings Management";
        public readonly static string HIRE_BOOKINGS_MANAGEMENT = "Hire Bookings Management";
        public readonly static string LONG_TOUR_HIRE_BOOKINGS_MANAGEMENT = "Long Tour Bookings Management";
        public readonly static string DAY_TOUR_HIRE_BOOKINGS_MANAGEMENT = "Day Tour Bookings Management";
        public readonly static string PACKAGE_TYPE_MANAGEMENT = "Package Management";
        public readonly static string VEHICLE_TYPE_MANAGEMENT = "Vehicle Type Management";
        public readonly static string VEHICLE_MANAGEMENT = "Vehicle Management";
        public readonly static string CUSTOMER_MANAGEMENT = "Customer Management";

        public readonly static int[] RENTAL_BOOKINGS_MANAGEMENT_POSITIONS = { 0, 0, 0, 0, 0, 0 };
        public readonly static int[] HIRE_BOOKINGS_MANAGEMENT_POSITIONS = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public readonly static int[] LONG_TOUR_HIRE_BOOKINGS_MANAGEMENT_POSITIONS = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public readonly static int[] DAY_TOUR_HIRE_BOOKINGS_MANAGEMENT_POSITIONS = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public readonly static int[] PACKAGE_TYPE_MANAGEMENT_POSITIONS = { 0, 0, 0, 0, 0, 0, 0 };
        public readonly static int[] VEHICLE_TYPE_MANAGEMENT_POSITIONS = { 0, 0, 0, 0, 0 };
        public readonly static int[] VEHICLE_MANAGEMENT_POSITIONS = { 0, 0, 0, 0 };
        public readonly static int[] CUSTOMER_MANAGEMENT_POSITIONS = { 0, 0, 0, 0 , 0};

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginFormV2());

            //DateTime start = DateTime.Parse("2022-01-01"); // The vehicle was gone since this day
            //DateTime end = DateTime.Parse("2022-01-01"); // The vehicle was returned on this day

            //int[] result = DayWeekMonthCalculator.GetDaysWeeksMonths((end - start).Days+1);
            //Console.WriteLine($"Days: {result[0]}");
            //Console.WriteLine($"Weeks: {result[1]}");
            //Console.WriteLine($"Months: {result[2]}");


            //decimal rentValue = RentCalculator.GetRentValue("1", start, end, "1");
            //Console.WriteLine($"The rent value is: {rentValue}");


            //DateTime start = DateTime.Parse("12/09/2022 4:00:00 AM");
            //DateTime end = DateTime.Parse("16/09/2022 11:00:00 AM");

            //Console.WriteLine($"The hire value is: {DayTourHireCalculator.GetHireValue("1", "1", "1", start, end, 200).ToString()}");
            //Console.WriteLine($"The hire value is: {LongTourHireCalculator.GetHireValue("1", "1", "1", start, end, 13, 200)}");



        }
    }
}
