using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    class DatabaseHandler
    {
        private const string connectionString = @"Data Source=DESKTOP-0CECDCR;Initial Catalog=AyuboDriveV1;Integrated Security=True";

        public void Insert(string query)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                }
            } catch(Exception e)
            {
                MessageBox.Show("An error occurred when inserting", $"{e}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Select(string query)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred when selecting", $"{e}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public void Delete(string query)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred when deleting", $"{e}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update(string query)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred when updating", $"{e}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
