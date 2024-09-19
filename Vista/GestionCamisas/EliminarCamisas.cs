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
    public partial class EliminarCamisas : Form
    {
        public EliminarCamisas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void buttonSalirEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAtrasEliminar_Click(object sender, EventArgs e)
        {
            AgregarCamisas agregarCamisas = new AgregarCamisas();
            agregarCamisas.Show();
            this.Close(); ;
        }
    }
}
