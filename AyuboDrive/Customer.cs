using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDrive
{

    class Customer
    {
        public int CustomerID { get; }
        private String FirstName { get; }
        private String LastName { get; }
        private string ContactNumber { get; }
        //private databasehandler databasehandler;

        public Customer(int customerID, string firstName, string lastName, string contactNumber)
        {
            this.CustomerID = customerID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ContactNumber = contactNumber;
        }

        public static void registerCustomer(string firstName, string lastName, string contactNumber)
        {
            //Add the customer details into the database
        }

        public void updateCustomer() {}

        public void deleteCustomer() {}

    }
}
