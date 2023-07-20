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
    public partial class progressbar : Form
    {
        public progressbar()
        {
            InitializeComponent();
        }
        int x;

        private void progressbar_Load(object sender, EventArgs e)
        {
            for(x=0;x<=100;x++)
            {
                lbsourse.Items.Add($"Item {x}");
            }
        }

        private void Shift_data_Click(object sender, EventArgs e)
        {
            x = lbsourse.Items.Count;
            timer.Start();
            probar.Minimum = 0;
            probar.Maximum = x;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(lbsourse.Items.Count > 0)
            {
                lbtarget.Items.Add(lbsourse.Items[0]);
                lbsourse.Items.Remove(lbsourse.Items[0]);
                probar.Value++;
                int p = probar.Value * 100 / x;
                label1.Text = ($"{p}%");
                if(p==100)
                {
                    MessageBox.Show("Successful");
                }
                else
                {
                    MessageBox.Show("Unsuccessful");
                }
            }
            else
            {
                timer.Stop();
            }
        }
    }
}
