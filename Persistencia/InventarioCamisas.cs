using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Persistencia
{
    public class InventarioCamisas
    {
        private readonly ConexionDAL conexion = new ConexionDAL();

        public DataTable ObtenerTodasLasCamisas()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = conexion.AbrirConexion())
                {
 
                    string query = @"
                SELECT 
                    c.id_camisa,
                    l.nombre AS Liga,
                    e.nombre AS Equipo,
                    t.nombre AS Talla,
                    c.precio,
                    c.stock,
                    tl.nombre AS Tela,
                    c.foto
                FROM Kb_sport3.Camisas c
                JOIN Kb_sport3.Liga l ON c.id_liga = l.id_liga
                JOIN Kb_sport3.Equipo e ON c.id_equipo = e.id_equipo
                JOIN Kb_sport3.Talla t ON c.id_talla = t.id_talla
                JOIN Kb_sport3.Telas tl ON c.id_tela = tl.id_tela;";

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
                    string query = @"
                SELECT 
                    c.id_camisa,
                    l.nombre AS Liga,
                    e.nombre AS Equipo,
                    t.nombre AS Tela,
                    ta.nombre AS Talla,
                    c.precio,
                    c.stock,
                    c.foto
                FROM 
                    Kb_sport3.Camisas c
                JOIN 
                    Kb_sport3.Liga l ON c.id_liga = l.id_liga
                JOIN 
                    Kb_sport3.Equipo e ON c.id_equipo = e.id_equipo
                JOIN 
                    Kb_sport3.Telas t ON c.id_tela = t.id_tela
                JOIN 
                    Kb_sport3.Talla ta ON c.id_talla = ta.id_talla
                WHERE 
                    e.nombre LIKE @nombre;";

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


        public DataTable ObtenerCamisasPorLiga(string liga)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = conexion.AbrirConexion())
                {

                    string query = "SELECT * FROM Kb_sport3.Camisas WHERE liga LIKE @liga";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@liga", "%" + liga + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener las camisas por liga: " + ex.Message);
            }
            return dt;
        }


        public bool InsertarCamisa(Camisa camisa)
        {
            try
            {
                using (MySqlConnection conn = conexion.AbrirConexion())
                {
                    string query = "INSERT INTO Kb_sport3.Camisas (id_liga, id_equipo, id_talla, precio, id_tela, stock, foto) " +
                                   "VALUES (@liga, @equipo, @talla, @precio, @tela, @stock, @foto)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);


                    cmd.Parameters.AddWithValue("@liga", camisa.IdLiga);
                    cmd.Parameters.AddWithValue("@equipo", camisa.IdEquipo);
                    cmd.Parameters.AddWithValue("@talla", camisa.IdTalla);
                    cmd.Parameters.AddWithValue("@precio", camisa.Precio);
                    cmd.Parameters.AddWithValue("@tela", camisa.IdTela);
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

        public List<Liga> ObtenerLigas()
        {
            List<Liga> ligas = new List<Liga>();
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT id_liga, nombre FROM Kb_sport3.Liga;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Liga liga = new Liga
                            {
                                Id_liga = reader.GetInt32("id_liga"),
                                Nombre = reader.GetString("nombre")
                            };
                            ligas.Add(liga);
                        }
                    }
                }
            }
            return ligas;
        }

        public List<Equipo> ObtenerEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT id_equipo, nombre FROM Kb_sport3.Equipo;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Equipo equipo = new Equipo
                            {
                                Id_equipo = reader.GetInt32("id_equipo"),
                                Nombre = reader.GetString("nombre")
                            };
                            equipos.Add(equipo);
                        }
                    }
                }
            }
            return equipos;
        }

        public List<Talla> ObtenerTallas()
        {
            List<Talla> tallas = new List<Talla>();
            try
            {
                using (MySqlConnection connection = conexion.AbrirConexion())
                {
                    string query = "SELECT id_talla, nombre FROM Kb_sport3.Talla;";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Talla talla = new Talla
                                {
                                    Id_talla = reader.GetInt32("id_talla"),
                                    Nombre = reader.GetString("nombre")
                                };
                                tallas.Add(talla);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener las tallas: " + ex.Message);
            }
            return tallas;
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
                                Id_tela = reader.GetInt32("id_tela"),
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
