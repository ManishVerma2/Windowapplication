using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace WindowsFormsApp
{
    public partial class treeview : Form
    {
        public treeview()
        {
            InitializeComponent();
        }
        TreeNode mypcnode;
        private void treeview_Load(object sender, EventArgs e)
        {
            loaddrives();
        }
        void loaddrives()
        {
            mypcnode = new TreeNode("My Pc");
            mypcnode.ImageIndex = 0;
            mypcnode.SelectedImageIndex = 0;
            treev.Nodes.Add(mypcnode);

            foreach(var drive in Directory.GetLogicalDrives())
            {
                TreeNode tnode=new TreeNode(drive);
                tnode.ImageIndex = 1;  
                tnode.SelectedImageIndex = 1;
                tnode.Tag = drive;
                mypcnode.Nodes.Add(tnode);

                ListViewItem item=new ListViewItem(drive);
                item.Tag = drive;
                item.ImageIndex = 0;
                item.SubItems.Add("");
                item.SubItems.Add("Drive");

                listv.Items.Add(item); 
            }

        }

        void loadfolder(TreeNode tnode,string path)
        {
            listv.Items.Clear();

            foreach (var dri in Directory.GetDirectories(path))
            {
                DirectoryInfo d = new DirectoryInfo(dri);
                if (tnode != null)
                {
                    TreeNode tnodefolder = new TreeNode(d.Name);

                    tnodefolder.ImageIndex = 3;
                    tnodefolder.SelectedImageIndex = 2;
                    tnodefolder.Tag = d.FullName;

                    tnode.Nodes.Add(tnodefolder);
                }

               ListViewItem item= new ListViewItem(d.Name);
                item.Tag = d.FullName;
                item.ImageIndex = 2;
                item.SubItems.Add(d.LastAccessTime.ToString());
                item.SubItems.Add("File Folder");

                listv.Items.Add(item);
            }
        }
        void fileload(string path)
        {

            foreach (var file in Directory.GetFiles(path))
            {
                FileInfo f=new FileInfo(file);

                ListViewItem item = new ListViewItem(f.Name);
                item.Tag = f.FullName;
                item.ImageIndex = 4;
                item.SubItems.Add(f.LastAccessTime.ToString());
                item.SubItems.Add(f.Extension);
                item.SubItems.Add(f.Length.ToString());

                listv.Items.Add(item);
            }
        }

        private void treev_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path=e.Node.Tag as string;
            if(!string.IsNullOrEmpty(path) )
            {
                loadfolder(e.Node,path);
                fileload(path);

            }
        }

        private void largeicon_Click(object sender, EventArgs e)
        {
            listv.View = View.LargeIcon;
        }

        private void smallicon_Click(object sender, EventArgs e)
        {
            listv.View = View.SmallIcon;
        }

        private void listview_Click(object sender, EventArgs e)
        {
            listv.View = View.List;
        }

        private void Detailsview_Click(object sender, EventArgs e)
        {
            listv.View= View.Details;
        }

        private void listv_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lvitem = listv.SelectedItems[0];
            string path =lvitem.Tag as string;
            string type = lvitem.SubItems[2].Text;

            if((!string.IsNullOrEmpty(path)) && (type=="Drive" || type=="File Folder"))
            {
                loadfolder(null,path);
                fileload(path);
            }
            else
            {
                Process.Start(path);
            }
        }
    }
}
