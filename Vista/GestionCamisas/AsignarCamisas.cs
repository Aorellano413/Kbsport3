using Entidades;
using Logica;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Vista.GestionCamisas
{
    public partial class AsignarCamisas : Form
    {
        private InventarioCamisas camisasBD;

        public AsignarCamisas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            camisasBD = new InventarioCamisas();
            CargarCamisas();
        }

        private void CargarCamisas()
        {

        }

        private void buttonAsignarCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAtrasAsignar_Click(object sender, EventArgs e)
        {
            AgregarCamisas agregarCamisas = new AgregarCamisas();
            agregarCamisas.Show();
            this.Close();
        }

        private void buttonBuscarCamisas_Click(object sender, EventArgs e)
        {

        }
    }
}

