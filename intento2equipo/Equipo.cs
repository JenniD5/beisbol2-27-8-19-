using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intento2equipo
{
    class Equipo
    {   public string Nomb { get; set; }

        public string Entrenador { get; set; }
        public string Direccion { get; set; }
        public List<Jugador> Jugadores { get; set; }

        public Equipo()
        {
            Entrenador = "no hay entrenador";
            Direccion = "no tiene direccion";
            Nomb = "sin nombre";
        }

        public Equipo(string entrenador, string direccion,string nomb)
        {
            Nomb = nomb;
            Entrenador = entrenador;
            Direccion = direccion;
            Jugadores = new List<Jugador>();

        }
    }
}


