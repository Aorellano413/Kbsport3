namespace Vista
{
    partial class InventariosTelas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventariosTelas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxBuscarTelas = new System.Windows.Forms.TextBox();
            this.buttonAtrasTelas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 328);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(174, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "RESTABLECER";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarTelas
            // 
            this.textBoxBuscarTelas.Location = new System.Drawing.Point(12, 39);
            this.textBoxBuscarTelas.Name = "textBoxBuscarTelas";
            this.textBoxBuscarTelas.Size = new System.Drawing.Size(156, 20);
            this.textBoxBuscarTelas.TabIndex = 2;
            // 
            // buttonAtrasTelas
            // 
            this.buttonAtrasTelas.FlatAppearance.BorderSize = 0;
            this.buttonAtrasTelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtrasTelas.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtrasTelas.Image")));
            this.buttonAtrasTelas.Location = new System.Drawing.Point(746, 3);
            this.buttonAtrasTelas.Name = "buttonAtrasTelas";
            this.buttonAtrasTelas.Size = new System.Drawing.Size(42, 26);
            this.buttonAtrasTelas.TabIndex = 3;
            this.buttonAtrasTelas.UseVisualStyleBackColor = true;
            this.buttonAtrasTelas.Click += new System.EventHandler(this.buttonAtrasTelas_Click);
            // 
            // InventariosTelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAtrasTelas);
            this.Controls.Add(this.textBoxBuscarTelas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventariosTelas";
            this.Text = "InventariosTelas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxBuscarTelas;
        private System.Windows.Forms.Button buttonAtrasTelas;
    }
}