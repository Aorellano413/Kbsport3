namespace Vista
{
    partial class InventariosCamisas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventariosCamisas));
            this.dataGridViewStockCamisas = new System.Windows.Forms.DataGridView();
            this.textBoxNombreCamisas = new System.Windows.Forms.TextBox();
            this.buttonRestablecer = new System.Windows.Forms.Button();
            this.buttonSalirStock = new System.Windows.Forms.Button();
            this.buttonDevolverStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockCamisas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStockCamisas
            // 
            this.dataGridViewStockCamisas.AllowUserToAddRows = false;
            this.dataGridViewStockCamisas.AllowUserToDeleteRows = false;
            this.dataGridViewStockCamisas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStockCamisas.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewStockCamisas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStockCamisas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewStockCamisas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewStockCamisas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStockCamisas.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewStockCamisas.Location = new System.Drawing.Point(28, 67);
            this.dataGridViewStockCamisas.Name = "dataGridViewStockCamisas";
            this.dataGridViewStockCamisas.ReadOnly = true;
            this.dataGridViewStockCamisas.RowHeadersVisible = false;
            this.dataGridViewStockCamisas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStockCamisas.Size = new System.Drawing.Size(731, 371);
            this.dataGridViewStockCamisas.TabIndex = 0;
            // 
            // textBoxNombreCamisas
            // 
            this.textBoxNombreCamisas.Location = new System.Drawing.Point(28, 33);
            this.textBoxNombreCamisas.Name = "textBoxNombreCamisas";
            this.textBoxNombreCamisas.Size = new System.Drawing.Size(120, 20);
            this.textBoxNombreCamisas.TabIndex = 2;
            this.textBoxNombreCamisas.TextChanged += new System.EventHandler(this.textBoxNombreCamisas_TextChanged);
            // 
            // buttonRestablecer
            // 
            this.buttonRestablecer.FlatAppearance.BorderSize = 0;
            this.buttonRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestablecer.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestablecer.Image = ((System.Drawing.Image)(resources.GetObject("buttonRestablecer.Image")));
            this.buttonRestablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRestablecer.Location = new System.Drawing.Point(180, 23);
            this.buttonRestablecer.Name = "buttonRestablecer";
            this.buttonRestablecer.Size = new System.Drawing.Size(139, 38);
            this.buttonRestablecer.TabIndex = 3;
            this.buttonRestablecer.Text = "RESTABLECER";
            this.buttonRestablecer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRestablecer.UseVisualStyleBackColor = true;
            // 
            // buttonSalirStock
            // 
            this.buttonSalirStock.FlatAppearance.BorderSize = 0;
            this.buttonSalirStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalirStock.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalirStock.Image")));
            this.buttonSalirStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalirStock.Location = new System.Drawing.Point(759, 3);
            this.buttonSalirStock.Name = "buttonSalirStock";
            this.buttonSalirStock.Size = new System.Drawing.Size(39, 29);
            this.buttonSalirStock.TabIndex = 4;
            this.buttonSalirStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalirStock.UseVisualStyleBackColor = true;
            this.buttonSalirStock.Click += new System.EventHandler(this.buttonSalirStock_Click);
            // 
            // buttonDevolverStock
            // 
            this.buttonDevolverStock.FlatAppearance.BorderSize = 0;
            this.buttonDevolverStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDevolverStock.Image = ((System.Drawing.Image)(resources.GetObject("buttonDevolverStock.Image")));
            this.buttonDevolverStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDevolverStock.Location = new System.Drawing.Point(1, 3);
            this.buttonDevolverStock.Name = "buttonDevolverStock";
            this.buttonDevolverStock.Size = new System.Drawing.Size(35, 29);
            this.buttonDevolverStock.TabIndex = 5;
            this.buttonDevolverStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDevolverStock.UseVisualStyleBackColor = true;
            this.buttonDevolverStock.Click += new System.EventHandler(this.buttonDevolverStock_Click);
            // 
            // InventariosCamisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDevolverStock);
            this.Controls.Add(this.buttonSalirStock);
            this.Controls.Add(this.buttonRestablecer);
            this.Controls.Add(this.textBoxNombreCamisas);
            this.Controls.Add(this.dataGridViewStockCamisas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventariosCamisas";
            this.Text = "StockCamisetas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockCamisas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStockCamisas;
        private System.Windows.Forms.TextBox textBoxNombreCamisas;
        private System.Windows.Forms.Button buttonRestablecer;
        private System.Windows.Forms.Button buttonSalirStock;
        private System.Windows.Forms.Button buttonDevolverStock;
    }
}