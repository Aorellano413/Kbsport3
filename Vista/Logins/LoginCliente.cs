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

                if (txtCedula.Visible && txtCedula.Text.Length != 10)
                {
                    MessageBox.Show("La cédula debe tener 10 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (string.IsNullOrWhiteSpace(txtCedula.Text))
                {
                    MessageBox.Show("La cédula es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int cedula = int.Parse(txtCedula.Text);
                ServicioUsuario servicioUsuario = new ServicioUsuario();

                Cliente clienteExistente = servicioUsuario.ObtenerClientePorCedula(cedula);
                if (clienteExistente != null)
                {
       
                    MessageBox.Show("Ya has ingresado anteriormente, bienvenido nuevamente.",
                                     "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Catalogo catalogo = new Catalogo(clienteExistente);
                    catalogo.Show();
                    this.Close();
                    return;
                }

            
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                    string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                    string.IsNullOrWhiteSpace(textBoxCorreo.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("El nombre solo debe contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(txtApellido.Text, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("El apellido solo debe contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(txtTelefono.Text, @"^\d+$"))
                {
                    MessageBox.Show("El teléfono debe contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string correo = textBoxCorreo.Text;

                Cliente clienteConCorreo = servicioUsuario.ObtenerClientePorCorreo(correo);
                if (clienteConCorreo != null)
                {
                    MessageBox.Show("El correo electrónico ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               
                Cliente cliente = new Cliente
                {
                    Cedula = cedula,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Telefono = txtTelefono.Text,
                    Direccion = txtDireccion.Text,
                    Correo_electronico = correo
                };

                servicioUsuario.AgregarCliente(cliente);

                MessageBox.Show("Cliente registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Catalogo catalogoNuevo = new Catalogo(cliente);
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

        private void buttonIGCliente_Click(object sender, EventArgs e)
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

        private void buttonWppCliente_Click(object sender, EventArgs e)
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

