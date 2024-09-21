using Logica;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vista
{
    public partial class InventariosTelas : Form
    {
        InventarioBD inventario = new InventarioBD();
        DataTable dtInventario;

        public InventariosTelas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ActualizarInventario();
        }

        public void ActualizarInventario()
        {
            dtInventario = inventario.MostrarInventario();
            dataGridViewMostrarTelas.DataSource = dtInventario;
        }

        private void buttonAtrasTelas_Click(object sender, EventArgs e)
        {
            MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
            menuGeneralAdministrador.Show();
            this.Close();
        }

        private void textBoxBuscarTelas_TextChanged(object sender, EventArgs e)
        {
            string nombre = textBoxBuscarTelas.Text.Trim();
            if (!string.IsNullOrEmpty(nombre))
            {
                DataTable dt = inventario.BuscarTelaPorNombre(nombre);
                dataGridViewMostrarTelas.DataSource = dt;
            }
            else
            {
                DataTable dt = inventario.MostrarInventario();
                dataGridViewMostrarTelas.DataSource = dt;
            }

        }

        private void buttonRestablecerTelas_Click(object sender, EventArgs e)
        {

            dataGridViewMostrarTelas.DataSource = dtInventario;
            textBoxBuscarTelas.Clear();
        }
    }
}
