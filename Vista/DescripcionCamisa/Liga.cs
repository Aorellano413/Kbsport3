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
    public partial class Liga : Form
    {
        public Liga()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public string Nombre { get; internal set; }

        private void buttonAceptarLiga_Click(object sender, EventArgs e)
        {

        }

        private void buttonBorrarLiga_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegresarliga_Click(object sender, EventArgs e)
        {
            MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
            menuGeneralAdministrador.Show();
            this.Close();
        }
    }
}
