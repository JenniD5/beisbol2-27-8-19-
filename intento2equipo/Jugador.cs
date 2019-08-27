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
        public string Numero { get; set; }

        public Jugador()
        {
            Numero = "sin numero";
            Nombre = "sin nombre";
        }

        public Jugador(string nombre, string numero)
        {
            Nombre = nombre;
            Numero = numero;
        }
    }
}
