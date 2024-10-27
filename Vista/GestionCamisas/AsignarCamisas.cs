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
            DataTable dtCamisas = camisasBD.ObtenerTodasLasCamisas();

            if (dtCamisas == null || dtCamisas.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron camisas para mostrar.");
                return;
            }

            comboBoxCamisasAsignar.DataSource = dtCamisas;
            comboBoxCamisasAsignar.DisplayMember = "Equipo";
            comboBoxCamisasAsignar.ValueMember = "id_camisa";
            dataGridViewAsignarValores.Columns.Clear(); 
            dataGridViewAsignarValores.Columns.Add("NombreTela", "Nombre Tela");
            dataGridViewAsignarValores.Columns.Add("Cantidad", "Cantidad");
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
            string nombreCamisa = comboBoxCamisasAsignar.Text;
            DataTable dtCamisas = camisasBD.ObtenerCamisasPorNombre(nombreCamisa);

            if (dtCamisas.Rows.Count > 0)
            {
                int idCamisa = Convert.ToInt32(dtCamisas.Rows[0]["id_camisa"]);
                List<CamisaTela> telas = camisasBD.ObtenerTelasDeCamisa(idCamisa);

                dataGridViewAsignarValores.Rows.Clear();

                foreach (var tela in telas)
                {
                    int rowIndex = dataGridViewAsignarValores.Rows.Add();
                    dataGridViewAsignarValores.Rows[rowIndex].Cells["IdTela"].Value = tela.IdTela;
                    dataGridViewAsignarValores.Rows[rowIndex].Cells["NombreTela"].Value = tela.NombreTela;
                    dataGridViewAsignarValores.Rows[rowIndex].Cells["Cantidad"].Value = tela.Cantidad;
                }
            }
            else
            {
                MessageBox.Show("No se encontraron camisas con ese nombre.");
            }
        }
    }
}

