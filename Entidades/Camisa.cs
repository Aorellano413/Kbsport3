using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camisa
    {
        public int Id { get; set; }             
        public string Equipo { get; set; }      
        public string Talla { get; set; }       
        public decimal Precio { get; set; }     
        public string Tela { get; set; }        
        public string Color { get; set; }       
        public int Stock { get; set; }          
        public string Foto { get; set; }

        public List<Tela> telas { get; set; } = new List<Tela>();
    }
}
