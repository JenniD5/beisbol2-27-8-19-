using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intento2equipo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo beisbol1 = new Equipo("juan", "obregon");
            Equipo beisbol2 = new Equipo("rene", "navojoa");

            equipos.Add(beisbol1);
            equipos.Add(beisbol2);


            Jugador ana = new Jugador("ana", "34");
            Jugador maria = new Jugador();
            Jugador marcos = new Jugador("marcos", "56");
            Jugador manuel = new Jugador("manuel", "57");
            Jugador emanuel = new Jugador("emanuel", "50");
            Jugador miguel = new Jugador("miguel", "59");
            Jugador Juan = new Jugador("Juan", "67");
            Jugador mia = new Jugador("mia", "26");
            Jugador noe = new Jugador("noe", "56");



            beisbol1.Jugadores.Add(ana);
            beisbol1.Jugadores.Add(maria);
            beisbol1.Jugadores.Add(marcos);
            beisbol1.Jugadores.Add(manuel);
            beisbol1.Jugadores.Add(Juan);
            beisbol1.Jugadores.Add(mia);
            beisbol1.Jugadores.Add(noe);
            beisbol1.Jugadores.Add(miguel);
            beisbol1.Jugadores.Add(emanuel);

            beisbol2.Jugadores.Add(maria);
            beisbol2.Jugadores.Add(ana);
            beisbol2.Jugadores.Add(maria);
            beisbol2.Jugadores.Add(marcos);
            beisbol2.Jugadores.Add(manuel);
            beisbol2.Jugadores.Add(Juan);
            beisbol2.Jugadores.Add(mia);
            beisbol2.Jugadores.Add(noe);
            beisbol2.Jugadores.Add(miguel);
            beisbol2.Jugadores.Add(emanuel);

            foreach (Equipo ekipo in equipos)
            {
                Console.WriteLine("entrenador: " + ekipo.Entrenador);
                Console.WriteLine("direccion: " + ekipo.Direccion);

                foreach(Jugador jugadr in ekipo.Jugadores)
                {
                    Console.WriteLine("*" + jugadr.Nombre);
                    Console.WriteLine("-" + jugadr.Numero);
                }
            }
            Console.Read();
        }
        
    }
}
