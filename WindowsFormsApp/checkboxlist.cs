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
    public partial class checkboxlist : Form
    {
        public checkboxlist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            foreach(string x in checkedList.CheckedItems)
            {
                label1.Text += x.ToString() +"\n";
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(!checkedList.Items.Contains(txtadd.Text))
            {
                checkedList.Items.Add(txtadd.Text);
                txtadd.Text="";
            }
            else
            {
                MessageBox.Show("item allredy exigest");
            }
        }

        private void checkedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!label3.Text.Contains(checkedList.SelectedItem.ToString()))
            {
                label3.Text += checkedList.SelectedItem.ToString() + "\n"; //selectedindex se index show kra skte h
            }
            else
            {
                MessageBox.Show("you allredy addit is item");
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            //checkedList.Items.RemoveAt(0);          // remove the items to index number 
            if(checkedList.Items.Contains(txtadd.Text))
            {
                checkedList.Items.Remove(txtadd.Text);
            }
            else
            {
                MessageBox.Show("item not found");
            }
        }

        private void checkboxlist_Load(object sender, EventArgs e)
        {

        }
    }
}
