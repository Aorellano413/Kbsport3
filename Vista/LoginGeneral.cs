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
    public partial class LoginGeneral : Form
    {
        public LoginGeneral()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {

            LoginCliente loginClienteForm = new LoginCliente();
            loginClienteForm.Show();

            this.Hide();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            
             LoginAdministador loginAdministradorForm = new LoginAdministador();
            loginAdministradorForm.Show();


            this.Hide();
        }

        private void HORA_Tick(object sender, EventArgs e)
        {
            labelFECHA.Text = DateTime.Now.ToLongDateString();
        }

        private void buttonExitGeneral_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAtrasGeneral_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }
    }
}
