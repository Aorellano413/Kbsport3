using Entidades;
using Persistencia;
using System.Collections.Generic;
using System.Data;

namespace Logica
{
    public class CamisasBD
    {
        InventarioCamisas datos = new InventarioCamisas();

        public bool InsertarCamisa(Camisa nuevaCamisa)
        {
            return datos.InsertarCamisa(nuevaCamisa);
        }

        public List<Tela> ObtenerTelas()
        {
            return datos.ObtenerTelas();
        }

        public List<Liga> ObtenerLigas()
        {
            return datos.ObtenerLigas();
        }

        public List<Equipo> ObtenerEquipos()
        {
            return datos.ObtenerEquipos();
        }

        public List<Talla> ObtenerTallas()
        {
            return datos.ObtenerTallas();
        }

        public DataTable ObtenerTodasLasCamisas()
        {
            return datos.ObtenerTodasLasCamisas();
        }

        public DataTable ObtenerCamisasPorNombre(string nombre)
        {
            return datos.ObtenerCamisasPorNombre(nombre);
        }
    }
}
