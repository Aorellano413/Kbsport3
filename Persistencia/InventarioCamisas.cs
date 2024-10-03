using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Persistencia
{
    public class InventarioCamisas
    {
        ConexionDAL conexion = new ConexionDAL();

        public DataTable ObtenerTodasLasCamisas()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = conexion.AbrirConexion())
                {
                    string query = "SELECT * FROM Kb_sport3.Camisas"; 
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener las camisas: " + ex.Message);
            }
            return dt;
        }

        
        public DataTable ObtenerCamisasPorNombre(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = conexion.AbrirConexion())
                {
                    string query = "SELECT * FROM Kb_sport3.Camisas WHERE equipo LIKE @nombre";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");   

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener las camisas por nombre: " + ex.Message);
            }
            return dt;
        }

        
        public bool InsertarCamisa(Camisa camisa)
        {
            try
            {
                using (MySqlConnection conn = conexion.AbrirConexion())
                {
                    string query = "INSERT INTO Kb_sport3.Camisas (liga, equipo, talla, precio, tela, stock, foto) " +
                                   "VALUES (@liga, @equipo, @talla, @precio, @tela, @stock, @foto)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@liga", camisa.Liga);
                    cmd.Parameters.AddWithValue("@equipo", camisa.Equipo);
                    cmd.Parameters.AddWithValue("@talla", camisa.Talla);
                    cmd.Parameters.AddWithValue("@precio", camisa.Precio);
                    cmd.Parameters.AddWithValue("@tela", camisa.Tela);
                    cmd.Parameters.AddWithValue("@stock", camisa.Stock);
                    cmd.Parameters.AddWithValue("@foto", camisa.Foto);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar la camisa: " + ex.Message);
                return false;
            }
        }

        public List<Tela> ObtenerTelas()
        {
            List<Tela> telas = new List<Tela>();
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT id_tela, nombre FROM Kb_sport3.Telas;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Tela tela = new Tela
                            {
                                Id = reader.GetInt32("id_tela"),
                                Nombre = reader.GetString("nombre")
                            };
                            telas.Add(tela);
                        }
                    }
                }
            }
            return telas;
        }
    }
}
