using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Vista
{
    public partial class CatalogoInvitado : Form
    {
        private CamisasBD camisasBD = new CamisasBD();
        private string ligaSeleccionada = null;
        private string tallaSeleccionada = null;
        private Panel panelSeleccionado = null;
        private decimal totalAPagar1 = 0;
        private Dictionary<int, int> camisasSeleccionadas = new Dictionary<int, int>();

        public CatalogoInvitado()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
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

            flowLayoutPanelCamisasinvitado.Controls.Clear();

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

                flowLayoutPanelCamisasinvitado.Controls.Add(panelCamisa);
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

            totalAPagar1 += precioSeleccionado;
            labelTotalApagar1.Text = totalAPagar1.ToString("C");

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

            MessageBox.Show($"Has seleccionado la camisa del equipo {equipoSeleccionado}, Talla: {tallaSeleccionada}, Precio: {precioSeleccionado:C}.\nTotal a pagar: {totalAPagar1:C}");
        }
        private void buttonSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void MostrarMensajeInvitado()
        {
            MessageBox.Show("La funcionalidad de compra no está disponible para usuarios invitados.", "Función Restringida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDimayor1_Click(object sender, EventArgs e)
        {
            ligaSeleccionada = "BetPlay Dimayor";
            tallaSeleccionada = null;
            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
        }

        private void buttonPremier1_Click(object sender, EventArgs e)
        {
            ligaSeleccionada = "Premier League";
            tallaSeleccionada = null;
            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
        }

        private void buttonSerieA1_Click(object sender, EventArgs e)
        {
            ligaSeleccionada = "Serie A";
            tallaSeleccionada = null;
            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
        }

        private void buttonEA1_Click(object sender, EventArgs e)
        {
            ligaSeleccionada = "EA Sports";
            tallaSeleccionada = null;
            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
        }

        private void buttonTALLAXL1_Click(object sender, EventArgs e)
        {
            tallaSeleccionada = "XL";
            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
        }

        private void buttonL1_Click(object sender, EventArgs e)
        {
            tallaSeleccionada = "L";
            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
        }

        private void buttonTALLAS1_Click(object sender, EventArgs e)
        {
            tallaSeleccionada = "S";
            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
        }

        private void buttonTallaM1_Click(object sender, EventArgs e)
        {
            tallaSeleccionada = "M";
            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
        }

        private void buttonRestablecerCatalogo1_Click(object sender, EventArgs e)
        {
            ligaSeleccionada = null;
            tallaSeleccionada = null;
            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
        }

        private void buttonSalirCliente1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAtrasInvitado_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void Chatvoz1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La funcionalidad de compra no está disponible para usuarios invitados.", "Función Restringida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonConfirmar1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("La funcionalidad de compra no está disponible para usuarios invitados.", "Función Restringida", MessageBoxButtons.OK, MessageBoxIcon.Information);


            totalAPagar1 = 0;
            labelTotalApagar1.Text = totalAPagar1.ToString("C");


            camisasSeleccionadas.Clear();


            if (panelSeleccionado != null)
            {
                panelSeleccionado.BackColor = Color.White;
            }
            panelSeleccionado = null;


            flowLayoutPanelCamisasinvitado.Controls.Clear();

            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
        }


        private void buttonRestablecerCatalogo1_Click_1(object sender, EventArgs e)
        {
            ligaSeleccionada = null;
            tallaSeleccionada = null;
            CargarCamisasConFotos(ligaSeleccionada, tallaSeleccionada);
        }
    }
}
