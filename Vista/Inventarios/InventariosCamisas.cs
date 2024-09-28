using System;
using System.Data;
using System.Windows.Forms;
using Logica; 

namespace Vista
{
    public partial class InventariosCamisas : Form
    {
        CamisasBD camisasBD = new CamisasBD(); 
        DataTable dt = new DataTable(); 

        public InventariosCamisas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarCamisas(); 
        }

        private void CargarCamisas()
        {
            dt = camisasBD.ObtenerTodasLasCamisas();
            dataGridViewStockCamisas.DataSource = dt; 
        }

        private void buttonSalirStock_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDevolverStock_Click(object sender, EventArgs e)
        {
            MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
            menuGeneralAdministrador.Show();
            this.Close();
        }
    }
}
