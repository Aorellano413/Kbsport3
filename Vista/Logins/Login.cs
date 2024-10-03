using Logica;
using System;
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

            string nombreUsuario = textBoxUsuario.Text;
            string contraseña = textBoxContraseña.Text;

       
            var usuario = servicioUsuario.Autenticar(nombreUsuario, contraseña);

            if (usuario != null)
            {
      
                MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
                menuGeneralAdministrador.Show();
                this.Hide();
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
