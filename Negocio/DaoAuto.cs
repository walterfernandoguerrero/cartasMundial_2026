using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Negocio
{
    public class DaoAuto
    {
        public List<Auto> listar()
        {
            List<Auto> lista_autos = new List<Auto>();
            Auto auto1 = new Auto();
            Auto auto2 = new Auto();

            auto1.Id = 1;
            auto1.Modelo = "Fiesta";
            auto1.Descripcion = "BMB205";
            auto1.Color = "Gris";
            auto1.Usado = true;
            auto1.Importado = true;

            auto2.Id = 2;
            auto2.Modelo = "Kangoo ";
            auto2.Descripcion = "OYH456";
            auto2.Color = "Azul";
            auto2.Usado = true;
            auto2.Importado = true;

            Auto auto3 = new Auto();
            auto3.Id = 3;
            auto3.Modelo = "Corolla";
            auto3.Descripcion = "AE123RS";
            auto3.Color = "Blanco";
            auto3.Usado = false;
            auto3.Importado = true;

            Auto auto4 = new Auto();
            auto4.Id = 4;
            auto4.Modelo = "Gol Trend";
            auto4.Descripcion = "AD987LL";
            auto4.Color = "Negro";
            auto4.Usado = true;
            auto4.Importado = false;

            Auto auto5 = new Auto();
            auto5.Id = 5;
            auto5.Modelo = "Civic";
            auto5.Descripcion = "AF456TY";
            auto5.Color = "Gris Plata";
            auto5.Usado = false;
            auto5.Importado = true;

            Auto auto6 = new Auto();
            auto6.Id = 6;
            auto6.Modelo = "Amarok";
            auto6.Descripcion = "AA555KK";
            auto6.Color = "Azul Marino";
            auto6.Usado = true;
            auto6.Importado = false;

            Auto auto7 = new Auto();
            auto7.Id = 7;
            auto7.Modelo = "Cronos";
            auto7.Descripcion = "AE888PO";
            auto7.Color = "Rojo";
            auto7.Usado = false;
            auto7.Importado = false;

            Auto auto8 = new Auto();
            auto8.Id = 8;
            auto8.Modelo = "Etios";
            auto8.Descripcion = "AC222WE";
            auto8.Color = "Arena";
            auto8.Usado = true;
            auto8.Importado = true;

            Auto auto9 = new Auto();
            auto9.Id = 9;
            auto9.Modelo = "Cruze";
            auto9.Descripcion = "AF111MN";
            auto9.Color = "Bordeaux";
            auto9.Usado = false;
            auto9.Importado = false;

            Auto auto10 = new Auto();
            auto10.Id = 10;
            auto10.Modelo = "Hilux";
            auto10.Descripcion = "AD000ZX";
            auto10.Color = "Verde";
            auto10.Usado = true;
            auto10.Importado = true;

            Auto auto11 = new Auto();
            auto11.Id = 11;
            auto11.Modelo = "208";
            auto11.Descripcion = "AE777GH";
            auto11.Color = "Blanco Nácar";
            auto11.Usado = false;
            auto11.Importado = false;

            Auto auto12 = new Auto();
            auto12.Id = 12;
            auto12.Modelo = "Renegade";
            auto12.Descripcion = "AF999QQ";
            auto12.Color = "Naranja";
            auto12.Usado = false;
            auto12.Importado = true;

            lista_autos.Add(auto1);
            lista_autos.Add(auto2);
            lista_autos.Add(auto3);
            lista_autos.Add(auto4);
            lista_autos.Add(auto5);
            lista_autos.Add(auto6);
            lista_autos.Add(auto7);
            lista_autos.Add(auto8);
            lista_autos.Add(auto9);
            lista_autos.Add(auto10);
            lista_autos.Add(auto11);
            lista_autos.Add(auto12);

            return lista_autos;
        }
    }
}
