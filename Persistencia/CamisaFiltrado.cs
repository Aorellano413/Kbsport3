using System;
using System.Collections.Generic;
using Entidades;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class CamisaFiltrado
    {
        ConexionDAL conexion = new ConexionDAL();

        public List<Liga> ObtenerLigas()
        {
            List<Liga> ligas = new List<Liga>();
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT id_liga, nombre FROM Kb_sport3.Ligas;"; 
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Liga liga = new Liga
                            {
                                Id = reader.GetInt32("id_liga"),
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
                string query = "SELECT id_equipo, nombre FROM Kb_sport3.Equipos;"; 
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Equipo equipo = new Equipo
                            {
                                Id = reader.GetInt32("id_equipo"),
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
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT id_talla, nombre FROM Kb_sport3.Tallas;"; 
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Talla talla = new Talla
                            {
                                Id = reader.GetInt32("id_talla"),
                                Nombre = reader.GetString("nombre")
                            };
                            tallas.Add(talla);
                        }
                    }
                }
            }
            return tallas;
        }
    }
}
