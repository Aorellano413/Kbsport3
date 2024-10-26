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
            this.dataGridViewAsignarValores = new System.Windows.Forms.DataGridView();
            this.buttonAsignarValoresCamisas = new System.Windows.Forms.Button();
            this.buttonAsignarCerrar = new System.Windows.Forms.Button();
            this.comboBoxCamisasAsignar = new System.Windows.Forms.ComboBox();
            this.buttonBuscarCamisas = new System.Windows.Forms.Button();
            this.buttonAtrasAsignar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignarValores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAsignarValores
            // 
            this.dataGridViewAsignarValores.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewAsignarValores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAsignarValores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewAsignarValores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewAsignarValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsignarValores.Location = new System.Drawing.Point(12, 142);
            this.dataGridViewAsignarValores.Name = "dataGridViewAsignarValores";
            this.dataGridViewAsignarValores.Size = new System.Drawing.Size(776, 240);
            this.dataGridViewAsignarValores.TabIndex = 0;
            // 
            // buttonAsignarValoresCamisas
            // 
            this.buttonAsignarValoresCamisas.FlatAppearance.BorderSize = 0;
            this.buttonAsignarValoresCamisas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAsignarValoresCamisas.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsignarValoresCamisas.Image = ((System.Drawing.Image)(resources.GetObject("buttonAsignarValoresCamisas.Image")));
            this.buttonAsignarValoresCamisas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAsignarValoresCamisas.Location = new System.Drawing.Point(587, 58);
            this.buttonAsignarValoresCamisas.Name = "buttonAsignarValoresCamisas";
            this.buttonAsignarValoresCamisas.Size = new System.Drawing.Size(201, 78);
            this.buttonAsignarValoresCamisas.TabIndex = 2;
            this.buttonAsignarValoresCamisas.Text = "ASIGNAR VALORES";
            this.buttonAsignarValoresCamisas.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            // comboBoxCamisasAsignar
            // 
            this.comboBoxCamisasAsignar.FormattingEnabled = true;
            this.comboBoxCamisasAsignar.Location = new System.Drawing.Point(78, 64);
            this.comboBoxCamisasAsignar.Name = "comboBoxCamisasAsignar";
            this.comboBoxCamisasAsignar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCamisasAsignar.TabIndex = 4;
            this.comboBoxCamisasAsignar.SelectedIndexChanged += new System.EventHandler(this.comboBoxCamisasAsignar_SelectedIndexChanged);
            // 
            // buttonBuscarCamisas
            // 
            this.buttonBuscarCamisas.FlatAppearance.BorderSize = 0;
            this.buttonBuscarCamisas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarCamisas.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarCamisas.Image")));
            this.buttonBuscarCamisas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarCamisas.Location = new System.Drawing.Point(12, 40);
            this.buttonBuscarCamisas.Name = "buttonBuscarCamisas";
            this.buttonBuscarCamisas.Size = new System.Drawing.Size(48, 45);
            this.buttonBuscarCamisas.TabIndex = 5;
            this.buttonBuscarCamisas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscarCamisas.UseVisualStyleBackColor = true;
            // 
            // buttonAtrasAsignar
            // 
            this.buttonAtrasAsignar.FlatAppearance.BorderSize = 0;
            this.buttonAtrasAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtrasAsignar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtrasAsignar.Image")));
            this.buttonAtrasAsignar.Location = new System.Drawing.Point(0, 1);
            this.buttonAtrasAsignar.Name = "buttonAtrasAsignar";
            this.buttonAtrasAsignar.Size = new System.Drawing.Size(45, 33);
            this.buttonAtrasAsignar.TabIndex = 6;
            this.buttonAtrasAsignar.UseVisualStyleBackColor = true;
            this.buttonAtrasAsignar.Click += new System.EventHandler(this.buttonAtrasAsignar_Click);
            // 
            // AsignarCamisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.buttonAtrasAsignar);
            this.Controls.Add(this.buttonBuscarCamisas);
            this.Controls.Add(this.comboBoxCamisasAsignar);
            this.Controls.Add(this.buttonAsignarCerrar);
            this.Controls.Add(this.buttonAsignarValoresCamisas);
            this.Controls.Add(this.dataGridViewAsignarValores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AsignarCamisas";
            this.Text = "AsignarValores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignarValores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAsignarValores;
        private System.Windows.Forms.Button buttonAsignarValoresCamisas;
        private System.Windows.Forms.Button buttonAsignarCerrar;
        private System.Windows.Forms.ComboBox comboBoxCamisasAsignar;
        private System.Windows.Forms.Button buttonBuscarCamisas;
        private System.Windows.Forms.Button buttonAtrasAsignar;
    }
}