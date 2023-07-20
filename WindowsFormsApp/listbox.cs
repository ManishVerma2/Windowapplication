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
    public partial class listbox : Form
    {
        public listbox()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(!listbb.Items.Contains(textadd.Text))
            {
                listbb.Items.Add(textadd.Text);
                textadd.Text="";
            }
            else
            {
                MessageBox.Show("Item allready exist");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            allitem.Text = "";
            int x = listbb.Items.Count;
            for( int i=0;i< x;i++ )
            {
                allitem.Text += listbb.Items[i].ToString() + "\n";
            }
        }

        private void listbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listbb.SelectedIndex >-1)
            {
                opt.Text=listbb.SelectedItem.ToString();
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if(listbb.SelectedIndex>-1)
            {
                listbb.Items.RemoveAt(listbb.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select the Item");
            }
        }

        private void btnab_Click(object sender, EventArgs e)
        {
            if(lista.SelectedIndex>-1)
            {
                listb.Items.Add(lista.SelectedItem.ToString());
            }
        }

        private void btnba_Click(object sender, EventArgs e)
        {
            if(listb.SelectedIndex>-1)
            {
                lista.Items.Add(listb.SelectedItem.ToString());
            }
        }

        private void btnaball_Click(object sender, EventArgs e)
        {
            int x=lista.Items.Count;
            for(int i=0; i<x;i++)
            {
                listb.Items.Add(lista.Items[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = lista.Items.Count;
            for (int i = 0; i < x; i++)
            {
                lista.Items.Add(listb.Items[i]);
            }
        }
    }
}
