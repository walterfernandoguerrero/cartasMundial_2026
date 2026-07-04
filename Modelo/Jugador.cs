using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Jugador
    {
        //atributos
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public decimal altura { get; set; }
        public string puesto { get; set; }
        public string imagen { get; set; }
        public DateTime nacimiento { get; set; }
        public bool estado { get; set; }

        //constructor
        public Jugador() { }
        //segundo contructor sobrecarga
        public Jugador(int id, string nombre, string apellido, decimal altura, string puesto, string imagen, DateTime nacimiento, bool estado) {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.altura = altura;
            this.puesto = puesto;
            this.imagen = imagen;
            this.nacimiento = nacimiento;
            this.estado = estado;
        }

        //metodos 
        public List<Jugador> JugadorList()
        {
            List<Jugador> jug = new List<Jugador>();
            Jugador j1 = new Jugador();
            j1.id = 1;
            j1.nombre = "walter";
            j1.apellido = "guerrero";
            j1.imagen = "https://i.pinimg.com/736x/61/0b/75/610b75f223ec57c4bdc7b1131c7f415b.jpg";

            Jugador j2 = new Jugador();
            j2.id = 2;
            j2.nombre = "Lionel";
            j2.apellido = "Messi";
            j2.imagen = "https://cdn.conmebol.com/wp-content/uploads/2014/06/messieslo.jpg";

            jug.Add(j1);
            jug.Add(j2);

            return jug;

        }

        public override string  ToString()
        {
            return $"Nombre: {nombre}, Apellido: {apellido}";
        }
        

    }
}
