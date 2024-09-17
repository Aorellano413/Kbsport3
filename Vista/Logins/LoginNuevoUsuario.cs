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
    public partial class LoginNuevoUsuario : Form
    {
        public LoginNuevoUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonExitCliente_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void buttonRegresarCliente_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();  
            login.Show();
            this.Close();
            
        }

        private void buttonBorrarCliente_Click(object sender, EventArgs e)
        {
            textBoxLoginNombreCliente.Text = "";
            textBoxLoginContraseñaCliente.Text = "";
        }
    }
}
