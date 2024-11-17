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
    public partial class MenuGeneralAdministrador : Form
    {
        public MenuGeneralAdministrador()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


            if (FormLogin.esEmpleado)
            {
                NOMBRE.Text = "Daniel Florez";
            }
            else
            {
                NOMBRE.Text = "Andres Orellano";
            }


        }

        private void buttonAgregarCamisetas_Click(object sender, EventArgs e)
        {
            AgregarCamisas agregarCamisetas = new AgregarCamisas();
            agregarCamisetas.Show();
            this.Close();

        }

        private void ButtonStockCamisetas_Click(object sender, EventArgs e)
        {
            InventariosCamisas stockCamisetas = new InventariosCamisas();
            stockCamisetas.Show();
            this.Close();

        }

        private void buttonInforme_Click(object sender, EventArgs e)
        {
            if (FormLogin.esEmpleado)
            {

                MessageBox.Show("No tienes acceso a esta sección.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                InformeEmpresa informeEmpresa = new InformeEmpresa();
                informeEmpresa.Show();
                this.Close();
            }
        }





        private void buttonCerrarAdministrador_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAtrasAdministrador_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();

        }

        private void buttonInventarioTelas_Click(object sender, EventArgs e)
        {
            InventariosTelas inventariosTelas = new InventariosTelas();
            inventariosTelas.Show();
            this.Close();
        }

        private void buttonGestionarTelas_Click(object sender, EventArgs e)
        {
            AgregarTela agregarTela = new AgregarTela();
            agregarTela.Show();
            this.Close();
        }

        private void HorFechaAdmin_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToLongTimeString();
            fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void buttonEquipo_Click(object sender, EventArgs e)
        {

            if (FormLogin.esEmpleado)
            {

                MessageBox.Show("No tienes acceso a esta sección.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Equipo equipo = new Equipo();
                equipo.Show();
                this.Close();
            }

        }
        private void buttonLiga_Click(object sender, EventArgs e)
        {

            if (FormLogin.esEmpleado)
            {

                MessageBox.Show("No tienes acceso a esta sección.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Liga liga = new Liga();
                liga.Show();
                this.Close();
            }
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            if (FormLogin.esEmpleado)
            {

                MessageBox.Show("No tienes acceso a esta sección.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Clientes clientes = new Clientes();
                clientes.Show();
                this.Close();
            }

        }

        private void ButtonProducto_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Close();
        }
    }
}
