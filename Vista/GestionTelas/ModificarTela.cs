using Entidades;
using Logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class ModificarTela : Form
    {
        InventarioBD inventario = new InventarioBD();


        public ModificarTela()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            MostrarInventario();
        }

        public void MostrarInventario()
        {
            DataTable dt = inventario.MostrarInventario();
            dataGridViewModificarTelas.DataSource = dt;
        }

        private void buttonAtrasModificarTelas_Click(object sender, EventArgs e)
        {
            AgregarTela agregarTela = new AgregarTela();
            agregarTela.Show();
            this.Close();
        }



        private void buttonModificarTela_Click(object sender, EventArgs e)
        {
            if (dataGridViewModificarTelas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewModificarTelas.SelectedRows[0];

                int idTela = Convert.ToInt32(selectedRow.Cells["id_tela"].Value);
                string nombre = selectedRow.Cells["nombre"].Value.ToString();
                int stock = Convert.ToInt32(selectedRow.Cells["stock"].Value);

                Tela tela = new Tela
                {
                    Id_tela = idTela,
                    Nombre = nombre,
                    Stock = stock
                };

                inventario.ActualizarTela(tela);
                Console.WriteLine("Tela modificada exitosamente.");


                InventariosTelas inventarioForm = Application.OpenForms["InventariosTelas"] as InventariosTelas;
                if (inventarioForm != null)
                {
                    inventarioForm.ActualizarInventario();
                }
            }
            else
            {
                Console.WriteLine("Por favor, seleccione una tela para modificar.");
            }
        }



        private void textBoxBuscarModificarTela_TextChanged(object sender, EventArgs e)
        {
            FiltrarTelas();
        }
        private void FiltrarTelas()
        {
            string nombre = textBoxBuscarModificarTela.Text.Trim();
            DataTable dt;

            if (!string.IsNullOrEmpty(nombre))
            {
                dt = inventario.BuscarTelaPorNombre(nombre);
            }
            else
            {
                dt = inventario.MostrarInventario();
            }

            dataGridViewModificarTelas.DataSource = dt;


            if (dataGridViewModificarTelas.Columns["id_tela"] != null)
            {
                dataGridViewModificarTelas.Columns["id_tela"].ReadOnly = true;
            }
        }
    }
}
