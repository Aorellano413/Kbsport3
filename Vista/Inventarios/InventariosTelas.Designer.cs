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
            this.dataGridViewMostrarTelas = new System.Windows.Forms.DataGridView();
            this.buttonRestablecerTelas = new System.Windows.Forms.Button();
            this.textBoxBuscarTelas = new System.Windows.Forms.TextBox();
            this.buttonAtrasTelas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarTelas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMostrarTelas
            // 
            this.dataGridViewMostrarTelas.AllowUserToAddRows = false;
            this.dataGridViewMostrarTelas.AllowUserToDeleteRows = false;
            this.dataGridViewMostrarTelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMostrarTelas.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewMostrarTelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMostrarTelas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewMostrarTelas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewMostrarTelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostrarTelas.Location = new System.Drawing.Point(12, 109);
            this.dataGridViewMostrarTelas.Name = "dataGridViewMostrarTelas";
            this.dataGridViewMostrarTelas.ReadOnly = true;
            this.dataGridViewMostrarTelas.RowHeadersVisible = false;
            this.dataGridViewMostrarTelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMostrarTelas.Size = new System.Drawing.Size(776, 301);
            this.dataGridViewMostrarTelas.TabIndex = 0;
            // 
            // buttonRestablecerTelas
            // 
            this.buttonRestablecerTelas.FlatAppearance.BorderSize = 0;
            this.buttonRestablecerTelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestablecerTelas.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestablecerTelas.Image = ((System.Drawing.Image)(resources.GetObject("buttonRestablecerTelas.Image")));
            this.buttonRestablecerTelas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRestablecerTelas.Location = new System.Drawing.Point(641, 57);
            this.buttonRestablecerTelas.Name = "buttonRestablecerTelas";
            this.buttonRestablecerTelas.Size = new System.Drawing.Size(147, 34);
            this.buttonRestablecerTelas.TabIndex = 1;
            this.buttonRestablecerTelas.Text = "RESTABLECER";
            this.buttonRestablecerTelas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRestablecerTelas.UseVisualStyleBackColor = true;
            this.buttonRestablecerTelas.Click += new System.EventHandler(this.buttonRestablecerTelas_Click);
            // 
            // textBoxBuscarTelas
            // 
            this.textBoxBuscarTelas.Location = new System.Drawing.Point(12, 83);
            this.textBoxBuscarTelas.Name = "textBoxBuscarTelas";
            this.textBoxBuscarTelas.Size = new System.Drawing.Size(104, 20);
            this.textBoxBuscarTelas.TabIndex = 2;
            this.textBoxBuscarTelas.TextChanged += new System.EventHandler(this.textBoxBuscarTelas_TextChanged);
            // 
            // buttonAtrasTelas
            // 
            this.buttonAtrasTelas.FlatAppearance.BorderSize = 0;
            this.buttonAtrasTelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtrasTelas.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtrasTelas.Image")));
            this.buttonAtrasTelas.Location = new System.Drawing.Point(12, 7);
            this.buttonAtrasTelas.Name = "buttonAtrasTelas";
            this.buttonAtrasTelas.Size = new System.Drawing.Size(42, 26);
            this.buttonAtrasTelas.TabIndex = 3;
            this.buttonAtrasTelas.UseVisualStyleBackColor = true;
            this.buttonAtrasTelas.Click += new System.EventHandler(this.buttonAtrasTelas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "BUSCAR TELA :";
            // 
            // InventariosTelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAtrasTelas);
            this.Controls.Add(this.textBoxBuscarTelas);
            this.Controls.Add(this.buttonRestablecerTelas);
            this.Controls.Add(this.dataGridViewMostrarTelas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventariosTelas";
            this.Text = "InventariosTelas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarTelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMostrarTelas;
        private System.Windows.Forms.Button buttonRestablecerTelas;
        private System.Windows.Forms.TextBox textBoxBuscarTelas;
        private System.Windows.Forms.Button buttonAtrasTelas;
        private System.Windows.Forms.Label label1;
    }
}