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
                    t.nombre AS Tela,
                    c.talla,
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
                    Kb_sport3.Telas t ON c.id_tela = t.id_tela;";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener todas las camisas: " + ex.Message);
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
                    c.talla, 
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
                    string query = "SELECT * FROM Kb_sport3.Camisas WHERE liga LIKE @liga;";
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
            using (MySqlConnection conn = conexion.AbrirConexion())
            {
                if (conn.State != ConnectionState.Open)
                {
                    throw new Exception("No se pudo abrir la conexión a la base de datos.");
                }


                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO Kb_sport3.Camisas (id_liga, id_equipo, talla, precio, id_tela, stock, foto) " +
                    "VALUES (@liga, @equipo, @talla, @precio, @tela, @stock, @foto)",
                    conn
                );

                cmd.Parameters.AddWithValue("@liga", camisa.IdLiga);
                cmd.Parameters.AddWithValue("@equipo", camisa.IdEquipo);
                cmd.Parameters.AddWithValue("@talla", camisa.Talla);
                cmd.Parameters.AddWithValue("@precio", camisa.Precio);
                cmd.Parameters.AddWithValue("@tela", camisa.IdTela);
                cmd.Parameters.AddWithValue("@stock", camisa.Stock);
                cmd.Parameters.AddWithValue("@foto", camisa.Foto);

                cmd.ExecuteNonQuery();
                int idCamisa = (int)cmd.LastInsertedId;


                MySqlCommand cmdCheck = new MySqlCommand("SELECT COUNT(*) FROM Kb_sport3.Telas WHERE id_tela = @idTela", conn);
                cmdCheck.Parameters.AddWithValue("@idTela", camisa.IdTela);
                int countTela = Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (countTela > 0)
                {
                    MySqlCommand cmdTelasCamisas = new MySqlCommand(
                        "INSERT INTO Kb_sport3.Telas_Camisas (id_tela, id_camisa, cantidad) VALUES (@idTela, @idCamisa, @cantidad)",
                        conn
                    );


                    cmdTelasCamisas.Parameters.AddWithValue("@idCamisa", idCamisa);
                    cmdTelasCamisas.Parameters.AddWithValue("@idTela", camisa.IdTela);
                    cmdTelasCamisas.Parameters.AddWithValue("@cantidad", camisa.Stock);

                    cmdTelasCamisas.ExecuteNonQuery();
                }
                else
                {
                    throw new Exception($"Tela con id {camisa.IdTela} no existe.");
                }

                return true;
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

        public void AsignarCantidadTelas(int idCamisa, List<CamisaTela> telas)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                foreach (var camisaTela in telas)
                {
                    string query = @"
                    UPDATE Kb_sport3.Telas_Camisas 
                    SET cantidad = @cantidad 
                     WHERE id_tela = @idTela AND id_camisa = @idCamisa;";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@cantidad", camisaTela.Cantidad);
                        cmd.Parameters.AddWithValue("@idTela", camisaTela.IdTelaCamisa);
                        cmd.Parameters.AddWithValue("@idCamisa", idCamisa);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public bool EliminarCamisa(int idCamisa)
        {
            try
            {
                using (MySqlConnection conn = conexion.AbrirConexion())
                {
                    string query = "DELETE FROM Kb_sport3.Camisas WHERE id_camisa = @idCamisa;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idCamisa", idCamisa);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar la camisa: " + ex.Message);
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
