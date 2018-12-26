using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E39
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////
            SobreSobreescrito sSobreescrito = new SobreSobreescrito();
            SobreSobreescrito sSobreescrito2 = new SobreSobreescrito();

            Console.WriteLine(sSobreescrito.MiPropiedad);
            Console.WriteLine(sSobreescrito.MiMetodo());

            Console.ReadKey();
            /////////////////////////////////////////

            Console.Title = "Ejercicio Nº39 Guía 2017";
            Console.WriteLine(sSobreescrito.ToString());
            string objeto = "¡Este es mi método ToString sobreescrito!";
            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(sSobreescrito.Equals(sSobreescrito2));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sSobreescrito.GetHashCode());
            Console.ReadKey();




        }
    }
}
