﻿namespace Vista
{
    partial class EliminarTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarTela));
            this.dataGridViewEliminarTela = new System.Windows.Forms.DataGridView();
            this.buttonEliminarTela = new System.Windows.Forms.Button();
            this.textBoxBuscarTela = new System.Windows.Forms.TextBox();
            this.buttonAtrasTela = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEliminarTela)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEliminarTela
            // 
            this.dataGridViewEliminarTela.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewEliminarTela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEliminarTela.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewEliminarTela.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewEliminarTela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEliminarTela.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewEliminarTela.Name = "dataGridViewEliminarTela";
            this.dataGridViewEliminarTela.Size = new System.Drawing.Size(541, 260);
            this.dataGridViewEliminarTela.TabIndex = 0;
            // 
            // buttonEliminarTela
            // 
            this.buttonEliminarTela.FlatAppearance.BorderSize = 0;
            this.buttonEliminarTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarTela.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarTela.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminarTela.Image")));
            this.buttonEliminarTela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminarTela.Location = new System.Drawing.Point(162, 346);
            this.buttonEliminarTela.Name = "buttonEliminarTela";
            this.buttonEliminarTela.Size = new System.Drawing.Size(231, 83);
            this.buttonEliminarTela.TabIndex = 1;
            this.buttonEliminarTela.Text = "ELIMINAR TELA";
            this.buttonEliminarTela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEliminarTela.UseVisualStyleBackColor = true;
            this.buttonEliminarTela.Click += new System.EventHandler(this.buttonEliminarTela_Click);
            // 
            // textBoxBuscarTela
            // 
            this.textBoxBuscarTela.Location = new System.Drawing.Point(12, 28);
            this.textBoxBuscarTela.Name = "textBoxBuscarTela";
            this.textBoxBuscarTela.Size = new System.Drawing.Size(135, 20);
            this.textBoxBuscarTela.TabIndex = 2;
            // 
            // buttonAtrasTela
            // 
            this.buttonAtrasTela.FlatAppearance.BorderSize = 0;
            this.buttonAtrasTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtrasTela.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtrasTela.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtrasTela.Image")));
            this.buttonAtrasTela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAtrasTela.Location = new System.Drawing.Point(517, 2);
            this.buttonAtrasTela.Name = "buttonAtrasTela";
            this.buttonAtrasTela.Size = new System.Drawing.Size(36, 36);
            this.buttonAtrasTela.TabIndex = 3;
            this.buttonAtrasTela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAtrasTela.UseVisualStyleBackColor = true;
            this.buttonAtrasTela.Click += new System.EventHandler(this.buttonAtrasTela_Click);
            // 
            // EliminarTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.buttonAtrasTela);
            this.Controls.Add(this.textBoxBuscarTela);
            this.Controls.Add(this.buttonEliminarTela);
            this.Controls.Add(this.dataGridViewEliminarTela);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarTela";
            this.Text = "EliminarTela";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEliminarTela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEliminarTela;
        private System.Windows.Forms.Button buttonEliminarTela;
        private System.Windows.Forms.TextBox textBoxBuscarTela;
        private System.Windows.Forms.Button buttonAtrasTela;
    }
}