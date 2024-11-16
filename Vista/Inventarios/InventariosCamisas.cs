using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using Logica;

namespace Vista
{
    public partial class InventariosCamisas : Form
    {
        CamisasBD camisasBD = new CamisasBD();
        DataTable dt = new DataTable();

        public InventariosCamisas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarCamisas();
        }

        private void CargarCamisas()
        {
            dt = camisasBD.ObtenerTodasLasCamisas();

            if (!dt.Columns.Contains("Imagen"))
            {
                dt.Columns.Add("Imagen", typeof(Image));
            }

            foreach (DataRow row in dt.Rows)
            {
                string rutaImagen = row["Foto"].ToString();

                if (System.IO.File.Exists(rutaImagen))
                {
                    try
                    {
                        row["Imagen"] = new Bitmap(Image.FromFile(rutaImagen), new Size(70, 70));
                    }
                    catch
                    {
                        row["Imagen"] = null;
                    }
                }
                else
                {
                    row["Imagen"] = null;
                }
            }

            dataGridViewStockCamisas.DataSource = dt;

            dataGridViewStockCamisas.Columns["id_camisa"].Visible = false;
            dataGridViewStockCamisas.Columns["Foto"].Visible = false;
            dataGridViewStockCamisas.Columns["Imagen"].HeaderText = "Foto";
            dataGridViewStockCamisas.Columns["Imagen"].Width = 70;
            ((DataGridViewImageColumn)dataGridViewStockCamisas.Columns["Imagen"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            if (dataGridViewStockCamisas.Columns[0].HeaderText == "Foto")
            {
                dataGridViewStockCamisas.Columns.RemoveAt(0);
            }
        }

        private void textBoxNombreCamisas_TextChanged(object sender, EventArgs e)
        {
            string nombre = textBoxNombreCamisas.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                CargarCamisas();
            }
            else
            {
                DataTable camisasFiltradas = camisasBD.ObtenerCamisasPorNombre(nombre);

                if (!camisasFiltradas.Columns.Contains("Imagen"))
                {
                    camisasFiltradas.Columns.Add("Imagen", typeof(Image));
                }

                foreach (DataRow row in camisasFiltradas.Rows)
                {
                    string rutaImagen = row["Foto"].ToString();

                    if (System.IO.File.Exists(rutaImagen))
                    {
                        try
                        {
                            row["Imagen"] = new Bitmap(Image.FromFile(rutaImagen), new Size(70, 70));
                        }
                        catch
                        {
                            row["Imagen"] = null;
                        }
                    }
                    else
                    {
                        row["Imagen"] = null;
                    }

                }

                dataGridViewStockCamisas.ScrollBars = ScrollBars.Both;
                dataGridViewStockCamisas.DataSource = camisasFiltradas;

                dataGridViewStockCamisas.Columns["id_camisa"].Visible = false;
                dataGridViewStockCamisas.Columns["Foto"].Visible = false;
                dataGridViewStockCamisas.Columns["Imagen"].HeaderText = "Foto";
                dataGridViewStockCamisas.Columns["Imagen"].Width = 70;
                ((DataGridViewImageColumn)dataGridViewStockCamisas.Columns["Imagen"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }

        private void buttonSalirStock_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDevolverStock_Click(object sender, EventArgs e)
        {
            MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
            menuGeneralAdministrador.Show();
            this.Close();
        }

        private void buttonRestablecer_Click(object sender, EventArgs e)
        {
            CargarCamisas();
            textBoxNombreCamisas.Clear();
        }
    }
}
