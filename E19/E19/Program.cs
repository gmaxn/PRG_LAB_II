using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador();
            Sumador s2 = new Sumador(250);

            for (int i = 0; i < 250; i++)
                s1.Sumar(1, 1);

            if(s1 | s2)
            {
                Console.WriteLine("Ambos sumadores tienen igual cantidad de sumas");
            }

            Console.WriteLine(s2.Sumar("Hello", "World!"));
        }
    }
}
