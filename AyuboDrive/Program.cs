using AyuboDrive.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());


            //string query = "DELETE FROM Customer WHERE customerID = @customerID";
            //string[] parameters = {"@customerID"};
            //Object[] values = {8};
            //new QueryHandler().QueryHandler(query, parameters, values);

            //new EmailSender("shalinkulawardana@gmail.com", "shalinkulawardana7424@gmail.com", "AyuboDrive", "wuxrfgttqosyplba").SendEmail("Your OTP", "The OPT is: 6352383");

            //Console.WriteLine($"The OTP is: {KeyGenerator.GenerateKey()}");


            //QueryHandler queryHandler = new QueryHandler();
            //DataTable dt = queryHandler.SelectQueryHandler("SELECT * FROM Customer");

            //Console.WriteLine($"The record is: {dt.Rows[1][1].ToString()}");
        }
    }
}
