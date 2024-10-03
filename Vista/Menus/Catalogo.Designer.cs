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
            this.panel1.SuspendLayout();
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
            this.panelLiga.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLiga.Location = new System.Drawing.Point(0, 55);
            this.panelLiga.Name = "panelLiga";
            this.panelLiga.Size = new System.Drawing.Size(200, 490);
            this.panelLiga.TabIndex = 11;
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1134, 545);
            this.Controls.Add(this.panelLiga);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Colombiana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Catalogo";
            this.Text = "Catalogo";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Colombiana;
        private System.Windows.Forms.Button buttonAtrasCliente;
        private System.Windows.Forms.Button buttonSalirCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLiga;
    }
}