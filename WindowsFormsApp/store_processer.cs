using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp
{
    public partial class store_processer : Form
    {
        public store_processer()
        {
            InitializeComponent();
        }
        SqlConnection conn=new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand comm = new SqlCommand();
        SqlDataAdapter da= new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void store_processer_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata(int bid=0)
        {
            ds.Tables.Clear();
            comm.CommandText = "sp_brand";
            //if(bid != 0)// when you don't define in your store processer  
            //{
                comm.Parameters.AddWithValue("@bid", bid);
            //}
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(ds, "a");
            dgvbrnd.DataSource = ds.Tables["a"];

            comm.Parameters.Clear();
        }

        private void txtb_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            int ascii = Convert.ToInt32(e.KeyChar);
            if(ascii >=48 && ascii<=57 || ascii==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; 
            }
        }

        private void txtb_id_TextChanged(object sender, EventArgs e)
        {
            if(txtb_id.Text.Length > 0)
            {
                loaddata(Convert.ToInt32(txtb_id.Text));
            }
            else
            {
                loaddata();
            }
        }

        void loaddata(string bname)
        {
            ds.Tables.Clear();
            comm.CommandText = "sp_brand_byname";
            comm.Parameters.AddWithValue("@bname", bname);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(ds, "a");
            dgvbrnd.DataSource = ds.Tables["a"];

            comm.Parameters.Clear();
        }

        private void txtB_name_TextChanged(object sender, EventArgs e)
        {
            if(txtB_name.Text.Length > 0)
            {
                loaddata(txtB_name.Text);
            }
            else
            {
                loaddata();
            }
        }
    }
}
