namespace WindowsFormsApp
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.btnmc = new System.Windows.Forms.Button();
            this.btnmr = new System.Windows.Forms.Button();
            this.btnMs = new System.Windows.Forms.Button();
            this.btnmp = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.btnbackspacke = new System.Windows.Forms.Button();
            this.btnce = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btnper = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btnp = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.screen = new System.Windows.Forms.TextBox();
            this.first = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnsqre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmc
            // 
            this.btnmc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmc.Location = new System.Drawing.Point(7, 106);
            this.btnmc.Name = "btnmc";
            this.btnmc.Size = new System.Drawing.Size(55, 33);
            this.btnmc.TabIndex = 0;
            this.btnmc.Text = "MC";
            this.btnmc.UseVisualStyleBackColor = true;
            this.btnmc.Click += new System.EventHandler(this.Mc_click);
            // 
            // btnmr
            // 
            this.btnmr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmr.Location = new System.Drawing.Point(68, 106);
            this.btnmr.Name = "btnmr";
            this.btnmr.Size = new System.Drawing.Size(55, 33);
            this.btnmr.TabIndex = 0;
            this.btnmr.Text = "MR";
            this.btnmr.UseVisualStyleBackColor = true;
            this.btnmr.Click += new System.EventHandler(this.Mr_click);
            // 
            // btnMs
            // 
            this.btnMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMs.Location = new System.Drawing.Point(129, 106);
            this.btnMs.Name = "btnMs";
            this.btnMs.Size = new System.Drawing.Size(55, 33);
            this.btnMs.TabIndex = 0;
            this.btnMs.Text = "MS";
            this.btnMs.UseVisualStyleBackColor = true;
            this.btnMs.Click += new System.EventHandler(this.Ms_click);
            // 
            // btnmp
            // 
            this.btnmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmp.Location = new System.Drawing.Point(190, 106);
            this.btnmp.Name = "btnmp";
            this.btnmp.Size = new System.Drawing.Size(55, 33);
            this.btnmp.TabIndex = 0;
            this.btnmp.Text = "M+";
            this.btnmp.UseVisualStyleBackColor = true;
            this.btnmp.Click += new System.EventHandler(this.Mplus_Click);
            // 
            // btnmin
            // 
            this.btnmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmin.Location = new System.Drawing.Point(251, 106);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(55, 33);
            this.btnmin.TabIndex = 0;
            this.btnmin.Text = "M-";
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.Click += new System.EventHandler(this.Mmin_Click);
            // 
            // btnbackspacke
            // 
            this.btnbackspacke.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackspacke.Location = new System.Drawing.Point(7, 145);
            this.btnbackspacke.Name = "btnbackspacke";
            this.btnbackspacke.Size = new System.Drawing.Size(55, 33);
            this.btnbackspacke.TabIndex = 0;
            this.btnbackspacke.Text = "B";
            this.btnbackspacke.UseVisualStyleBackColor = true;
            this.btnbackspacke.Click += new System.EventHandler(this.bspace);
            // 
            // btnce
            // 
            this.btnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnce.Location = new System.Drawing.Point(68, 145);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(55, 33);
            this.btnce.TabIndex = 0;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = true;
            this.btnce.Click += new System.EventHandler(this.Ce_Click);
            // 
            // btnc
            // 
            this.btnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnc.Location = new System.Drawing.Point(129, 145);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(55, 33);
            this.btnc.TabIndex = 0;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.C_click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(190, 145);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 33);
            this.button9.TabIndex = 0;
            this.button9.Text = "+-";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(7, 184);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 33);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btndigit_click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(68, 184);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 33);
            this.btn8.TabIndex = 0;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btndigit_click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(129, 184);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 33);
            this.btn9.TabIndex = 0;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btndigit_click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(190, 184);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(55, 33);
            this.button14.TabIndex = 0;
            this.button14.Text = "/";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.op_click);
            // 
            // btnper
            // 
            this.btnper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnper.Location = new System.Drawing.Point(251, 184);
            this.btnper.Name = "btnper";
            this.btnper.Size = new System.Drawing.Size(55, 33);
            this.btnper.TabIndex = 0;
            this.btnper.Text = "%";
            this.btnper.UseVisualStyleBackColor = true;
            this.btnper.Click += new System.EventHandler(this.btn_Per);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(7, 223);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 33);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btndigit_click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(68, 223);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 33);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btndigit_click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(129, 223);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 33);
            this.btn6.TabIndex = 0;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btndigit_click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(190, 223);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(55, 33);
            this.button19.TabIndex = 0;
            this.button19.Text = "*";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.op_click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(251, 223);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(55, 33);
            this.button20.TabIndex = 0;
            this.button20.Text = "1/x";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(7, 262);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 33);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btndigit_click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(129, 262);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 33);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btndigit_click);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(190, 262);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(55, 33);
            this.button24.TabIndex = 0;
            this.button24.Text = "-";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.op_click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(7, 301);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(116, 33);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btndigit_click);
            // 
            // btndot
            // 
            this.btndot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndot.Location = new System.Drawing.Point(129, 301);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(55, 33);
            this.btndot.TabIndex = 0;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            this.btndot.Click += new System.EventHandler(this.btndot_click);
            // 
            // btnp
            // 
            this.btnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnp.Location = new System.Drawing.Point(190, 301);
            this.btnp.Name = "btnp";
            this.btnp.Size = new System.Drawing.Size(55, 33);
            this.btnp.TabIndex = 0;
            this.btnp.Text = "+";
            this.btnp.UseVisualStyleBackColor = true;
            this.btnp.Click += new System.EventHandler(this.op_click);
            // 
            // button30
            // 
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.Location = new System.Drawing.Point(251, 262);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(55, 72);
            this.button30.TabIndex = 0;
            this.button30.Text = "=";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.equl_click);
            // 
            // screen
            // 
            this.screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screen.Location = new System.Drawing.Point(7, 60);
            this.screen.Multiline = true;
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(299, 40);
            this.screen.TabIndex = 1;
            this.screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first.Location = new System.Drawing.Point(260, 21);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(0, 24);
            this.first.TabIndex = 2;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(68, 262);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 33);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btndigit_click);
            // 
            // btnsqre
            // 
            this.btnsqre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsqre.Location = new System.Drawing.Point(251, 145);
            this.btnsqre.Name = "btnsqre";
            this.btnsqre.Size = new System.Drawing.Size(55, 33);
            this.btnsqre.TabIndex = 0;
            this.btnsqre.Text = "Sque";
            this.btnsqre.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 341);
            this.Controls.Add(this.first);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.btnper);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btnp);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.btndot);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnsqre);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnmp);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnce);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnMs);
            this.Controls.Add(this.btnbackspacke);
            this.Controls.Add(this.btnmr);
            this.Controls.Add(this.btnmc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmc;
        private System.Windows.Forms.Button btnmr;
        private System.Windows.Forms.Button btnMs;
        private System.Windows.Forms.Button btnmp;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btnbackspacke;
        private System.Windows.Forms.Button btnce;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnper;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btnp;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.TextBox screen;
        private System.Windows.Forms.Label first;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnsqre;
    }
}