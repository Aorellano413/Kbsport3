﻿namespace Vista
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
            this.dateTimePickerInforme1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewInforme = new System.Windows.Forms.DataGridView();
            this.buttonAtrasInforme = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.INFORME = new System.Windows.Forms.Button();
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
            this.ButtonRestblecerInforme.Location = new System.Drawing.Point(567, 64);
            this.ButtonRestblecerInforme.Name = "ButtonRestblecerInforme";
            this.ButtonRestblecerInforme.Size = new System.Drawing.Size(133, 38);
            this.ButtonRestblecerInforme.TabIndex = 0;
            this.ButtonRestblecerInforme.Text = "RESTABECER";
            this.ButtonRestblecerInforme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonRestblecerInforme.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerInforme1
            // 
            this.dateTimePickerInforme1.Location = new System.Drawing.Point(112, 78);
            this.dateTimePickerInforme1.Name = "dateTimePickerInforme1";
            this.dateTimePickerInforme1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerInforme1.TabIndex = 1;
            // 
            // dataGridViewInforme
            // 
            this.dataGridViewInforme.AllowUserToAddRows = false;
            this.dataGridViewInforme.AllowUserToDeleteRows = false;
            this.dataGridViewInforme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInforme.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewInforme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewInforme.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewInforme.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewInforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInforme.Location = new System.Drawing.Point(23, 129);
            this.dataGridViewInforme.Name = "dataGridViewInforme";
            this.dataGridViewInforme.ReadOnly = true;
            this.dataGridViewInforme.RowHeadersVisible = false;
            this.dataGridViewInforme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInforme.Size = new System.Drawing.Size(677, 372);
            this.dataGridViewInforme.TabIndex = 2;
            // 
            // buttonAtrasInforme
            // 
            this.buttonAtrasInforme.FlatAppearance.BorderSize = 0;
            this.buttonAtrasInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtrasInforme.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtrasInforme.Image")));
            this.buttonAtrasInforme.Location = new System.Drawing.Point(12, 9);
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
            this.panel1.Size = new System.Drawing.Size(741, 51);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "INFORME MENUSAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "FILTRAR:";
            // 
            // INFORME
            // 
            this.INFORME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.INFORME.FlatAppearance.BorderSize = 0;
            this.INFORME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.INFORME.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INFORME.Image = ((System.Drawing.Image)(resources.GetObject("INFORME.Image")));
            this.INFORME.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.INFORME.Location = new System.Drawing.Point(334, 64);
            this.INFORME.Name = "INFORME";
            this.INFORME.Size = new System.Drawing.Size(135, 51);
            this.INFORME.TabIndex = 6;
            this.INFORME.Text = "GENERAR INFORME";
            this.INFORME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.INFORME.UseVisualStyleBackColor = true;
            this.INFORME.Click += new System.EventHandler(this.INFORME_Click);
            // 
            // InformeEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(741, 528);
            this.Controls.Add(this.INFORME);
            this.Controls.Add(this.ButtonRestblecerInforme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewInforme);
            this.Controls.Add(this.dateTimePickerInforme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformeEmpresa";
            this.Text = "InformeEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInforme)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonRestblecerInforme;
        private System.Windows.Forms.DateTimePicker dateTimePickerInforme1;
        private System.Windows.Forms.DataGridView dataGridViewInforme;
        private System.Windows.Forms.Button buttonAtrasInforme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button INFORME;
    }
}