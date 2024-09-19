namespace Vista.GestionCamisas
{
    partial class AsignarCamisas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarCamisas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAsignarValoresCamisas = new System.Windows.Forms.Button();
            this.buttonAsignarCerrar = new System.Windows.Forms.Button();
            this.comboBoxCamisas = new System.Windows.Forms.ComboBox();
            this.buttonBuscarCamisas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAsignarValoresCamisas
            // 
            this.buttonAsignarValoresCamisas.FlatAppearance.BorderSize = 0;
            this.buttonAsignarValoresCamisas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAsignarValoresCamisas.Image = ((System.Drawing.Image)(resources.GetObject("buttonAsignarValoresCamisas.Image")));
            this.buttonAsignarValoresCamisas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAsignarValoresCamisas.Location = new System.Drawing.Point(604, 58);
            this.buttonAsignarValoresCamisas.Name = "buttonAsignarValoresCamisas";
            this.buttonAsignarValoresCamisas.Size = new System.Drawing.Size(184, 78);
            this.buttonAsignarValoresCamisas.TabIndex = 2;
            this.buttonAsignarValoresCamisas.Text = "ASIGNAR VALORES";
            this.buttonAsignarValoresCamisas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAsignarValoresCamisas.UseVisualStyleBackColor = true;
            // 
            // buttonAsignarCerrar
            // 
            this.buttonAsignarCerrar.FlatAppearance.BorderSize = 0;
            this.buttonAsignarCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAsignarCerrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAsignarCerrar.Image")));
            this.buttonAsignarCerrar.Location = new System.Drawing.Point(713, 1);
            this.buttonAsignarCerrar.Name = "buttonAsignarCerrar";
            this.buttonAsignarCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonAsignarCerrar.TabIndex = 3;
            this.buttonAsignarCerrar.UseVisualStyleBackColor = true;
            this.buttonAsignarCerrar.Click += new System.EventHandler(this.buttonAsignarCerrar_Click);
            // 
            // comboBoxCamisas
            // 
            this.comboBoxCamisas.FormattingEnabled = true;
            this.comboBoxCamisas.Location = new System.Drawing.Point(84, 53);
            this.comboBoxCamisas.Name = "comboBoxCamisas";
            this.comboBoxCamisas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCamisas.TabIndex = 4;
            // 
            // buttonBuscarCamisas
            // 
            this.buttonBuscarCamisas.FlatAppearance.BorderSize = 0;
            this.buttonBuscarCamisas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarCamisas.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarCamisas.Image")));
            this.buttonBuscarCamisas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarCamisas.Location = new System.Drawing.Point(12, 29);
            this.buttonBuscarCamisas.Name = "buttonBuscarCamisas";
            this.buttonBuscarCamisas.Size = new System.Drawing.Size(48, 45);
            this.buttonBuscarCamisas.TabIndex = 5;
            this.buttonBuscarCamisas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscarCamisas.UseVisualStyleBackColor = true;
            // 
            // AsignarCamisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.buttonBuscarCamisas);
            this.Controls.Add(this.comboBoxCamisas);
            this.Controls.Add(this.buttonAsignarCerrar);
            this.Controls.Add(this.buttonAsignarValoresCamisas);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AsignarCamisas";
            this.Text = "AsignarValores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAsignarValoresCamisas;
        private System.Windows.Forms.Button buttonAsignarCerrar;
        private System.Windows.Forms.ComboBox comboBoxCamisas;
        private System.Windows.Forms.Button buttonBuscarCamisas;
    }
}