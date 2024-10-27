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

        public bool InsertarCamisa(Camisa nuevaCamisa)
        {
            try
            {
                using (MySqlConnection conn = conexion.AbrirConexion())
                {

                    string query = "INSERT INTO Kb_sport3.Camisas (id_liga, id_equipo, talla, precio, id_tela, stock, foto) " +
                                   "VALUES (@liga, @equipo, @talla, @precio, @tela, @stock, @foto)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@liga", nuevaCamisa.IdLiga);
                    cmd.Parameters.AddWithValue("@equipo", nuevaCamisa.IdEquipo);
                    cmd.Parameters.AddWithValue("@talla", nuevaCamisa.Talla);
                    cmd.Parameters.AddWithValue("@precio", nuevaCamisa.Precio);
                    cmd.Parameters.AddWithValue("@tela", nuevaCamisa.IdTela);
                    cmd.Parameters.AddWithValue("@stock", nuevaCamisa.Stock);
                    cmd.Parameters.AddWithValue("@foto", nuevaCamisa.Foto);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {

                        nuevaCamisa.IdCamisa = (int)cmd.LastInsertedId;


                        foreach (var tela in nuevaCamisa.Telas)
                        {

                            MySqlCommand cmdCheck = new MySqlCommand("SELECT COUNT(*) FROM TELAS WHERE id_tela = @idTela", conn);
                            cmdCheck.Parameters.AddWithValue("@idTela", tela.Id_tela);
                            int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

                            if (count > 0)
                            {

                                cmd = new MySqlCommand("INSERT INTO Kb_sport3.Camisas_Telas (id_camisa, id_tela, cantidad) VALUES (@id_camisa, @id_tela, @cantidad)", conn);
                                cmd.Parameters.AddWithValue("@id_camisa", nuevaCamisa.IdCamisa);
                                cmd.Parameters.AddWithValue("@id_tela", tela.Id_tela);
                                cmd.Parameters.AddWithValue("@cantidad", tela.Stock);
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                throw new Exception($"Tela con id {tela.Id_tela} no existe.");
                            }
                        }

                        return true;
                    }
                    return false;
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

        public void AsignarTelasCamisas(int idCamisa, List<CamisaTela> telas)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                foreach (var camisaTela in telas)
                {
                    string query = @"
                UPDATE TELAS_CAMISAS 
                SET cantidad = @cantidad 
                WHERE id_tela = @idTela AND id_camisa = @idCamisa;";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@cantidad", camisaTela.Cantidad);
                        cmd.Parameters.AddWithValue("@idTela", camisaTela.IdTela);
                        cmd.Parameters.AddWithValue("@idCamisa", idCamisa);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void AsignarCantidadTelas(int idCamisa, List<CamisaTela> telas)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                foreach (var camisaTela in telas)
                {
                    string query = @"
                UPDATE Camisas_Telas 
                SET cantidad = @cantidad 
                WHERE id_tela = @idTela AND id_camisa = @idCamisa;";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@cantidad", camisaTela.Cantidad);
                        cmd.Parameters.AddWithValue("@idTela", camisaTela.IdTela);
                        cmd.Parameters.AddWithValue("@idCamisa", idCamisa);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }


        public List<CamisaTela> ObtenerTelasDeCamisa(int idCamisa)
        {
            List<CamisaTela> telas = new List<CamisaTela>();
            try
            {
                using (MySqlConnection connection = conexion.AbrirConexion())
                {
                    string query = @"
                SELECT 
                    tc.id_tela, 
                    t.nombre AS NombreTela, 
                    tc.cantidad 
                FROM 
                    TELAS_CAMISAS tc
                JOIN 
                    Telas t ON tc.id_tela = t.id_tela
                WHERE 
                    tc.id_camisa = @idCamisa;";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idCamisa", idCamisa);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CamisaTela camisaTela = new CamisaTela
                                {
                                    IdTela = reader.GetInt32("id_tela"),
                                    NombreTela = reader.GetString("NombreTela"),
                                    Cantidad = reader.GetInt32("cantidad")
                                };
                                telas.Add(camisaTela);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener las telas de la camisa: " + ex.Message);
            }
            return telas;
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
