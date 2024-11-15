using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Entidades;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class DatosFactura
    {
        ConexionDAL conexion = new ConexionDAL();

        public void InsertarFactura(Factura factura)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = @"INSERT INTO Facturas (fecha_factura, cedula_cliente, total) 
                         VALUES (@fechaFactura, @cedulaCliente, @total);";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@fechaFactura", factura.FechaFactura);

                   
                    int cedulaCliente = (factura.Cliente != null) ? factura.Cliente.Cedula : 0;

                    cmd.Parameters.AddWithValue("@cedulaCliente", cedulaCliente);
                    cmd.Parameters.AddWithValue("@total", factura.Total);
                    cmd.ExecuteNonQuery();

                    factura.Id = (int)cmd.LastInsertedId;
                }
            }
        }





    }


}
