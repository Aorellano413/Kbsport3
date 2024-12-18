﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using Entidades;


namespace Persistencia
{
    public class DatosPedido
    {
        ConexionDAL conexion = new ConexionDAL();
        public int InsertarPedido(Pedido pedido)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "INSERT INTO PEDIDOS (fecha_pedido) VALUES (@fechaPedido);";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@fechaPedido", pedido.FechaPedido);
                    cmd.ExecuteNonQuery();
                    return (int)cmd.LastInsertedId;
                }
            }
        }
        public void InsertarDetallePedido(DetallePedido detalle, int idPedido)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                
                string queryCheck = "SELECT id_detalle, cantidad, precio FROM DETALLE_PEDIDOS WHERE id_pedido = @idPedido AND id_camisa = @idCamisa;";
                using (MySqlCommand cmdCheck = new MySqlCommand(queryCheck, connection))
                {
                    cmdCheck.Parameters.AddWithValue("@idPedido", idPedido);
                    cmdCheck.Parameters.AddWithValue("@idCamisa", detalle.IdCamisa);

                    using (MySqlDataReader reader = cmdCheck.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idDetalle = reader.GetInt32("id_detalle");
                            int cantidadExistente = reader.GetInt32("cantidad");
                            decimal precioExistente = reader.GetDecimal("precio");

                            reader.Close();

                            string queryUpdate = "UPDATE DETALLE_PEDIDOS SET cantidad = @cantidad, precio = @precio WHERE id_detalle = @idDetalle;";
                            using (MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, connection))
                            {
                                int nuevaCantidad = cantidadExistente + detalle.Cantidad;
                                decimal nuevoPrecio = precioExistente + (detalle.Precio * detalle.Cantidad);

                                cmdUpdate.Parameters.AddWithValue("@cantidad", nuevaCantidad);
                                cmdUpdate.Parameters.AddWithValue("@precio", nuevoPrecio);
                                cmdUpdate.Parameters.AddWithValue("@idDetalle", idDetalle);
                                cmdUpdate.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                         
                            reader.Close();
                            string queryInsert = "INSERT INTO DETALLE_PEDIDOS (cantidad, precio, id_pedido, id_camisa) VALUES (@cantidad, @precio, @idPedido, @idCamisa);";
                            using (MySqlCommand cmdInsert = new MySqlCommand(queryInsert, connection))
                            {
                                decimal precioTotal = detalle.Precio * detalle.Cantidad;

                                cmdInsert.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                                cmdInsert.Parameters.AddWithValue("@precio", precioTotal);
                                cmdInsert.Parameters.AddWithValue("@idPedido", idPedido);
                                cmdInsert.Parameters.AddWithValue("@idCamisa", detalle.IdCamisa);
                                cmdInsert.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            DescontarStockCamisa(detalle.IdCamisa, detalle.Cantidad);
        }



        public decimal ObtenerPrecioCamisa(int idCamisa)
        {
            decimal precio = 0;
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT precio FROM CAMISAS WHERE id_camisa = @idCamisa;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idCamisa", idCamisa);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            precio = reader.GetDecimal("precio");
                        }
                    }
                }
            }
            return precio;
        }


        public void DescontarStockCamisa(int idCamisa, int cantidad)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "UPDATE CAMISAS SET stock = stock - @cantidad WHERE id_camisa = @idCamisa";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idCamisa", idCamisa);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public DataTable ObtenerPedidos()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT * FROM PEDIDOS;";
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
        public DataTable ObtenerDetallesPedido(int idPedido)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = @"
                SELECT dp.id_detalle, dp.cantidad, dp.precio, c.nombre AS 'Nombre Camisa'
                FROM DETALLE_PEDIDOS dp
                JOIN CAMISAS c ON dp.id_camisa = c.id_camisa
                WHERE dp.id_pedido = @idPedido;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idPedido", idPedido);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable ObtenerPedidosPorRangoFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = @"
        SELECT 
            p.id_pedido AS 'ID Pedido', 
            p.fecha_pedido AS 'Fecha Pedido', 
            dp.cantidad AS 'Cantidad', 
            dp.precio AS 'Precio', 
            c.nombre AS 'Nombre Camisa'
        FROM PEDIDOS p
        JOIN DETALLE_PEDIDOS dp ON p.id_pedido = dp.id_pedido
        JOIN CAMISAS c ON dp.id_camisa = c.id_camisa
        WHERE p.fecha_pedido BETWEEN @fechaInicio AND @fechaFin;
        ";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.Date);
                    cmd.Parameters.AddWithValue("@fechaFin", fechaFin.Date);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable ObtenerPedidosPorAnoKB(int ano)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = @"
        SELECT 
        m.Mes,
        COALESCE(COUNT(p.id_pedido), 0) AS CantidadPedidos,
        COALESCE(SUM(dp.precio), 0) AS TotalDinero
        FROM (
            SELECT 1 AS Mes UNION ALL SELECT 2 UNION ALL SELECT 3 UNION ALL
            SELECT 4 UNION ALL SELECT 5 UNION ALL SELECT 6 UNION ALL
            SELECT 7 UNION ALL SELECT 8 UNION ALL SELECT 9 UNION ALL
            SELECT 10 UNION ALL SELECT 11 UNION ALL SELECT 12
        ) AS m
        LEFT JOIN PEDIDOS p ON m.Mes = MONTH(p.fecha_pedido) AND YEAR(p.fecha_pedido) = @ano
        LEFT JOIN DETALLE_PEDIDOS dp ON p.id_pedido = dp.id_pedido
        GROUP BY m.Mes
        ORDER BY m.Mes;
        ";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ano", ano);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }


    }
}