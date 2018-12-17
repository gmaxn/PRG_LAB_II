using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace E20
{
    class Program
    {
        static void Main(string[] args)
        {


            Peso p1 = new Peso(1, (float)0.025);
            Peso p2 = new Peso(40, (float)0.025);

            Dolar d1 = new Dolar(1, 1);
            Dolar d2 = new Dolar(40, 1);

            Euro e1 = new Euro(1, (float)1.13);
            Euro e2 = new Euro(40, (float)1.13);


            Console.WriteLine("OPERACIONES MIXTAS PESO");
            Console.WriteLine("ARS{0} + ARS{1}: ARS{2}", (double)p2, (double)p2, (double)(p2 + p2));
            Console.WriteLine("ARS{0} + USD{1}: ARS{2}", (double)p2, (double)d2, (double)(p2 + d2));
            Console.WriteLine("ARS{0} + EUR{1}: ARS{2}", (double)p2, (double)e2, (double)(p2 + e2));
            Console.WriteLine("******************************************");

            Console.WriteLine("OPERACIONES MIXTAS EURO");
            Console.WriteLine("EUR{0} + EUR{1}: EUR{2}", (double)e2, (double)e2, (double)(e2 + e2));
            Console.WriteLine("EUR{0} + USD{1}: EUR{2}", (double)e2, (double)d2, (double)(e2 + d2));
            Console.WriteLine("EUR{0} + ARS{1}: EUR{2}", (double)e1, (double)p2, (double)(e2 + p2));
            Console.WriteLine("******************************************");

            Console.WriteLine("OPERACIONES MIXTAS DOLAR");
            Console.WriteLine("USD{0} + USD{1}: USD{2}", (double)d2, (double)d2, (double)(d2 + d2));
            Console.WriteLine("USD{0} + ARS{1}: USD{2}", (double)d2, (double)p2, (double)(d2 + p2));
            Console.WriteLine("USD{0} + EUR{1}: USD{2}", (double)d2, (double)e2, (double)(d2 + e2));
            Console.WriteLine("******************************************");

            Console.ReadKey();

        }
    }
}


 