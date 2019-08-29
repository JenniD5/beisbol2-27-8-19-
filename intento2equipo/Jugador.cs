using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intento2equipo
{
    class Jugador

    {
        public string Nombre { get; set; }
        public int Numero { get; set; }

        public Jugador()
        {
            Numero = 0;
            Nombre = "sin nombre";
        }

        public Jugador(string nombre, int numero)
        {
            Nombre = nombre;
            Numero = numero;
        }

       public Jugador(string nombre)//PARA HACER MAS RAPIDA LA CAPTURA 
        {
          Nombre = nombre;
        }
    }
}
