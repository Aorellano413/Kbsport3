using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Equipo : Form
    {
        InventarioBD inventario = new InventarioBD();

        public string Nombre { get; internal set; }

        public Equipo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            MostrarEquipos();

        }

        public void MostrarEquipos()
        {
            DataTable dt = inventario.MostrarEquipos();
            dataGridViewEquipo.DataSource = dt;
        }

        private void buttonBorrarEquipo_Click(object sender, EventArgs e)
        {
            textBoxEquipo.Clear();
        }

        private void buttonAceptarEquipo_Click(object sender, EventArgs e)
        {
            string nombre = textBoxEquipo.Text.Trim();

            try
            {

                Entidades.Equipo nuevoEquipo = new Entidades.Equipo
                {
                    Nombre = nombre
                };

                inventario.InsertarEquipo(nuevoEquipo);
                MessageBox.Show("Equipo guardado exitosamente.");

                textBoxEquipo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void buttonAtrasEquipo_Click(object sender, EventArgs e)
        {
            MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
            menuGeneralAdministrador.Show();
            this.Close();
        }
    }
}
