namespace Vista
{
    partial class EliminarCamisas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarCamisas));
            this.dataGridViewEliminarCamisas = new System.Windows.Forms.DataGridView();
            this.buttonEliminarCamisas = new System.Windows.Forms.Button();
            this.textBuscarCa = new System.Windows.Forms.TextBox();
            this.buttonAtrasEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEliminarCamisas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEliminarCamisas
            // 
            this.dataGridViewEliminarCamisas.AllowUserToAddRows = false;
            this.dataGridViewEliminarCamisas.AllowUserToDeleteRows = false;
            this.dataGridViewEliminarCamisas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEliminarCamisas.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewEliminarCamisas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEliminarCamisas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewEliminarCamisas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewEliminarCamisas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEliminarCamisas.Location = new System.Drawing.Point(12, 199);
            this.dataGridViewEliminarCamisas.Name = "dataGridViewEliminarCamisas";
            this.dataGridViewEliminarCamisas.ReadOnly = true;
            this.dataGridViewEliminarCamisas.RowHeadersVisible = false;
            this.dataGridViewEliminarCamisas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEliminarCamisas.Size = new System.Drawing.Size(776, 225);
            this.dataGridViewEliminarCamisas.TabIndex = 0;
            // 
            // buttonEliminarCamisas
            // 
            this.buttonEliminarCamisas.FlatAppearance.BorderSize = 0;
            this.buttonEliminarCamisas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarCamisas.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarCamisas.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminarCamisas.Image")));
            this.buttonEliminarCamisas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminarCamisas.Location = new System.Drawing.Point(12, 146);
            this.buttonEliminarCamisas.Name = "buttonEliminarCamisas";
            this.buttonEliminarCamisas.Size = new System.Drawing.Size(117, 47);
            this.buttonEliminarCamisas.TabIndex = 1;
            this.buttonEliminarCamisas.Text = "ELIMINAR";
            this.buttonEliminarCamisas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEliminarCamisas.UseVisualStyleBackColor = true;
            this.buttonEliminarCamisas.Click += new System.EventHandler(this.buttonEliminarCamisas_Click);
            // 
            // textBuscarCa
            // 
            this.textBuscarCa.Location = new System.Drawing.Point(12, 103);
            this.textBuscarCa.Name = "textBuscarCa";
            this.textBuscarCa.Size = new System.Drawing.Size(150, 20);
            this.textBuscarCa.TabIndex = 2;
            // 
            // buttonAtrasEliminar
            // 
            this.buttonAtrasEliminar.FlatAppearance.BorderSize = 0;
            this.buttonAtrasEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtrasEliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtrasEliminar.Image")));
            this.buttonAtrasEliminar.Location = new System.Drawing.Point(3, 3);
            this.buttonAtrasEliminar.Name = "buttonAtrasEliminar";
            this.buttonAtrasEliminar.Size = new System.Drawing.Size(29, 32);
            this.buttonAtrasEliminar.TabIndex = 15;
            this.buttonAtrasEliminar.UseVisualStyleBackColor = true;
            this.buttonAtrasEliminar.Click += new System.EventHandler(this.buttonAtrasEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "BUSCAR CAMISA:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonAtrasEliminar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "ELIMINAR CAMISA";
            // 
            // EliminarCamisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBuscarCa);
            this.Controls.Add(this.buttonEliminarCamisas);
            this.Controls.Add(this.dataGridViewEliminarCamisas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarCamisas";
            this.Text = "EliminarCamisas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEliminarCamisas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEliminarCamisas;
        private System.Windows.Forms.Button buttonEliminarCamisas;
        private System.Windows.Forms.TextBox textBuscarCa;
        private System.Windows.Forms.Button buttonAtrasEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}