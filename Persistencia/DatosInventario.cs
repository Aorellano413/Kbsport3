﻿using Entidades;
using MySql.Data.MySqlClient;
using System;
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

        public DataTable BuscarTelaPorNombre(string nombre)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT id_tela, nombre, stock FROM Kb_sport3.telas WHERE nombre LIKE @nombre;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public void EliminarTela(int idTela)
        {
            using (MySqlConnection conn = conexion.AbrirConexion())
            {
                using (MySqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string nombreTela = "";
                        string queryGetNombreTela = "SELECT nombre FROM telas WHERE id_tela = @idTela;";
                        using (MySqlCommand cmdGetNombreTela = new MySqlCommand(queryGetNombreTela, conn, transaction))
                        {
                            cmdGetNombreTela.Parameters.AddWithValue("@idTela", idTela);
                            using (MySqlDataReader reader = cmdGetNombreTela.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    nombreTela = reader.GetString("nombre");
                                }
                            }
                        }

                        string queryDeleteTela = "DELETE FROM telas WHERE id_tela = @idTela;";
                        using (MySqlCommand cmdDeleteTela = new MySqlCommand(queryDeleteTela, conn, transaction))
                        {
                            cmdDeleteTela.Parameters.AddWithValue("@idTela", idTela);
                            cmdDeleteTela.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        public void ActualizarTela(Tela tela)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "UPDATE Kb_sport3.telas SET nombre = @nombre, stock = @stock WHERE id_tela = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", tela.Id);
                    cmd.Parameters.AddWithValue("@nombre", tela.Nombre);
                    cmd.Parameters.AddWithValue("@stock", tela.Stock);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public bool ExisteTela(string nombre)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT COUNT(*) FROM Kb_sport3.telas WHERE nombre = @nombre;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

    }
}