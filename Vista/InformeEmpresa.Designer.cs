namespace Vista
{
    partial class InformeEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformeEmpresa));
            this.ButtonRestblecerInforme = new System.Windows.Forms.Button();
            this.dateTimePickerInforme = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewInforme = new System.Windows.Forms.DataGridView();
            this.buttonAtrasInforme = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInforme)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonRestblecerInforme
            // 
            this.ButtonRestblecerInforme.FlatAppearance.BorderSize = 0;
            this.ButtonRestblecerInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRestblecerInforme.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRestblecerInforme.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRestblecerInforme.Image")));
            this.ButtonRestblecerInforme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonRestblecerInforme.Location = new System.Drawing.Point(268, 55);
            this.ButtonRestblecerInforme.Name = "ButtonRestblecerInforme";
            this.ButtonRestblecerInforme.Size = new System.Drawing.Size(133, 38);
            this.ButtonRestblecerInforme.TabIndex = 0;
            this.ButtonRestblecerInforme.Text = "RESTABECER";
            this.ButtonRestblecerInforme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonRestblecerInforme.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerInforme
            // 
            this.dateTimePickerInforme.Location = new System.Drawing.Point(52, 65);
            this.dateTimePickerInforme.Name = "dateTimePickerInforme";
            this.dateTimePickerInforme.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerInforme.TabIndex = 1;
            // 
            // dataGridViewInforme
            // 
            this.dataGridViewInforme.AllowUserToAddRows = false;
            this.dataGridViewInforme.AllowUserToDeleteRows = false;
            this.dataGridViewInforme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInforme.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewInforme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewInforme.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewInforme.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewInforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInforme.Location = new System.Drawing.Point(52, 99);
            this.dataGridViewInforme.Name = "dataGridViewInforme";
            this.dataGridViewInforme.ReadOnly = true;
            this.dataGridViewInforme.RowHeadersVisible = false;
            this.dataGridViewInforme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInforme.Size = new System.Drawing.Size(420, 319);
            this.dataGridViewInforme.TabIndex = 2;
            // 
            // buttonAtrasInforme
            // 
            this.buttonAtrasInforme.FlatAppearance.BorderSize = 0;
            this.buttonAtrasInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtrasInforme.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtrasInforme.Image")));
            this.buttonAtrasInforme.Location = new System.Drawing.Point(532, 3);
            this.buttonAtrasInforme.Name = "buttonAtrasInforme";
            this.buttonAtrasInforme.Size = new System.Drawing.Size(37, 29);
            this.buttonAtrasInforme.TabIndex = 3;
            this.buttonAtrasInforme.UseVisualStyleBackColor = true;
            this.buttonAtrasInforme.Click += new System.EventHandler(this.buttonAtrasInforme_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonAtrasInforme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 51);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "INFORME";
            // 
            // InformeEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewInforme);
            this.Controls.Add(this.dateTimePickerInforme);
            this.Controls.Add(this.ButtonRestblecerInforme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformeEmpresa";
            this.Text = "InformeEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInforme)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonRestblecerInforme;
        private System.Windows.Forms.DateTimePicker dateTimePickerInforme;
        private System.Windows.Forms.DataGridView dataGridViewInforme;
        private System.Windows.Forms.Button buttonAtrasInforme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}