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
    public partial class dailog : Form
    {
        public dailog()
        {
            InitializeComponent();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png";
            openFileDialog1.ShowDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if(result!=DialogResult.Cancel)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "jpg files(*.jpg)|*jpg|png files(*.png)|*.png";
            saveFileDialog1.ShowDialog();
            DialogResult result=saveFileDialog1.ShowDialog();
            if(result!=DialogResult.Cancel)
            {
                pictureBox1.Image=Image.FromFile(saveFileDialog1.FileName);
            }

        }

        private void btnfont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font= fontDialog1.Font;
        }

        private void btnfolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.BackColor=colorDialog1.Color;
        }
    }
}
