namespace WindowsFormsApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.TextBox();
            this.n2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsum = new System.Windows.Forms.Button();
            this.resultlable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter 1st Number : ";
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(87, 82);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(161, 20);
            this.n1.TabIndex = 1;
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(87, 154);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(161, 20);
            this.n2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter 2nd Number : ";
            // 
            // btnsum
            // 
            this.btnsum.Location = new System.Drawing.Point(87, 199);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(73, 21);
            this.btnsum.TabIndex = 4;
            this.btnsum.Text = "Sum";
            this.btnsum.UseVisualStyleBackColor = true;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // resultlable
            // 
            this.resultlable.AutoSize = true;
            this.resultlable.Location = new System.Drawing.Point(94, 250);
            this.resultlable.Name = "resultlable";
            this.resultlable.Size = new System.Drawing.Size(46, 13);
            this.resultlable.TabIndex = 5;
            this.resultlable.Text = "Result : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.resultlable);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.TextBox n2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Label resultlable;
    }
}

