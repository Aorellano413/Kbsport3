using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime FechaPedido { get; set; }
        public List<DetallePedido> Detalles { get; set; } = new List<DetallePedido>();
    }
}
