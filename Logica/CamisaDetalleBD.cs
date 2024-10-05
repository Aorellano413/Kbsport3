using System;
using Entidades;
using Persistencia;
using System.Collections.Generic;

namespace Logica
{
    public class CamisaDetalleBD
    {
        CamisaFiltrado datosCamisa = new CamisaFiltrado();


        public List<Talla> ObtenerTallas()
        {
            return datosCamisa.ObtenerTallas();
        }

        public List<Equipo> ObtenerEquipos()
        {
            return datosCamisa.ObtenerEquipos();
        }

        public List<Liga> ObtenerLigas()
        {
            return datosCamisa.ObtenerLigas();
        }
    }
}
