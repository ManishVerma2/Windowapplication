namespace WindowsFormsApp
{
    partial class treeview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(treeview));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treev = new System.Windows.Forms.TreeView();
            this.largeimage = new System.Windows.Forms.ImageList(this.components);
            this.listv = new System.Windows.Forms.ListView();
            this.smallimage = new System.Windows.Forms.ImageList(this.components);
            this.cmstrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.largeicon = new System.Windows.Forms.ToolStripMenuItem();
            this.smallicon = new System.Windows.Forms.ToolStripMenuItem();
            this.listview = new System.Windows.Forms.ToolStripMenuItem();
            this.Detailsview = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cmstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treev);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listv);
            this.splitContainer1.Size = new System.Drawing.Size(1128, 511);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.TabIndex = 0;
            // 
            // treev
            // 
            this.treev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treev.ImageIndex = 0;
            this.treev.ImageList = this.largeimage;
            this.treev.Location = new System.Drawing.Point(0, 0);
            this.treev.Name = "treev";
            this.treev.SelectedImageIndex = 0;
            this.treev.Size = new System.Drawing.Size(375, 511);
            this.treev.TabIndex = 0;
            this.treev.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treev_AfterSelect);
            // 
            // largeimage
            // 
            this.largeimage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeimage.ImageStream")));
            this.largeimage.TransparentColor = System.Drawing.Color.Transparent;
            this.largeimage.Images.SetKeyName(0, "pc.png");
            this.largeimage.Images.SetKeyName(1, "disk.png");
            this.largeimage.Images.SetKeyName(2, "open_folder.png");
            this.largeimage.Images.SetKeyName(3, "close_folder.png");
            this.largeimage.Images.SetKeyName(4, "fileimage.png");
            // 
            // listv
            // 
            this.listv.ContextMenuStrip = this.cmstrip;
            this.listv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listv.HideSelection = false;
            this.listv.LargeImageList = this.largeimage;
            this.listv.Location = new System.Drawing.Point(0, 0);
            this.listv.Name = "listv";
            this.listv.Size = new System.Drawing.Size(749, 511);
            this.listv.SmallImageList = this.smallimage;
            this.listv.TabIndex = 0;
            this.listv.UseCompatibleStateImageBehavior = false;
            this.listv.DoubleClick += new System.EventHandler(this.listv_DoubleClick);
            // 
            // smallimage
            // 
            this.smallimage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallimage.ImageStream")));
            this.smallimage.TransparentColor = System.Drawing.Color.Transparent;
            this.smallimage.Images.SetKeyName(0, "pc.png");
            this.smallimage.Images.SetKeyName(1, "disk.png");
            this.smallimage.Images.SetKeyName(2, "open_folder.png");
            this.smallimage.Images.SetKeyName(3, "close_folder.png");
            this.smallimage.Images.SetKeyName(4, "fileimage.png");
            // 
            // cmstrip
            // 
            this.cmstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeicon,
            this.smallicon,
            this.listview,
            this.Detailsview});
            this.cmstrip.Name = "cmstrip";
            this.cmstrip.Size = new System.Drawing.Size(110, 92);
            // 
            // largeicon
            // 
            this.largeicon.Name = "largeicon";
            this.largeicon.Size = new System.Drawing.Size(109, 22);
            this.largeicon.Text = "Large";
            this.largeicon.Click += new System.EventHandler(this.largeicon_Click);
            // 
            // smallicon
            // 
            this.smallicon.Name = "smallicon";
            this.smallicon.Size = new System.Drawing.Size(109, 22);
            this.smallicon.Text = "Small";
            this.smallicon.Click += new System.EventHandler(this.smallicon_Click);
            // 
            // listview
            // 
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(109, 22);
            this.listview.Text = "List";
            this.listview.Click += new System.EventHandler(this.listview_Click);
            // 
            // Detailsview
            // 
            this.Detailsview.Name = "Detailsview";
            this.Detailsview.Size = new System.Drawing.Size(109, 22);
            this.Detailsview.Text = "Details";
            this.Detailsview.Click += new System.EventHandler(this.Detailsview_Click);
            // 
            // treeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 511);
            this.Controls.Add(this.splitContainer1);
            this.Name = "treeview";
            this.Text = "treeview";
            this.Load += new System.EventHandler(this.treeview_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.cmstrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treev;
        private System.Windows.Forms.ImageList largeimage;
        private System.Windows.Forms.ListView listv;
        private System.Windows.Forms.ImageList smallimage;
        private System.Windows.Forms.ContextMenuStrip cmstrip;
        private System.Windows.Forms.ToolStripMenuItem largeicon;
        private System.Windows.Forms.ToolStripMenuItem smallicon;
        private System.Windows.Forms.ToolStripMenuItem listview;
        private System.Windows.Forms.ToolStripMenuItem Detailsview;
    }
}