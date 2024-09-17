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
        }

        private void buttonAgregarCamisetas_Click(object sender, EventArgs e)
        {
            MenuAgregarCamisetas agregarCamisetas = new MenuAgregarCamisetas();
            agregarCamisetas.Show();
            this.Close();
            
        }

        private void ButtonStockCamisetas_Click(object sender, EventArgs e)
        {
            MenuStockCamisetas stockCamisetas  = new MenuStockCamisetas();
            stockCamisetas.Show();
            this.Close();

        }

        private void buttonInforme_Click(object sender, EventArgs e)
        {
            InformeEmpresa informeEmpresa = new InformeEmpresa();
            informeEmpresa.Show();
            this.Close();
        }

        private void ButtonMenuCliente_Click(object sender, EventArgs e)
        {
            MenuCliente menuCliente = new MenuCliente();    
            menuCliente.Show();
            this.Close();
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
    }
}
