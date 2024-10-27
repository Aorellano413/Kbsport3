using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Camisa
    {
        public int IdCamisa { get; set; }
        public int IdLiga { get; set; }
        public int IdEquipo { get; set; }
        public string Talla { get; set; }
        public decimal Precio { get; set; }
        public int IdTela { get; set; }
        public int Stock { get; set; }
        public string Foto { get; set; }

        public List<Tela> Telas { get; set; } = new List<Tela>();
        public List<Liga> Ligas { get; set; } = new List<Liga>();
        public List<Equipo> Equipos { get; set; } = new List<Equipo>();
    }
}
