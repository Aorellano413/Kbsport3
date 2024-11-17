namespace Vista.Logins
{
    partial class FormCargando
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
            this.LblMensaje = new System.Windows.Forms.Label();
            this.CARGANDOBARRA = new System.Windows.Forms.ProgressBar();
            this.labelCarga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Location = new System.Drawing.Point(105, 97);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(47, 13);
            this.LblMensaje.TabIndex = 0;
            this.LblMensaje.Text = "Mensaje";
            // 
            // CARGANDOBARRA
            // 
            this.CARGANDOBARRA.Location = new System.Drawing.Point(222, 234);
            this.CARGANDOBARRA.Name = "CARGANDOBARRA";
            this.CARGANDOBARRA.Size = new System.Drawing.Size(340, 23);
            this.CARGANDOBARRA.TabIndex = 1;
            // 
            // labelCarga
            // 
            this.labelCarga.AutoSize = true;
            this.labelCarga.Location = new System.Drawing.Point(370, 282);
            this.labelCarga.Name = "labelCarga";
            this.labelCarga.Size = new System.Drawing.Size(35, 13);
            this.labelCarga.TabIndex = 2;
            this.labelCarga.Text = "Carga";
            // 
            // FormCargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCarga);
            this.Controls.Add(this.CARGANDOBARRA);
            this.Controls.Add(this.LblMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCargando";
            this.Text = "FormCargando";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.ProgressBar CARGANDOBARRA;
        private System.Windows.Forms.Label labelCarga;
    }
}