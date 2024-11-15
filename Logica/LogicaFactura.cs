using Entidades;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LogicaFactura
    {
        private DatosFactura datosFactura = new DatosFactura();

        public void InsertarFactura(Factura factura)
        {
            datosFactura.InsertarFactura(factura);
        }
    }
}
