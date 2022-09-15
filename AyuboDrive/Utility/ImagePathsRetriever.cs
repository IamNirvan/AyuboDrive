using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDrive.Utility
{
    public static class ImagePathsRetriever
    {
        private static readonly QueryHandler _queryHandler = new QueryHandler();

        private static string[] RetrievePaths(string query)
        {
            DataTable dataTable = _queryHandler.SelectQueryHandler(query);

            try
            {
                string[] result = new string[dataTable.Rows.Count];

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    result[i] = dataTable.Rows[i][0].ToString();
                }
                return result;
            }
            catch (Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occurred when fetching vehicle image paths");
            }
            return null;
        }

        public static string[] GetVehicleImagePaths(string query = "SELECT imagePath from vehicle")
        {
            return RetrievePaths(query);
        }

         public static string[] GetUserImagePaths(string query = "SELECT imagePath from userAccount")
        {
            return RetrievePaths(query);
        }

    }
}
