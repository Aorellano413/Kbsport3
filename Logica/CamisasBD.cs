using Entidades;
using Persistencia;
using System.Collections.Generic;
using System.Data;

namespace Logica
{
    public class CamisasBD
    {
        InventarioCamisas datos = new InventarioCamisas();

        public DataTable MostrarNuevaTabla()
        {
            return datos.MostrarNuevaTabla();
        }

     
        public bool InsertarCamisa(Camisa nuevaCamisa)
        {
   
            return datos.InsertarCamisa(nuevaCamisa);
        }

        public List<Tela> ObtenerTelas()
        {
            return datos.ObtenerTelas();
        }
    }
}
