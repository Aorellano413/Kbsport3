namespace Vista
{
    partial class MenuGeneralAdministrador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGeneralAdministrador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.hora = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.NOMBRE = new System.Windows.Forms.Label();
            this.buttonGestionarCamisas = new System.Windows.Forms.Button();
            this.ButtonStockCamisetas = new System.Windows.Forms.Button();
            this.ButtonMenuCliente = new System.Windows.Forms.Button();
            this.buttonInforme = new System.Windows.Forms.Button();
            this.buttonAtrasAdministrador = new System.Windows.Forms.Button();
            this.buttonCerrarAdministrador = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonInventarioTelas = new System.Windows.Forms.Button();
            this.buttonGestionarTelas = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.HorFechaAdmin = new System.Windows.Forms.Timer(this.components);
            this.buttonLiga = new System.Windows.Forms.Button();
            this.buttonTalla = new System.Windows.Forms.Button();
            this.buttonEquipo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.hora);
            this.panel1.Controls.Add(this.fecha);
            this.panel1.Controls.Add(this.NOMBRE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 697);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 53);
            this.panel1.TabIndex = 0;
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.Location = new System.Drawing.Point(523, 15);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(55, 29);
            this.hora.TabIndex = 18;
            this.hora.Text = "HORA";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(799, 15);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(62, 29);
            this.fecha.TabIndex = 17;
            this.fecha.Text = "FECHA";
            // 
            // NOMBRE
            // 
            this.NOMBRE.AutoSize = true;
            this.NOMBRE.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOMBRE.Location = new System.Drawing.Point(12, 15);
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Size = new System.Drawing.Size(78, 29);
            this.NOMBRE.TabIndex = 16;
            this.NOMBRE.Text = "NOMBRE";
            // 
            // buttonGestionarCamisas
            // 
            this.buttonGestionarCamisas.FlatAppearance.BorderSize = 0;
            this.buttonGestionarCamisas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionarCamisas.Image = ((System.Drawing.Image)(resources.GetObject("buttonGestionarCamisas.Image")));
            this.buttonGestionarCamisas.Location = new System.Drawing.Point(28, 59);
            this.buttonGestionarCamisas.Name = "buttonGestionarCamisas";
            this.buttonGestionarCamisas.Size = new System.Drawing.Size(211, 155);
            this.buttonGestionarCamisas.TabIndex = 1;
            this.buttonGestionarCamisas.UseVisualStyleBackColor = true;
            this.buttonGestionarCamisas.Click += new System.EventHandler(this.buttonAgregarCamisetas_Click);
            // 
            // ButtonStockCamisetas
            // 
            this.ButtonStockCamisetas.FlatAppearance.BorderSize = 0;
            this.ButtonStockCamisetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStockCamisetas.Image = ((System.Drawing.Image)(resources.GetObject("ButtonStockCamisetas.Image")));
            this.ButtonStockCamisetas.Location = new System.Drawing.Point(466, 59);
            this.ButtonStockCamisetas.Name = "ButtonStockCamisetas";
            this.ButtonStockCamisetas.Size = new System.Drawing.Size(200, 155);
            this.ButtonStockCamisetas.TabIndex = 2;
            this.ButtonStockCamisetas.UseVisualStyleBackColor = true;
            this.ButtonStockCamisetas.Click += new System.EventHandler(this.ButtonStockCamisetas_Click);
            // 
            // ButtonMenuCliente
            // 
            this.ButtonMenuCliente.FlatAppearance.BorderSize = 0;
            this.ButtonMenuCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMenuCliente.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMenuCliente.Image")));
            this.ButtonMenuCliente.Location = new System.Drawing.Point(822, 276);
            this.ButtonMenuCliente.Name = "ButtonMenuCliente";
            this.ButtonMenuCliente.Size = new System.Drawing.Size(200, 155);
            this.ButtonMenuCliente.TabIndex = 3;
            this.ButtonMenuCliente.UseVisualStyleBackColor = true;
            this.ButtonMenuCliente.Click += new System.EventHandler(this.ButtonMenuCliente_Click);
            // 
            // buttonInforme
            // 
            this.buttonInforme.FlatAppearance.BorderSize = 0;
            this.buttonInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInforme.Image = ((System.Drawing.Image)(resources.GetObject("buttonInforme.Image")));
            this.buttonInforme.Location = new System.Drawing.Point(822, 59);
            this.buttonInforme.Name = "buttonInforme";
            this.buttonInforme.Size = new System.Drawing.Size(200, 155);
            this.buttonInforme.TabIndex = 4;
            this.buttonInforme.UseVisualStyleBackColor = true;
            this.buttonInforme.Click += new System.EventHandler(this.buttonInforme_Click);
            // 
            // buttonAtrasAdministrador
            // 
            this.buttonAtrasAdministrador.FlatAppearance.BorderSize = 0;
            this.buttonAtrasAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtrasAdministrador.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtrasAdministrador.Image")));
            this.buttonAtrasAdministrador.Location = new System.Drawing.Point(1016, 3);
            this.buttonAtrasAdministrador.Name = "buttonAtrasAdministrador";
            this.buttonAtrasAdministrador.Size = new System.Drawing.Size(30, 32);
            this.buttonAtrasAdministrador.TabIndex = 5;
            this.buttonAtrasAdministrador.UseVisualStyleBackColor = true;
            this.buttonAtrasAdministrador.Click += new System.EventHandler(this.buttonAtrasAdministrador_Click);
            // 
            // buttonCerrarAdministrador
            // 
            this.buttonCerrarAdministrador.FlatAppearance.BorderSize = 0;
            this.buttonCerrarAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrarAdministrador.Image = ((System.Drawing.Image)(resources.GetObject("buttonCerrarAdministrador.Image")));
            this.buttonCerrarAdministrador.Location = new System.Drawing.Point(1052, 3);
            this.buttonCerrarAdministrador.Name = "buttonCerrarAdministrador";
            this.buttonCerrarAdministrador.Size = new System.Drawing.Size(30, 32);
            this.buttonCerrarAdministrador.TabIndex = 6;
            this.buttonCerrarAdministrador.UseVisualStyleBackColor = true;
            this.buttonCerrarAdministrador.Click += new System.EventHandler(this.buttonCerrarAdministrador_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "GESTIONAR CAMISAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(887, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "INFORME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(868, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "MENU CLIENTE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(477, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "INVENTARIO CAMISAS";
            // 
            // buttonInventarioTelas
            // 
            this.buttonInventarioTelas.FlatAppearance.BorderSize = 0;
            this.buttonInventarioTelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventarioTelas.Image = ((System.Drawing.Image)(resources.GetObject("buttonInventarioTelas.Image")));
            this.buttonInventarioTelas.Location = new System.Drawing.Point(466, 297);
            this.buttonInventarioTelas.Name = "buttonInventarioTelas";
            this.buttonInventarioTelas.Size = new System.Drawing.Size(200, 155);
            this.buttonInventarioTelas.TabIndex = 12;
            this.buttonInventarioTelas.UseVisualStyleBackColor = true;
            this.buttonInventarioTelas.Click += new System.EventHandler(this.buttonInventarioTelas_Click);
            // 
            // buttonGestionarTelas
            // 
            this.buttonGestionarTelas.FlatAppearance.BorderSize = 0;
            this.buttonGestionarTelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionarTelas.Image = ((System.Drawing.Image)(resources.GetObject("buttonGestionarTelas.Image")));
            this.buttonGestionarTelas.Location = new System.Drawing.Point(28, 297);
            this.buttonGestionarTelas.Name = "buttonGestionarTelas";
            this.buttonGestionarTelas.Size = new System.Drawing.Size(200, 155);
            this.buttonGestionarTelas.TabIndex = 13;
            this.buttonGestionarTelas.UseVisualStyleBackColor = true;
            this.buttonGestionarTelas.Click += new System.EventHandler(this.buttonGestionarTelas_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "GESTIONAR TELAS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(489, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "INVENTARIOS TELAS";
            // 
            // HorFechaAdmin
            // 
            this.HorFechaAdmin.Enabled = true;
            this.HorFechaAdmin.Tick += new System.EventHandler(this.HorFechaAdmin_Tick);
            // 
            // buttonLiga
            // 
            this.buttonLiga.FlatAppearance.BorderSize = 0;
            this.buttonLiga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLiga.Image = ((System.Drawing.Image)(resources.GetObject("buttonLiga.Image")));
            this.buttonLiga.Location = new System.Drawing.Point(822, 504);
            this.buttonLiga.Name = "buttonLiga";
            this.buttonLiga.Size = new System.Drawing.Size(200, 155);
            this.buttonLiga.TabIndex = 16;
            this.buttonLiga.UseVisualStyleBackColor = true;
            this.buttonLiga.Click += new System.EventHandler(this.buttonLiga_Click);
            // 
            // buttonTalla
            // 
            this.buttonTalla.FlatAppearance.BorderSize = 0;
            this.buttonTalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTalla.Image = ((System.Drawing.Image)(resources.GetObject("buttonTalla.Image")));
            this.buttonTalla.Location = new System.Drawing.Point(466, 504);
            this.buttonTalla.Name = "buttonTalla";
            this.buttonTalla.Size = new System.Drawing.Size(200, 155);
            this.buttonTalla.TabIndex = 17;
            this.buttonTalla.UseVisualStyleBackColor = true;
            this.buttonTalla.Click += new System.EventHandler(this.buttonTalla_Click);
            // 
            // buttonEquipo
            // 
            this.buttonEquipo.FlatAppearance.BorderSize = 0;
            this.buttonEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEquipo.Image = ((System.Drawing.Image)(resources.GetObject("buttonEquipo.Image")));
            this.buttonEquipo.Location = new System.Drawing.Point(28, 504);
            this.buttonEquipo.Name = "buttonEquipo";
            this.buttonEquipo.Size = new System.Drawing.Size(200, 155);
            this.buttonEquipo.TabIndex = 18;
            this.buttonEquipo.UseVisualStyleBackColor = true;
            this.buttonEquipo.Click += new System.EventHandler(this.buttonEquipo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 662);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "TALLA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 662);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "EQUIPO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(901, 662);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 29);
            this.label9.TabIndex = 21;
            this.label9.Text = "LIGA";
            // 
            // MenuGeneralAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1094, 750);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEquipo);
            this.Controls.Add(this.buttonTalla);
            this.Controls.Add(this.buttonLiga);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonGestionarTelas);
            this.Controls.Add(this.buttonInventarioTelas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCerrarAdministrador);
            this.Controls.Add(this.buttonAtrasAdministrador);
            this.Controls.Add(this.buttonInforme);
            this.Controls.Add(this.ButtonMenuCliente);
            this.Controls.Add(this.ButtonStockCamisetas);
            this.Controls.Add(this.buttonGestionarCamisas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuGeneralAdministrador";
            this.Text = "MenuGeneralAdministrador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGestionarCamisas;
        private System.Windows.Forms.Button ButtonStockCamisetas;
        private System.Windows.Forms.Button ButtonMenuCliente;
        private System.Windows.Forms.Button buttonInforme;
        private System.Windows.Forms.Button buttonAtrasAdministrador;
        private System.Windows.Forms.Button buttonCerrarAdministrador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonInventarioTelas;
        private System.Windows.Forms.Button buttonGestionarTelas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label NOMBRE;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Timer HorFechaAdmin;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Button buttonLiga;
        private System.Windows.Forms.Button buttonTalla;
        private System.Windows.Forms.Button buttonEquipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}