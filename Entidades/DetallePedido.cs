using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
         public class DetallePedido
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int IdPedido { get; set; }
        public int IdCamisa { get; set; }
        public Camisa Camisa{ get; set; }

    }
}
