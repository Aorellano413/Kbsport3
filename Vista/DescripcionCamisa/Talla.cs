using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Vista
{
    public partial class Talla : Form
    {
        InventarioBD inventario = new InventarioBD();

        public string Nombre { get; internal set; }

        public Talla()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
            menuGeneralAdministrador.Show();
            this.Close();
        }

        private void buttonAceptarTalla_Click(object sender, EventArgs e)
        {
            string nombre = txtTalla.Text.Trim();

            try
            {

                Entidades.Talla nuevaTalla = new Entidades.Talla
                {
                    Nombre = nombre
                };


                inventario.InsertarTalla(nuevaTalla);
                MessageBox.Show("Talla guardada exitosamente.");

                txtTalla.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonBorrarTalla_Click(object sender, EventArgs e)
        {
            txtTalla.Clear();
        }

        private void buttonAcepetarTalla_Click(object sender, EventArgs e)
        {

            string nombre = txtTalla.Text.Trim();

            try
            {

                Entidades.Talla nuevaTalla = new Entidades.Talla
                {
                    Nombre = nombre
                };


                inventario.InsertarTalla(nuevaTalla);
                MessageBox.Show("Talla guardada exitosamente.");

                txtTalla.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
