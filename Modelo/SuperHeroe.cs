using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class SuperHeroe
    {
        public int Id {get; set;}
        public string Codigo {get; set;}
        public string Nombre {get; set;}
        public decimal Altura {get; set;}
        public int Peso { get; set; }
        public int Fuerza { get; set; }
        public int PeleasGanadas { get; set; }
        public int Velocidad { get; set; }
        public string UrlImagen { get; set; }

    }
}
