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
    public partial class monthcalender : Form
    {
        public monthcalender()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            ShowInTaskbar=true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void monthcalender_Resize(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Minimized)
            {
                ShowIcon=true;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(2000);
            }
        }

        private void monthcalender_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible=false;
            notifyIcon1.BalloonTipTitle = "hello";
            notifyIcon1.BalloonTipText = "user";
        }

     

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //for(int i = 0; i < 100; i++)
            //{
            //    progressBar1.Value = i;
            //}

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);
                if(progressBar1.Value==100)
            {
                timer1.Stop();
                MessageBox.Show("secessfull");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text= richTextBox1.Text ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
