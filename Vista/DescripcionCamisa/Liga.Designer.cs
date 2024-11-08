namespace Vista
{
    partial class Liga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Liga));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRegresarliga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBorrarLiga = new System.Windows.Forms.Button();
            this.buttonAceptarLiga = new System.Windows.Forms.Button();
            this.txtLiga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.buttonRegresarliga);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 43);
            this.panel1.TabIndex = 0;
            // 
            // buttonRegresarliga
            // 
            this.buttonRegresarliga.FlatAppearance.BorderSize = 0;
            this.buttonRegresarliga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegresarliga.Image = ((System.Drawing.Image)(resources.GetObject("buttonRegresarliga.Image")));
            this.buttonRegresarliga.Location = new System.Drawing.Point(517, 1);
            this.buttonRegresarliga.Name = "buttonRegresarliga";
            this.buttonRegresarliga.Size = new System.Drawing.Size(43, 39);
            this.buttonRegresarliga.TabIndex = 12;
            this.buttonRegresarliga.UseVisualStyleBackColor = true;
            this.buttonRegresarliga.Click += new System.EventHandler(this.buttonRegresarliga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "LIGA DE EQUIPO DE FUTBOL";
            // 
            // buttonBorrarLiga
            // 
            this.buttonBorrarLiga.FlatAppearance.BorderSize = 0;
            this.buttonBorrarLiga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrarLiga.Image = ((System.Drawing.Image)(resources.GetObject("buttonBorrarLiga.Image")));
            this.buttonBorrarLiga.Location = new System.Drawing.Point(376, 141);
            this.buttonBorrarLiga.Name = "buttonBorrarLiga";
            this.buttonBorrarLiga.Size = new System.Drawing.Size(37, 39);
            this.buttonBorrarLiga.TabIndex = 10;
            this.buttonBorrarLiga.UseVisualStyleBackColor = true;
            this.buttonBorrarLiga.Click += new System.EventHandler(this.buttonBorrarLiga_Click);
            // 
            // buttonAceptarLiga
            // 
            this.buttonAceptarLiga.FlatAppearance.BorderSize = 0;
            this.buttonAceptarLiga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptarLiga.Image = ((System.Drawing.Image)(resources.GetObject("buttonAceptarLiga.Image")));
            this.buttonAceptarLiga.Location = new System.Drawing.Point(265, 141);
            this.buttonAceptarLiga.Name = "buttonAceptarLiga";
            this.buttonAceptarLiga.Size = new System.Drawing.Size(38, 39);
            this.buttonAceptarLiga.TabIndex = 9;
            this.buttonAceptarLiga.UseVisualStyleBackColor = true;
            this.buttonAceptarLiga.Click += new System.EventHandler(this.buttonAceptarLiga_Click);
            // 
            // txtLiga
            // 
            this.txtLiga.Location = new System.Drawing.Point(265, 82);
            this.txtLiga.Name = "txtLiga";
            this.txtLiga.Size = new System.Drawing.Size(148, 20);
            this.txtLiga.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "LIGA DE EQUIPO DE FUTBOL";
            // 
            // Liga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(563, 217);
            this.Controls.Add(this.buttonBorrarLiga);
            this.Controls.Add(this.buttonAceptarLiga);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtLiga);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Liga";
            this.Text = "Liga";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBorrarLiga;
        private System.Windows.Forms.Button buttonAceptarLiga;
        private System.Windows.Forms.TextBox txtLiga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegresarliga;
    }
}