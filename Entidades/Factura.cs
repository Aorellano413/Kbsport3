using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Factura
    {
        public int Id { get; set; }
        public DateTime FechaFactura { get; set; }
        public decimal Total { get; set; }
        public Cliente Cliente { get; set; }
        public List<Camisa> CamisasVendidas { get; set; } = new List<Camisa>();
    }
}
