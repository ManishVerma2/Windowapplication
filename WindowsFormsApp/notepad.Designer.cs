namespace WindowsFormsApp
{
    partial class notepad
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
            this.rtbox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menufile = new System.Windows.Forms.ToolStripMenuItem();
            this.filenew = new System.Windows.Forms.ToolStripMenuItem();
            this.fileopen = new System.Windows.Forms.ToolStripMenuItem();
            this.filesave = new System.Windows.Forms.ToolStripMenuItem();
            this.filesaveas = new System.Windows.Forms.ToolStripMenuItem();
            this.fileprint = new System.Windows.Forms.ToolStripMenuItem();
            this.fileexit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuedit = new System.Windows.Forms.ToolStripMenuItem();
            this.editundo = new System.Windows.Forms.ToolStripMenuItem();
            this.editcut = new System.Windows.Forms.ToolStripMenuItem();
            this.editcopy = new System.Windows.Forms.ToolStripMenuItem();
            this.editpaste = new System.Windows.Forms.ToolStripMenuItem();
            this.editdelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuformat = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuview = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuhelp = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutNotepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbnewfile = new System.Windows.Forms.ToolStripButton();
            this.tsbopen = new System.Windows.Forms.ToolStripButton();
            this.tsbsave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbundo = new System.Windows.Forms.ToolStripSplitButton();
            this.tsbredo = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbbold = new System.Windows.Forms.ToolStripSplitButton();
            this.tsbitalic = new System.Windows.Forms.ToolStripSplitButton();
            this.tsbunderline = new System.Windows.Forms.ToolStripSplitButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.filepagesatup = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbox
            // 
            this.rtbox.Location = new System.Drawing.Point(0, 48);
            this.rtbox.Name = "rtbox";
            this.rtbox.Size = new System.Drawing.Size(1096, 354);
            this.rtbox.TabIndex = 0;
            this.rtbox.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menufile,
            this.menuedit,
            this.menuformat,
            this.menuview,
            this.menuhelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1096, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menufile
            // 
            this.menufile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filenew,
            this.fileopen,
            this.filesave,
            this.filesaveas,
            this.filepagesatup,
            this.fileprint,
            this.fileexit});
            this.menufile.Name = "menufile";
            this.menufile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menufile.Size = new System.Drawing.Size(37, 20);
            this.menufile.Tag = "0";
            this.menufile.Text = "&File";
            this.menufile.Click += new System.EventHandler(this.menufile_click);
            // 
            // filenew
            // 
            this.filenew.Name = "filenew";
            this.filenew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.filenew.Size = new System.Drawing.Size(186, 22);
            this.filenew.Tag = "1";
            this.filenew.Text = "&New";
            this.filenew.Click += new System.EventHandler(this.menufile_click);
            // 
            // fileopen
            // 
            this.fileopen.Name = "fileopen";
            this.fileopen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileopen.Size = new System.Drawing.Size(186, 22);
            this.fileopen.Tag = "2";
            this.fileopen.Text = "&Open";
            this.fileopen.Click += new System.EventHandler(this.menufile_click);
            // 
            // filesave
            // 
            this.filesave.Name = "filesave";
            this.filesave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.filesave.Size = new System.Drawing.Size(186, 22);
            this.filesave.Tag = "3";
            this.filesave.Text = "&Save";
            this.filesave.Click += new System.EventHandler(this.menufile_click);
            // 
            // filesaveas
            // 
            this.filesaveas.Name = "filesaveas";
            this.filesaveas.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.filesaveas.Size = new System.Drawing.Size(186, 22);
            this.filesaveas.Tag = "4";
            this.filesaveas.Text = "&Save As";
            this.filesaveas.Click += new System.EventHandler(this.menufile_click);
            // 
            // fileprint
            // 
            this.fileprint.Name = "fileprint";
            this.fileprint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.fileprint.Size = new System.Drawing.Size(186, 22);
            this.fileprint.Tag = "6";
            this.fileprint.Text = "&Print";
            this.fileprint.Click += new System.EventHandler(this.menufile_click);
            // 
            // fileexit
            // 
            this.fileexit.Name = "fileexit";
            this.fileexit.Size = new System.Drawing.Size(186, 22);
            this.fileexit.Tag = "7";
            this.fileexit.Text = "Exit";
            this.fileexit.Click += new System.EventHandler(this.menufile_click);
            // 
            // menuedit
            // 
            this.menuedit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editundo,
            this.redoToolStripMenuItem,
            this.editcut,
            this.editcopy,
            this.editpaste,
            this.selectAllToolStripMenuItem,
            this.editdelete});
            this.menuedit.Name = "menuedit";
            this.menuedit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuedit.Size = new System.Drawing.Size(39, 20);
            this.menuedit.Tag = "-1";
            this.menuedit.Text = "&Edit";
            this.menuedit.Click += new System.EventHandler(this.menufile_click);
            // 
            // editundo
            // 
            this.editundo.Name = "editundo";
            this.editundo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.editundo.Size = new System.Drawing.Size(180, 22);
            this.editundo.Tag = "8";
            this.editundo.Text = "&Undo";
            this.editundo.Click += new System.EventHandler(this.menufile_click);
            // 
            // editcut
            // 
            this.editcut.Name = "editcut";
            this.editcut.Size = new System.Drawing.Size(180, 22);
            this.editcut.Tag = "10";
            this.editcut.Text = "Cut";
            this.editcut.Click += new System.EventHandler(this.menufile_click);
            // 
            // editcopy
            // 
            this.editcopy.Name = "editcopy";
            this.editcopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.editcopy.Size = new System.Drawing.Size(180, 22);
            this.editcopy.Tag = "11";
            this.editcopy.Text = "&Copy";
            this.editcopy.Click += new System.EventHandler(this.menufile_click);
            // 
            // editpaste
            // 
            this.editpaste.Name = "editpaste";
            this.editpaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.editpaste.Size = new System.Drawing.Size(180, 22);
            this.editpaste.Tag = "12";
            this.editpaste.Text = "&Paste";
            this.editpaste.Click += new System.EventHandler(this.menufile_click);
            // 
            // editdelete
            // 
            this.editdelete.Name = "editdelete";
            this.editdelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.editdelete.Size = new System.Drawing.Size(180, 22);
            this.editdelete.Tag = "14";
            this.editdelete.Text = "&Delete";
            this.editdelete.Click += new System.EventHandler(this.menufile_click);
            // 
            // menuformat
            // 
            this.menuformat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.menuformat.Name = "menuformat";
            this.menuformat.Size = new System.Drawing.Size(57, 20);
            this.menuformat.Tag = "-2";
            this.menuformat.Text = "&Format";
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.wordToolStripMenuItem.Tag = "12";
            this.wordToolStripMenuItem.Text = "Word Wrap";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.fontToolStripMenuItem.Tag = "13";
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // menuview
            // 
            this.menuview.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.menuview.Name = "menuview";
            this.menuview.Size = new System.Drawing.Size(44, 20);
            this.menuview.Tag = "-3";
            this.menuview.Text = "&View";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.zoomToolStripMenuItem.Tag = "14";
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.statusBarToolStripMenuItem.Tag = "15";
            this.statusBarToolStripMenuItem.Text = "Status bar";
            // 
            // menuhelp
            // 
            this.menuhelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.sendFeedbackToolStripMenuItem,
            this.aboutNotepadToolStripMenuItem});
            this.menuhelp.Name = "menuhelp";
            this.menuhelp.Size = new System.Drawing.Size(44, 20);
            this.menuhelp.Tag = "-4";
            this.menuhelp.Text = "&Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.viewHelpToolStripMenuItem.Tag = "16";
            this.viewHelpToolStripMenuItem.Text = "View help";
            // 
            // sendFeedbackToolStripMenuItem
            // 
            this.sendFeedbackToolStripMenuItem.Name = "sendFeedbackToolStripMenuItem";
            this.sendFeedbackToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.sendFeedbackToolStripMenuItem.Tag = "17";
            this.sendFeedbackToolStripMenuItem.Text = "Send Feedback";
            // 
            // aboutNotepadToolStripMenuItem
            // 
            this.aboutNotepadToolStripMenuItem.Name = "aboutNotepadToolStripMenuItem";
            this.aboutNotepadToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutNotepadToolStripMenuItem.Tag = "18";
            this.aboutNotepadToolStripMenuItem.Text = "About Notepad";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 409);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1096, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbnewfile,
            this.tsbopen,
            this.tsbsave,
            this.toolStripSeparator1,
            this.tsbundo,
            this.tsbredo,
            this.toolStripSeparator2,
            this.tsbbold,
            this.tsbitalic,
            this.tsbunderline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1096, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbnewfile
            // 
            this.tsbnewfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbnewfile.Image = global::WindowsFormsApp.Properties.Resources.fileimage;
            this.tsbnewfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbnewfile.Name = "tsbnewfile";
            this.tsbnewfile.Size = new System.Drawing.Size(23, 22);
            this.tsbnewfile.Text = "toolStripButton1";
            // 
            // tsbopen
            // 
            this.tsbopen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbopen.Image = global::WindowsFormsApp.Properties.Resources.open_folder;
            this.tsbopen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbopen.Name = "tsbopen";
            this.tsbopen.Size = new System.Drawing.Size(23, 22);
            this.tsbopen.Text = "toolStripButton1";
            // 
            // tsbsave
            // 
            this.tsbsave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbsave.Image = global::WindowsFormsApp.Properties.Resources.save;
            this.tsbsave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbsave.Name = "tsbsave";
            this.tsbsave.Size = new System.Drawing.Size(23, 22);
            this.tsbsave.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbundo
            // 
            this.tsbundo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbundo.Image = global::WindowsFormsApp.Properties.Resources.undo1;
            this.tsbundo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbundo.Name = "tsbundo";
            this.tsbundo.Size = new System.Drawing.Size(32, 22);
            this.tsbundo.Text = "toolStripSplitButton1";
            // 
            // tsbredo
            // 
            this.tsbredo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbredo.Image = global::WindowsFormsApp.Properties.Resources.redo1;
            this.tsbredo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbredo.Name = "tsbredo";
            this.tsbredo.Size = new System.Drawing.Size(32, 22);
            this.tsbredo.Text = "toolStripSplitButton1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbbold
            // 
            this.tsbbold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbbold.Image = global::WindowsFormsApp.Properties.Resources.bold;
            this.tsbbold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbold.Name = "tsbbold";
            this.tsbbold.Size = new System.Drawing.Size(32, 22);
            this.tsbbold.Text = "toolStripSplitButton1";
            // 
            // tsbitalic
            // 
            this.tsbitalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbitalic.Image = global::WindowsFormsApp.Properties.Resources.italic;
            this.tsbitalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbitalic.Name = "tsbitalic";
            this.tsbitalic.Size = new System.Drawing.Size(32, 22);
            this.tsbitalic.Text = "toolStripSplitButton1";
            // 
            // tsbunderline
            // 
            this.tsbunderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbunderline.Image = global::WindowsFormsApp.Properties.Resources.underline;
            this.tsbunderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbunderline.Name = "tsbunderline";
            this.tsbunderline.Size = new System.Drawing.Size(32, 22);
            this.tsbunderline.Text = "toolStripSplitButton1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // filepagesatup
            // 
            this.filepagesatup.Name = "filepagesatup";
            this.filepagesatup.Size = new System.Drawing.Size(186, 22);
            this.filepagesatup.Tag = "5";
            this.filepagesatup.Text = "Page setup";
            this.filepagesatup.Click += new System.EventHandler(this.menufile_click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redoToolStripMenuItem.Tag = "9";
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.menufile_click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectAllToolStripMenuItem.Tag = "13";
            this.selectAllToolStripMenuItem.Text = "Select all";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.menufile_click);
            // 
            // notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 431);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rtbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "notepad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menufile;
        private System.Windows.Forms.ToolStripMenuItem filenew;
        private System.Windows.Forms.ToolStripMenuItem fileopen;
        private System.Windows.Forms.ToolStripMenuItem filesave;
        private System.Windows.Forms.ToolStripMenuItem filesaveas;
        private System.Windows.Forms.ToolStripMenuItem fileprint;
        private System.Windows.Forms.ToolStripMenuItem fileexit;
        private System.Windows.Forms.ToolStripMenuItem menuedit;
        private System.Windows.Forms.ToolStripMenuItem editundo;
        private System.Windows.Forms.ToolStripMenuItem editcut;
        private System.Windows.Forms.ToolStripMenuItem editcopy;
        private System.Windows.Forms.ToolStripMenuItem editpaste;
        private System.Windows.Forms.ToolStripMenuItem editdelete;
        private System.Windows.Forms.ToolStripMenuItem menuformat;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuview;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuhelp;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutNotepadToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbnewfile;
        private System.Windows.Forms.ToolStripButton tsbopen;
        private System.Windows.Forms.ToolStripButton tsbsave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton tsbundo;
        private System.Windows.Forms.ToolStripSplitButton tsbredo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton tsbbold;
        private System.Windows.Forms.ToolStripSplitButton tsbitalic;
        private System.Windows.Forms.ToolStripSplitButton tsbunderline;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem filepagesatup;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
    }
}