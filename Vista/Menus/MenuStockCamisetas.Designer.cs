namespace Vista
{
    partial class MenuStockCamisetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuStockCamisetas));
            this.dataGridViewStockCamisas = new System.Windows.Forms.DataGridView();
            this.textBoxStockCamisas = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSalirStock = new System.Windows.Forms.Button();
            this.buttonDevolverStock = new System.Windows.Forms.Button();
            this.EQUIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TALLA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FOTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockCamisas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStockCamisas
            // 
            this.dataGridViewStockCamisas.AllowUserToAddRows = false;
            this.dataGridViewStockCamisas.AllowUserToDeleteRows = false;
            this.dataGridViewStockCamisas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStockCamisas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewStockCamisas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStockCamisas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewStockCamisas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewStockCamisas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStockCamisas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EQUIPO,
            this.TALLA,
            this.PRECIO,
            this.COLOR,
            this.FOTO});
            this.dataGridViewStockCamisas.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewStockCamisas.Location = new System.Drawing.Point(28, 67);
            this.dataGridViewStockCamisas.Name = "dataGridViewStockCamisas";
            this.dataGridViewStockCamisas.ReadOnly = true;
            this.dataGridViewStockCamisas.RowHeadersVisible = false;
            this.dataGridViewStockCamisas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStockCamisas.Size = new System.Drawing.Size(731, 371);
            this.dataGridViewStockCamisas.TabIndex = 0;
            // 
            // textBoxStockCamisas
            // 
            this.textBoxStockCamisas.Location = new System.Drawing.Point(28, 31);
            this.textBoxStockCamisas.Name = "textBoxStockCamisas";
            this.textBoxStockCamisas.Size = new System.Drawing.Size(120, 20);
            this.textBoxStockCamisas.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(180, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "RESTABLECER";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
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
            this.buttonDevolverStock.Location = new System.Drawing.Point(718, 3);
            this.buttonDevolverStock.Name = "buttonDevolverStock";
            this.buttonDevolverStock.Size = new System.Drawing.Size(35, 29);
            this.buttonDevolverStock.TabIndex = 5;
            this.buttonDevolverStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDevolverStock.UseVisualStyleBackColor = true;
            this.buttonDevolverStock.Click += new System.EventHandler(this.buttonDevolverStock_Click);
            // 
            // EQUIPO
            // 
            this.EQUIPO.HeaderText = "EQUIPO";
            this.EQUIPO.Name = "EQUIPO";
            this.EQUIPO.ReadOnly = true;
            // 
            // TALLA
            // 
            this.TALLA.HeaderText = "TALLA";
            this.TALLA.Name = "TALLA";
            this.TALLA.ReadOnly = true;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            // 
            // COLOR
            // 
            this.COLOR.HeaderText = "COLOR";
            this.COLOR.Name = "COLOR";
            this.COLOR.ReadOnly = true;
            // 
            // FOTO
            // 
            this.FOTO.HeaderText = "FOTO";
            this.FOTO.Name = "FOTO";
            this.FOTO.ReadOnly = true;
            // 
            // StockCamisetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDevolverStock);
            this.Controls.Add(this.buttonSalirStock);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxStockCamisas);
            this.Controls.Add(this.dataGridViewStockCamisas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockCamisetas";
            this.Text = "StockCamisetas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockCamisas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStockCamisas;
        private System.Windows.Forms.TextBox textBoxStockCamisas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EQUIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TALLA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FOTO;
        private System.Windows.Forms.Button buttonSalirStock;
        private System.Windows.Forms.Button buttonDevolverStock;
    }
}