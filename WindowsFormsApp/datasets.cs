using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class datasets : Form
    {
        public datasets()
        {
            InitializeComponent();
        }

        DataSet ds=new DataSet();
        DataTable dt = new DataTable("DtDept");

        DataColumn d1= new DataColumn("DNo");
        DataColumn d2= new DataColumn("DName");
        DataColumn d3= new DataColumn("Loc");

        int si = -1;
        private void datasets_Load(object sender, EventArgs e)
        {
            dt.Columns.Add(d1);
            dt.Columns.Add(d2);
            dt.Columns.Add(d3);

            ds.Tables.Add(dt);

            dgvdept.DataSource = ds.Tables["DtDept"];
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["DNo"]=txtDno.Text;
            dr["DName"] = txtDname.Text;
            dr["Loc"]=txtLoc.Text;

            ds.Tables["DtDept"].Rows.Add(dr);

            reset();
        }
        void reset()
        {
            txtDno.Text ="";
            txtDname.Text = "";
            txtLoc.Text = "";
            txtDno.Focus();
            btnupdate.TabStop=false;
            btnsave.TabStop=true;
            btnsave.BringToFront();
            btndelete.Visible = false;
            si = -1;
        }
        private void dgvdept_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            si=e.RowIndex;
            txtDno.Text = dgvdept.Rows[si].Cells["DNo"].Value.ToString();
            txtDname.Text = dgvdept.Rows[si].Cells["DName"].Value.ToString();
            txtLoc.Text = dgvdept.Rows[si].Cells["Loc"].Value.ToString();
          
            btndelete.Visible = true;
            btnsave.TabStop = false;
            btnupdate.BringToFront();
            btnupdate.TabStop = true;

        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if(si>-1)
            {
                ds.Tables["DtDept"].Rows[si]["DNo"]=txtDno.Text;
                ds.Tables["DtDept"].Rows[si]["DName"]=txtDname.Text;
                ds.Tables["DtDept"].Rows[si]["Loc"]=txtLoc.Text;

                reset();
            }
            else
            {
                MessageBox.Show("Pleace select any column");
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if(si>-1)
            {
                ds.Tables["DtDept"].Rows[si].Delete();
                reset();
            }
        }

        private void btnrest_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
