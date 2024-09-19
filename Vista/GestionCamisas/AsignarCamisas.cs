using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.GestionCamisas
{
    public partial class AsignarCamisas : Form
    {
        public AsignarCamisas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonAsignarCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
