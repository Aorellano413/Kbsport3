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
            int stock;

            if (string.IsNullOrEmpty(nombre) || !int.TryParse(textBoxStockTela.Text, out stock))
            {
                MessageBox.Show("Por favor, ingrese datos válidos.");
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
    }
}
