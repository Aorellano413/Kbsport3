using Entidades;
using Persistencia;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class DatosInventarioCamisa
    {
        ConexionDAL conexion = new ConexionDAL();

        public DataTable MostrarTelas()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT * FROM kb_sport3.telas";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public void InsertarTela(Tela tela)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "INSERT INTO Telas (nombre, stock) VALUES (@nombre, @stock)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", tela.Nombre);
                    cmd.Parameters.AddWithValue("@stock", tela.Stock);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
