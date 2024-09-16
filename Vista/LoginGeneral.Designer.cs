namespace Vista
{
    partial class LoginGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginGeneral));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAtrasGeneral = new System.Windows.Forms.Button();
            this.buttonExitGeneral = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelFECHA = new System.Windows.Forms.Label();
            this.HORA = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINSTRADOR";
            // 
            // buttonCliente
            // 
            this.buttonCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCliente.FlatAppearance.BorderSize = 0;
            this.buttonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonCliente.Image")));
            this.buttonCliente.Location = new System.Drawing.Point(262, 132);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(153, 72);
            this.buttonCliente.TabIndex = 1;
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.buttonAtrasGeneral);
            this.panel1.Controls.Add(this.buttonExitGeneral);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 55);
            this.panel1.TabIndex = 2;
            // 
            // buttonAtrasGeneral
            // 
            this.buttonAtrasGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAtrasGeneral.FlatAppearance.BorderSize = 0;
            this.buttonAtrasGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtrasGeneral.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtrasGeneral.Image")));
            this.buttonAtrasGeneral.Location = new System.Drawing.Point(458, 3);
            this.buttonAtrasGeneral.Name = "buttonAtrasGeneral";
            this.buttonAtrasGeneral.Size = new System.Drawing.Size(47, 35);
            this.buttonAtrasGeneral.TabIndex = 6;
            this.buttonAtrasGeneral.UseVisualStyleBackColor = true;
            this.buttonAtrasGeneral.Click += new System.EventHandler(this.buttonAtrasGeneral_Click);
            // 
            // buttonExitGeneral
            // 
            this.buttonExitGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExitGeneral.FlatAppearance.BorderSize = 0;
            this.buttonExitGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitGeneral.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitGeneral.Image")));
            this.buttonExitGeneral.Location = new System.Drawing.Point(511, 8);
            this.buttonExitGeneral.Name = "buttonExitGeneral";
            this.buttonExitGeneral.Size = new System.Drawing.Size(36, 24);
            this.buttonExitGeneral.TabIndex = 7;
            this.buttonExitGeneral.UseVisualStyleBackColor = true;
            this.buttonExitGeneral.Click += new System.EventHandler(this.buttonExitGeneral_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "LOGIN GENERAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "CLIENTE";
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdmin.FlatAppearance.BorderSize = 0;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdmin.Image")));
            this.buttonAdmin.Location = new System.Drawing.Point(262, 228);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(153, 72);
            this.buttonAdmin.TabIndex = 4;
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.labelFECHA);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 55);
            this.panel2.TabIndex = 5;
            // 
            // labelFECHA
            // 
            this.labelFECHA.AutoSize = true;
            this.labelFECHA.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFECHA.Location = new System.Drawing.Point(130, 17);
            this.labelFECHA.Name = "labelFECHA";
            this.labelFECHA.Size = new System.Drawing.Size(62, 29);
            this.labelFECHA.TabIndex = 5;
            this.labelFECHA.Text = "FECHA";
            // 
            // HORA
            // 
            this.HORA.Enabled = true;
            this.HORA.Tick += new System.EventHandler(this.HORA_Tick);
            // 
            // LoginGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginGeneral";
            this.Text = "LoginGeneral";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelFECHA;
        private System.Windows.Forms.Timer HORA;
        private System.Windows.Forms.Button buttonAtrasGeneral;
        private System.Windows.Forms.Button buttonExitGeneral;
    }
}