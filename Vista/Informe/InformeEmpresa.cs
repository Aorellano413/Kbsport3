using Logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class InformeEmpresa : Form
    {
        PedidosBD pedidosBD = new PedidosBD();

        public InformeEmpresa()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonAtrasInforme_Click(object sender, EventArgs e)
        {

            MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
            menuGeneralAdministrador.Show();
            this.Close();
        }

        private void INFORME_Click(object sender, EventArgs e)
        {

            int anoSeleccionado = DateTime.Now.Year;

        
            DataTable dtPedidosPorAno = pedidosBD.ObtenerPedidosPorAnoKB(anoSeleccionado);


            dataGridViewInforme.DataSource = dtPedidosPorAno;


            dataGridViewInforme.Columns["CantidadPedidos"].Visible = false;
        }
    }
}
