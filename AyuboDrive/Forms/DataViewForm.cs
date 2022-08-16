using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    public partial class DataViewForm : Form
    {
        private readonly string Query;

        public DataViewForm(string query = null)
        {
            InitializeComponent();
            Query = query;
        }

        private void DataViewForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new QueryHandler().SelectQueryHandler(Query);
          
            // data grid view modification
            dataGridView.RowHeadersVisible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            // Bound a data table to the data grid view
            dataGridView.DataSource = dataTable;            
        }
    }
}
