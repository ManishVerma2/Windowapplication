namespace WindowsFormsApp
{
    partial class checkbox
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
            this.palying = new System.Windows.Forms.CheckBox();
            this.studing = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.conform = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.perment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // palying
            // 
            this.palying.AutoSize = true;
            this.palying.Location = new System.Drawing.Point(99, 60);
            this.palying.Name = "palying";
            this.palying.Size = new System.Drawing.Size(60, 17);
            this.palying.TabIndex = 0;
            this.palying.Text = "Palying";
            this.palying.UseVisualStyleBackColor = true;
            // 
            // studing
            // 
            this.studing.AutoSize = true;
            this.studing.Location = new System.Drawing.Point(99, 83);
            this.studing.Name = "studing";
            this.studing.Size = new System.Drawing.Size(62, 17);
            this.studing.TabIndex = 1;
            this.studing.Text = "Studing";
            this.studing.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your hobbies : ";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(99, 106);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(47, 23);
            this.submit.TabIndex = 3;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.check_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter your address : ";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(98, 160);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(140, 20);
            this.address.TabIndex = 5;
            // 
            // conform
            // 
            this.conform.AutoSize = true;
            this.conform.Location = new System.Drawing.Point(99, 186);
            this.conform.Name = "conform";
            this.conform.Size = new System.Drawing.Size(241, 17);
            this.conform.TabIndex = 7;
            this.conform.Text = "Your current address is your perment address ";
            this.conform.UseVisualStyleBackColor = true;
            this.conform.CheckedChanged += new System.EventHandler(this.conform_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Perment address : ";
            // 
            // perment
            // 
            this.perment.Location = new System.Drawing.Point(98, 225);
            this.perment.Name = "perment";
            this.perment.Size = new System.Drawing.Size(140, 20);
            this.perment.TabIndex = 9;
            // 
            // checkbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 332);
            this.Controls.Add(this.perment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.conform);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studing);
            this.Controls.Add(this.palying);
            this.Name = "checkbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox palying;
        private System.Windows.Forms.CheckBox studing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.CheckBox conform;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox perment;
    }
}