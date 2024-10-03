using Persistencia;
using Entidades;

namespace Logica
{
    public class ServicioUsuario
    {
        private DatosUsuario datosUsuario = new DatosUsuario();

        public Administrador Autenticar(string nombreUsuario, string contraseña)
        {
            return datosUsuario.ObtenerAdministrador(nombreUsuario, contraseña);
        }
    }
}
