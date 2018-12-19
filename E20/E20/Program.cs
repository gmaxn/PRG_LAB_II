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

            Console.WriteLine("OPERACIONES LOGICAS - CONVERSIONES (CASTING)");
            Console.WriteLine("USD {0} = USD {1:N3}: {2}", (double)d1, (double)d1, (d1 == d1));
            Console.WriteLine("USD {0} = ARS {1:N3}: {2}", (double)d1, (double)(Peso)d1, (d1 == (Peso)d1));
            Console.WriteLine("USD {0} = EUR {1:N3}: {2}", (double)d1, (double)(Euro)d1, (d1 == (Euro)d1));
            Console.WriteLine();
            Console.WriteLine("EUR {0} = EUR {1:N3}: {2}", (double)e1, (double)e1, (e1 == e1));
            Console.WriteLine("EUR {0} = ARS {1:N3}: {2}", (double)e1, (double)(Peso)e1, (e1 == (Peso)e1));
            Console.WriteLine("EUR {0} = USD {1:N3}: {2}", (double)e1, (double)(Dolar)e1, (e1 == (Dolar)e1));
            Console.WriteLine();
            Console.WriteLine("ARS {0} = ARS {1:N3}: {2}", (double)p1, (double)p1, (p1 == p1));
            Console.WriteLine("ARS {0} = USD {1:N3}: {2}", (double)p1, (double)(Dolar)p1, (p1 == (Dolar)p1));
            Console.WriteLine("ARS {0} = EUR {1:N3}: {2}", (double)p1, (double)(Euro)p1, (p1 == (Euro)p1));
            Console.WriteLine("******************************************");

            Console.ReadKey();
        }
    }
}


 