using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class DatosUsuario
    {
        private ConexionDAL conexionDAL = new ConexionDAL();

        public Cliente ObtenerCliente(string usuario, string contra)
        {
            using (var connection = conexionDAL.AbrirConexion())
            {
                string query = "SELECT * FROM CLIENTES WHERE Usuario = @usuario AND Contra = @contra";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contra", contra);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Cliente
                        {
                            Id = reader.GetInt32("Id"),
                            Usuario = reader.GetString("Usuario"),
                            Contra = reader.GetString("Contra")
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
                string query = "INSERT INTO CLIENTES (Usuario, Contra) VALUES (@usuario, @contra)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@usuario", cliente.Usuario);
                cmd.Parameters.AddWithValue("@contra", cliente.Contra);

                cmd.ExecuteNonQuery();
            }
        }
        public Administrador ObtenerAdministrador(string usuario, string contra)
        {
            using (var connection = conexionDAL.AbrirConexion())
            {
                string query = "SELECT * FROM ADMINISTRADORES WHERE Usuario = @usuario AND Contra = @contra";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contra", contra);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Administrador
                        {
                            Id = reader.GetInt32("Id"),
                            Usuario = reader.GetString("Usuario"),
                            Contra = reader.GetString("Contra")
                        };
                    }
                }
            }
            return null;
        }

      
    }
}
