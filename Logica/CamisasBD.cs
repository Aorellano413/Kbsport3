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

            List<CamisaTela> telas = nuevaCamisa.Telas.Select(t => new CamisaTela
            {
                IdTelaCamisa = t.Id_tela,
                NombreTela = t.Nombre,
                Cantidad = t.Stock
            }).ToList();

            datos.AsignarCantidadTelas(nuevaCamisa.IdCamisa, telas);
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

        public DataTable ObtenerNombresDeCamisas()
        {
            return datos.ObtenerNombresDeCamisas();
        }

        public DataTable ObtenerCamisasPorNombre(string nombre)
        {
            return datos.ObtenerCamisasPorNombre(nombre);
        }

        public DataTable ObtenerCamisasPorLiga(string liga)
        {
            return datos.ObtenerCamisasPorLiga(liga);
        }

        public List<CamisaTela> ObtenerTelasDeCamisa(int idCamisa)
        {
            return datos.ObtenerTelasDeCamisa(idCamisa);
        }
    }
}
