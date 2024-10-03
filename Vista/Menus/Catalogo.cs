using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Logica;

namespace Vista
{
    public partial class Catalogo : Form
    {
        CamisasBD camisasBD = new CamisasBD();
        private Panel panelSeleccionado = null;

        public Catalogo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarCamisasConFotos();
        }

        private void CargarCamisasConFotos()
        {
            DataTable camisas = camisasBD.ObtenerTodasLasCamisas();
            Colombiana.Controls.Clear();

            foreach (DataRow fila in camisas.Rows)
            {
                PictureBox pictureBoxFoto = new PictureBox();
                pictureBoxFoto.Size = new Size(100, 100);
                pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                string rutaImagen = fila["foto"].ToString();
                pictureBoxFoto.Image = Image.FromFile(rutaImagen);

                Label labelInfo = new Label();
                labelInfo.Text = $"Equipo: {fila["equipo"]}\nTalla: {fila["talla"]}\nPrecio: ${fila["precio"]}";
                labelInfo.AutoSize = true;

                Panel panelCamisa = new Panel();
                panelCamisa.BorderStyle = BorderStyle.FixedSingle;
                panelCamisa.Size = new Size(150, 200);
                panelCamisa.Margin = new Padding(10);

                panelCamisa.Controls.Add(pictureBoxFoto);
                pictureBoxFoto.Location = new Point(25, 10);
                panelCamisa.Controls.Add(labelInfo);
                labelInfo.Location = new Point(10, 120);

                panelCamisa.Click += (sender, e) => SeleccionarCamisa(panelCamisa, fila);

                Colombiana.Controls.Add(panelCamisa);
            }
        }

        private void SeleccionarCamisa(Panel panelCamisa, DataRow datosCamisa)
        {
            if (panelSeleccionado != null)
            {
                panelSeleccionado.BackColor = Color.White;
            }

            panelCamisa.BackColor = Color.LightBlue;
            panelSeleccionado = panelCamisa;

            string equipoSeleccionado = datosCamisa["equipo"].ToString();
            string tallaSeleccionada = datosCamisa["talla"].ToString();
            decimal precioSeleccionado = Convert.ToDecimal(datosCamisa["precio"]);

            MessageBox.Show($"Has seleccionado la camisa del equipo {equipoSeleccionado}, Talla: {tallaSeleccionada}, Precio: {precioSeleccionado:C}");
        }

        private void buttonAtrasCliente_Click(object sender, EventArgs e)
        {
            MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
            menuGeneralAdministrador.Show();
            this.Close();
        }

        private void buttonSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
