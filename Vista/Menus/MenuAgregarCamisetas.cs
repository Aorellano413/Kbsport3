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
    public partial class MenuAgregarCamisetas : Form
    {
        public MenuAgregarCamisetas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonCerrarCamisas_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void buttonAtrasCamisas_Click(object sender, EventArgs e)
        {
            MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
            menuGeneralAdministrador.Show();
            this.Close();
        }

        private void buttonBorrarCamposCamisas_Click(object sender, EventArgs e)
        {
            textBoxAgregarCamisas.Text = "";
            textBoxColorCamisas.Text = "";
            textBoxPrecioCamisas.Text = "";
            textBoxTallaCamisas.Text = "";
        }
    }
}
