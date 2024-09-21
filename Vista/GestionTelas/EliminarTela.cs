using Logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class EliminarTela : Form
    {
        InventarioBD inventario = new InventarioBD();

        public EliminarTela()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ActualizarInventario();
        }

        public void ActualizarInventario()
        {
            DataTable dt = inventario.MostrarInventario();
            dataGridViewEliminarTela.DataSource = dt;
        }

        private void buttonEliminarTela_Click(object sender, EventArgs e)
        {


            if (dataGridViewEliminarTela.CurrentRow != null)
            {
                int idTela = Convert.ToInt32(dataGridViewEliminarTela.CurrentRow.Cells["id_tela"].Value);
                inventario.EliminarTela(idTela);
                ActualizarInventario();
                MessageBox.Show("La tela fue  eliminada correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una tela para eliminar.");
            }
        }



        private void buttonAtrasTela_Click(object sender, EventArgs e)
        {
            AgregarTela agregarTela = new AgregarTela();
            agregarTela.Show();
            this.Close();
        }

        private void textBoxBuscarTela_TextChanged(object sender, EventArgs e)
        {
            string nombreBuscar = textBoxBuscarTela.Text.Trim();
            DataTable dt = inventario.BuscarTelaPorNombre(nombreBuscar);
            dataGridViewEliminarTela.DataSource = dt;
        }
    }
}
