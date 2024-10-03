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
            this.flowLayoutPanelCamisas = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAtrasCliente = new System.Windows.Forms.Button();
            this.buttonSalirCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelCamisas
            // 
            this.flowLayoutPanelCamisas.Location = new System.Drawing.Point(12, 61);
            this.flowLayoutPanelCamisas.Name = "flowLayoutPanelCamisas";
            this.flowLayoutPanelCamisas.Size = new System.Drawing.Size(881, 371);
            this.flowLayoutPanelCamisas.TabIndex = 0;
            // 
            // buttonAtrasCliente
            // 
            this.buttonAtrasCliente.FlatAppearance.BorderSize = 0;
            this.buttonAtrasCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtrasCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtrasCliente.Image")));
            this.buttonAtrasCliente.Location = new System.Drawing.Point(801, 12);
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
            this.buttonSalirCliente.Location = new System.Drawing.Point(854, 14);
            this.buttonSalirCliente.Name = "buttonSalirCliente";
            this.buttonSalirCliente.Size = new System.Drawing.Size(39, 29);
            this.buttonSalirCliente.TabIndex = 9;
            this.buttonSalirCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalirCliente.UseVisualStyleBackColor = true;
            this.buttonSalirCliente.Click += new System.EventHandler(this.buttonSalirCliente_Click);
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(905, 545);
            this.Controls.Add(this.buttonSalirCliente);
            this.Controls.Add(this.buttonAtrasCliente);
            this.Controls.Add(this.flowLayoutPanelCamisas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Catalogo";
            this.Text = "Catalogo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCamisas;
        private System.Windows.Forms.Button buttonAtrasCliente;
        private System.Windows.Forms.Button buttonSalirCliente;
    }
}