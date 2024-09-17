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

            string usuario = textBoxUsuario.Text;
            string contraseña = textBoxContraseña.Text;

   
            if (usuario == "1" && contraseña == "1")
            {
                
               MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
                menuGeneralAdministrador.Show();       
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBoxUsuario.Text = "";
                textBoxContraseña.Text = "";
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
