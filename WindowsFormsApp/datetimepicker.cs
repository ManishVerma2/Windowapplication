using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class datetimepicker : Form
    {
        public datetimepicker()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtpicker.Value. ToString("T"));
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.google.com/");
        }
    }
}
