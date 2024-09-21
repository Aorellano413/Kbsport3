using Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace Persistencia
{
    public class DatosInventario
    {
        ConexionDAL conexion = new ConexionDAL();

        public DataTable MostrarInventario()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT * FROM Kb_sport3.telas;";

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
                string query = "INSERT INTO telas (nombre, stock) VALUES (@nombre, @stock)";
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
