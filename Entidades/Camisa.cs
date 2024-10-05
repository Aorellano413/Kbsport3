using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Camisa
    {
        public int Id { get; set; }

        public string Liga { get; set; }
        public string Equipo { get; set; }
        public string Talla { get; set; }
        public decimal Precio { get; set; }
        public string Tela { get; set; }
        public int Stock { get; set; }
        public string Foto { get; set; }

        public List<Tela> Telas { get; set; } = new List<Tela>();
        public List<Liga> Ligas { get; set; } = new List<Liga>();
        public List<Equipo> Equipos { get; set; } = new List<Equipo>();
        public List<Talla> Tallas { get; set; } = new List<Talla>();
    }
}
