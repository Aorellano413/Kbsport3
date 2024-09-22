using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FacturaCamisa
    {
        public int Id { get; set; }
        public DateTime FechaFactura { get; set; }
        public int IdPedido { get; set; }
        public List<DetallePedido> Detalles { get; set; } = new List<DetallePedido>();
        public decimal Total { get; set; }
    }
}
