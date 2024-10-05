namespace Vista
{
    partial class Talla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Talla));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.buttonAcepetarTalla = new System.Windows.Forms.Button();
            this.buttonBorrarTalla = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.buttonRegresar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 43);
            this.panel1.TabIndex = 0;
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.FlatAppearance.BorderSize = 0;
            this.buttonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegresar.Image = ((System.Drawing.Image)(resources.GetObject("buttonRegresar.Image")));
            this.buttonRegresar.Location = new System.Drawing.Point(507, 1);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(43, 39);
            this.buttonRegresar.TabIndex = 7;
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TALLA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "TALLA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(538, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Advertencia: Estas son las tallas  que existen: XS, S, M, L, XL, XXL, XXXL. Otro " +
    "tipo de talla no sera aceptada\r\n";
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(173, 76);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(148, 20);
            this.txtTalla.TabIndex = 4;
            // 
            // buttonAcepetarTalla
            // 
            this.buttonAcepetarTalla.FlatAppearance.BorderSize = 0;
            this.buttonAcepetarTalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcepetarTalla.Image = ((System.Drawing.Image)(resources.GetObject("buttonAcepetarTalla.Image")));
            this.buttonAcepetarTalla.Location = new System.Drawing.Point(173, 127);
            this.buttonAcepetarTalla.Name = "buttonAcepetarTalla";
            this.buttonAcepetarTalla.Size = new System.Drawing.Size(39, 39);
            this.buttonAcepetarTalla.TabIndex = 5;
            this.buttonAcepetarTalla.UseVisualStyleBackColor = true;
            this.buttonAcepetarTalla.Click += new System.EventHandler(this.buttonAcepetarTalla_Click);
            // 
            // buttonBorrarTalla
            // 
            this.buttonBorrarTalla.FlatAppearance.BorderSize = 0;
            this.buttonBorrarTalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrarTalla.Image = ((System.Drawing.Image)(resources.GetObject("buttonBorrarTalla.Image")));
            this.buttonBorrarTalla.Location = new System.Drawing.Point(282, 127);
            this.buttonBorrarTalla.Name = "buttonBorrarTalla";
            this.buttonBorrarTalla.Size = new System.Drawing.Size(39, 39);
            this.buttonBorrarTalla.TabIndex = 6;
            this.buttonBorrarTalla.UseVisualStyleBackColor = true;
            this.buttonBorrarTalla.Click += new System.EventHandler(this.buttonBorrarTalla_Click);
            // 
            // Talla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(563, 217);
            this.Controls.Add(this.buttonBorrarTalla);
            this.Controls.Add(this.buttonAcepetarTalla);
            this.Controls.Add(this.txtTalla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Talla";
            this.Text = "Talla";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.Button buttonAcepetarTalla;
        private System.Windows.Forms.Button buttonBorrarTalla;
        private System.Windows.Forms.Button buttonRegresar;
    }
}