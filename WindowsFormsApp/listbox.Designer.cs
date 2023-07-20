namespace WindowsFormsApp
{
    partial class listbox
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
            this.listbb = new System.Windows.Forms.ListBox();
            this.textadd = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.allitem = new System.Windows.Forms.Label();
            this.opt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnremove = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.listb = new System.Windows.Forms.ListBox();
            this.btnab = new System.Windows.Forms.Button();
            this.btnba = new System.Windows.Forms.Button();
            this.btnaball = new System.Windows.Forms.Button();
            this.btnbaall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbb
            // 
            this.listbb.FormattingEnabled = true;
            this.listbb.Items.AddRange(new object[] {
            "c ",
            "c++",
            "html",
            "Css"});
            this.listbb.Location = new System.Drawing.Point(23, 31);
            this.listbb.Name = "listbb";
            this.listbb.Size = new System.Drawing.Size(103, 121);
            this.listbb.TabIndex = 0;
            this.listbb.SelectedIndexChanged += new System.EventHandler(this.listbb_SelectedIndexChanged);
            // 
            // textadd
            // 
            this.textadd.Location = new System.Drawing.Point(23, 180);
            this.textadd.Name = "textadd";
            this.textadd.Size = new System.Drawing.Size(103, 20);
            this.textadd.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(23, 206);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(46, 23);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your cources ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // allitem
            // 
            this.allitem.AutoSize = true;
            this.allitem.Location = new System.Drawing.Point(20, 266);
            this.allitem.Name = "allitem";
            this.allitem.Size = new System.Drawing.Size(0, 13);
            this.allitem.TabIndex = 5;
            // 
            // opt
            // 
            this.opt.AutoSize = true;
            this.opt.Location = new System.Drawing.Point(146, 31);
            this.opt.Name = "opt";
            this.opt.Size = new System.Drawing.Size(0, 13);
            this.opt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Add cource :";
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(132, 206);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(50, 23);
            this.btnremove.TabIndex = 8;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Black",
            "Green"});
            this.lista.Location = new System.Drawing.Point(284, 18);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(120, 134);
            this.lista.TabIndex = 9;
            // 
            // listb
            // 
            this.listb.FormattingEnabled = true;
            this.listb.Items.AddRange(new object[] {
            "Yellow",
            "Gray",
            "Pink",
            "Nevyblue"});
            this.listb.Location = new System.Drawing.Point(484, 18);
            this.listb.Name = "listb";
            this.listb.Size = new System.Drawing.Size(120, 134);
            this.listb.TabIndex = 10;
            // 
            // btnab
            // 
            this.btnab.Location = new System.Drawing.Point(422, 24);
            this.btnab.Name = "btnab";
            this.btnab.Size = new System.Drawing.Size(42, 26);
            this.btnab.TabIndex = 11;
            this.btnab.Text = ">";
            this.btnab.UseVisualStyleBackColor = true;
            this.btnab.Click += new System.EventHandler(this.btnab_Click);
            // 
            // btnba
            // 
            this.btnba.Location = new System.Drawing.Point(422, 56);
            this.btnba.Name = "btnba";
            this.btnba.Size = new System.Drawing.Size(42, 26);
            this.btnba.TabIndex = 12;
            this.btnba.Text = "<";
            this.btnba.UseVisualStyleBackColor = true;
            this.btnba.Click += new System.EventHandler(this.btnba_Click);
            // 
            // btnaball
            // 
            this.btnaball.Location = new System.Drawing.Point(422, 88);
            this.btnaball.Name = "btnaball";
            this.btnaball.Size = new System.Drawing.Size(42, 26);
            this.btnaball.TabIndex = 13;
            this.btnaball.Text = ">all";
            this.btnaball.UseVisualStyleBackColor = true;
            this.btnaball.Click += new System.EventHandler(this.btnaball_Click);
            // 
            // btnbaall
            // 
            this.btnbaall.Location = new System.Drawing.Point(422, 120);
            this.btnbaall.Name = "btnbaall";
            this.btnbaall.Size = new System.Drawing.Size(42, 26);
            this.btnbaall.TabIndex = 14;
            this.btnbaall.Text = "<all";
            this.btnbaall.UseVisualStyleBackColor = true;
            this.btnbaall.Click += new System.EventHandler(this.button2_Click);
            // 
            // listbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 374);
            this.Controls.Add(this.btnbaall);
            this.Controls.Add(this.btnaball);
            this.Controls.Add(this.btnba);
            this.Controls.Add(this.btnab);
            this.Controls.Add(this.listb);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.opt);
            this.Controls.Add(this.allitem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.textadd);
            this.Controls.Add(this.listbb);
            this.Name = "listbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbb;
        private System.Windows.Forms.TextBox textadd;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label allitem;
        private System.Windows.Forms.Label opt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.ListBox listb;
        private System.Windows.Forms.Button btnab;
        private System.Windows.Forms.Button btnba;
        private System.Windows.Forms.Button btnaball;
        private System.Windows.Forms.Button btnbaall;
    }
}