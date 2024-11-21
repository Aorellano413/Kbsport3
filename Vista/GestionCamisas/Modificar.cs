using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Modificar : Form
    {
        CamisasBD camisasBD = new CamisasBD();
        DataTable dt = new DataTable();
        public Modificar()
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

            dataGridViewModificarCamisas.DataSource = dt;

            dataGridViewModificarCamisas.Columns["id_camisa"].Visible = false;
            dataGridViewModificarCamisas.Columns["Foto"].Visible = false;
            dataGridViewModificarCamisas.Columns["Imagen"].HeaderText = "Foto";
            dataGridViewModificarCamisas.Columns["Imagen"].Width = 70;
            ((DataGridViewImageColumn)dataGridViewModificarCamisas.Columns["Imagen"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            if (dataGridViewModificarCamisas.Columns[0].HeaderText == "Foto")
            {
                dataGridViewModificarCamisas.Columns.RemoveAt(0);
            }
        }

        private void buttonAtrasCamisas_Click(object sender, EventArgs e)
        {
            AgregarCamisas agregar = new AgregarCamisas();
            agregar.Show();
            this.Close();
        }

        private void buttonRestablecerModificar_Click(object sender, EventArgs e)
        {
            CargarCamisas();
            TXTCAMISAMODIFICAR.Clear();
        }

        private void TXTCAMISAMODIFICAR_TextChanged(object sender, EventArgs e)
        {
            string nombre = TXTCAMISAMODIFICAR.Text.Trim();

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

                dataGridViewModificarCamisas.ScrollBars = ScrollBars.Both;
                dataGridViewModificarCamisas.DataSource = camisasFiltradas;

                dataGridViewModificarCamisas.Columns["id_camisa"].Visible = false;
                dataGridViewModificarCamisas.Columns["Foto"].Visible = false;
                dataGridViewModificarCamisas.Columns["Imagen"].HeaderText = "Foto";
                dataGridViewModificarCamisas.Columns["Imagen"].Width = 70;
                ((DataGridViewImageColumn)dataGridViewModificarCamisas.Columns["Imagen"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }

        private void buttonModificarCamisa_Click(object sender, EventArgs e)
        {
            if (dataGridViewModificarCamisas.SelectedRows.Count > 0)
            {
               
                DataGridViewRow filaSeleccionada = dataGridViewModificarCamisas.SelectedRows[0];

                
                int idCamisa = Convert.ToInt32(filaSeleccionada.Cells["id_camisa"].Value);

           
                if (int.TryParse(filaSeleccionada.Cells["stock"].Value?.ToString(), out int nuevoStock) &&
                    decimal.TryParse(filaSeleccionada.Cells["precio"].Value?.ToString(), out decimal nuevoPrecio))
                {
       
                    camisasBD.ModificarCamisa(idCamisa, nuevoStock, nuevoPrecio);

      
                    MessageBox.Show("Camisa modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarCamisas();
                }
                else
                {
                    MessageBox.Show("Asegúrate de ingresar valores válidos en las columnas de stock y precio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una camisa para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
