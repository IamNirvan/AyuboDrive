using AyuboDrive.Utility;
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
    /// <summary>
    /// This class has functions that handle the select, insert, delete and update operations.
    /// </summary>
    public class QueryHandler
    {
        private readonly string _connectionString = Properties.Settings.Default.CONNECTION_STRING;
        
        private bool ProcessQuery(string queryTemplate, string[] parameters, object[] values)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(queryTemplate, sqlConnection);

                    if (parameters.Length == values.Length)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            sqlCommand.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                        sqlCommand.ExecuteNonQuery();
                        return true;
                    }
                    throw new ArgumentException("Parameter array and values array length mismatch");
                }
            }
            catch (Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occurred when processing the query");
                return false;
            }
        }

        public bool InsertQueryHandler(string query, string[] parameters, object[] values)
        {
            return ProcessQuery(query, parameters, values);
        }

        public bool DeleteQueryHandler(string query, string[] parameters, object[] values)
        {
            return ProcessQuery(query, parameters, values);
        }

        public bool UpdateQueryHandler(string query, string[] parameters, object[] values)
        {
            return ProcessQuery(query, parameters, values);
        }

        public DataTable SelectQueryHandler(string query)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                    DataTable result = new DataTable();
                    sqlDataAdapter.Fill(result);
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occurred when handling the select query");
                return null;
            }
        }

        [Obsolete("This method is no longer supported. Try using InsertQueryHandler, DeleteQueryHandler or UpdateQueryHandler instead.")]
        public bool HandleInsertDeleteUpdateQuery(string query, string[] parameters, object[] values)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    if(parameters.Length == values.Length)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            sqlCommand.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                        sqlCommand.ExecuteNonQuery();
                        return true;
                    }
                    throw new ArgumentException("Parameter array and values array length mismatch");
                }
            }
            catch (Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occurred");
                return false;
            }
        }
    }
}
