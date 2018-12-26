using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MiBiblioteca;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("CONMEBOL Libertadores de America");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("FIBA World Championship");

            EquipoFutbol eFutbolA = new EquipoFutbol("ROSARIO CENTRAL", new DateTime(1896, 1, 21));
            EquipoFutbol eFutbolB = new EquipoFutbol("RIVER", new DateTime(1901, 5, 25));
            EquipoFutbol eFutbolC = new EquipoFutbol("BOCA", new DateTime(1905, 4, 3));

            EquipoBasquet eBasquetA = new EquipoBasquet("SAN ANTONIO SPURS", new DateTime(1967, 5, 1));
            EquipoBasquet eBasquetB = new EquipoBasquet("LOS ANGELES LAKERS", new DateTime(1947, 3, 12));
            EquipoBasquet eBasquetC = new EquipoBasquet("CHICAGO BULLS", new DateTime(1966, 8, 25));

            // Agrego los Equipos de Futbol al torneo
            torneoFutbol += eFutbolA;
            torneoFutbol += eFutbolB;
            torneoFutbol += eFutbolC;

            //Juego los partidos de Futbol e imprimo los resultados por pantalla
            Console.WriteLine("Resultados partidos de Futbol");
            Console.WriteLine("******************************");
            Console.WriteLine(torneoFutbol.ToString());

            Console.WriteLine(torneoFutbol.JugarParido);
            Console.WriteLine(torneoFutbol.JugarParido);
            Console.WriteLine(torneoFutbol.JugarParido);


            Console.WriteLine("------------- Fin -------------");
            Console.WriteLine("\n");

            // Agrego los Equipos de Basquet al torneo
            torneoBasquet += eBasquetA;
            torneoBasquet += eBasquetB;
            torneoBasquet += eBasquetC;

            // Juego los partidos de Basquet e imprimo los resultados por pantalla
            Console.WriteLine("Resultados partidos de Basquet");
            Console.WriteLine("******************************");
            Console.WriteLine(torneoBasquet.ToString());

            Console.WriteLine(torneoBasquet.JugarParido);
            Console.WriteLine(torneoBasquet.JugarParido);
            Console.WriteLine(torneoBasquet.JugarParido);
            Console.WriteLine("------------- Fin -------------");
            Console.WriteLine("\n");
        }
    }
}
