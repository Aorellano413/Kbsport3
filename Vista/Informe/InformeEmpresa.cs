using iTextSharp.text.pdf;
using iTextSharp.text;
using Logica;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;


namespace Vista
{
    public partial class InformeEmpresa : Form
    {
        PedidosBD pedidosBD = new PedidosBD();

        public InformeEmpresa()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonAtrasInforme_Click(object sender, EventArgs e)
        {

            MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
            menuGeneralAdministrador.Show();
            this.Close();
        }

        private void INFORME_Click(object sender, EventArgs e)
        {

            int anoSeleccionado = DateTime.Now.Year;


            DataTable dtPedidosPorAno = pedidosBD.ObtenerPedidosPorAnoKB(anoSeleccionado);


            dataGridViewInforme.DataSource = dtPedidosPorAno;


            dataGridViewInforme.Columns["CantidadPedidos"].Visible = false;
        }

        private void buttonPDFInforme_Click(object sender, EventArgs e)
        {
            if (dataGridViewInforme.Rows.Count == 0 || dataGridViewInforme.DataSource == null)
            {
                MessageBox.Show("Debe generar primero el informe antes de exportarlo a PDF.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(escritorio, "InformePedidos_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf");

            Document documento = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 10f);

            try
            {
                PdfWriter.GetInstance(documento, new FileStream(rutaArchivo, FileMode.Create));
                documento.Open();

                Font fontTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
                Paragraph titulo = new Paragraph("Informe de Pedidos", fontTitulo);
                titulo.Alignment = Element.ALIGN_CENTER;
                documento.Add(titulo);

                documento.Add(new Paragraph("\n"));

                PdfPTable tabla = new PdfPTable(2);
                tabla.WidthPercentage = 80;
                tabla.SpacingBefore = 5f;
                tabla.SpacingAfter = 5f;
                tabla.DefaultCell.Padding = 5;
                tabla.HorizontalAlignment = Element.ALIGN_CENTER;

                PdfPCell cellMes = new PdfPCell(new Phrase("Mes", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
                cellMes.HorizontalAlignment = Element.ALIGN_CENTER;
                cellMes.BackgroundColor = BaseColor.LIGHT_GRAY;
                tabla.AddCell(cellMes);

                PdfPCell cellTotal = new PdfPCell(new Phrase("TotalDinero", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
                cellTotal.HorizontalAlignment = Element.ALIGN_CENTER;
                cellTotal.BackgroundColor = BaseColor.LIGHT_GRAY;
                tabla.AddCell(cellTotal);

                string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

                for (int i = 0; i < dataGridViewInforme.Rows.Count; i++)
                {
                    if (!dataGridViewInforme.Rows[i].IsNewRow)
                    {
                        tabla.AddCell(meses[i]);
                        object valor = dataGridViewInforme.Rows[i].Cells["TotalDinero"].Value;
                        tabla.AddCell(valor != null ? valor.ToString() : "0,00");
                    }
                }

                documento.Add(tabla);

                Font fontFooter = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                Font fontAdminBold = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);

                Paragraph fecha = new Paragraph("Fecha de generación: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), fontFooter);
                fecha.Alignment = Element.ALIGN_LEFT;
                documento.Add(fecha);

                Chunk textoGenerado = new Chunk("Generado por el Administrador ", fontFooter);
                Chunk nombreAdmin = new Chunk("Andres Orellano", fontAdminBold);
                Paragraph admin = new Paragraph();
                admin.Alignment = Element.ALIGN_LEFT;
                admin.Add(textoGenerado);
                admin.Add(nombreAdmin);
                documento.Add(admin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message);
            }
            finally
            {
                documento.Close();
            }

            MessageBox.Show("PDF generado exitosamente en: " + rutaArchivo);
        }


    }
}

