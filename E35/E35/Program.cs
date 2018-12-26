using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E35
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo e1 = new Equipo(4, "River Plate");
            Equipo e2 = new Equipo(5, "Boca Juniors");

            Persona p1 = new Persona("sarasa", 11111111);
            Jugador j8 = new Jugador("Carlos Tevez", 50, 35);

            p1 = j8;


            Console.WriteLine(p1.MostrarDatos());
            Console.WriteLine(((e2 + (Jugador)p1) ? "jugador agregado" : "Error de carga"));


        }
    }
}
