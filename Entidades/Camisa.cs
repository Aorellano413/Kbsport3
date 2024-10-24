using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Camisa
    {
        private int idCamisa;
        private string nombreCamisa;

        public Camisa(int idCamisa, string nombreCamisa, decimal precio, int cantidad)
        {
            this.idCamisa = idCamisa;
            this.nombreCamisa = nombreCamisa;
            Precio = precio;
            Cantidad = cantidad;
        }

        public int Id { get; set; }

        public int IdLiga { get; set; }    
        public int IdEquipo { get; set; }   
        public int IdTalla { get; set; }  
        public decimal Precio { get; set; }
        public int IdTela { get; set; }     
        public int Stock { get; set; }
        public string Foto { get; set; }

        public List<Tela> Telas { get; set; } = new List<Tela>();
        public List<Liga> Ligas { get; set; } = new List<Liga>();
        public List<Equipo> Equipos { get; set; } = new List<Equipo>();
        public List<Talla> Tallas { get; set; } = new List<Talla>();
        public object Cantidad { get; set; }
    }
}
