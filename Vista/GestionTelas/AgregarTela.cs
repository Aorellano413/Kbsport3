using Entidades;
using Logica;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class AgregarTela : Form
    {
        InventarioBD inventario = new InventarioBD();

        public AgregarTela()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonGuardarTela_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombreTela.Text.Trim();
            string stockText = textBoxStockTela.Text.Trim();
            int stock;


            if (string.IsNullOrEmpty(nombre) || !System.Text.RegularExpressions.Regex.IsMatch(nombre, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Por favor, ingrese un nombre válido (solo letras).");
                return;
            }


            if (string.IsNullOrEmpty(stockText) || !int.TryParse(stockText, out stock) || stock < 0)
            {
                MessageBox.Show("Por favor, ingrese un stock válido (solo números positivos).");
                return;
            }

            if (inventario.ExisteTela(nombre))
            {
                MessageBox.Show("Ya existe una tela con ese nombre. Por favor, elija otro.");
                return;
            }

            try
            {
                Tela tela = new Tela
                {
                    Nombre = nombre,
                    Stock = stock
                };

                inventario.InsertarTela(tela);
                MessageBox.Show("Tela guardada exitosamente.");

                InventariosTelas inventarioForm = Application.OpenForms["InventariosTelas"] as InventariosTelas;
                if (inventarioForm != null)
                {
                    inventarioForm.ActualizarInventario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonAtrasTelas_Click(object sender, EventArgs e)
        {
            MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
            menuGeneralAdministrador.Show();
            this.Close();
        }

        private void buttonModificarTela_Click(object sender, EventArgs e)
        {
            ModificarTela tela = new ModificarTela();
            tela.Show();
            this.Close();
        }

        private void buttonEliminarTela_Click(object sender, EventArgs e)
        {
            EliminarTela tela = new EliminarTela();
            tela.Show();
            this.Close();
        }
    }
}
