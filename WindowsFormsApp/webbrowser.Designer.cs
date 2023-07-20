namespace WindowsFormsApp
{
    partial class webbrowser
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
            this.weburl = new System.Windows.Forms.WebBrowser();
            this.txturl = new System.Windows.Forms.TextBox();
            this.btngo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weburl
            // 
            this.weburl.Location = new System.Drawing.Point(28, 79);
            this.weburl.MinimumSize = new System.Drawing.Size(20, 20);
            this.weburl.Name = "weburl";
            this.weburl.Size = new System.Drawing.Size(743, 348);
            this.weburl.TabIndex = 0;
            // 
            // txturl
            // 
            this.txturl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txturl.Location = new System.Drawing.Point(28, 28);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(661, 31);
            this.txturl.TabIndex = 1;
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(695, 28);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(76, 31);
            this.btngo.TabIndex = 2;
            this.btngo.Text = "Go";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // webbrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.weburl);
            this.Name = "webbrowser";
            this.Text = "webbrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser weburl;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.Button btngo;
    }
}