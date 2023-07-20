namespace WindowsFormsApp
{
    partial class progressbar
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
            this.lbsourse = new System.Windows.Forms.ListBox();
            this.lbtarget = new System.Windows.Forms.ListBox();
            this.Shift_data = new System.Windows.Forms.Button();
            this.probar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbsourse
            // 
            this.lbsourse.FormattingEnabled = true;
            this.lbsourse.Location = new System.Drawing.Point(77, 22);
            this.lbsourse.Name = "lbsourse";
            this.lbsourse.Size = new System.Drawing.Size(120, 290);
            this.lbsourse.TabIndex = 0;
            // 
            // lbtarget
            // 
            this.lbtarget.FormattingEnabled = true;
            this.lbtarget.Location = new System.Drawing.Point(405, 22);
            this.lbtarget.Name = "lbtarget";
            this.lbtarget.Size = new System.Drawing.Size(120, 290);
            this.lbtarget.TabIndex = 1;
            // 
            // Shift_data
            // 
            this.Shift_data.Location = new System.Drawing.Point(261, 289);
            this.Shift_data.Name = "Shift_data";
            this.Shift_data.Size = new System.Drawing.Size(75, 23);
            this.Shift_data.TabIndex = 2;
            this.Shift_data.Text = "Click";
            this.Shift_data.UseVisualStyleBackColor = true;
            this.Shift_data.Click += new System.EventHandler(this.Shift_data_Click);
            // 
            // probar
            // 
            this.probar.Location = new System.Drawing.Point(77, 343);
            this.probar.Name = "probar";
            this.probar.Size = new System.Drawing.Size(448, 23);
            this.probar.TabIndex = 3;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // progressbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.probar);
            this.Controls.Add(this.Shift_data);
            this.Controls.Add(this.lbtarget);
            this.Controls.Add(this.lbsourse);
            this.Name = "progressbar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "progressbar";
            this.Load += new System.EventHandler(this.progressbar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbsourse;
        private System.Windows.Forms.ListBox lbtarget;
        private System.Windows.Forms.Button Shift_data;
        private System.Windows.Forms.ProgressBar probar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
    }
}