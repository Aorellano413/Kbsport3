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
    public partial class FormLogin : Form
    {
        private ServicioUsuario servicioUsuario = new ServicioUsuario();

        public FormLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void HorFecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "";
            textBoxContraseña.Text = "";
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxUsuario.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre de usuario.");
                return;
            }

            if (string.IsNullOrEmpty(textBoxContraseña.Text))
            {
                MessageBox.Show("Por favor, ingrese la contraseña.");
                return;
            }

            if (ComboRoll.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un rol.");
                return;
            }

            string nombreUsuario = textBoxUsuario.Text;
            string contraseña = textBoxContraseña.Text;
            string rolSeleccionado = ComboRoll.SelectedItem.ToString();

            var usuario = servicioUsuario.Autenticar(nombreUsuario, contraseña, rolSeleccionado);

            if (usuario != null)
            {
                if (rolSeleccionado == "Administrador")
                {
                     MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
                    menuGeneralAdministrador.Show();
                    this.Hide();
                }
                else if (rolSeleccionado == "Cliente")
                {
                
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void buttonExitLogin_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void buttonNuevoUsuario_Click(object sender, EventArgs e)
        {
            LoginNuevoUsuario loginClienteForm = new LoginNuevoUsuario();
            loginClienteForm.Show();

            this.Hide();
        }
    }
}
