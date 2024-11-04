using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Vista
{
    public partial class Catalogo : Form
    {
        private InventarioBD inventarioBD = new InventarioBD();
        private CamisasBD camisasBD = new CamisasBD();
        private Panel panelSeleccionado = null;
        private decimal totalAPagar = 0;
        private decimal efectivoIngresado = 0;
        public static bool esInvitado { get; private set; } = false;


        private Dictionary<int, int> camisasSeleccionadas = new Dictionary<int, int>();

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

                PictureBox pictureBoxFoto = new PictureBox
                {
                    Size = new Size(100, 100),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Image = Image.FromFile(fila["foto"].ToString())
                };

                Label labelInfo = new Label
                {
                    Text = $"Equipo: {fila["equipo"]}\nTalla: {fila["talla"]}\nPrecio: ${fila["precio"]}",
                    AutoSize = true
                };

                Panel panelCamisa = new Panel
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(150, 200),
                    Margin = new Padding(10),
                    Tag = fila["id_camisa"]
                };

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

            int idCamisa = Convert.ToInt32(datosCamisa["id_camisa"]);
            decimal precioSeleccionado = Convert.ToDecimal(datosCamisa["precio"]);


            totalAPagar += precioSeleccionado;
            labelTotalApagar.Text = totalAPagar.ToString("C");

            if (camisasSeleccionadas.ContainsKey(idCamisa))
            {
                camisasSeleccionadas[idCamisa]++;
            }
            else
            {
                camisasSeleccionadas[idCamisa] = 1;
            }

            string equipoSeleccionado = datosCamisa["equipo"].ToString();
            string tallaSeleccionada = datosCamisa["talla"].ToString();

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

    
                    foreach (var entry in camisasSeleccionadas)
                    {
                        int idCamisa = entry.Key;
                        int cantidadSeleccionada = entry.Value; 

                        List<CamisaTela> telas = camisasBD.ObtenerTelasDeCamisa(idCamisa);

                        foreach (var tela in telas)
                        {
                            int cantidadTotal = tela.Cantidad * cantidadSeleccionada; 
                            inventarioBD.DescontarStockTela(tela.IdTelaCamisa, cantidadTotal);
                        }
                    }

                    MessageBox.Show("Compra exitosa. Gracias por preferir KB Sport3.");
                    totalAPagar = 0;
                    labelTotalApagar.Text = totalAPagar.ToString("C");
                    txtEfectivo.Clear();
                    labelCambioRegreso.Text = "$0";
                    camisasSeleccionadas.Clear();
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
