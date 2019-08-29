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
            Equipo beisbol1 = new Equipo("juan", "obregon", "xolos");
            Equipo beisbol2 = new Equipo("rene", "navojoa", "Pepes");

            Equipo yakis = new Equipo("yakis"); //con el nuevo constructor, linea 33 de la clase equipo
            yakis.Entrenador = "juan";
            yakis.Direccion = "obregon";


            yakis.Jugadores.Add(new Jugador("jugador1", 34));
            yakis.Jugadores.Add(new Jugador("jugador2", 35));
            yakis.Jugadores.Add(new Jugador("jugador3", 36));
            yakis.Jugadores.Add(new Jugador("jugador4", 37));
            yakis.Jugadores.Add(new Jugador("jugador5", 38));
            yakis.Jugadores.Add(new Jugador("jugador6", 38));
            yakis.Jugadores.Add(new Jugador("jugador7", 39));
            yakis.Jugadores.Add(new Jugador("jugador8", 30));
            yakis.Jugadores.Add(new Jugador("jugador9", 33));

            Equipo mochis = new Equipo("mochis");
            mochis.Entrenador = "juan";
            mochis.Direccion = "obregon";


            mochis.Jugadores.Add(new Jugador("jugador13", 34));
            mochis.Jugadores.Add(new Jugador("jugador14", 44));
            mochis.Jugadores.Add(new Jugador("jugador15", 46));
            mochis.Jugadores.Add(new Jugador("jugador16", 47));
            mochis.Jugadores.Add(new Jugador("jugador12", 48));
            mochis.Jugadores.Add(new Jugador("jugador17", 49));
            mochis.Jugadores.Add(new Jugador("jugador18", 43));
            mochis.Jugadores.Add(new Jugador("jugador19", 42));
            mochis.Jugadores.Add(new Jugador("jugador11", 41));

            equipos.Add(yakis);
            equipos.Add(mochis);
            foreach (Equipo equipo in equipos)
            {
                Console.WriteLine("*" + equipo.Nomb +" de "+ equipo.Direccion);
                foreach (Jugador jugador in equipo.Jugadores)
                {
                    Console.WriteLine("-" + jugador.Nombre + " con el numero " + jugador.Numero);
                }
             }     









            //equipos.Add(beisbol1);
            //equipos.Add(beisbol2);


            //Jugador ana = new Jugador("ana", "34");
            //Jugador maria = new Jugador();
            //Jugador marcos = new Jugador("marcos", "56");
            //Jugador manuel = new Jugador("manuel", "57");
            //Jugador emanuel = new Jugador("emanuel", "50");
            //Jugador miguel = new Jugador("miguel", "59");
            //Jugador Juan = new Jugador("Juan", "67");
            //Jugador mia = new Jugador("mia", "26");
            //Jugador noe = new Jugador("noe", "56");





            //beisbol1.Jugadores.Add(ana);
            //beisbol1.Jugadores.Add(maria);
            //beisbol1.Jugadores.Add(marcos);
            //beisbol1.Jugadores.Add(manuel);
            //beisbol1.Jugadores.Add(Juan);
            //beisbol1.Jugadores.Add(mia);
            //beisbol1.Jugadores.Add(noe);
            //beisbol1.Jugadores.Add(miguel);
            //beisbol1.Jugadores.Add(emanuel);

            //beisbol2.Jugadores.Add(maria);
            //beisbol2.Jugadores.Add(ana);
            //beisbol2.Jugadores.Add(maria);
            //beisbol2.Jugadores.Add(marcos);
            //beisbol2.Jugadores.Add(manuel);
            //beisbol2.Jugadores.Add(Juan);
            //beisbol2.Jugadores.Add(mia);
            //beisbol2.Jugadores.Add(noe);
            //beisbol2.Jugadores.Add(miguel);
            //beisbol2.Jugadores.Add(emanuel);

            //foreach (Equipo ekipo in equipos)
            //clasedelaqueviene   nuevonombre   nuevonombrequesedeclaroarriba
            //{

            //Console.WriteLine("nombre del equipo" + ekipo.Nomb);
            //Console.WriteLine("entrenador: " + ekipo.Entrenador);
            //Console.WriteLine("direccion: " + ekipo.Direccion);

            //foreach (Jugador jugadr in ekipo.Jugadores)
            //{
            //Console.WriteLine("*" + jugadr.Nombre);
            //Console.WriteLine("-" + jugadr.Numero);
            // }
        
        Console.Read();
        }
        
    }
}
