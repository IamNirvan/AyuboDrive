﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    class QueryHandler
    {
        private readonly string ConnectionString;

        public QueryHandler(string connectionString = @"Data Source=DESKTOP-0CECDCR;Initial Catalog=AyuboDriveV1;Integrated Security=True")
        {
            ConnectionString = connectionString;
        }

        public bool HandleInsertDeleteUpdateQuery(string query, string[] parameters, object[] values)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    if(parameters.Length != values.Length)
                    {
                        throw new Exception("Parameter array and values array length mismatch");
                    }

                    for (int i = 0; i < parameters.Length; i++)
                    {
                        sqlCommand.Parameters.AddWithValue(parameters[i], values[i]);
                    }
                    sqlCommand.ExecuteNonQuery();
                }
                return true;
            } catch (Exception)
            {
                return false;
            }
        }

        public DataTable SelectQueryHandler(string query)
        {
            DataTable result = null;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                    sqlDataAdapter.Fill(result);
                    return result;
                }
            }
            catch (Exception)
            {
                return result;
            }
        }
    }
}
