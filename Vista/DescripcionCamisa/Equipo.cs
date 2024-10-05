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
    public partial class Equipo : Form
    {
        public string Nombre { get; internal set; }

        public Equipo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonBorrarEquipo_Click(object sender, EventArgs e)
        {

        }

        private void buttonAceptarEquipo_Click(object sender, EventArgs e)
        {

        }

        private void buttonAtrasEquipo_Click(object sender, EventArgs e)
        {
            MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
            menuGeneralAdministrador.Show();
            this.Close();
        }
    }
}
