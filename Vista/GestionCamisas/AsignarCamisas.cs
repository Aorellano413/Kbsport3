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
        private CamisasBD camisasBD;
        private int selectedCamisaId;

        public AsignarCamisas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            camisasBD = new CamisasBD();
            InitializeDataGridView();
            CargarCamisas();
        }

        private void InitializeDataGridView()
        {
            dataGridViewAsignarValores.Columns.Clear();

            // Se eliminó la columna de ID Tela
            dataGridViewAsignarValores.Columns.Add("NombreTela", "Nombre Tela");
            dataGridViewAsignarValores.Columns.Add("Cantidad", "Cantidad");

            dataGridViewAsignarValores.Columns["Cantidad"].ReadOnly = false;
        }

        private void CargarCamisas()
        {
            DataTable camisasDataTable = camisasBD.ObtenerNombresDeCamisas();
            comboBoxCamisasAsignar.DataSource = camisasDataTable;
            comboBoxCamisasAsignar.DisplayMember = "nombre_equipo"; 
            comboBoxCamisasAsignar.ValueMember = "id_camisa"; 
        }

        private void buttonBuscarCamisas_Click(object sender, EventArgs e)
        {
            string camisaNombre = comboBoxCamisasAsignar.Text;
            DataTable dtCamisas = camisasBD.ObtenerCamisasPorNombre(camisaNombre);

            if (dtCamisas.Rows.Count > 0)
            {
                selectedCamisaId = Convert.ToInt32(dtCamisas.Rows[0]["id_camisa"]);
                List<CamisaTela> telas = camisasBD.ObtenerTelasDeCamisa(selectedCamisaId);
                dataGridViewAsignarValores.Rows.Clear();

                foreach (var camisaTela in telas)
                {
                    int rowIndex = dataGridViewAsignarValores.Rows.Add();
                    dataGridViewAsignarValores.Rows[rowIndex].Cells["NombreTela"].Value = camisaTela.NombreTela;
                    dataGridViewAsignarValores.Rows[rowIndex].Cells["Cantidad"].Value = camisaTela.Cantidad;
                    dataGridViewAsignarValores.Rows[rowIndex].Cells["Cantidad"].ReadOnly = false;
                }
            }
            else
            {
                MessageBox.Show("No se encontraron camisas con ese nombre.");
            }
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
    }
}
