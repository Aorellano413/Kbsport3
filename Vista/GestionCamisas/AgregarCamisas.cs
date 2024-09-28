using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
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
        DataTable dt = new DataTable();

        private void CargarTelas()
        {
            var telas = camisasBD.ObtenerTelas();
            comboBoxTela.DataSource = telas;
            comboBoxTela.DisplayMember = "Nombre";
            comboBoxTela.ValueMember = "Id";
        }

        private void InicializarDataTable()
        {
            dt.Columns.Add("EQUIPO");
            dt.Columns.Add("TALLA");
            dt.Columns.Add("PRECIO");
            dt.Columns.Add("TELA");
            dt.Columns.Add("STOCK");
            dt.Columns.Add("FOTO");

            dataGridViewCamisas.DataSource = dt;
        }

        public AgregarCamisas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InicializarDataTable();
            CargarTelas();

            textBoxAgregarCamisas.KeyPress += new KeyPressEventHandler(ValidarSoloLetras);
            textBoxTallaCamisas.KeyPress += new KeyPressEventHandler(ValidarSoloLetras);
            textBoxPrecioCamisas.KeyPress += new KeyPressEventHandler(ValidarSoloNumeros);
            textBoxStcok.KeyPress += new KeyPressEventHandler(ValidarSoloNumeros);
        }

   
        private void ValidarSoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
                MessageBox.Show("Solo se permiten letras.");
            }
        }

        private void ValidarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
                MessageBox.Show("Solo se permiten números.");
            }
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
            string equipo = textBoxAgregarCamisas.Text;
            string talla = textBoxTallaCamisas.Text;
            decimal precio;
            decimal.TryParse(textBoxPrecioCamisas.Text, out precio);
            Tela telaSeleccionada = (Tela)comboBoxTela.SelectedItem;
            int stock;
            int.TryParse(textBoxStcok.Text, out stock);
            string color = textBoxColorCamisas.Text;

            string foto = pictureBoxFoto.Tag as string;

            if (string.IsNullOrEmpty(foto))
            {
                MessageBox.Show("Por favor, seleccione una imagen para la camiseta.");
                return;
            }

            if (string.IsNullOrEmpty(color))
            {
                MessageBox.Show("Por favor, ingrese un color para la camiseta.");
                return;
            }

            Camisa nuevaCamisa = new Camisa
            {
                Equipo = equipo,
                Talla = talla,
                Precio = precio,
                Tela = telaSeleccionada?.Nombre,
                Stock = stock,
                Color = color,
                Foto = foto
            };

            bool insercionExitosa = camisasBD.InsertarCamisa(nuevaCamisa);

            if (insercionExitosa)
            {
                MessageBox.Show("Camiseta registrada con éxito.");

                
                DataRow nuevaFila = dt.NewRow();
                nuevaFila["EQUIPO"] = equipo;
                nuevaFila["TALLA"] = talla;
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

            textBoxAgregarCamisas.Clear();
            textBoxTallaCamisas.Clear();
            textBoxPrecioCamisas.Clear();
            textBoxStcok.Clear();

            comboBoxTela.SelectedIndex = -1; 
         
            pictureBoxFoto.Image = null;
            pictureBoxFoto.Tag = null; 
        }

    }
}
