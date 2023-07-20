using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class webbrowser : Form
    {
        public webbrowser()
        {
            InitializeComponent();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            weburl.Url=new Uri(txturl.Text);
        }
    }
}
