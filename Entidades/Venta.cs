using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Venta
    {
        public int IDVenta { get; set; }
        public Cliente Cliente { get; set; }
        public List<Producto> ListaProductos { get; set; }
        public decimal Total { get; set; }
    }
}
