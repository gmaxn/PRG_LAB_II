using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = Sets.GetRandomSet(20, -100, 100);

            Console.WriteLine("-- ARRAY DESORDENADO --");
            Console.WriteLine(Sets.ShowSet(numeros));

            Console.WriteLine("-- ARRAY ORDENADO (QUICKSORT)--");
            Sets.QuickSortDecreciente(numeros, 0, numeros.Length-1);
            Sets.OrdenarSoloNegativosCreciente(numeros);
            Console.WriteLine(Sets.ShowSet(numeros));

            Console.ReadKey();
        }
    }

}
