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
    public partial class Talla : Form
    {
        public string Nombre { get; internal set; }

        public Talla()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
            menuGeneralAdministrador.Show();
            this.Close();
        }

        private void buttonAcepetarTalla_Click(object sender, EventArgs e)
        {

        }

        private void buttonBorrarTalla_Click(object sender, EventArgs e)
        {

        }
    }
}
