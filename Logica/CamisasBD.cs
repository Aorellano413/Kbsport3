using Entidades;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Logica
{
    public class CamisasBD
    {
        InventarioCamisas datos = new InventarioCamisas();


        public void InsertarCamisa(Camisa nuevaCamisa)
        {

            datos.InsertarCamisa(nuevaCamisa);
        }

        public bool EliminarCamisa(int idCamisa)
        {
            return datos.EliminarCamisa(idCamisa);
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

        public DataTable ObtenerTodasLasCamisas()
        {
            return datos.ObtenerTodasLasCamisas();
        }

        public DataTable ObtenerCamisasPorNombre(string nombre)
        {
            return datos.ObtenerCamisasPorNombre(nombre);
        }
        public DataTable ObtenerCamisasPorLiga(string liga)
        {
            return datos.ObtenerCamisasPorLiga(liga);
        }
        public DataTable ObtenerCamisasPorNombre()
        {
            throw new NotImplementedException();
        }
    }
}
