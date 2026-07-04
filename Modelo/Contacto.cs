using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contacto
    {
        //atributos 
        public int id { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string grupos { get; set; }

        //constructores
        public Contacto() { }
        public Contacto(int id, string nombre, string telefono, string correo, string grupos)
        {
            this.id = id;
            this.nombre = nombre;
            this.telefono = telefono;
            this.correo = correo;
            this.grupos = grupos;
        }


    }
}
