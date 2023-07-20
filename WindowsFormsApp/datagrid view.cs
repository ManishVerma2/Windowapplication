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
    public partial class datadrid_view : Form
    {
        public datadrid_view()
        {
            InitializeComponent();
        }
        DataTable dt=new DataTable();
        DataRow dr;
        private void datadrid_view_Load(object sender, EventArgs e)
        {
            dt.Columns.Add(new DataColumn("Srno",typeof(int)));
            dt.Columns.Add(new DataColumn("Name",typeof(string)));
            dt.Columns.Add(new DataColumn("Fater name",typeof(string)));
            dt.Columns.Add(new DataColumn("Contact no.",typeof(string)));

            dataGridView1.DataSource = dt;

            dr=dt.NewRow();

            dr[0] = 1;
            dr[1] = "Manish";
            dr[2] = "Rameshwar dass";
            dr[3] = "9992094217";
            dt.Rows.Add(dr);

            dr = dt.NewRow();

            dr[0] = 2;
            dr[1] = "Parveen";
            dr[2] = "Bansilal";
            dr[3] = "9817587034";
            dt.Rows.Add(dr);

            dt.Rows.Add(3,"Sandeep","Subhash","9817535845");
            dt.Rows.Add(4, "Rajesh", "Lalchand", "9467025846");

            DataGridViewButtonColumn dgbbtn= new DataGridViewButtonColumn();
            dgbbtn.FlatStyle = FlatStyle.Flat;
            dgbbtn.HeaderText = "View Record";
            dgbbtn.Name = "btnview";
            dgbbtn.UseColumnTextForButtonValue = true;
            dgbbtn.Text = "view";

            dataGridView1.Columns.Add(dgbbtn);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>-1)
            {
                int i = e.RowIndex;
                string lbl = dataGridView1.Columns[e.ColumnIndex].HeaderText.ToString();
                if(lbl.ToLower()== "view record")
                {
                    int srno = Convert.ToInt32(dataGridView1.Rows[i].Cells["Srno"].Value.ToString());
                    string SName = (dataGridView1.Rows[i].Cells["Name"].Value.ToString());
                    string FName = (dataGridView1.Rows[i].Cells["Fater name"].Value.ToString());
                    string CNo = (dataGridView1.Rows[i].Cells["Contact no."].Value.ToString());
                    MessageBox.Show(srno.ToString() + "    " + SName + "    " + FName + "    " + CNo);
                }
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex > -1)
            //{
            //    int i = e.RowIndex;
            //    int srno = Convert.ToInt32(dataGridView1.Rows[i].Cells["Srno"].Value.ToString());
            //    string SName = (dataGridView1.Rows[i].Cells["Name"].Value.ToString());
            //    string FName = (dataGridView1.Rows[i].Cells["Fater name"].Value.ToString());
            //    string CNo = (dataGridView1.Rows[i].Cells["Contact no."].Value.ToString());
            //    MessageBox.Show(srno.ToString() + "    " + SName + "    " + FName + "    " + CNo);
            //}
        }
    }
}
