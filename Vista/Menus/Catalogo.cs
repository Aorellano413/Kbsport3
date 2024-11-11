using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Entidades;
using Logica;
using System.Linq;
using System.Speech.Synthesis;

namespace Vista
{
    public partial class Catalogo : Form
    {
        private PedidosBD pedidosBD = new PedidosBD();
        private InventarioBD inventarioBD = new InventarioBD();
        private CamisasBD camisasBD = new CamisasBD();
        private Panel panelSeleccionado = null;
        private decimal totalAPagar = 0;
        public static bool esInvitado { get; private set; } = false;

        private Dictionary<int, int> camisasSeleccionadas = new Dictionary<int, int>();

        public Catalogo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarCamisasConFotos();
        }

        private void CargarCamisasConFotos(string liga = null, string talla = null)
        {
            DataTable camisas;

          
            if (liga != null && talla != null)
            {
                camisas = camisasBD.ObtenerCamisasPorLigaYtalla(liga, talla);
            }
            else if (liga != null)
            {
                camisas = camisasBD.ObtenerCamisasPorLiga(liga);
            }
            else if (talla != null)
            {
                camisas = camisasBD.ObtenerCamisasPorTalla(talla);
            }
            else
            {
                camisas = camisasBD.ObtenerTodasLasCamisas();
            }

            flowLayoutPanelCamisasVentas.Controls.Clear();

            foreach (DataRow fila in camisas.Rows)
            {
                List<CamisaTela> telas = camisasBD.ObtenerTelasDeCamisa(Convert.ToInt32(fila["id_camisa"]));
                string nombreTela = telas.Count > 0 ? telas[0].NombreTela : "Desconocida";
                string tallaCamisa = fila["talla"].ToString();

                PictureBox pictureBoxFoto = new PictureBox
                {
                    Size = new Size(100, 100),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Image = System.Drawing.Image.FromFile(fila["foto"].ToString())
                };

                Label labelInfo = new Label
                {
                    Text = $"Equipo: {fila["equipo"]}\nTela: {nombreTela}\nTalla: {tallaCamisa}\nPrecio: ${fila["precio"]}",
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
            if (decimal.TryParse(txtEfectivo.Text, out decimal efectivoIngresado))
            {
                if (efectivoIngresado >= totalAPagar)
                {
                    decimal cambio = efectivoIngresado - totalAPagar;
                    labelCambioRegreso.Text = cambio.ToString("C");

                    Pedido pedido = new Pedido
                    {
                        FechaPedido = DateTime.Now,
                        Id = 1
                    };

                    int idPedido = pedidosBD.CrearPedido(pedido);
                    List<DetallePedido> detallesPedido = new List<DetallePedido>();

                    foreach (Control control in flowLayoutPanelCamisasVentas.Controls)
                    {
                        if (control is Panel panelCamisa && panelCamisa.Tag != null)
                        {
                            int idCamisa = (int)panelCamisa.Tag;
                            int cantidadSeleccionada = ObtenerCantidadSeleccionada(panelCamisa);

                            DetallePedido detalle = new DetallePedido
                            {
                                Cantidad = cantidadSeleccionada,
                                IdPedido = idPedido,
                                IdCamisa = idCamisa
                            };

                            pedidosBD.AgregarDetallePedido(detalle);
                            detallesPedido.Add(detalle);

                            List<CamisaTela> telas = camisasBD.ObtenerTelasDeCamisa(idCamisa);
                            foreach (var tela in telas)
                            {
                                int cantidadTotal = tela.Cantidad * cantidadSeleccionada;

                                inventarioBD.DescontarStockTela(tela.IdTelaCamisa, cantidadTotal);
                            }
                        }
                    }

                    if (detallesPedido.Count > 0)
                    {
                        CrearPDF(detallesPedido);
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

        private void CrearPDF(List<DetallePedido> detallesPedido)
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaPDF = Path.Combine(rutaEscritorio, "FacturaKB_Sport3.pdf");

            Document documento = new Document(PageSize.A4);
            PdfWriter.GetInstance(documento, new FileStream(rutaPDF, FileMode.Create));

            documento.Open();

            string rutaLogo = @"E:\Universidad\BASE DE DATOS\Krsport3.png";

            if (File.Exists(rutaLogo))
            {
                try
                {
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(rutaLogo);
                    logo.ScaleToFit(100, 100);
                    logo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    documento.Add(logo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar la imagen: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("La imagen no se encuentra en la ruta especificada.");
            }

            documento.Add(new Paragraph("Factura de Compra KB Sport3"));
            documento.Add(new Paragraph("\n"));

            decimal totalFactura = 0;
            foreach (var detallePedido in detallesPedido)
            {
                if (detallePedido.Cantidad > 0)
                {
                    Camisa camisa = camisasBD.ObtenerCamisaPorId(detallePedido.IdCamisa);

                    decimal totalCamisa = camisa.Precio * detallePedido.Cantidad;
                    documento.Add(new Paragraph($"Talla: {camisa.Talla}"));
                    documento.Add(new Paragraph($"Precio: {camisa.Precio.ToString("C")}"));
                    documento.Add(new Paragraph($"Cantidad: {detallePedido.Cantidad}"));
                    documento.Add(new Paragraph($"Total: {totalCamisa.ToString("C")}\n"));

                    totalFactura += totalCamisa;
                }
            }

            documento.Add(new Paragraph($"Total a pagar: {totalFactura.ToString("C")}"));
            documento.Close();

            MessageBox.Show($"El PDF de la factura se ha guardado en el escritorio como 'FacturaKB_Sport3.pdf'.");
        }

        private int ObtenerCantidadSeleccionada(Panel panelCamisa)
        {
            if (camisasSeleccionadas.TryGetValue((int)panelCamisa.Tag, out int cantidad))
            {
                return cantidad;
            }
            return 0;
        }

        private void Chatvoz_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Las ligas disponibles en nuestro catalogo son : LaLiga EA Sports, LaLiga BetPlay Dimayor, LaLiga Premier League y LaLiga Serie A.");
        }

        private string ligaSeleccionada = null;
        private string tallaSeleccionada = null;

        private void buttonEA_Click(object sender, EventArgs e)
        {
            ligaSeleccionada = "EA Sports";
            tallaSeleccionada = null; 
            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
        }

        private void buttonDimayor_Click(object sender, EventArgs e)
        {
            ligaSeleccionada = "BetPlay Dimayor";
            tallaSeleccionada = null;  
            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
        }

        private void buttonPremier_Click(object sender, EventArgs e)
        {
            ligaSeleccionada = "Premier League";
            tallaSeleccionada = null;  
            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
        }

        private void buttonSerieA_Click(object sender, EventArgs e)
        {
            ligaSeleccionada = "Serie A";
            tallaSeleccionada = null;  
            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
        }

        private void buttonTallaM_Click(object sender, EventArgs e)
        {
            tallaSeleccionada = "M";
            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
        }

        private void buttonTALLAS_Click(object sender, EventArgs e)
        {
            tallaSeleccionada = "S";
            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            tallaSeleccionada = "L";
            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
        }

        private void buttonTALLAXL_Click(object sender, EventArgs e)
        {
            tallaSeleccionada = "XL";
            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
        }

        private void buttonRestablecerCatalogo_Click(object sender, EventArgs e)
        {
            ligaSeleccionada = null; 
            tallaSeleccionada = null;  
            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
        }

    }
}
