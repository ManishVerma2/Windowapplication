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
    public partial class checkbox : Form
    {
        public checkbox()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
           
        }

        private void check_Click(object sender, EventArgs e)
        {
            if (palying.Checked && studing.Checked)
            {
                MessageBox.Show("Exlignt");
            }
            else if (studing.Checked)
            {
                MessageBox.Show("V good");
            }
            else if (palying.Checked)
            {
                MessageBox.Show("good");
            }
        }

        private void conform_CheckedChanged(object sender, EventArgs e)
        {
            perment.Text=address.Text;
        }
    }
}
