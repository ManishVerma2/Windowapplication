namespace WindowsFormsApp
{
    partial class si
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
            this.p = new System.Windows.Forms.Label();
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtr = new System.Windows.Forms.TextBox();
            this.r = new System.Windows.Forms.Label();
            this.txtt = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.Label();
            this.btnr = new System.Windows.Forms.Button();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p.Location = new System.Drawing.Point(59, 33);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(95, 18);
            this.p.TabIndex = 0;
            this.p.Text = "Principal : ";
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(62, 62);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(120, 20);
            this.txtp.TabIndex = 1;
            // 
            // txtr
            // 
            this.txtr.Location = new System.Drawing.Point(62, 114);
            this.txtr.Name = "txtr";
            this.txtr.Size = new System.Drawing.Size(120, 20);
            this.txtr.TabIndex = 3;
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.Location = new System.Drawing.Point(59, 85);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(58, 18);
            this.r.TabIndex = 2;
            this.r.Text = "Rate : ";
            // 
            // txtt
            // 
            this.txtt.Location = new System.Drawing.Point(62, 166);
            this.txtt.Name = "txtt";
            this.txtt.Size = new System.Drawing.Size(120, 20);
            this.txtt.TabIndex = 5;
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(59, 137);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(62, 18);
            this.t.TabIndex = 4;
            this.t.Text = "Time : ";
            // 
            // btnr
            // 
            this.btnr.Location = new System.Drawing.Point(62, 192);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(75, 23);
            this.btnr.TabIndex = 6;
            this.btnr.Text = "Go result";
            this.btnr.UseVisualStyleBackColor = true;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // resultbox
            // 
            this.resultbox.Location = new System.Drawing.Point(67, 237);
            this.resultbox.Name = "resultbox";
            this.resultbox.Size = new System.Drawing.Size(115, 20);
            this.resultbox.TabIndex = 7;
            // 
            // si
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.txtt);
            this.Controls.Add(this.t);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.r);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.p);
            this.Name = "si";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "si";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.TextBox txtr;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.TextBox txtt;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Button btnr;
        private System.Windows.Forms.TextBox resultbox;
    }
}