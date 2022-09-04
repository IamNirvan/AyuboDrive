using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;

namespace AyuboDrive.Utility
{
    /// <summary>
    /// This class works with the .settings file to obtain the necessary configuration values
    /// </summary>
    static class ConfigurationHandler
    {
        public static string GetConnectionString()
        {
            return Properties.Settings.Default.CONNECTION_STRING;
        }

        public static string GetPassword()
        {
            return Properties.Settings.Default.PASSWORD;
        }

        public static string GetMailServer()
        {
            return Properties.Settings.Default.MAIL_SERVER;
        }

        public static int GetPort()
        {
            return Properties.Settings.Default.PORT;
        }

        public static string GetSenderEmail()
        {
            return Properties.Settings.Default.SENDER_EMAIL;
        }

        public static string GetReceiverEmail()
        {
            return Properties.Settings.Default.RECEIVER_EMAIL;
        }
    }
}
