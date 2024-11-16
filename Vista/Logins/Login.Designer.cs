namespace Vista
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonInvitado = new System.Windows.Forms.Button();
            this.buttonNuevoUsuario = new System.Windows.Forms.Button();
            this.buttonExitLogin = new System.Windows.Forms.Button();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.HorFecha = new System.Windows.Forms.Timer(this.components);
            this.buttonWpp = new System.Windows.Forms.Button();
            this.buttonIG = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.buttonInvitado);
            this.panel1.Controls.Add(this.buttonNuevoUsuario);
            this.panel1.Controls.Add(this.buttonExitLogin);
            this.panel1.Controls.Add(this.textBoxContraseña);
            this.panel1.Controls.Add(this.textBoxUsuario);
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Controls.Add(this.buttonIngresar);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.labelContraseña);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(337, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 381);
            this.panel1.TabIndex = 0;
            // 
            // buttonInvitado
            // 
            this.buttonInvitado.FlatAppearance.BorderSize = 0;
            this.buttonInvitado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInvitado.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInvitado.Image = ((System.Drawing.Image)(resources.GetObject("buttonInvitado.Image")));
            this.buttonInvitado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInvitado.Location = new System.Drawing.Point(3, 4);
            this.buttonInvitado.Name = "buttonInvitado";
            this.buttonInvitado.Size = new System.Drawing.Size(175, 63);
            this.buttonInvitado.TabIndex = 13;
            this.buttonInvitado.Text = "INGRESAR INVITADO";
            this.buttonInvitado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInvitado.UseVisualStyleBackColor = true;
            this.buttonInvitado.Click += new System.EventHandler(this.buttonInvitado_Click);
            // 
            // buttonNuevoUsuario
            // 
            this.buttonNuevoUsuario.FlatAppearance.BorderSize = 0;
            this.buttonNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevoUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("buttonNuevoUsuario.Image")));
            this.buttonNuevoUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNuevoUsuario.Location = new System.Drawing.Point(93, 312);
            this.buttonNuevoUsuario.Name = "buttonNuevoUsuario";
            this.buttonNuevoUsuario.Size = new System.Drawing.Size(177, 60);
            this.buttonNuevoUsuario.TabIndex = 12;
            this.buttonNuevoUsuario.Text = "Ingresar como cliente";
            this.buttonNuevoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNuevoUsuario.UseVisualStyleBackColor = true;
            this.buttonNuevoUsuario.Click += new System.EventHandler(this.buttonNuevoUsuario_Click);
            // 
            // buttonExitLogin
            // 
            this.buttonExitLogin.FlatAppearance.BorderSize = 0;
            this.buttonExitLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitLogin.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitLogin.Image")));
            this.buttonExitLogin.Location = new System.Drawing.Point(305, 4);
            this.buttonExitLogin.Name = "buttonExitLogin";
            this.buttonExitLogin.Size = new System.Drawing.Size(55, 34);
            this.buttonExitLogin.TabIndex = 11;
            this.buttonExitLogin.UseVisualStyleBackColor = true;
            this.buttonExitLogin.Click += new System.EventHandler(this.buttonExitLogin_Click);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContraseña.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.Location = new System.Drawing.Point(93, 206);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(195, 26);
            this.textBoxContraseña.TabIndex = 10;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(89, 119);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(195, 26);
            this.textBoxUsuario.TabIndex = 9;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.Location = new System.Drawing.Point(216, 249);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(68, 40);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.FlatAppearance.BorderSize = 0;
            this.buttonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIngresar.Image = ((System.Drawing.Image)(resources.GetObject("buttonIngresar.Image")));
            this.buttonIngresar.Location = new System.Drawing.Point(86, 238);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(84, 63);
            this.buttonIngresar.TabIndex = 6;
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(83, 83);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(87, 33);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "USUARIO";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(83, 168);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(128, 33);
            this.labelContraseña.TabIndex = 3;
            this.labelContraseña.Text = "CONTRASEÑA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(99, 9);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(45, 25);
            this.labelHora.TabIndex = 2;
            this.labelHora.Text = "Hora";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(40, 347);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(54, 25);
            this.labelFecha.TabIndex = 3;
            this.labelFecha.Text = "Fecha";
            // 
            // HorFecha
            // 
            this.HorFecha.Enabled = true;
            this.HorFecha.Tick += new System.EventHandler(this.HorFecha_Tick);
            // 
            // buttonWpp
            // 
            this.buttonWpp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWpp.FlatAppearance.BorderSize = 0;
            this.buttonWpp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWpp.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWpp.Image = ((System.Drawing.Image)(resources.GetObject("buttonWpp.Image")));
            this.buttonWpp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWpp.Location = new System.Drawing.Point(30, 241);
            this.buttonWpp.Name = "buttonWpp";
            this.buttonWpp.Size = new System.Drawing.Size(129, 48);
            this.buttonWpp.TabIndex = 14;
            this.buttonWpp.Text = "301 5318600";
            this.buttonWpp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonWpp.UseVisualStyleBackColor = true;
            this.buttonWpp.Click += new System.EventHandler(this.buttonWpp_Click);
            // 
            // buttonIG
            // 
            this.buttonIG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIG.FlatAppearance.BorderSize = 0;
            this.buttonIG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIG.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIG.Image = ((System.Drawing.Image)(resources.GetObject("buttonIG.Image")));
            this.buttonIG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIG.Location = new System.Drawing.Point(30, 296);
            this.buttonIG.Name = "buttonIG";
            this.buttonIG.Size = new System.Drawing.Size(129, 48);
            this.buttonIG.TabIndex = 15;
            this.buttonIG.Text = "Kb_sport3";
            this.buttonIG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonIG.UseVisualStyleBackColor = true;
            this.buttonIG.Click += new System.EventHandler(this.buttonIG_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(700, 381);
            this.Controls.Add(this.buttonIG);
            this.Controls.Add(this.buttonWpp);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Timer HorFecha;
        private System.Windows.Forms.Button buttonExitLogin;
        private System.Windows.Forms.Button buttonNuevoUsuario;
        private System.Windows.Forms.Button buttonInvitado;
        private System.Windows.Forms.Button buttonWpp;
        private System.Windows.Forms.Button buttonIG;
    }
}

