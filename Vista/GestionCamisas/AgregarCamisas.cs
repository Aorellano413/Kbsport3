using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Logica;
using System.Windows.Forms;
using Vista.GestionCamisas;

namespace Vista
{
    public partial class AgregarCamisas : Form
    {
        
        public List<Tela> telas = new List<Tela>();
        CamisasBD camisasBD = new CamisasBD();
        DataTable dt = new DataTable();



        private void InicializarDataTable()
        {
            dt.Columns.Add("EQUIPO");
            dt.Columns.Add("TALLA");
            dt.Columns.Add("PRECIO");
            dt.Columns.Add("TELA");
            dt.Columns.Add("STOCK");
            dt.Columns.Add("FOTO");
            dataGridViewAgregarCamisas.DataSource = dt;
        }

        private void CargarTelas()
        {
            var telas = camisasBD.ObtenerTelas();
            comboBoxTela.DataSource = telas;
            comboBoxTela.DisplayMember = "Nombre";
            comboBoxTela.ValueMember = "Id";
        }

        public AgregarCamisas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarTelas();
        }

        private void buttonCerrarCamisas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAtrasCamisas_Click(object sender, EventArgs e)
        {
            MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
            menuGeneralAdministrador.Show();
            this.Close();
        }

        private void buttonModificarCamisas_Click(object sender, EventArgs e)
        {
            ModificarCamisas modificarCamisas = new ModificarCamisas();
            modificarCamisas.Show();
            this.Close();
        }

        private void buttonValoresCamisas_Click(object sender, EventArgs e)
        {
            AsignarCamisas asignarCamisas = new AsignarCamisas();
            asignarCamisas.Show();
            this.Close();
        }

        private void buttonEliminarCamisas_Click(object sender, EventArgs e)
        {
            EliminarCamisas eliminarCamisas = new EliminarCamisas();
            eliminarCamisas.Show();
            this.Close();
        }

        private void buttonRegistrarCamisas_Click(object sender, EventArgs e)
        {
            

        }

        private void buttonEquipoAñadir_Click(object sender, EventArgs e)
        {
       
        }

        private void buttonTallaAñadir_Click(object sender, EventArgs e)
        {
        
        }

        private void buttonPrecioAñadir_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonTelaAñadir_Click(object sender, EventArgs e)
        {
           
        }

       

        private void buttonStock_Click(object sender, EventArgs e)
        {

        }

        private void buttonColorAñadir_Click(object sender, EventArgs e)
        {

        }

        private void buttonFotoAñadir_Click(object sender, EventArgs e)
        {

        }
    }
}
