﻿namespace Vista
{
    partial class Equipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAtrasEquipo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEquipo = new System.Windows.Forms.TextBox();
            this.buttonAceptarEquipo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBorrarEquipo = new System.Windows.Forms.Button();
            this.dataGridViewEquipo = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.buttonAtrasEquipo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 43);
            this.panel1.TabIndex = 0;
            // 
            // buttonAtrasEquipo
            // 
            this.buttonAtrasEquipo.FlatAppearance.BorderSize = 0;
            this.buttonAtrasEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtrasEquipo.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtrasEquipo.Image")));
            this.buttonAtrasEquipo.Location = new System.Drawing.Point(3, 4);
            this.buttonAtrasEquipo.Name = "buttonAtrasEquipo";
            this.buttonAtrasEquipo.Size = new System.Drawing.Size(32, 36);
            this.buttonAtrasEquipo.TabIndex = 5;
            this.buttonAtrasEquipo.UseVisualStyleBackColor = true;
            this.buttonAtrasEquipo.Click += new System.EventHandler(this.buttonAtrasEquipo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "EQUIPO DE FUTBOL";
            // 
            // textBoxEquipo
            // 
            this.textBoxEquipo.Location = new System.Drawing.Point(290, 90);
            this.textBoxEquipo.Name = "textBoxEquipo";
            this.textBoxEquipo.Size = new System.Drawing.Size(140, 20);
            this.textBoxEquipo.TabIndex = 2;
            // 
            // buttonAceptarEquipo
            // 
            this.buttonAceptarEquipo.FlatAppearance.BorderSize = 0;
            this.buttonAceptarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptarEquipo.Image = ((System.Drawing.Image)(resources.GetObject("buttonAceptarEquipo.Image")));
            this.buttonAceptarEquipo.Location = new System.Drawing.Point(454, 81);
            this.buttonAceptarEquipo.Name = "buttonAceptarEquipo";
            this.buttonAceptarEquipo.Size = new System.Drawing.Size(37, 36);
            this.buttonAceptarEquipo.TabIndex = 3;
            this.buttonAceptarEquipo.UseVisualStyleBackColor = true;
            this.buttonAceptarEquipo.Click += new System.EventHandler(this.buttonAceptarEquipo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE DE EQUIPO DE FUTBOL:\r\n";
            // 
            // buttonBorrarEquipo
            // 
            this.buttonBorrarEquipo.FlatAppearance.BorderSize = 0;
            this.buttonBorrarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrarEquipo.Image = ((System.Drawing.Image)(resources.GetObject("buttonBorrarEquipo.Image")));
            this.buttonBorrarEquipo.Location = new System.Drawing.Point(537, 82);
            this.buttonBorrarEquipo.Name = "buttonBorrarEquipo";
            this.buttonBorrarEquipo.Size = new System.Drawing.Size(37, 36);
            this.buttonBorrarEquipo.TabIndex = 4;
            this.buttonBorrarEquipo.UseVisualStyleBackColor = true;
            this.buttonBorrarEquipo.Click += new System.EventHandler(this.buttonBorrarEquipo_Click);
            // 
            // dataGridViewEquipo
            // 
            this.dataGridViewEquipo.AllowUserToAddRows = false;
            this.dataGridViewEquipo.AllowUserToDeleteRows = false;
            this.dataGridViewEquipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEquipo.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewEquipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEquipo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewEquipo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipo.Location = new System.Drawing.Point(36, 135);
            this.dataGridViewEquipo.Name = "dataGridViewEquipo";
            this.dataGridViewEquipo.ReadOnly = true;
            this.dataGridViewEquipo.RowHeadersVisible = false;
            this.dataGridViewEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEquipo.Size = new System.Drawing.Size(694, 181);
            this.dataGridViewEquipo.TabIndex = 19;
            // 
            // Equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(784, 368);
            this.Controls.Add(this.dataGridViewEquipo);
            this.Controls.Add(this.buttonBorrarEquipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAceptarEquipo);
            this.Controls.Add(this.textBoxEquipo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Equipo";
            this.Text = "Equipo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEquipo;
        private System.Windows.Forms.Button buttonAceptarEquipo;
        private System.Windows.Forms.Button buttonAtrasEquipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBorrarEquipo;
        private System.Windows.Forms.DataGridView dataGridViewEquipo;
    }
}