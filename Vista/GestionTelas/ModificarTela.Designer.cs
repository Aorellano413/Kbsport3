﻿namespace Vista
{
    partial class ModificarTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarTela));
            this.textBoxBuscarModificarTela = new System.Windows.Forms.TextBox();
            this.dataGridViewModificarTelas = new System.Windows.Forms.DataGridView();
            this.buttonModificarTela = new System.Windows.Forms.Button();
            this.buttonAtrasModificarTelas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificarTelas)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBuscarModificarTela
            // 
            this.textBoxBuscarModificarTela.Location = new System.Drawing.Point(12, 94);
            this.textBoxBuscarModificarTela.Name = "textBoxBuscarModificarTela";
            this.textBoxBuscarModificarTela.Size = new System.Drawing.Size(126, 20);
            this.textBoxBuscarModificarTela.TabIndex = 1;
            this.textBoxBuscarModificarTela.TextChanged += new System.EventHandler(this.textBoxBuscarModificarTela_TextChanged);
            // 
            // dataGridViewModificarTelas
            // 
            this.dataGridViewModificarTelas.AllowUserToAddRows = false;
            this.dataGridViewModificarTelas.AllowUserToDeleteRows = false;
            this.dataGridViewModificarTelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewModificarTelas.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewModificarTelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewModificarTelas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewModificarTelas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewModificarTelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModificarTelas.Location = new System.Drawing.Point(12, 130);
            this.dataGridViewModificarTelas.Name = "dataGridViewModificarTelas";
            this.dataGridViewModificarTelas.RowHeadersVisible = false;
            this.dataGridViewModificarTelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewModificarTelas.Size = new System.Drawing.Size(546, 196);
            this.dataGridViewModificarTelas.TabIndex = 2;
            // 
            // buttonModificarTela
            // 
            this.buttonModificarTela.FlatAppearance.BorderSize = 0;
            this.buttonModificarTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificarTela.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarTela.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificarTela.Image")));
            this.buttonModificarTela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModificarTela.Location = new System.Drawing.Point(398, 24);
            this.buttonModificarTela.Name = "buttonModificarTela";
            this.buttonModificarTela.Size = new System.Drawing.Size(151, 70);
            this.buttonModificarTela.TabIndex = 3;
            this.buttonModificarTela.Text = "Modificar";
            this.buttonModificarTela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonModificarTela.UseVisualStyleBackColor = true;
            this.buttonModificarTela.Click += new System.EventHandler(this.buttonModificarTela_Click);
            // 
            // buttonAtrasModificarTelas
            // 
            this.buttonAtrasModificarTelas.FlatAppearance.BorderSize = 0;
            this.buttonAtrasModificarTelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtrasModificarTelas.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtrasModificarTelas.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtrasModificarTelas.Image")));
            this.buttonAtrasModificarTelas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAtrasModificarTelas.Location = new System.Drawing.Point(2, 1);
            this.buttonAtrasModificarTelas.Name = "buttonAtrasModificarTelas";
            this.buttonAtrasModificarTelas.Size = new System.Drawing.Size(38, 35);
            this.buttonAtrasModificarTelas.TabIndex = 4;
            this.buttonAtrasModificarTelas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAtrasModificarTelas.UseVisualStyleBackColor = true;
            this.buttonAtrasModificarTelas.Click += new System.EventHandler(this.buttonAtrasModificarTelas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "BUSCAR TELA";
            // 
            // ModificarTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAtrasModificarTelas);
            this.Controls.Add(this.buttonModificarTela);
            this.Controls.Add(this.dataGridViewModificarTelas);
            this.Controls.Add(this.textBoxBuscarModificarTela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarTela";
            this.Text = "ModificarTela";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificarTelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxBuscarModificarTela;
        private System.Windows.Forms.DataGridView dataGridViewModificarTelas;
        private System.Windows.Forms.Button buttonModificarTela;
        private System.Windows.Forms.Button buttonAtrasModificarTelas;
        private System.Windows.Forms.Label label1;
    }
}