using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Entidades;

namespace Persistencia
{
    public class DatosFactura
    {
        private readonly string connectionString;


        public DatosFactura(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public int InsertarFactura(Factura factura)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {

                    string queryFactura = @"INSERT INTO Factura (fecha_factura, cedula, total) 
                                            OUTPUT INSERTED.id_factura 
                                            VALUES (@FechaFactura, @Cedula, @Total)";

                    SqlCommand cmdFactura = new SqlCommand(queryFactura, connection, transaction);
                    cmdFactura.Parameters.AddWithValue("@FechaFactura", factura.FechaFactura);
                    cmdFactura.Parameters.AddWithValue("@Cedula", factura.Cedula);
                    cmdFactura.Parameters.AddWithValue("@Total", factura.Total);

                    int idFactura = (int)cmdFactura.ExecuteScalar();


                    foreach (var camisa in factura.CamisasVendidas)
                    {
                        string queryCamisas = @"INSERT INTO FacturaCamisas (id_factura, id_camisa, cantidad) 
                                                VALUES (@IdFactura, @IdCamisa, @Cantidad)";

                        SqlCommand cmdCamisas = new SqlCommand(queryCamisas, connection, transaction);
                        cmdCamisas.Parameters.AddWithValue("@IdFactura", idFactura);
                        cmdCamisas.Parameters.AddWithValue("@IdCamisa", camisa.Id);
                        cmdCamisas.Parameters.AddWithValue("@Cantidad", camisa.Cantidad);
                        cmdCamisas.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return idFactura;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public List<Factura> ObtenerFacturas()
        {
            List<Factura> facturas = new List<Factura>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT f.id_factura, f.fecha_factura, f.cedula, f.total, 
                           c.id_camisa, c.nombre, fc.cantidad, c.precio
                    FROM Factura f
                    JOIN FacturaCamisas fc ON f.id_factura = fc.id_factura
                    JOIN Camisas c ON fc.id_camisa = c.id_camisa";

                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idFactura = reader.GetInt32(0);
                        DateTime fechaFactura = reader.GetDateTime(1);
                        string cedula = reader.GetString(2);
                        decimal total = reader.GetDecimal(3);


                        Factura factura = facturas.FirstOrDefault(f => f.Id == idFactura);
                        if (factura == null)
                        {
                            factura = new Factura(idFactura, fechaFactura, cedula);
                            facturas.Add(factura);
                        }
                        int idCamisa = reader.GetInt32(4);
                        string nombreCamisa = reader.GetString(5);
                        int cantidad = reader.GetInt32(6);
                        decimal precio = reader.GetDecimal(7);

                        Camisa camisa = new Camisa(idCamisa, nombreCamisa, precio, cantidad);
                        factura.CamisasVendidas.Add(camisa);
                    }
                }
            }
            return facturas;
        }
    }
}
