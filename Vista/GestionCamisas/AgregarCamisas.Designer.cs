﻿namespace Vista
{
    partial class AgregarCamisas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCamisas));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAtrasCamisas = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewAgregarCamisas = new System.Windows.Forms.DataGridView();
            this.buttonRegistrarCamisas = new System.Windows.Forms.Button();
            this.buttonEliminarCamisas = new System.Windows.Forms.Button();
            this.buttonValoresCamisas = new System.Windows.Forms.Button();
            this.dataGridViewCamisas = new System.Windows.Forms.DataGridView();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.buttonFotoAñadir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStcok = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTela = new System.Windows.Forms.ComboBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.comboBoxEquipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxliga = new System.Windows.Forms.ComboBox();
            this.textBoxTalla = new System.Windows.Forms.TextBox();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgregarCamisas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamisas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "PRECIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "TALLA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buttonAtrasCamisas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 54);
            this.panel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(308, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "AGREGAR CAMISETAS ";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "TELA";
            // 
            // dataGridViewAgregarCamisas
            // 
            this.dataGridViewAgregarCamisas.AllowUserToAddRows = false;
            this.dataGridViewAgregarCamisas.AllowUserToDeleteRows = false;
            this.dataGridViewAgregarCamisas.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewAgregarCamisas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAgregarCamisas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewAgregarCamisas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewAgregarCamisas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgregarCamisas.Location = new System.Drawing.Point(60, 453);
            this.dataGridViewAgregarCamisas.Name = "dataGridViewAgregarCamisas";
            this.dataGridViewAgregarCamisas.ReadOnly = true;
            this.dataGridViewAgregarCamisas.Size = new System.Drawing.Size(650, 150);
            this.dataGridViewAgregarCamisas.TabIndex = 15;
            // 
            // buttonRegistrarCamisas
            // 
            this.buttonRegistrarCamisas.FlatAppearance.BorderSize = 0;
            this.buttonRegistrarCamisas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarCamisas.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarCamisas.Image = ((System.Drawing.Image)(resources.GetObject("buttonRegistrarCamisas.Image")));
            this.buttonRegistrarCamisas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegistrarCamisas.Location = new System.Drawing.Point(444, 78);
            this.buttonRegistrarCamisas.Name = "buttonRegistrarCamisas";
            this.buttonRegistrarCamisas.Size = new System.Drawing.Size(104, 40);
            this.buttonRegistrarCamisas.TabIndex = 26;
            this.buttonRegistrarCamisas.Text = "REGISTRAR";
            this.buttonRegistrarCamisas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRegistrarCamisas.UseVisualStyleBackColor = true;
            this.buttonRegistrarCamisas.Click += new System.EventHandler(this.buttonRegistrarCamisas_Click);
            // 
            // buttonEliminarCamisas
            // 
            this.buttonEliminarCamisas.FlatAppearance.BorderSize = 0;
            this.buttonEliminarCamisas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarCamisas.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarCamisas.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminarCamisas.Image")));
            this.buttonEliminarCamisas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminarCamisas.Location = new System.Drawing.Point(444, 281);
            this.buttonEliminarCamisas.Name = "buttonEliminarCamisas";
            this.buttonEliminarCamisas.Size = new System.Drawing.Size(104, 40);
            this.buttonEliminarCamisas.TabIndex = 27;
            this.buttonEliminarCamisas.Text = "ELIMINAR";
            this.buttonEliminarCamisas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEliminarCamisas.UseVisualStyleBackColor = true;
            this.buttonEliminarCamisas.Click += new System.EventHandler(this.buttonEliminarCamisas_Click);
            // 
            // buttonValoresCamisas
            // 
            this.buttonValoresCamisas.FlatAppearance.BorderSize = 0;
            this.buttonValoresCamisas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValoresCamisas.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValoresCamisas.Image = ((System.Drawing.Image)(resources.GetObject("buttonValoresCamisas.Image")));
            this.buttonValoresCamisas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonValoresCamisas.Location = new System.Drawing.Point(444, 141);
            this.buttonValoresCamisas.Name = "buttonValoresCamisas";
            this.buttonValoresCamisas.Size = new System.Drawing.Size(104, 40);
            this.buttonValoresCamisas.TabIndex = 28;
            this.buttonValoresCamisas.Text = "VALORES";
            this.buttonValoresCamisas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonValoresCamisas.UseVisualStyleBackColor = true;
            this.buttonValoresCamisas.Click += new System.EventHandler(this.buttonValoresCamisas_Click);
            // 
            // dataGridViewCamisas
            // 
            this.dataGridViewCamisas.AllowUserToAddRows = false;
            this.dataGridViewCamisas.AllowUserToDeleteRows = false;
            this.dataGridViewCamisas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCamisas.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewCamisas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCamisas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewCamisas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewCamisas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCamisas.Location = new System.Drawing.Point(12, 470);
            this.dataGridViewCamisas.Name = "dataGridViewCamisas";
            this.dataGridViewCamisas.ReadOnly = true;
            this.dataGridViewCamisas.RowHeadersVisible = false;
            this.dataGridViewCamisas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCamisas.Size = new System.Drawing.Size(741, 182);
            this.dataGridViewCamisas.TabIndex = 30;
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(618, 78);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(163, 118);
            this.pictureBoxFoto.TabIndex = 31;
            this.pictureBoxFoto.TabStop = false;
            // 
            // buttonFotoAñadir
            // 
            this.buttonFotoAñadir.FlatAppearance.BorderSize = 0;
            this.buttonFotoAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFotoAñadir.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFotoAñadir.Image = ((System.Drawing.Image)(resources.GetObject("buttonFotoAñadir.Image")));
            this.buttonFotoAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFotoAñadir.Location = new System.Drawing.Point(635, 206);
            this.buttonFotoAñadir.Name = "buttonFotoAñadir";
            this.buttonFotoAñadir.Size = new System.Drawing.Size(133, 40);
            this.buttonFotoAñadir.TabIndex = 32;
            this.buttonFotoAñadir.Text = "AÑADIR IMAGEN";
            this.buttonFotoAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFotoAñadir.UseVisualStyleBackColor = true;
            this.buttonFotoAñadir.Click += new System.EventHandler(this.buttonFotoAñadir_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 29);
            this.label5.TabIndex = 33;
            this.label5.Text = "STOCK";
            // 
            // textBoxStcok
            // 
            this.textBoxStcok.Location = new System.Drawing.Point(132, 302);
            this.textBoxStcok.Name = "textBoxStcok";
            this.textBoxStcok.Size = new System.Drawing.Size(130, 20);
            this.textBoxStcok.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "LIGA";
            // 
            // comboBoxTela
            // 
            this.comboBoxTela.FormattingEnabled = true;
            this.comboBoxTela.Location = new System.Drawing.Point(132, 255);
            this.comboBoxTela.Name = "comboBoxTela";
            this.comboBoxTela.Size = new System.Drawing.Size(130, 21);
            this.comboBoxTela.TabIndex = 14;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(132, 206);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(130, 20);
            this.textBoxPrecio.TabIndex = 40;
            // 
            // comboBoxEquipo
            // 
            this.comboBoxEquipo.FormattingEnabled = true;
            this.comboBoxEquipo.Location = new System.Drawing.Point(132, 121);
            this.comboBoxEquipo.Name = "comboBoxEquipo";
            this.comboBoxEquipo.Size = new System.Drawing.Size(130, 21);
            this.comboBoxEquipo.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "EQUIPO";
            // 
            // comboBoxliga
            // 
            this.comboBoxliga.FormattingEnabled = true;
            this.comboBoxliga.Location = new System.Drawing.Point(132, 78);
            this.comboBoxliga.Name = "comboBoxliga";
            this.comboBoxliga.Size = new System.Drawing.Size(130, 21);
            this.comboBoxliga.TabIndex = 45;
            // 
            // textBoxTalla
            // 
            this.textBoxTalla.Location = new System.Drawing.Point(132, 161);
            this.textBoxTalla.Name = "textBoxTalla";
            this.textBoxTalla.Size = new System.Drawing.Size(130, 20);
            this.textBoxTalla.TabIndex = 46;
            // 
            // buttonModificar
            // 
            this.buttonModificar.FlatAppearance.BorderSize = 0;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificar.Image")));
            this.buttonModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModificar.Location = new System.Drawing.Point(444, 215);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(104, 40);
            this.buttonModificar.TabIndex = 47;
            this.buttonModificar.Text = "MODIFICAR";
            this.buttonModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // AgregarCamisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(814, 677);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.textBoxTalla);
            this.Controls.Add(this.comboBoxliga);
            this.Controls.Add(this.comboBoxEquipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxStcok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonFotoAñadir);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.dataGridViewCamisas);
            this.Controls.Add(this.buttonValoresCamisas);
            this.Controls.Add(this.buttonEliminarCamisas);
            this.Controls.Add(this.buttonRegistrarCamisas);
            this.Controls.Add(this.dataGridViewAgregarCamisas);
            this.Controls.Add(this.comboBoxTela);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarCamisas";
            this.Text = "AgregarCamisetas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgregarCamisas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamisas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAtrasCamisas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewAgregarCamisas;
        private System.Windows.Forms.Button buttonRegistrarCamisas;
        private System.Windows.Forms.Button buttonEliminarCamisas;
        private System.Windows.Forms.Button buttonValoresCamisas;
        private System.Windows.Forms.DataGridView dataGridViewCamisas;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Button buttonFotoAñadir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStcok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTela;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.ComboBox comboBoxEquipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxliga;
        private System.Windows.Forms.TextBox textBoxTalla;
        private System.Windows.Forms.Button buttonModificar;
    }
}