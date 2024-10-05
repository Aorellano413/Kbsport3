using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Logica;
using Vista.GestionCamisas;

namespace Vista
{
    public partial class AgregarCamisas : Form
    {
        public List<Tela> telas = new List<Tela>();
        CamisasBD camisasBD = new CamisasBD();
        CamisaDetalleBD CamisaDetalleBD = new CamisaDetalleBD();
        DataTable dt = new DataTable();

        public AgregarCamisas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InicializarDataTable();
            CargarTelas();
            CargarLigas();
            CargarEquipos();
            CargarTallas();

            textBoxPrecioCamisas.KeyPress += new KeyPressEventHandler(ValidarSoloNumeros);
            textBoxStcok.KeyPress += new KeyPressEventHandler(ValidarSoloNumeros);
        }

        private void InicializarDataTable()
        {
            dt.Columns.Add("LIGA");
            dt.Columns.Add("EQUIPO");
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

        private void CargarLigas()
        {
            var ligas = CamisaDetalleBD.ObtenerLigas();
            comboBoxLiga.DataSource = ligas;
            comboBoxLiga.DisplayMember = "Nombre";
            comboBoxLiga.ValueMember = "Id";
        }

        private void CargarEquipos()
        {
            var equipos = CamisaDetalleBD.ObtenerEquipos();
            comboBoxEquipo.DataSource = equipos;
            comboBoxEquipo.DisplayMember = "Nombre";
            comboBoxEquipo.ValueMember = "Id";
        }

        private void CargarTallas()
        {
            var tallas = CamisaDetalleBD.ObtenerTallas();
            comboBoxTalla.DataSource = tallas;
            comboBoxTalla.DisplayMember = "Nombre";
            comboBoxTalla.ValueMember = "Id";
        }

        private void ValidarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.");
            }
        }

        private void buttonRegistrarCamisas_Click(object sender, EventArgs e)
        {

            Liga ligaSeleccionada = (Liga)comboBoxLiga.SelectedItem;
            Equipo equipoSeleccionado = (Equipo)comboBoxEquipo.SelectedItem;
            Talla tallaSeleccionada = (Talla)comboBoxTalla.SelectedItem;
            Tela telaSeleccionada = (Tela)comboBoxTela.SelectedItem;


            decimal precio;
            if (!decimal.TryParse(textBoxPrecioCamisas.Text, out precio))
            {
                MessageBox.Show("Por favor, ingrese un valor válido para el precio.");
                return;
            }


            int stock;
            if (!int.TryParse(textBoxStcok.Text, out stock))
            {
                MessageBox.Show("Por favor, ingrese un valor válido para el stock.");
                return;
            }


            string foto = pictureBoxFoto.Tag as string;
            if (string.IsNullOrEmpty(foto))
            {
                MessageBox.Show("Por favor, seleccione una imagen para la camiseta.");
                return;
            }


            Camisa nuevaCamisa = new Camisa
            {
                Liga = ligaSeleccionada?.Nombre,
                Equipo = equipoSeleccionado?.Nombre,
                Talla = tallaSeleccionada?.Nombre,
                Precio = precio,
                Tela = telaSeleccionada?.Nombre,
                Stock = stock,
                Foto = foto
            };


            bool insercionExitosa = camisasBD.InsertarCamisa(nuevaCamisa);

            if (insercionExitosa)
            {
                MessageBox.Show("Camiseta registrada con éxito.");


                DataRow nuevaFila = dt.NewRow();
                nuevaFila["LIGA"] = ligaSeleccionada?.Nombre;
                nuevaFila["EQUIPO"] = equipoSeleccionado?.Nombre;
                nuevaFila["TALLA"] = tallaSeleccionada?.Nombre;
                nuevaFila["PRECIO"] = precio;
                nuevaFila["TELA"] = telaSeleccionada?.Nombre;
                nuevaFila["STOCK"] = stock;
                nuevaFila["FOTO"] = foto;

                dt.Rows.Add(nuevaFila);
            }
            else
            {
                MessageBox.Show("Error al registrar la camiseta. Intente de nuevo.");
            }
        }

        private void buttonFotoAñadir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaImagen = openFileDialog.FileName;

                    pictureBoxFoto.Image = Image.FromFile(rutaImagen);
                    pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;

                    pictureBoxFoto.Tag = rutaImagen;
                }
            }
        }

        private void buttonLimpiar_Click_1(object sender, EventArgs e)
        {
            comboBoxLiga.SelectedIndex = -1;
            comboBoxEquipo.SelectedIndex = -1;
            comboBoxTalla.SelectedIndex = -1;
            comboBoxTela.SelectedIndex = -1;

            textBoxPrecioCamisas.Clear();
            textBoxStcok.Clear();

            pictureBoxFoto.Image = null;
            pictureBoxFoto.Tag = null;
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
    }
}
