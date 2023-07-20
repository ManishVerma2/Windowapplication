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
    public partial class combobox : Form
    {
        public combobox()
        {
            InitializeComponent();
        }

        private void btaadd_Click(object sender, EventArgs e)
        {
            if(!cbmbox.Items.Contains(txtadd.Text))
            {
                cbmbox.Items.Add(txtadd.Text);
                txtadd.Text = "";
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            allitem.Text = "";
            int x = cbmbox.Items.Count;
            for(int i = 0; i < x; i++)
            {
                allitem.Text += cbmbox.Items[i].ToString() + "\n";
            }
        }

        private void cbmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbmbox.SelectedIndex>-1)
            {
                select.Text = "";
                select.Text=cbmbox.SelectedItem.ToString();
            }
        }
    }
}
