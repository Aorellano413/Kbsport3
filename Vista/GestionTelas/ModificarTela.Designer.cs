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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonModificarTela = new System.Windows.Forms.Button();
            this.buttonAtrasModificarTelas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBuscarModificarTela
            // 
            this.textBoxBuscarModificarTela.Location = new System.Drawing.Point(12, 40);
            this.textBoxBuscarModificarTela.Name = "textBoxBuscarModificarTela";
            this.textBoxBuscarModificarTela.Size = new System.Drawing.Size(126, 20);
            this.textBoxBuscarModificarTela.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 196);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonModificarTela
            // 
            this.buttonModificarTela.FlatAppearance.BorderSize = 0;
            this.buttonModificarTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificarTela.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarTela.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificarTela.Image")));
            this.buttonModificarTela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModificarTela.Location = new System.Drawing.Point(186, 340);
            this.buttonModificarTela.Name = "buttonModificarTela";
            this.buttonModificarTela.Size = new System.Drawing.Size(172, 77);
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
            this.buttonAtrasModificarTelas.Location = new System.Drawing.Point(520, 2);
            this.buttonAtrasModificarTelas.Name = "buttonAtrasModificarTelas";
            this.buttonAtrasModificarTelas.Size = new System.Drawing.Size(38, 35);
            this.buttonAtrasModificarTelas.TabIndex = 4;
            this.buttonAtrasModificarTelas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAtrasModificarTelas.UseVisualStyleBackColor = true;
            this.buttonAtrasModificarTelas.Click += new System.EventHandler(this.buttonAtrasModificarTelas_Click);
            // 
            // ModificarTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.buttonAtrasModificarTelas);
            this.Controls.Add(this.buttonModificarTela);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxBuscarModificarTela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarTela";
            this.Text = "ModificarTela";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxBuscarModificarTela;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonModificarTela;
        private System.Windows.Forms.Button buttonAtrasModificarTelas;
    }
}