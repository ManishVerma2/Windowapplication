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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        int num1;
        int num2;
        string r;
        string op;
        string mem;
        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btndigit_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            screen.Text += btn.Text;
        }

        private void op_click(object sender, EventArgs e)
        {
            Button x= (Button)sender;
            num1 =Convert.ToInt32( screen.Text);
            screen.Text = "";
            first.Text =Convert.ToString( num1);
            op = x.Text;
            first.Text += x.Text;
        }

        private void equl_click(object sender, EventArgs e)
        {
            num2 =Convert.ToInt32( screen.Text);
            if (op == "+")
            {
                r=Convert.ToString( num1+num2);
            }
            else if(op == "-")
            {
                r=Convert.ToString( num1-num2);
            }
            else if (op == "*")
            {
                r = Convert.ToString(num1 * num2);
            }
            else if (op == "/")
            {
                r = Convert.ToString(num1 / num2);
            }
            screen.Text = r;
        }

        private void C_click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            first.Text = "";
            screen.Text = "";
        }

        private void Ce_Click(object sender, EventArgs e)
        {
            num2 = 0;
            screen.Text = "";
        }

        private void bspace(object sender, EventArgs e)
        {
            string text = screen.Text;
            int r = text.Length;
            if(r>0)
            {
              text=text.Substring(0,r-1);
                screen.Text=text;
            }
            else
            {
                MessageBox.Show("Noting to delete");
            }
        }

        private void Ms_click(object sender, EventArgs e)
        {
            mem=screen.Text;
            screen.Text ="";
        }

        private void Mr_click(object sender, EventArgs e)
        {
            screen.Text = mem;
        }

        private void Mc_click(object sender, EventArgs e)
        {
            mem = "";
            screen.Text = "";
        }

        private void Mplus_Click(object sender, EventArgs e)
        {
            mem =Convert.ToString(Convert.ToInt32(mem)+ Convert.ToInt32( screen.Text));
            screen.Text = "";
        }

        private void Mmin_Click(object sender, EventArgs e)
        {
            mem = Convert.ToString(Convert.ToInt32(mem) - Convert.ToInt32(screen.Text));
            screen.Text = "";
        }

        private void btn_Per(object sender, EventArgs e)
        {
            num2 =Convert.ToInt32( screen.Text);
            r =Convert.ToString( num1 * num2 / 100);
            screen.Text = r;
        }

        private void btndot_click(object sender, EventArgs e)
        {
            r = screen.Text;
            if (r.IndexOf(".") == -1)
            {
                screen.Text += ".";
            }
        }
    }
}
