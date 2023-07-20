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
    public partial class radiobutton : Form
    {
        public radiobutton()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if(male.Checked)
            {
                MessageBox.Show("Male");
            }
            else if(female.Checked)
            {
                MessageBox.Show("female");
            }
            if (first.Checked)
            {
                MessageBox.Show("1st year");
            }
            else if (second.Checked)
            {
                MessageBox.Show("2nd year");
            }
            else if (third.Checked)
            {
                MessageBox.Show("3rd year");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            permenent.Text = currentadd.Text;
        }

        private void no_CheckedChanged(object sender, EventArgs e)
        {
            permenent.Text = "";
        }

        private void radiobutton_Load(object sender, EventArgs e)
        {

        }
    }
}
