using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Entidades;

namespace Logica
{
    public class ServicioUsuario
    {
        private DatosUsuario datosUsuario = new DatosUsuario();

        public object Autenticar(string nombreUsuario, string contraseña, string rol)
        {
            if (rol == "Administrador")
            {
                return datosUsuario.ObtenerAdministrador(nombreUsuario, contraseña);
            }
            else if (rol == "Cliente")
            {
                return datosUsuario.ObtenerCliente(nombreUsuario, contraseña);
            }
            return null;
        }
    }
}
