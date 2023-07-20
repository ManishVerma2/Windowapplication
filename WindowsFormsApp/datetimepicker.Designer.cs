namespace WindowsFormsApp
{
    partial class datetimepicker
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
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.btn = new System.Windows.Forms.Button();
            this.link = new System.Windows.Forms.LinkLabel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpicker
            // 
            this.dtpicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker.Checked = false;
            this.dtpicker.CustomFormat = "hh/mm/ss/tt";
            this.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpicker.Location = new System.Drawing.Point(44, 36);
            this.dtpicker.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.dtpicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(213, 20);
            this.dtpicker.TabIndex = 0;
            this.dtpicker.Value = new System.DateTime(2023, 3, 12, 16, 50, 27, 0);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(50, 91);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(121, 37);
            this.btn.TabIndex = 1;
            this.btn.Text = "button";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(49, 168);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(39, 13);
            this.link.TabIndex = 2;
            this.link.TabStop = true;
            this.link.Text = "google";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(57, 216);
            this.maskedTextBox1.Mask = "(+91)";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(170, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "mask";
            // 
            // datetimepicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.link);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.dtpicker);
            this.Name = "datetimepicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "datetimepicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
    }
}