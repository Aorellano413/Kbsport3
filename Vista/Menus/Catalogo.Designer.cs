﻿namespace Vista
{
    partial class Catalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogo));
            this.flowLayoutPanelCamisasVentas = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAtrasCliente = new System.Windows.Forms.Button();
            this.buttonSalirCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLiga = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRestablecerCatalogo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFiltrar = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.labelTotalApagar = new System.Windows.Forms.Label();
            this.labelEfectivo = new System.Windows.Forms.Label();
            this.labelPagar = new System.Windows.Forms.Label();
            this.labelCambioRegreso = new System.Windows.Forms.Label();
            this.labelCambio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelLiga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelCamisasVentas
            // 
            this.flowLayoutPanelCamisasVentas.Location = new System.Drawing.Point(206, 74);
            this.flowLayoutPanelCamisasVentas.Name = "flowLayoutPanelCamisasVentas";
            this.flowLayoutPanelCamisasVentas.Size = new System.Drawing.Size(916, 474);
            this.flowLayoutPanelCamisasVentas.TabIndex = 0;
            // 
            // buttonAtrasCliente
            // 
            this.buttonAtrasCliente.FlatAppearance.BorderSize = 0;
            this.buttonAtrasCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtrasCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtrasCliente.Image")));
            this.buttonAtrasCliente.Location = new System.Drawing.Point(3, 9);
            this.buttonAtrasCliente.Name = "buttonAtrasCliente";
            this.buttonAtrasCliente.Size = new System.Drawing.Size(47, 32);
            this.buttonAtrasCliente.TabIndex = 8;
            this.buttonAtrasCliente.UseVisualStyleBackColor = true;
            this.buttonAtrasCliente.Click += new System.EventHandler(this.buttonAtrasCliente_Click);
            // 
            // buttonSalirCliente
            // 
            this.buttonSalirCliente.FlatAppearance.BorderSize = 0;
            this.buttonSalirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalirCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalirCliente.Image")));
            this.buttonSalirCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalirCliente.Location = new System.Drawing.Point(1083, 12);
            this.buttonSalirCliente.Name = "buttonSalirCliente";
            this.buttonSalirCliente.Size = new System.Drawing.Size(39, 29);
            this.buttonSalirCliente.TabIndex = 9;
            this.buttonSalirCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalirCliente.UseVisualStyleBackColor = true;
            this.buttonSalirCliente.Click += new System.EventHandler(this.buttonSalirCliente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonSalirCliente);
            this.panel1.Controls.Add(this.buttonAtrasCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 55);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "CATALOGO CLIENTE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelLiga
            // 
            this.panelLiga.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLiga.Controls.Add(this.label3);
            this.panelLiga.Controls.Add(this.pictureBox3);
            this.panelLiga.Controls.Add(this.label4);
            this.panelLiga.Controls.Add(this.pictureBox2);
            this.panelLiga.Controls.Add(this.pictureBox1);
            this.panelLiga.Controls.Add(this.buttonRestablecerCatalogo);
            this.panelLiga.Controls.Add(this.label1);
            this.panelLiga.Controls.Add(this.textBoxFiltrar);
            this.panelLiga.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLiga.Location = new System.Drawing.Point(0, 55);
            this.panelLiga.Name = "panelLiga";
            this.panelLiga.Size = new System.Drawing.Size(200, 580);
            this.panelLiga.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "301 5318600";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(23, 191);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Kb_sport3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 270);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRestablecerCatalogo
            // 
            this.buttonRestablecerCatalogo.FlatAppearance.BorderSize = 0;
            this.buttonRestablecerCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestablecerCatalogo.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestablecerCatalogo.Image = ((System.Drawing.Image)(resources.GetObject("buttonRestablecerCatalogo.Image")));
            this.buttonRestablecerCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRestablecerCatalogo.Location = new System.Drawing.Point(17, 19);
            this.buttonRestablecerCatalogo.Name = "buttonRestablecerCatalogo";
            this.buttonRestablecerCatalogo.Size = new System.Drawing.Size(138, 34);
            this.buttonRestablecerCatalogo.TabIndex = 0;
            this.buttonRestablecerCatalogo.Text = "Restablecer";
            this.buttonRestablecerCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRestablecerCatalogo.UseVisualStyleBackColor = true;
            this.buttonRestablecerCatalogo.Click += new System.EventHandler(this.buttonRestablecerCatalogo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Busqueda por liga:";
            // 
            // textBoxFiltrar
            // 
            this.textBoxFiltrar.Location = new System.Drawing.Point(17, 109);
            this.textBoxFiltrar.Name = "textBoxFiltrar";
            this.textBoxFiltrar.Size = new System.Drawing.Size(152, 20);
            this.textBoxFiltrar.TabIndex = 25;
            this.textBoxFiltrar.TextChanged += new System.EventHandler(this.textBoxFiltrar_TextChanged);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.FlatAppearance.BorderSize = 0;
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfirmar.Image")));
            this.buttonConfirmar.Location = new System.Drawing.Point(1068, 572);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(45, 42);
            this.buttonConfirmar.TabIndex = 17;
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(621, 584);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(100, 20);
            this.txtEfectivo.TabIndex = 21;
            // 
            // labelTotalApagar
            // 
            this.labelTotalApagar.AutoSize = true;
            this.labelTotalApagar.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalApagar.Location = new System.Drawing.Point(347, 574);
            this.labelTotalApagar.Name = "labelTotalApagar";
            this.labelTotalApagar.Size = new System.Drawing.Size(23, 29);
            this.labelTotalApagar.TabIndex = 20;
            this.labelTotalApagar.Text = "0";
            // 
            // labelEfectivo
            // 
            this.labelEfectivo.AutoSize = true;
            this.labelEfectivo.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEfectivo.Location = new System.Drawing.Point(511, 574);
            this.labelEfectivo.Name = "labelEfectivo";
            this.labelEfectivo.Size = new System.Drawing.Size(97, 29);
            this.labelEfectivo.TabIndex = 18;
            this.labelEfectivo.Text = "EFECTIVO  :";
            // 
            // labelPagar
            // 
            this.labelPagar.AutoSize = true;
            this.labelPagar.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagar.Location = new System.Drawing.Point(206, 574);
            this.labelPagar.Name = "labelPagar";
            this.labelPagar.Size = new System.Drawing.Size(140, 29);
            this.labelPagar.TabIndex = 19;
            this.labelPagar.Text = "TOTAL A PAGAR :";
            // 
            // labelCambioRegreso
            // 
            this.labelCambioRegreso.AutoSize = true;
            this.labelCambioRegreso.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambioRegreso.Location = new System.Drawing.Point(880, 575);
            this.labelCambioRegreso.Name = "labelCambioRegreso";
            this.labelCambioRegreso.Size = new System.Drawing.Size(23, 29);
            this.labelCambioRegreso.TabIndex = 23;
            this.labelCambioRegreso.Text = "0";
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambio.Location = new System.Drawing.Point(787, 575);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(75, 29);
            this.labelCambio.TabIndex = 22;
            this.labelCambio.Text = "CAMBIO:";
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1134, 635);
            this.Controls.Add(this.labelCambioRegreso);
            this.Controls.Add(this.labelCambio);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.labelTotalApagar);
            this.Controls.Add(this.labelEfectivo);
            this.Controls.Add(this.labelPagar);
            this.Controls.Add(this.panelLiga);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanelCamisasVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Catalogo";
            this.Text = "Catalogo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLiga.ResumeLayout(false);
            this.panelLiga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCamisasVentas;
        private System.Windows.Forms.Button buttonAtrasCliente;
        private System.Windows.Forms.Button buttonSalirCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLiga;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label labelTotalApagar;
        private System.Windows.Forms.Label labelEfectivo;
        private System.Windows.Forms.Label labelPagar;
        private System.Windows.Forms.Label labelCambioRegreso;
        private System.Windows.Forms.Label labelCambio;
        private System.Windows.Forms.TextBox textBoxFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRestablecerCatalogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}