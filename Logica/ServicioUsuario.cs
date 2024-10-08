﻿using Entidades;
using Persistencia;

namespace Logica
{
    public class ServicioUsuario
    {
        private DatosUsuario datosUsuario = new DatosUsuario();

        public Administrador Autenticar(string nombreUsuario, string contraseña)
        {
            return datosUsuario.ObtenerAdministrador(nombreUsuario, contraseña);
        }

        public Cliente ObtenerClientePorCedula(int cedula)
        {
            return datosUsuario.ObtenerCliente(cedula);
        }

        public void AgregarCliente(Cliente cliente)
        {
            datosUsuario.AgregarCliente(cliente);
        }


        public bool ValidarCedulaExistente(int cedula)
        {
            Cliente clienteExistente = ObtenerClientePorCedula(cedula);

            return clienteExistente != null;
        }
    }
}
