using System;
using System.Windows.Forms;
using Logica;
using Entidades;

namespace Vista
{
    public partial class LoginCliente : Form
    {
        public LoginCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonExitCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegresarCliente_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void buttonBorrarCliente_Click(object sender, EventArgs e)
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            textBoxCorreo.Clear(); 
        }

        private void buttonAceptarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int cedula = int.Parse(txtCedula.Text);

                ServicioUsuario servicioUsuario = new ServicioUsuario();

                Cliente clienteExistente = servicioUsuario.ObtenerClientePorCedula(cedula);

                if (clienteExistente != null)
                {
                    MessageBox.Show("Ya has ingresado anteriormente, bienvenido nuevamente.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Catalogo catalogo = new Catalogo();
                    catalogo.Show();
                    this.Close();
                    return;
                }

                Cliente cliente = new Cliente
                {
                    Cedula = cedula,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Telefono = txtTelefono.Text,
                    Direccion = txtDireccion.Text,
                    Correo_electronico = textBoxCorreo.Text 
                };

                servicioUsuario.AgregarCliente(cliente);

                MessageBox.Show("Cliente registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Catalogo catalogoNuevo = new Catalogo();
                catalogoNuevo.Show();
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("La cédula debe ser numérica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
