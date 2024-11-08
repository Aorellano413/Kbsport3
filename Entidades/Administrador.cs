using System;

namespace Entidades
{
    public class Administrador
    {
        public int IdAdministrador { get; set; }  
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public int IdPersonaAdministrador { get; set; } 
    }
}
