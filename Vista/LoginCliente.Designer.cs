﻿namespace Vista
{
    partial class LoginCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLoginIdCliente = new System.Windows.Forms.TextBox();
            this.buttonAceptarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLoginNomnreCliente = new System.Windows.Forms.TextBox();
            this.buttonBorrarCliente = new System.Windows.Forms.Button();
            this.buttonRegresarCliente = new System.Windows.Forms.Button();
            this.buttonExitCliente = new System.Windows.Forms.Button();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.buttonRegresarCliente);
            this.panel2.Controls.Add(this.buttonExitCliente);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 60);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOGIN CLIENTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOMBRE:";
            // 
            // textBoxLoginIdCliente
            // 
            this.textBoxLoginIdCliente.Location = new System.Drawing.Point(271, 136);
            this.textBoxLoginIdCliente.Name = "textBoxLoginIdCliente";
            this.textBoxLoginIdCliente.Size = new System.Drawing.Size(125, 20);
            this.textBoxLoginIdCliente.TabIndex = 3;
            // 
            // buttonAceptarCliente
            // 
            this.buttonAceptarCliente.FlatAppearance.BorderSize = 0;
            this.buttonAceptarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonAceptarCliente.Image")));
            this.buttonAceptarCliente.Location = new System.Drawing.Point(166, 287);
            this.buttonAceptarCliente.Name = "buttonAceptarCliente";
            this.buttonAceptarCliente.Size = new System.Drawing.Size(66, 51);
            this.buttonAceptarCliente.TabIndex = 4;
            this.buttonAceptarCliente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID:";
            // 
            // textBoxLoginNomnreCliente
            // 
            this.textBoxLoginNomnreCliente.Location = new System.Drawing.Point(271, 227);
            this.textBoxLoginNomnreCliente.Name = "textBoxLoginNomnreCliente";
            this.textBoxLoginNomnreCliente.Size = new System.Drawing.Size(125, 20);
            this.textBoxLoginNomnreCliente.TabIndex = 6;
            // 
            // buttonBorrarCliente
            // 
            this.buttonBorrarCliente.FlatAppearance.BorderSize = 0;
            this.buttonBorrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonBorrarCliente.Image")));
            this.buttonBorrarCliente.Location = new System.Drawing.Point(305, 287);
            this.buttonBorrarCliente.Name = "buttonBorrarCliente";
            this.buttonBorrarCliente.Size = new System.Drawing.Size(66, 51);
            this.buttonBorrarCliente.TabIndex = 7;
            this.buttonBorrarCliente.UseVisualStyleBackColor = true;
            // 
            // buttonRegresarCliente
            // 
            this.buttonRegresarCliente.FlatAppearance.BorderSize = 0;
            this.buttonRegresarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegresarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonRegresarCliente.Image")));
            this.buttonRegresarCliente.Location = new System.Drawing.Point(456, 2);
            this.buttonRegresarCliente.Name = "buttonRegresarCliente";
            this.buttonRegresarCliente.Size = new System.Drawing.Size(39, 35);
            this.buttonRegresarCliente.TabIndex = 8;
            this.buttonRegresarCliente.UseVisualStyleBackColor = true;
            this.buttonRegresarCliente.Click += new System.EventHandler(this.buttonRegresarCliente_Click);
            // 
            // buttonExitCliente
            // 
            this.buttonExitCliente.FlatAppearance.BorderSize = 0;
            this.buttonExitCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitCliente.Image")));
            this.buttonExitCliente.Location = new System.Drawing.Point(501, 1);
            this.buttonExitCliente.Name = "buttonExitCliente";
            this.buttonExitCliente.Size = new System.Drawing.Size(49, 37);
            this.buttonExitCliente.TabIndex = 9;
            this.buttonExitCliente.UseVisualStyleBackColor = true;
            this.buttonExitCliente.Click += new System.EventHandler(this.buttonExitCliente_Click);
            // 
            // LoginCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.buttonBorrarCliente);
            this.Controls.Add(this.textBoxLoginNomnreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAceptarCliente);
            this.Controls.Add(this.textBoxLoginIdCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginCliente";
            this.Text = "FormLoginCliente";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLoginIdCliente;
        private System.Windows.Forms.Button buttonAceptarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLoginNomnreCliente;
        private System.Windows.Forms.Button buttonBorrarCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExitCliente;
        private System.Windows.Forms.Button buttonRegresarCliente;
    }
}