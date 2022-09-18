using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDrive.Utility
{
    class PostMan
    {
        public bool DeliverKey(string firstName, string lastName, string emailAddress, string key)
        {
            SimpleEmailSender simpleEmailSender = new SimpleEmailSender(emailAddress);
            return simpleEmailSender.SendEmail(
                "Ayubo Drive secret key",
                $"Hello {firstName} {lastName},\n\n" +
                "You received this mail because a request was made to create an account for AyuobDrive.\n\n" +
                "Please use this secret key to finish creating the account.\n" +
                $"Secret key: {key}"
            );
        }
    }
}
