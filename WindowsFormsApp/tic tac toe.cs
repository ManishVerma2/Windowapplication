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
    public partial class tic_tac_toe : Form
    {
        public tic_tac_toe()
        {
            InitializeComponent();
        }
        string choice;
        private void submit_Click(object sender, EventArgs e)
        {
            if(x.Checked)
            {
                choice = x.Text;
            }
            else if(o.Checked)
            {
                choice= o.Text;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            x.Text = choice;
        }
    }
}
