using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E9
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.ImprimirPiramide(9);
            Console.ReadKey();
        }

        public static void ImprimirPiramide(int dimension)
        {
            int i = 0;
            int asteriscos = 1;

            while (asteriscos <= dimension)
            {
                while (i < asteriscos)
                {
                    Console.Write("*");
                    i++;
                }
                Console.Write("\n");
                asteriscos = i + 2;
                i = 0;
            }
        }
    }
}
