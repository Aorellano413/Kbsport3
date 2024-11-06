using MySql.Data.MySqlClient;
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
                string query = "INSERT INTO DETALLE_PEDIDOS (cantidad, precio, id_pedido, id_camisa) VALUES (@cantidad, @precio, @idPedido, @idCamisa);";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmd.Parameters.AddWithValue("@precio", detalle.Precio);
                    cmd.Parameters.AddWithValue("@idPedido", idPedido);
                    cmd.Parameters.AddWithValue("@idCamisa", detalle.IdCamisa);
                    cmd.ExecuteNonQuery();
                }
            }

            DescontarStockCamisa(detalle.IdCamisa, detalle.Cantidad);
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
    }
}
