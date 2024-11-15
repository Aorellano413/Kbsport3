namespace Vista
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAtrasProductos = new System.Windows.Forms.Button();
            this.dataGridViewCamisasVendidasMenos = new System.Windows.Forms.DataGridView();
            this.buttonSube = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonBaja = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamisasVendidasMenos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonAtrasProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 51);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "INFORME DE PRODUCTOS";
            // 
            // buttonAtrasProductos
            // 
            this.buttonAtrasProductos.FlatAppearance.BorderSize = 0;
            this.buttonAtrasProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtrasProductos.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtrasProductos.Image")));
            this.buttonAtrasProductos.Location = new System.Drawing.Point(12, 9);
            this.buttonAtrasProductos.Name = "buttonAtrasProductos";
            this.buttonAtrasProductos.Size = new System.Drawing.Size(37, 29);
            this.buttonAtrasProductos.TabIndex = 3;
            this.buttonAtrasProductos.UseVisualStyleBackColor = true;
            this.buttonAtrasProductos.Click += new System.EventHandler(this.buttonAtrasProductos_Click);
            // 
            // dataGridViewCamisasVendidasMenos
            // 
            this.dataGridViewCamisasVendidasMenos.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewCamisasVendidasMenos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCamisasVendidasMenos.Location = new System.Drawing.Point(31, 124);
            this.dataGridViewCamisasVendidasMenos.Name = "dataGridViewCamisasVendidasMenos";
            this.dataGridViewCamisasVendidasMenos.Size = new System.Drawing.Size(665, 339);
            this.dataGridViewCamisasVendidasMenos.TabIndex = 8;
            // 
            // buttonSube
            // 
            this.buttonSube.FlatAppearance.BorderSize = 0;
            this.buttonSube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSube.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSube.Image = ((System.Drawing.Image)(resources.GetObject("buttonSube.Image")));
            this.buttonSube.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSube.Location = new System.Drawing.Point(31, 67);
            this.buttonSube.Name = "buttonSube";
            this.buttonSube.Size = new System.Drawing.Size(131, 51);
            this.buttonSube.TabIndex = 9;
            this.buttonSube.Text = "CAMISA MAS :";
            this.buttonSube.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSube.UseVisualStyleBackColor = true;
            this.buttonSube.Click += new System.EventHandler(this.buttonSube_Click);
            // 
            // buttonBaja
            // 
            this.buttonBaja.FlatAppearance.BorderSize = 0;
            this.buttonBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBaja.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBaja.Image = ((System.Drawing.Image)(resources.GetObject("buttonBaja.Image")));
            this.buttonBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBaja.Location = new System.Drawing.Point(547, 67);
            this.buttonBaja.Name = "buttonBaja";
            this.buttonBaja.Size = new System.Drawing.Size(149, 51);
            this.buttonBaja.TabIndex = 10;
            this.buttonBaja.Text = "CAMISA MENOS :";
            this.buttonBaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBaja.UseVisualStyleBackColor = true;
            this.buttonBaja.Click += new System.EventHandler(this.buttonBaja_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(741, 528);
            this.Controls.Add(this.buttonBaja);
            this.Controls.Add(this.buttonSube);
            this.Controls.Add(this.dataGridViewCamisasVendidasMenos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamisasVendidasMenos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAtrasProductos;
        private System.Windows.Forms.DataGridView dataGridViewCamisasVendidasMenos;
        private System.Windows.Forms.Button buttonSube;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonBaja;
    }
}