using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Producto
    {
        public int IDProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal Precio { get; set; }
        public int CantidadEnStock { get; set; }
    }
}
