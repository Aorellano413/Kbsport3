using Logica;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Logins;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Vista
{
    public partial class FormLogin : Form
    {
        private ServicioUsuario servicioUsuario = new ServicioUsuario();
        public static bool esInvitado { get; private set; } = false;
        public static bool esEmpleado { get; private set; } = false;

        public FormLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
     
        }

        private void HorFecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "";
            textBoxContraseña.Text = "";
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsuario.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre de usuario.");
                return;
            }

            if (string.IsNullOrEmpty(textBoxContraseña.Text))
            {
                MessageBox.Show("Por favor, ingrese la contraseña.");
                return;
            }

            string nombreUsuario = textBoxUsuario.Text;
            string contraseña = textBoxContraseña.Text;

            this.Hide();

            FormCargando formCargando = new FormCargando();
            formCargando.Show();

            Task.Run(async () =>
            {
               
                await Task.Delay(6400);

                var administrador = servicioUsuario.Autenticar(nombreUsuario, contraseña);
                if (administrador != null)
                {
                    Invoke(new Action(() =>
                    {
                        formCargando.Close();

                        FormLogin.esEmpleado = false;
                        FormLogin.esInvitado = false;

                        MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
                        menuGeneralAdministrador.Show();
                    }));
                    return;
                }

                var empleado = servicioUsuario.AutenticarEmpleado(nombreUsuario, contraseña);
                if (empleado != null)
                {
                    Invoke(new Action(() =>
                    {
                        formCargando.Close();

                        FormLogin.esEmpleado = true;
                        FormLogin.esInvitado = false;

                        MenuGeneralAdministrador menuGeneralAdministrador = new MenuGeneralAdministrador();
                        menuGeneralAdministrador.Show();
                    }));
                    return;
                }

                Invoke(new Action(() =>
                {
                    formCargando.Close();
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }));
            });
        }

        private void buttonExitLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonInvitado_Click(object sender, EventArgs e)
        {
            CatalogoInvitado catalogoInvitado = new CatalogoInvitado();
            catalogoInvitado.Show();
            this.Hide();
        }

        private void buttonNuevoUsuario_Click(object sender, EventArgs e)
        {
            LoginCliente loginCliente = new LoginCliente();
            loginCliente.Show();
            this.Hide();
        }

        private void buttonWpp_Click(object sender, EventArgs e)
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


        private void buttonIG_Click(object sender, EventArgs e)
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

    }
}
