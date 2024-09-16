namespace Vista
{
    partial class LoginAdministador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdministador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLoginIdAdmin = new System.Windows.Forms.TextBox();
            this.buttonAceptarAdmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExitAdmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRegresarAdmin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLoginNombreAdmin = new System.Windows.Forms.TextBox();
            this.buttonBorrarAdmin = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN ADMINSTRADOR";
            // 
            // textBoxLoginIdAdmin
            // 
            this.textBoxLoginIdAdmin.Location = new System.Drawing.Point(284, 117);
            this.textBoxLoginIdAdmin.Name = "textBoxLoginIdAdmin";
            this.textBoxLoginIdAdmin.Size = new System.Drawing.Size(121, 20);
            this.textBoxLoginIdAdmin.TabIndex = 2;
            // 
            // buttonAceptarAdmin
            // 
            this.buttonAceptarAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAceptarAdmin.FlatAppearance.BorderSize = 0;
            this.buttonAceptarAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptarAdmin.Image = ((System.Drawing.Image)(resources.GetObject("buttonAceptarAdmin.Image")));
            this.buttonAceptarAdmin.Location = new System.Drawing.Point(138, 283);
            this.buttonAceptarAdmin.Name = "buttonAceptarAdmin";
            this.buttonAceptarAdmin.Size = new System.Drawing.Size(91, 45);
            this.buttonAceptarAdmin.TabIndex = 3;
            this.buttonAceptarAdmin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.buttonExitAdmin);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.buttonRegresarAdmin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 60);
            this.panel2.TabIndex = 5;
            // 
            // buttonExitAdmin
            // 
            this.buttonExitAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExitAdmin.FlatAppearance.BorderSize = 0;
            this.buttonExitAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitAdmin.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitAdmin.Image")));
            this.buttonExitAdmin.Location = new System.Drawing.Point(507, 3);
            this.buttonExitAdmin.Name = "buttonExitAdmin";
            this.buttonExitAdmin.Size = new System.Drawing.Size(40, 33);
            this.buttonExitAdmin.TabIndex = 10;
            this.buttonExitAdmin.UseVisualStyleBackColor = true;
            this.buttonExitAdmin.Click += new System.EventHandler(this.buttonExitAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRegresarAdmin
            // 
            this.buttonRegresarAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegresarAdmin.FlatAppearance.BorderSize = 0;
            this.buttonRegresarAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegresarAdmin.Image = ((System.Drawing.Image)(resources.GetObject("buttonRegresarAdmin.Image")));
            this.buttonRegresarAdmin.Location = new System.Drawing.Point(461, 3);
            this.buttonRegresarAdmin.Name = "buttonRegresarAdmin";
            this.buttonRegresarAdmin.Size = new System.Drawing.Size(40, 29);
            this.buttonRegresarAdmin.TabIndex = 9;
            this.buttonRegresarAdmin.UseVisualStyleBackColor = true;
            this.buttonRegresarAdmin.Click += new System.EventHandler(this.buttonRegresarAdmin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "NOMBRE:";
            // 
            // textBoxLoginNombreAdmin
            // 
            this.textBoxLoginNombreAdmin.Location = new System.Drawing.Point(284, 205);
            this.textBoxLoginNombreAdmin.Name = "textBoxLoginNombreAdmin";
            this.textBoxLoginNombreAdmin.Size = new System.Drawing.Size(121, 20);
            this.textBoxLoginNombreAdmin.TabIndex = 7;
            // 
            // buttonBorrarAdmin
            // 
            this.buttonBorrarAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBorrarAdmin.FlatAppearance.BorderSize = 0;
            this.buttonBorrarAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrarAdmin.Image = ((System.Drawing.Image)(resources.GetObject("buttonBorrarAdmin.Image")));
            this.buttonBorrarAdmin.Location = new System.Drawing.Point(330, 283);
            this.buttonBorrarAdmin.Name = "buttonBorrarAdmin";
            this.buttonBorrarAdmin.Size = new System.Drawing.Size(75, 48);
            this.buttonBorrarAdmin.TabIndex = 8;
            this.buttonBorrarAdmin.UseVisualStyleBackColor = true;
            // 
            // LoginAdministador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.buttonBorrarAdmin);
            this.Controls.Add(this.textBoxLoginNombreAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAceptarAdmin);
            this.Controls.Add(this.textBoxLoginIdAdmin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginAdministador";
            this.Text = "LoginAdministador";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLoginIdAdmin;
        private System.Windows.Forms.Button buttonAceptarAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLoginNombreAdmin;
        private System.Windows.Forms.Button buttonBorrarAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRegresarAdmin;
        private System.Windows.Forms.Button buttonExitAdmin;
    }
}