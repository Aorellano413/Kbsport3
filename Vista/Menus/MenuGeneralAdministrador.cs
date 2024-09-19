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
            AgregarCamisas agregarCamisetas = new AgregarCamisas();
            agregarCamisetas.Show();
            this.Close();
            
        }

        private void ButtonStockCamisetas_Click(object sender, EventArgs e)
        {
            InventariosCamisas stockCamisetas  = new InventariosCamisas();
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

        }
    }
}
