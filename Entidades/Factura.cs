using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Factura
    {
        private int idFactura;

        public Factura(int idFactura, DateTime fechaFactura, string cedula)
        {
            this.idFactura = idFactura;
            FechaFactura = fechaFactura;
            Cedula = cedula;
        }

        public int Id { get; set; }
        public DateTime FechaFactura { get; set; }
        public List<Camisa> CamisasVendidas { get; set; }
        public decimal Total { get; set; }
        public object Cedula { get; set; }
    }
}