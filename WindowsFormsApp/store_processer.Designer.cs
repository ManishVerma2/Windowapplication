namespace WindowsFormsApp
{
    partial class store_processer
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
            this.dgvbrnd = new System.Windows.Forms.DataGridView();
            this.txtb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbrnd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbrnd
            // 
            this.dgvbrnd.AllowUserToAddRows = false;
            this.dgvbrnd.AllowUserToDeleteRows = false;
            this.dgvbrnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbrnd.Location = new System.Drawing.Point(56, 195);
            this.dgvbrnd.Name = "dgvbrnd";
            this.dgvbrnd.ReadOnly = true;
            this.dgvbrnd.Size = new System.Drawing.Size(675, 167);
            this.dgvbrnd.TabIndex = 0;
            // 
            // txtb_id
            // 
            this.txtb_id.Location = new System.Drawing.Point(176, 149);
            this.txtb_id.Name = "txtb_id";
            this.txtb_id.Size = new System.Drawing.Size(199, 20);
            this.txtb_id.TabIndex = 1;
            this.txtb_id.TextChanged += new System.EventHandler(this.txtb_id_TextChanged);
            this.txtb_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_id_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search from brand_id : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search from Brand_name : ";
            // 
            // txtB_name
            // 
            this.txtB_name.Location = new System.Drawing.Point(532, 149);
            this.txtB_name.Name = "txtB_name";
            this.txtB_name.Size = new System.Drawing.Size(199, 20);
            this.txtB_name.TabIndex = 3;
            this.txtB_name.TextChanged += new System.EventHandler(this.txtB_name_TextChanged);
            // 
            // store_processer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtB_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_id);
            this.Controls.Add(this.dgvbrnd);
            this.Name = "store_processer";
            this.Text = "store_processer";
            this.Load += new System.EventHandler(this.store_processer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbrnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbrnd;
        private System.Windows.Forms.TextBox txtb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB_name;
    }
}