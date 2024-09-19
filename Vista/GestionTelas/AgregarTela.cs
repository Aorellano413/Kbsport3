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
    public partial class AgregarTela : Form
    {
        public AgregarTela()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonModificarTela_Click(object sender, EventArgs e)
        {
            ModificarTela modificarTela = new ModificarTela();
            modificarTela.Show();
            this.Close();
        }

        private void buttonEliminarTela_Click(object sender, EventArgs e)
        {
            EliminarTela eliminarTela = new EliminarTela();
            eliminarTela.Show();
            this.Close();
        }

        private void buttonGuardarTela_Click(object sender, EventArgs e)
        {

        }

        private void buttonAtrasTelas_Click(object sender, EventArgs e)
        {
            MenuGeneralAdministrador menuGeneralAdministrador   = new MenuGeneralAdministrador();   
            menuGeneralAdministrador.Show();
            this.Close();
        }
    }
}
