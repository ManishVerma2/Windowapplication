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
    public partial class CRUD_with_connection : Form
    {
        public CRUD_with_connection()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand comm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds=new DataSet();

        int si;
        private void CRUD_with_connection_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            ds.Tables.Clear();

            comm.CommandText = "select * from production.brands";
            comm.Connection= conn;
            da.SelectCommand = comm;
            da.Fill(ds, "a");
            dgvbrands.DataSource = ds.Tables["a"];
        }

        private void dgvbrands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            si = e.RowIndex;
            txtB_id.Text = dgvbrands.Rows[si].Cells["brand_id"].Value.ToString();
            txtB_name.Text = dgvbrands.Rows[si].Cells["brand_name"].Value.ToString();

            btnupdate.BringToFront();
            btnupdate.TabStop = true;
            btndelete.TabStop = true;
            btnsave.TabStop = false;
            btndelete.Visible = true;
            btndelete.TabStop = true;
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtB_name.Text!="")
            {
                comm.CommandText = "insert into production.brands values(@bname)";
                comm.Connection = conn;
                comm.Parameters.AddWithValue("@bname", txtB_name.Text);
                comm.CommandType = CommandType.Text;
                conn.Open();
                comm.ExecuteNonQuery();
                conn.Close();
                comm.Parameters.Clear();
                loaddata();
                reset();
            }
            else
            {
                MessageBox.Show("Pleace fill the require fild");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            comm.CommandText = "update production.brands set brand_name=@bname where brand_id=@id";
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@id", txtB_id.Text);
            comm.Parameters.AddWithValue("@bname", txtB_name.Text);
            comm.CommandType = CommandType.Text;
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            comm.Parameters.Clear();
            loaddata();
            reset();
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            comm.CommandText = "delete from production.brands where brand_id=@id";
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@id", txtB_id.Text);
            comm.CommandType = CommandType.Text;
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            comm.Parameters.Clear();
            loaddata();
            reset();
        }
        void reset()
        {
            txtB_id.Text = "";
            txtB_name.Text = "";

            btnsave.BringToFront();
            btnupdate.TabStop = false;
            btnsave.TabStop = true;
            btndelete.Visible = false;
            btndelete.TabStop = false;
            si = -1;
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            reset();
        }

        
    }
}
