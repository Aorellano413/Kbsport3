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
using Persistencia;

namespace Vista
{
    public partial class Catalogo : Form
    {
        private PedidosBD pedidosBD = new PedidosBD();
        private InventarioBD inventarioBD = new InventarioBD();
        private CamisasBD camisasBD = new CamisasBD();
        private DatosFactura datosFactura = new DatosFactura();
        private Cliente clienteActual; 
        private Panel panelSeleccionado = null;
        private decimal totalAPagar = 0;

        private Dictionary<int, int> camisasSeleccionadas = new Dictionary<int, int>();

        public Catalogo(Cliente cliente)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.clienteActual = cliente;
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


            var camisasOrdenadas = camisas.AsEnumerable()
                                           .OrderByDescending(row => row.Field<decimal>("precio"));

            flowLayoutPanelCamisasVentas.Controls.Clear();

            foreach (DataRow fila in camisasOrdenadas)
            {
                List<CamisaTela> telas = camisasBD.ObtenerTelasDeCamisa(Convert.ToInt32(fila["id_camisa"]));
                string nombreTela = telas.Count > 0 ? telas[0].NombreTela : "Desconocida";
                string tallaCamisa = fila["talla"].ToString();
                int stockDisponible = Convert.ToInt32(fila["stock"]);

                PictureBox pictureBoxFoto = new PictureBox
                {
                    Size = new Size(100, 100),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Image = System.Drawing.Image.FromFile(fila["foto"].ToString())
                };

                Label labelInfo = new Label
                {
                    Text = $"Equipo: {fila["equipo"]}\nTela: {nombreTela}\nTalla: {tallaCamisa}\nPrecio: ${fila["precio"]}\nStock: {stockDisponible}",
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

                    
                    Factura factura = new Factura
                    {
                        FechaFactura = DateTime.Now,
                        Total = totalAPagar,
                        Cliente = clienteActual
                    };

                    datosFactura.InsertarFactura(factura);

                   
                    Pedido pedido = new Pedido
                    {
                        FechaPedido = DateTime.Now,
                        Id = factura.Id 
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


        public void CrearPDF(List<DetallePedido> detallesPedido)
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fechaHora = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string rutaPDF = Path.Combine(rutaEscritorio, $"FacturaKB_Sport3_{fechaHora}.pdf");

            Document documento = new Document(PageSize.A5.Rotate());
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

            var tituloFactura = new Paragraph("FACTURA KB_SPORT3")
            {
                Font = FontFactory.GetFont("Times New Roman", 24, iTextSharp.text.Font.BOLD, BaseColor.BLACK),
                Alignment = Element.ALIGN_CENTER
            };
            documento.Add(tituloFactura);

            var datosCliente = new Paragraph($"Cliente: {clienteActual.Nombre} {clienteActual.Apellido}\n" +
                                              $"Cédula: {clienteActual.Cedula}\n" +
                                              $"Correo: {clienteActual.Correo_electronico}\n" +
                                              $"Fecha: {DateTime.Now:dd/MM/yyyy h:mm:ss tt}")
            {
                Font = FontFactory.GetFont("Perpetua", 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK),
                Alignment = Element.ALIGN_LEFT
            };
            documento.Add(datosCliente);

            documento.Add(new Paragraph("\n"));

            PdfPTable tabla = new PdfPTable(5);
            tabla.WidthPercentage = 100;

            PdfPCell cell = new PdfPCell(new Phrase("Equipo", FontFactory.GetFont("Perpetua", 12, iTextSharp.text.Font.BOLD)))
            {
                BackgroundColor = BaseColor.LIGHT_GRAY
            };
            tabla.AddCell(cell);
            tabla.AddCell(new PdfPCell(new Phrase("Talla", FontFactory.GetFont("Perpetua", 12, iTextSharp.text.Font.BOLD))) { BackgroundColor = BaseColor.LIGHT_GRAY });
            tabla.AddCell(new PdfPCell(new Phrase("Precio", FontFactory.GetFont("Perpetua", 12, iTextSharp.text.Font.BOLD))) { BackgroundColor = BaseColor.LIGHT_GRAY });
            tabla.AddCell(new PdfPCell(new Phrase("Cantidad", FontFactory.GetFont("Perpetua", 12, iTextSharp.text.Font.BOLD))) { BackgroundColor = BaseColor.LIGHT_GRAY });
            tabla.AddCell(new PdfPCell(new Phrase("Total", FontFactory.GetFont("Perpetua", 12, iTextSharp.text.Font.BOLD))) { BackgroundColor = BaseColor.LIGHT_GRAY });

            decimal totalFactura = 0;
            foreach (var detallePedido in detallesPedido)
            {
                if (detallePedido.Cantidad > 0)
                {
                    Camisa camisa = camisasBD.ObtenerCamisaPorId(detallePedido.IdCamisa);
                    decimal totalCamisa = camisa.Precio * detallePedido.Cantidad;

                    tabla.AddCell(new PdfPCell(new Phrase(camisa.IdEquipo.ToString(), FontFactory.GetFont("Perpetua", 12))) { HorizontalAlignment = Element.ALIGN_CENTER });
                    tabla.AddCell(new PdfPCell(new Phrase(camisa.Talla, FontFactory.GetFont("Perpetua", 12))) { HorizontalAlignment = Element.ALIGN_CENTER });
                    tabla.AddCell(new PdfPCell(new Phrase(camisa.Precio.ToString("C"), FontFactory.GetFont("Perpetua", 12))) { HorizontalAlignment = Element.ALIGN_CENTER });
                    tabla.AddCell(new PdfPCell(new Phrase(detallePedido.Cantidad.ToString(), FontFactory.GetFont("Perpetua", 12))) { HorizontalAlignment = Element.ALIGN_CENTER });
                    tabla.AddCell(new PdfPCell(new Phrase(totalCamisa.ToString("C"), FontFactory.GetFont("Perpetua", 12))) { HorizontalAlignment = Element.ALIGN_CENTER });

                    totalFactura += totalCamisa;
                }
            }

            documento.Add(tabla);

            documento.Add(new Paragraph("\n"));

            var totalPagar = new Paragraph($"Total a pagar: {totalFactura.ToString("C")}")
            {
                Font = FontFactory.GetFont("Perpetua", 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK),
                Alignment = Element.ALIGN_CENTER
            };
            documento.Add(totalPagar);

            documento.Add(new Paragraph("\n"));

    
            var mensajeAgradecimiento = new Paragraph("Gracias por preferir a la tienda KB_Sport3 no olvides seguirnos en nuestra redes sociales")
            {
                Font = FontFactory.GetFont("Perpetua", 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK),
                Alignment = Element.ALIGN_LEFT
            };
            documento.Add(mensajeAgradecimiento);

            documento.Close();

            MessageBox.Show($"El PDF de la factura se ha guardado en el escritorio como 'FacturaKB_Sport3_{fechaHora}.pdf'.");
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

        private void buttonAtrasCliente_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void buttonIGCatalogo_Click(object sender, EventArgs e)
        {
            string url = "https://instagram.com/kb_sport3?igshid=OGQ5ZDc2ODk2ZA%3D%3D&utm_source=qr";
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir el enlace: {ex.Message}");
            }
        }

        private void buttonWppCatalogo_Click(object sender, EventArgs e)
        {

            string url = "https://w.app/Kbsport3";
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir el enlace: {ex.Message}");
            }
        }
    }
}
