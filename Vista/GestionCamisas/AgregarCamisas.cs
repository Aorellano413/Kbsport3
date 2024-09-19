using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.GestionCamisas;

namespace Vista
{
    public partial class AgregarCamisas : Form
    {
        public AgregarCamisas()
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
            comboBoxTela.Text = "";
        }

        private void dataGridViewAgregarCamisas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonModificarCamisas_Click(object sender, EventArgs e)
        {
            ModificarCamisas modificarCamisas = new ModificarCamisas();
            modificarCamisas.Show();
            this.Close();
        }

        private void buttonValoresCamisas_Click(object sender, EventArgs e)
        {
            AsignarCamisas asignarCamisas = new AsignarCamisas();
            asignarCamisas.Show();
            this.Close();
        }
    }
}
