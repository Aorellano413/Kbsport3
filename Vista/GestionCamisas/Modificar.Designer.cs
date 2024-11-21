namespace Vista
{
    partial class Modificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAtrasCamisas = new System.Windows.Forms.Button();
            this.dataGridViewModificarCamisas = new System.Windows.Forms.DataGridView();
            this.IMAGEN = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonRestablecerModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTCAMISAMODIFICAR = new System.Windows.Forms.TextBox();
            this.buttonModificarCamisa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificarCamisas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buttonAtrasCamisas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 54);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(308, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "MODIFICAR CAMISA";
            // 
            // buttonAtrasCamisas
            // 
            this.buttonAtrasCamisas.FlatAppearance.BorderSize = 0;
            this.buttonAtrasCamisas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtrasCamisas.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtrasCamisas.Image")));
            this.buttonAtrasCamisas.Location = new System.Drawing.Point(3, 2);
            this.buttonAtrasCamisas.Name = "buttonAtrasCamisas";
            this.buttonAtrasCamisas.Size = new System.Drawing.Size(39, 35);
            this.buttonAtrasCamisas.TabIndex = 13;
            this.buttonAtrasCamisas.UseVisualStyleBackColor = true;
            this.buttonAtrasCamisas.Click += new System.EventHandler(this.buttonAtrasCamisas_Click);
            // 
            // dataGridViewModificarCamisas
            // 
            this.dataGridViewModificarCamisas.AllowUserToAddRows = false;
            this.dataGridViewModificarCamisas.AllowUserToDeleteRows = false;
            this.dataGridViewModificarCamisas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewModificarCamisas.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewModificarCamisas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewModificarCamisas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewModificarCamisas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewModificarCamisas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModificarCamisas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IMAGEN});
            this.dataGridViewModificarCamisas.Location = new System.Drawing.Point(12, 166);
            this.dataGridViewModificarCamisas.Name = "dataGridViewModificarCamisas";
            this.dataGridViewModificarCamisas.RowHeadersVisible = false;
            this.dataGridViewModificarCamisas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewModificarCamisas.Size = new System.Drawing.Size(760, 256);
            this.dataGridViewModificarCamisas.TabIndex = 21;
            // 
            // IMAGEN
            // 
            this.IMAGEN.HeaderText = "IMAGEN";
            this.IMAGEN.Name = "IMAGEN";
            this.IMAGEN.ReadOnly = true;
            // 
            // buttonRestablecerModificar
            // 
            this.buttonRestablecerModificar.FlatAppearance.BorderSize = 0;
            this.buttonRestablecerModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestablecerModificar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestablecerModificar.Image = ((System.Drawing.Image)(resources.GetObject("buttonRestablecerModificar.Image")));
            this.buttonRestablecerModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRestablecerModificar.Location = new System.Drawing.Point(633, 95);
            this.buttonRestablecerModificar.Name = "buttonRestablecerModificar";
            this.buttonRestablecerModificar.Size = new System.Drawing.Size(139, 38);
            this.buttonRestablecerModificar.TabIndex = 22;
            this.buttonRestablecerModificar.Text = "RESTABLECER";
            this.buttonRestablecerModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRestablecerModificar.UseVisualStyleBackColor = true;
            this.buttonRestablecerModificar.Click += new System.EventHandler(this.buttonRestablecerModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "BUSCAR CAMISA :";
            // 
            // TXTCAMISAMODIFICAR
            // 
            this.TXTCAMISAMODIFICAR.Location = new System.Drawing.Point(16, 128);
            this.TXTCAMISAMODIFICAR.Name = "TXTCAMISAMODIFICAR";
            this.TXTCAMISAMODIFICAR.Size = new System.Drawing.Size(120, 20);
            this.TXTCAMISAMODIFICAR.TabIndex = 23;
            this.TXTCAMISAMODIFICAR.TextChanged += new System.EventHandler(this.TXTCAMISAMODIFICAR_TextChanged);
            // 
            // buttonModificarCamisa
            // 
            this.buttonModificarCamisa.FlatAppearance.BorderSize = 0;
            this.buttonModificarCamisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificarCamisa.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarCamisa.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificarCamisa.Image")));
            this.buttonModificarCamisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModificarCamisa.Location = new System.Drawing.Point(660, 440);
            this.buttonModificarCamisa.Name = "buttonModificarCamisa";
            this.buttonModificarCamisa.Size = new System.Drawing.Size(112, 36);
            this.buttonModificarCamisa.TabIndex = 25;
            this.buttonModificarCamisa.Text = "CONFIRMAR";
            this.buttonModificarCamisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonModificarCamisa.UseVisualStyleBackColor = true;
            this.buttonModificarCamisa.Click += new System.EventHandler(this.buttonModificarCamisa_Click);
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(798, 638);
            this.Controls.Add(this.buttonModificarCamisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTCAMISAMODIFICAR);
            this.Controls.Add(this.buttonRestablecerModificar);
            this.Controls.Add(this.dataGridViewModificarCamisas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificarCamisas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAtrasCamisas;
        private System.Windows.Forms.DataGridView dataGridViewModificarCamisas;
        private System.Windows.Forms.DataGridViewImageColumn IMAGEN;
        private System.Windows.Forms.Button buttonRestablecerModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTCAMISAMODIFICAR;
        private System.Windows.Forms.Button buttonModificarCamisa;
    }
}