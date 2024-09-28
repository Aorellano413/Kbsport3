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

        
        public DataTable MostrarNuevaTabla()
        {
            using (MySqlConnection conn = conexion.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Kb_sport3.Camisas;", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
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



        public bool InsertarCamisa(Camisa camisa)
        {
            try
            {
                using (MySqlConnection conn = conexion.AbrirConexion())
                {
                    string query = "INSERT INTO Kb_sport3.Camisas (equipo, talla, precio, tela, color, stock, foto) " +
                                   "VALUES (@equipo, @talla, @precio, @tela, @color, @stock, @foto)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    
                    cmd.Parameters.AddWithValue("@equipo", camisa.Equipo);
                    cmd.Parameters.AddWithValue("@talla", camisa.Talla);
                    cmd.Parameters.AddWithValue("@precio", camisa.Precio);
                    cmd.Parameters.AddWithValue("@tela", camisa.Tela);
                    cmd.Parameters.AddWithValue("@color", camisa.Color);
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
