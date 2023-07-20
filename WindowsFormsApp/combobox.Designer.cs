namespace WindowsFormsApp
{
    partial class combobox
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
            this.cbmbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.btaadd = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.allitem = new System.Windows.Forms.Label();
            this.lable4 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbmbox
            // 
            this.cbmbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbmbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbmbox.FormattingEnabled = true;
            this.cbmbox.Items.AddRange(new object[] {
            "c",
            "c++",
            "html",
            "Css"});
            this.cbmbox.Location = new System.Drawing.Point(15, 34);
            this.cbmbox.Name = "cbmbox";
            this.cbmbox.Size = new System.Drawing.Size(159, 21);
            this.cbmbox.TabIndex = 0;
            this.cbmbox.SelectedIndexChanged += new System.EventHandler(this.cbmbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your coursces";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add cource ";
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(201, 34);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(134, 20);
            this.txtadd.TabIndex = 5;
            // 
            // btaadd
            // 
            this.btaadd.Location = new System.Drawing.Point(201, 60);
            this.btaadd.Name = "btaadd";
            this.btaadd.Size = new System.Drawing.Size(66, 26);
            this.btaadd.TabIndex = 6;
            this.btaadd.Text = "Add";
            this.btaadd.UseVisualStyleBackColor = true;
            this.btaadd.Click += new System.EventHandler(this.btaadd_Click);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(277, 60);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(57, 25);
            this.btnshow.TabIndex = 7;
            this.btnshow.Text = "show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // allitem
            // 
            this.allitem.AutoSize = true;
            this.allitem.Location = new System.Drawing.Point(198, 98);
            this.allitem.Name = "allitem";
            this.allitem.Size = new System.Drawing.Size(0, 13);
            this.allitem.TabIndex = 8;
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Location = new System.Drawing.Point(18, 105);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(66, 13);
            this.lable4.TabIndex = 9;
            this.lable4.Text = "You select : ";
            // 
            // select
            // 
            this.select.AutoSize = true;
            this.select.Location = new System.Drawing.Point(84, 105);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(0, 13);
            this.select.TabIndex = 10;
            // 
            // combobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.select);
            this.Controls.Add(this.lable4);
            this.Controls.Add(this.allitem);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btaadd);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbmbox);
            this.Name = "combobox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "combobox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.Button btaadd;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Label allitem;
        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.Label select;
    }
}