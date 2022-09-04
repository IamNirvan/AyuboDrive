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
    /// This class works with the app.config configuration file 
    /// to obtain the necessary configuration values
    /// </summary>
    static class ConfigurationHandler
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.AppSettings.Get("connectionString");
        }

        public static string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get("password");
        }

        public static string GetMailServer()
        {
            return ConfigurationManager.AppSettings.Get("mailServer");
        }

        public static int GetPort()
        {
            return int.Parse(ConfigurationManager.AppSettings.Get("port"));
        }

        public static string GetSenderEmail()
        {
            return ConfigurationManager.AppSettings.Get("senderEmail");
        }

        public static string GetReceiverEmail()
        {
            return ConfigurationManager.AppSettings.Get("receiverEmail");
        }
    }
}
