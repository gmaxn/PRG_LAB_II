using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E10
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.ImprimirPiramide(20);
            Console.ReadKey();
        }

        public static void ImprimirPiramide(int dimension)
        {
            int i = 0, j = 0;
            int asteriscos = 1;
            int espacios = dimension / 2;
            while (asteriscos <= dimension)
            {
                while (j < espacios)
                {
                    Console.Write(" ");
                    j++;
                }
                while (i < asteriscos)
                {
                    if (asteriscos%2 == 1 && i < 15 && i > 0)
                        Console.ForegroundColor = ((ConsoleColor)i);

                    Console.Write("*");
                    i++;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write("\n");
                asteriscos = i + 2;
                espacios = j - 1;
                i = 0;
                j = 0;
            }
            espacios = dimension / 2;
            for(int p = 0; p<2; p++)
            {
                while (j < espacios)
                {
                    Console.Write(" ");
                    j++;
                }
                for (int q = 0; q < 2; q++)
                {
                    Console.Write("*");
                    i++;
                }
                Console.Write("\n");
                i = 0;
                j = 0;
            }
        }
    }
}
