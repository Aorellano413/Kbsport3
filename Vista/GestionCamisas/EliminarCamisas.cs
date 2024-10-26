using Entidades;
using Logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class EliminarCamisas : Form
    {
        private CamisasBD camisasBD = new CamisasBD();
        private DataTable dtCamisas = new DataTable();

        public EliminarCamisas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarCamisas();
        }

        private void CargarCamisas()
        {
            dtCamisas = camisasBD.ObtenerTodasLasCamisas();
            dataGridViewEliminarCamisas.DataSource = dtCamisas;
        }

        private void buttonEliminarCamisas_Click(object sender, EventArgs e)
        {
            if (dataGridViewEliminarCamisas.SelectedRows.Count > 0)
            {
                int idCamisa = Convert.ToInt32(dataGridViewEliminarCamisas.SelectedRows[0].Cells["id_camisa"].Value);
                bool eliminado = camisasBD.EliminarCamisa(idCamisa);

                if (eliminado)
                {
                    MessageBox.Show("Camisa eliminada con éxito.");
                    CargarCamisas();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la camisa.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una camisa para eliminar.");
            }
        }


        private void buttonSalirEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAtrasEliminar_Click(object sender, EventArgs e)
        {
            AgregarCamisas agregarCamisas = new AgregarCamisas();
            agregarCamisas.Show();
            this.Close();
        }
    }
}
