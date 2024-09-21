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
        DataTable dtInventario; // Guardamos el DataTable original para restablecer

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
            string filtro = textBoxBuscarTelas.Text.Trim().ToLower(); 
            if (string.IsNullOrEmpty(filtro))
            {
                dataGridViewMostrarTelas.DataSource = dtInventario; 
            }
            else
            {
                
                var filteredRows = dtInventario.AsEnumerable()
                    .Where(row => row.Field<string>("nombre").ToLower().Contains(filtro));
                dataGridViewMostrarTelas.DataSource = filteredRows.CopyToDataTable(); 
            }
        }

        private void buttonRestablecerTelas_Click(object sender, EventArgs e)
        {
  
            dataGridViewMostrarTelas.DataSource = dtInventario;
            textBoxBuscarTelas.Clear(); 
        }
    }
}
