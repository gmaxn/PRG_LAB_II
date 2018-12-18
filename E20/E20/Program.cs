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
            Peso p1 = new Peso(1, (float)0.026);
            Euro e1 = new Euro(1, (float)1.14);
            Dolar d1 = new Dolar(1, 1);

            Peso p2 = new Peso(40, (float)0.026);
            Euro e2 = new Euro((double)1.14, (float)1.14);
            Dolar d2 = new Dolar(1, 1);



            Console.WriteLine("OPERACIONES PESO");
            Console.WriteLine("ARS {0} + ARS {1}: ARS {2:N3}", (double)p1, (double)p1, (double)(p1 + p1));
            Console.WriteLine("ARS {0} + USD {1}: ARS {2:N3}", (double)p1, (double)d1, (double)(p1 + d1));
            Console.WriteLine("ARS {0} + EUR {1}: ARS {2:N3}", (double)p1, (double)e1, (double)(p1 + e1));
            Console.WriteLine("******************************************");

            Console.WriteLine("OPERACIONES EURO");
            Console.WriteLine("EUR {0} + EUR {1}: EUR {2:N3}", (double)e1, (double)e1, (double)(e1 + e1));
            Console.WriteLine("EUR {0} + USD {1}: EUR {2:N3}", (double)e1, (double)d1, (double)(e1 + d1));
            Console.WriteLine("EUR {0} + ARS {1}: EUR {2:N3}", (double)e1, (double)p1, (double)(e1 + p1));
            Console.WriteLine("******************************************");

            Console.WriteLine("OPERACIONES DOLAR");
            Console.WriteLine("USD {0} + USD {1}: USD {2:N3}", (double)d1, (double)d1, (double)(d1 + d1));
            Console.WriteLine("USD {0} + ARS {1}: USD {2:N3}", (double)d1, (double)p1, (double)(d1 + p1));
            Console.WriteLine("USD {0} + EUR {1}: USD {2:N3}", (double)d1, (double)e1, (double)(d1 + e1));
            Console.WriteLine("******************************************");

            Console.WriteLine("OPERACIONES LOGICAS");
            Console.WriteLine("USD {0} = USD {1}: {2}", (double)d1, (double)d1, (d1 == d1));
            Console.WriteLine("USD {0} = ARS {1}: {2}", (double)d1, (double)p2, (d1 == p1));
            Console.WriteLine("USD {0} = EUR {1}: {2}", (double)d1, (double)e2, (d1 == e2));
            Console.WriteLine("******************************************");

            Console.WriteLine("CONVERSIONES (CASTING)");
            Console.WriteLine("USD {0} + USD {1}: USD {2:N3}", (double)d1, (double)d1, (double)(d1 + d1));
            Console.WriteLine("USD {0} + ARS {1}: USD {2:N3}", (double)d1, (double)p1, (double)(d1 + p1));
            Console.WriteLine("USD {0} + EUR {1}: USD {2:N3}", (double)d1, (double)e1, (double)(d1 + e1));
            Console.WriteLine("******************************************");


            Console.ReadKey();

        }
    }
}


 