using System;
using Entidades;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class DatosUsuario
    {
        private ConexionDAL conexionDAL = new ConexionDAL();


        public Cliente ObtenerCliente(int cedula)
        {
            using (var connection = conexionDAL.AbrirConexion())
            {
                string query = "SELECT * FROM CLIENTES WHERE Cedula = @cedula";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@cedula", cedula);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Cliente
                        {
                            Cedula = reader.GetInt32("Cedula"),
                            Nombre = reader.GetString("Nombre"),
                            Apellido = reader.GetString("Apellido"),
                            Telefono = reader.GetString("Telefono"),
                            Direccion = reader.GetString("Direccion")
                        };
                    }
                }
            }
            return null;
        }



        public void AgregarCliente(Cliente cliente)
        {
            using (var connection = conexionDAL.AbrirConexion())
            {
                string query = "INSERT INTO CLIENTES (Cedula, Nombre, Apellido, Telefono, Direccion) VALUES (@cedula, @nombre, @apellido, @telefono, @direccion)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@cedula", cliente.Cedula);
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);

                cmd.ExecuteNonQuery();
            }
        }

        public Administrador ObtenerAdministrador(string usuario, string contraseña)
        {
            using (var connection = conexionDAL.AbrirConexion())
            {
                string query = "SELECT Id_Administrador, Usuario, Contraseña FROM Administradores WHERE Usuario = @usuario AND Contraseña = @contraseña";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Administrador
                            {
                                IdAdministrador = reader.GetInt32("Id_Administrador"),
                                Usuario = reader.GetString("Usuario"),
                                Contraseña = reader.GetString("Contraseña")
                            };
                        }
                    }
                }
            }
            return null;
        }

    }
}
