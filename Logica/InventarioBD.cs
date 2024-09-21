using Entidades;
using Persistencia;
using System.Data;

namespace Logica
{
    public class InventarioBD
    {
        DatosInventario datos = new DatosInventario();

        public DataTable MostrarInventario()
        {
            return datos.MostrarInventario();
        }

        public void InsertarTela(Tela tela)
        {
            datos.InsertarTela(tela);
        }
    }
}
