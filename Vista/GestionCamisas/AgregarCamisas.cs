﻿using System;
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
        public List<Equipo> Equipos = new List<Equipo>();

        CamisasBD camisasBD = new CamisasBD();
        DataTable dt = new DataTable();
        private string rutaImagenSeleccionada;

        public AgregarCamisas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InicializarDataTable();
            CargarTelas();
            CargarEquipos();
            CargarLigas();
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
            comboBoxTela.ValueMember = "Id_tela";
        }

        private void CargarEquipos()
        {
            var equipos = camisasBD.ObtenerEquipos();
            comboBoxEquipo.DataSource = equipos;
            comboBoxEquipo.DisplayMember = "Nombre";
            comboBoxEquipo.ValueMember = "Id_equipo";
        }

        private void CargarLigas()
        {
            var ligas = camisasBD.ObtenerLigas();
            comboBoxliga.DataSource = ligas;
            comboBoxliga.DisplayMember = "Nombre";
            comboBoxliga.ValueMember = "Id_liga";
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
                    rutaImagenSeleccionada = openFileDialog.FileName;
                    pictureBoxFoto.Image = Image.FromFile(rutaImagenSeleccionada);
                    pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxFoto.Tag = rutaImagenSeleccionada;
                }
            }
        }

        private void buttonRegistrarCamisas_Click(object sender, EventArgs e)
        {
        
            if (comboBoxliga.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBoxPrecio.Text) ||
                string.IsNullOrWhiteSpace(textBoxStcok.Text) ||
                comboBoxTela.SelectedItem == null ||
                comboBoxEquipo.SelectedItem == null ||
                string.IsNullOrEmpty(rutaImagenSeleccionada) ||
                string.IsNullOrWhiteSpace(textBoxTalla.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione una imagen antes de registrar la camisa.",
                                "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!int.TryParse(textBoxStcok.Text, out int stock) || stock < 0 || stock > 200)
            {
                MessageBox.Show("El stock debe ser un número entre 0 y 200.", "Stock inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBoxPrecio.Text, out decimal precio) || precio < 0 || precio > 250000)
            {
                MessageBox.Show("El precio debe ser un valor entre 0 y 250,000.", "Precio inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string talla = textBoxTalla.Text.Trim();
            if (string.IsNullOrWhiteSpace(talla))
            {
                MessageBox.Show("La talla no puede estar vacía.", "Talla inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int ligaId = ((Entidades.Liga)comboBoxliga.SelectedItem).Id_liga;
            string ligaNombre = ((Entidades.Liga)comboBoxliga.SelectedItem).Nombre;

            int telaId = ((Entidades.Tela)comboBoxTela.SelectedItem).Id_tela;
            string telaNombre = ((Entidades.Tela)comboBoxTela.SelectedItem).Nombre;

            int equipoId = ((Entidades.Equipo)comboBoxEquipo.SelectedItem).Id_equipo;
            string equipoNombre = ((Entidades.Equipo)comboBoxEquipo.SelectedItem).Nombre;

            DataRow nuevaFila = dt.NewRow();
            nuevaFila["LIGA"] = ligaNombre;
            nuevaFila["EQUIPO"] = equipoNombre;
            nuevaFila["TALLA"] = talla;
            nuevaFila["PRECIO"] = precio;
            nuevaFila["STOCK"] = stock;
            nuevaFila["TELA"] = telaNombre;
            nuevaFila["FOTO"] = rutaImagenSeleccionada;

            dt.Rows.Add(nuevaFila);

            Camisa nuevaCamisa = new Camisa
            {
                IdLiga = ligaId,
                IdEquipo = equipoId,
                Talla = talla,
                Precio = precio,
                IdTela = telaId,
                Stock = stock,
                Foto = rutaImagenSeleccionada
            };

            Tela telaSeleccionada = new Tela
            {
                Id_tela = telaId,
                Nombre = telaNombre,
                Stock = stock
            };


            camisasBD.InsertarCamisa(nuevaCamisa);


            comboBoxliga.SelectedIndex = -1;
            textBoxPrecio.Clear();
            textBoxStcok.Clear();
            textBoxTalla.Clear();
            comboBoxTela.SelectedIndex = -1;
            comboBoxEquipo.SelectedIndex = -1;
            rutaImagenSeleccionada = null;
            pictureBoxFoto.Image = null;

            MessageBox.Show("Camisa registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonValoresCamisas_Click(object sender, EventArgs e)
        {
            AsignarCamisas asignarCamisas = new AsignarCamisas();
            asignarCamisas.Show();
            this.Close();
        }

        private void buttonEliminarCamisas_Click(object sender, EventArgs e)
        {
            EliminarCamisas camisas = new EliminarCamisas();
            camisas.Show();
            this.Close();
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



                }
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Modificar modificar = new Modificar(); 
            modificar.Show();
            this.Close();
        }
    }
}
