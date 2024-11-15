using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Vista
{
    public partial class Clientes : Form
    {
        private ServicioUsuario servicioUsuario = new ServicioUsuario();
        private DataTable dt = new DataTable();

        public Clientes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            
            ContClientes.Font = new Font(ContClientes.Font.FontFamily, 16, FontStyle.Bold);

            InicializarColumnas();
            CargarClientes();
        }

        private void InicializarColumnas()
        {
            dt.Columns.Add("Cedula");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("Correo_electronico");
        }

        private void CargarClientes()
        {
            var clientes = servicioUsuario.ObtenerTodosClientes();
            dt.Clear();

            if (clientes != null && clientes.Count > 0)
            {
                foreach (var cliente in clientes)
                {
                    dt.Rows.Add(cliente.Cedula, cliente.Nombre, cliente.Apellido, cliente.Telefono, cliente.Direccion, cliente.Correo_electronico);
                }
                ContClientes.Text = $"Total de clientes: {clientes.Count}";
            }
            else
            {
                ContClientes.Text = "Total de clientes: 0";
            }

            dataGridViewClientes.DataSource = dt;
        }


        private void textBoxCedulaClientes_TextChanged(object sender, EventArgs e)
        {
            string cedulaText = textBoxCedulaClientes.Text.Trim();

            if (string.IsNullOrEmpty(cedulaText))
            {
                CargarClientes();
            }
            else
            {
                int cedula;
                if (int.TryParse(cedulaText, out cedula))  
                {
                    var clientes = servicioUsuario.ObtenerTodosClientes();
                    var clientesFiltrados = new List<Cliente>();

            
                    foreach (var cliente in clientes)
                    {
                        if (cliente.Cedula.ToString().Contains(cedulaText))
                        {
                            clientesFiltrados.Add(cliente);
                        }
                    }

                  
                    dt.Clear();
                    foreach (var cliente in clientesFiltrados)
                    {
                        dt.Rows.Add(cliente.Cedula, cliente.Nombre, cliente.Apellido, cliente.Telefono, cliente.Direccion, cliente.Correo_electronico);
                    }

                    dataGridViewClientes.DataSource = dt;

                
                    if (clientesFiltrados.Count == 0)
                    {
                        dataGridViewClientes.DataSource = null;
                    }
                }
                else
                {
                    dt.Clear();  
                    dataGridViewClientes.DataSource = dt;  
                }
            }
        }


        private void buttonAtrasClientes_Click(object sender, EventArgs e)
        {
            MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
            menuGeneralAdministrador.Show();
            this.Close();
        }
    }
}
