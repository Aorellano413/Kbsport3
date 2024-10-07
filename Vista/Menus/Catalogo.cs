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
        private decimal totalAPagar = 0;
        private decimal efectivoIngresado = 0;

        public Catalogo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarCamisasConFotos();
        }

        private void CargarCamisasConFotos(string liga = null)
        {
            DataTable camisas = camisasBD.ObtenerTodasLasCamisas();
            flowLayoutPanelCamisasVentas.Controls.Clear();

            foreach (DataRow fila in camisas.Rows)
            {
                if (liga != null && fila["liga"].ToString().ToLower() != liga.ToLower())
                {
                    continue;
                }

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
                pictureBoxFoto.Click += (sender, e) => SeleccionarCamisa(panelCamisa, fila);
                labelInfo.Click += (sender, e) => SeleccionarCamisa(panelCamisa, fila);

                flowLayoutPanelCamisasVentas.Controls.Add(panelCamisa);
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

            totalAPagar += precioSeleccionado;
            labelTotalApagar.Text = totalAPagar.ToString("C");

            MessageBox.Show($"Has seleccionado la camisa del equipo {equipoSeleccionado}, Talla: {tallaSeleccionada}, Precio: {precioSeleccionado:C}.\nTotal a pagar: {totalAPagar:C}");
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

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtEfectivo.Text, out efectivoIngresado))
            {
                if (efectivoIngresado >= totalAPagar)
                {
                    decimal cambio = efectivoIngresado - totalAPagar;
                    labelCambioRegreso.Text = cambio.ToString("C");

                    MessageBox.Show("Compra exitosa. Gracias por preferir Kb_sport3");
                    totalAPagar = 0;
                    labelTotalApagar.Text = totalAPagar.ToString("C");
                    txtEfectivo.Clear();
                    labelCambioRegreso.Text = "$0";
                }
                else
                {
                    labelCambioRegreso.Text = $"Falta: {(totalAPagar - efectivoIngresado):C}";
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida de efectivo.");
            }
        }

        private void textBoxFiltrar_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBoxFiltrar.Text;
            CargarCamisasConFotos(filtro);
        }

        private void buttonRestablecerCatalogo_Click(object sender, EventArgs e)
        {

            textBoxFiltrar.Clear();

            CargarCamisasConFotos();
        }
    }
}
