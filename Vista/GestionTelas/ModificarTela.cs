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
    public partial class ModificarTela : Form
    {
        public ModificarTela()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonAtrasModificarTelas_Click(object sender, EventArgs e)
        {
            AgregarTela agregarTela = new AgregarTela();
            agregarTela.Show();
            this.Close();
        }

        private void buttonModificarTela_Click(object sender, EventArgs e)
        {

        }
    }
}
