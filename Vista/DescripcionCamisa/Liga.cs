﻿using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Liga : Form
    {
        InventarioBD inventario = new InventarioBD();
        public string Nombre { get; internal set; }

        public Liga()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            MostrarLigas();
        }
        public void MostrarLigas()
        {
            DataTable dt = inventario.MostrarLigas();
            dataGridViewLiga.DataSource = dt;
        }


        private void buttonAceptarLiga_Click(object sender, EventArgs e)
        {
            string nombre = txtLiga.Text.Trim();

            try
            {
                Entidades.Liga ligaNueva = new Entidades.Liga
                {
                    Nombre = nombre
                };

                inventario.InsertarLiga(ligaNueva);
                MessageBox.Show("Liga guardada exitosamente.");

                txtLiga.Clear();
                MostrarLigas();  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); 
            }
        }



        private void buttonBorrarLiga_Click(object sender, EventArgs e)
        {
            txtLiga.Clear();
        }

        private void buttonRegresarliga_Click(object sender, EventArgs e)
        {
            MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
            menuGeneralAdministrador.Show();
            this.Close();
        }
    }
}
