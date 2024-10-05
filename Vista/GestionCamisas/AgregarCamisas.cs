using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Logica;
using Persistencia;
using Vista.GestionCamisas;

namespace Vista
{
    public partial class AgregarCamisas : Form
    {
        public List<Tela> telas = new List<Tela>();
        public List<Liga> Ligas = new List<Liga>();
        public List<Talla> Tallas = new List<Talla>();
        CamisasBD camisasBD = new CamisasBD();
        DataTable dt = new DataTable();
        private string rutaImagenSeleccionada;

        public AgregarCamisas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InicializarDataTable();
            CargarTelas();
        }

        private void InicializarDataTable()
        {
            dt.Columns.Add("LIGA");
            dt.Columns.Add("TALLA");
            dt.Columns.Add("PRECIO");
            dt.Columns.Add("TELA");
            dt.Columns.Add("STOCK");
            dt.Columns.Add("FOTO");

            dataGridViewCamisas.DataSource = dt;
        }

        private void CargarTelas()
        {
            var telas = camisasBD.ObtenerTelas();
            comboBoxTela.DataSource = telas;
            comboBoxTela.DisplayMember = "Nombre";
            comboBoxTela.ValueMember = "Id";
        }

        private void buttonFotoAñadir_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaImagenSeleccionada = openFileDialog.FileName;
                    pictureBoxFoto.Image = Image.FromFile(rutaImagenSeleccionada);
                    pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxFoto.Tag = rutaImagenSeleccionada;
                }
            }
        }

        private void buttonRegistrarCamisas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLiga.Text) ||
                string.IsNullOrWhiteSpace(textBoxTalla.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrecio.Text) ||
                string.IsNullOrWhiteSpace(textBoxStcok.Text) ||
                comboBoxTela.SelectedItem == null ||
                string.IsNullOrEmpty(rutaImagenSeleccionada))
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione una imagen antes de registrar la camisa.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string liga = textBoxLiga.Text;
            string talla = textBoxTalla.Text;
            string precio = textBoxPrecio.Text;
            string stock = textBoxStcok.Text;
            string tela = ((Tela)comboBoxTela.SelectedItem).Nombre;

            DataRow nuevaFila = dt.NewRow();
            nuevaFila["LIGA"] = liga;
            nuevaFila["TALLA"] = talla;
            nuevaFila["PRECIO"] = precio;
            nuevaFila["STOCK"] = stock;
            nuevaFila["TELA"] = tela;
            nuevaFila["FOTO"] = rutaImagenSeleccionada;

            dt.Rows.Add(nuevaFila);

            textBoxLiga.Clear();
            textBoxTalla.Clear();
            textBoxPrecio.Clear();
            textBoxStcok.Clear();
            comboBoxTela.SelectedIndex = -1;
            rutaImagenSeleccionada = null;
            pictureBoxFoto.Image = null;
        }
    }
}
