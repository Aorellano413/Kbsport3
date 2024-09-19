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
    public partial class EliminarTela : Form
    {
        public EliminarTela()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonEliminarTela_Click(object sender, EventArgs e)
        {

        }

        private void buttonAtrasTela_Click(object sender, EventArgs e)
        {
            AgregarTela agregarTela = new AgregarTela();
            agregarTela.Show();
            this.Close();
        }
    }
}
