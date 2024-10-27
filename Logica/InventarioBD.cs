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

        public void InsertarEquipo(Equipo equipo) 
        {
            datos.InsertarEquipo(equipo);
        }

       

        public void InsertarLiga(Liga liga) 
        {
            datos.InsertarLiga(liga);
        }

        public DataTable BuscarTelaPorNombre(string nombre)
        {
            return datos.BuscarTelaPorNombre(nombre);
        }

        public void EliminarTela(int idTela)
        {
            datos.EliminarTela(idTela);
        }

        public void ActualizarTela(Tela tela)
        {
            datos.ActualizarTela(tela);
        }

        public bool ExisteTela(string nombre)
        {
            return datos.ExisteTela(nombre);
        }
    }
}
