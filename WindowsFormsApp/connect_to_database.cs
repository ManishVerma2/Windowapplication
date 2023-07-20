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
using System.Configuration;

namespace WindowsFormsApp
{
    public partial class connect_to_database : Form
    {
        public connect_to_database()
        {
            InitializeComponent();
        }
        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["conn"]);
        SqlCommand comm = new SqlCommand();
        SqlDataAdapter da= new SqlDataAdapter();
        DataSet ds= new DataSet();

        private void connect_to_database_Load(object sender, EventArgs e)
        {
            conn.Open();
            if(conn.State==ConnectionState.Open)
            {
                MessageBox.Show("connect susscesfully");
            }
            else
            {
                MessageBox.Show("connection fail");
            }
            conn.Close();

            loaddata();
        }

        void loaddata()
        {
            ds.Tables.Clear();

            comm.CommandText = "select * from production.products ";
            comm.Connection= conn;
            da.SelectCommand = comm;
            da.Fill(ds, "a");
            dataGridView1.DataSource= ds.Tables["a"];
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //unconnection method
            SqlCommandBuilder cb= new SqlCommandBuilder(da);
            da.Update(ds, "a");
            MessageBox.Show("update data saved");
            loaddata();
        }
    }
}
