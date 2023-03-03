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
    public partial class si : Form
    {
        public si()
        {
            InitializeComponent();
        }

        private void btnr_Click(object sender, EventArgs e)
        {
            resultbox.Text=Convert.ToString(Convert.ToInt32(txtp.Text)*Convert.ToInt32(txtr.Text)*Convert.ToInt32(txtt.Text)/100);
        }
    }
}
