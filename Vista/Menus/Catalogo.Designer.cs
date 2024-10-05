namespace Vista
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
            this.Colombiana = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAtrasCliente = new System.Windows.Forms.Button();
            this.buttonSalirCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLiga = new System.Windows.Forms.Panel();
            this.buttonitalia = new System.Windows.Forms.Button();
            this.buttonEspaña = new System.Windows.Forms.Button();
            this.buttonInglaterra = new System.Windows.Forms.Button();
            this.buttonColombia = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.labelTotalApagar = new System.Windows.Forms.Label();
            this.labelEfectivo = new System.Windows.Forms.Label();
            this.labelPagar = new System.Windows.Forms.Label();
            this.labelCambioRegreso = new System.Windows.Forms.Label();
            this.labelCambio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelLiga.SuspendLayout();
            this.SuspendLayout();
            // 
            // Colombiana
            // 
            this.Colombiana.Location = new System.Drawing.Point(206, 74);
            this.Colombiana.Name = "Colombiana";
            this.Colombiana.Size = new System.Drawing.Size(916, 371);
            this.Colombiana.TabIndex = 0;
            // 
            // buttonAtrasCliente
            // 
            this.buttonAtrasCliente.FlatAppearance.BorderSize = 0;
            this.buttonAtrasCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtrasCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtrasCliente.Image")));
            this.buttonAtrasCliente.Location = new System.Drawing.Point(1030, 5);
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
            this.buttonSalirCliente.Location = new System.Drawing.Point(1083, 5);
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
            this.panel1.Controls.Add(this.buttonSalirCliente);
            this.panel1.Controls.Add(this.buttonAtrasCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 55);
            this.panel1.TabIndex = 10;
            // 
            // panelLiga
            // 
            this.panelLiga.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLiga.Controls.Add(this.buttonitalia);
            this.panelLiga.Controls.Add(this.buttonEspaña);
            this.panelLiga.Controls.Add(this.buttonInglaterra);
            this.panelLiga.Controls.Add(this.buttonColombia);
            this.panelLiga.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLiga.Location = new System.Drawing.Point(0, 55);
            this.panelLiga.Name = "panelLiga";
            this.panelLiga.Size = new System.Drawing.Size(200, 580);
            this.panelLiga.TabIndex = 11;
            // 
            // buttonitalia
            // 
            this.buttonitalia.FlatAppearance.BorderSize = 0;
            this.buttonitalia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonitalia.Location = new System.Drawing.Point(3, 435);
            this.buttonitalia.Name = "buttonitalia";
            this.buttonitalia.Size = new System.Drawing.Size(194, 139);
            this.buttonitalia.TabIndex = 3;
            this.buttonitalia.UseVisualStyleBackColor = true;
            // 
            // buttonEspaña
            // 
            this.buttonEspaña.FlatAppearance.BorderSize = 0;
            this.buttonEspaña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEspaña.Location = new System.Drawing.Point(3, 290);
            this.buttonEspaña.Name = "buttonEspaña";
            this.buttonEspaña.Size = new System.Drawing.Size(194, 139);
            this.buttonEspaña.TabIndex = 2;
            this.buttonEspaña.UseVisualStyleBackColor = true;
            // 
            // buttonInglaterra
            // 
            this.buttonInglaterra.FlatAppearance.BorderSize = 0;
            this.buttonInglaterra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInglaterra.Location = new System.Drawing.Point(3, 145);
            this.buttonInglaterra.Name = "buttonInglaterra";
            this.buttonInglaterra.Size = new System.Drawing.Size(194, 139);
            this.buttonInglaterra.TabIndex = 1;
            this.buttonInglaterra.UseVisualStyleBackColor = true;
            // 
            // buttonColombia
            // 
            this.buttonColombia.FlatAppearance.BorderSize = 0;
            this.buttonColombia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColombia.Location = new System.Drawing.Point(3, 0);
            this.buttonColombia.Name = "buttonColombia";
            this.buttonColombia.Size = new System.Drawing.Size(194, 139);
            this.buttonColombia.TabIndex = 0;
            this.buttonColombia.UseVisualStyleBackColor = true;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.FlatAppearance.BorderSize = 0;
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfirmar.Image")));
            this.buttonConfirmar.Location = new System.Drawing.Point(206, 587);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(45, 42);
            this.buttonConfirmar.TabIndex = 17;
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(352, 516);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(100, 20);
            this.txtEfectivo.TabIndex = 21;
            // 
            // labelTotalApagar
            // 
            this.labelTotalApagar.AutoSize = true;
            this.labelTotalApagar.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalApagar.Location = new System.Drawing.Point(347, 455);
            this.labelTotalApagar.Name = "labelTotalApagar";
            this.labelTotalApagar.Size = new System.Drawing.Size(23, 29);
            this.labelTotalApagar.TabIndex = 20;
            this.labelTotalApagar.Text = "0";
            // 
            // labelEfectivo
            // 
            this.labelEfectivo.AutoSize = true;
            this.labelEfectivo.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEfectivo.Location = new System.Drawing.Point(206, 507);
            this.labelEfectivo.Name = "labelEfectivo";
            this.labelEfectivo.Size = new System.Drawing.Size(97, 29);
            this.labelEfectivo.TabIndex = 18;
            this.labelEfectivo.Text = "EFECTIVO  :";
            // 
            // labelPagar
            // 
            this.labelPagar.AutoSize = true;
            this.labelPagar.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagar.Location = new System.Drawing.Point(206, 455);
            this.labelPagar.Name = "labelPagar";
            this.labelPagar.Size = new System.Drawing.Size(140, 29);
            this.labelPagar.TabIndex = 19;
            this.labelPagar.Text = "TOTAL A PAGAR :";
            // 
            // labelCambioRegreso
            // 
            this.labelCambioRegreso.AutoSize = true;
            this.labelCambioRegreso.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambioRegreso.Location = new System.Drawing.Point(347, 555);
            this.labelCambioRegreso.Name = "labelCambioRegreso";
            this.labelCambioRegreso.Size = new System.Drawing.Size(23, 29);
            this.labelCambioRegreso.TabIndex = 23;
            this.labelCambioRegreso.Text = "0";
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambio.Location = new System.Drawing.Point(206, 555);
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
            this.Controls.Add(this.Colombiana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Catalogo";
            this.Text = "Catalogo";
            this.panel1.ResumeLayout(false);
            this.panelLiga.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Colombiana;
        private System.Windows.Forms.Button buttonAtrasCliente;
        private System.Windows.Forms.Button buttonSalirCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLiga;
        private System.Windows.Forms.Button buttonEspaña;
        private System.Windows.Forms.Button buttonInglaterra;
        private System.Windows.Forms.Button buttonitalia;
        private System.Windows.Forms.Button buttonColombia;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label labelTotalApagar;
        private System.Windows.Forms.Label labelEfectivo;
        private System.Windows.Forms.Label labelPagar;
        private System.Windows.Forms.Label labelCambioRegreso;
        private System.Windows.Forms.Label labelCambio;
    }
}