using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscalasTemperatura;

namespace E21
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius c1 = new Celsius(1);
            Kelvin k1 = new Kelvin(1);
            Fahrenheit f1 = new Fahrenheit(1);

            Console.WriteLine("OPERACIONES CELSIUS");
            Console.WriteLine("C {0} + C {1}: C {2}", (double)c1, (double)c1, (double)(c1 + c1));
            Console.WriteLine("C {0} + F {1}: C {2}", (double)c1, (double)f1, (double)(c1 + f1));
            Console.WriteLine("C {0} + K {1}: C {2}", (double)c1, (double)k1, (double)(c1 + k1));
            Console.WriteLine("******************************************");

            Console.WriteLine("OPERACIONES KELVIN");
            Console.WriteLine("K {0} + K {1}: K {2}", (double)k1, (double)k1, (double)(k1 + k1));
            Console.WriteLine("K {0} + F {1}: K {2}", (double)k1, (double)f1, (double)(k1 + f1));
            Console.WriteLine("K {0} + C {1}: K {2}", (double)k1, (double)c1, (double)(k1 + c1));
            Console.WriteLine("******************************************");

            Console.WriteLine("OPERACIONES FAHRENHEIT");
            Console.WriteLine("F {0} + F {1}: F {2}", (double)f1, (double)f1, (double)(f1 + f1));
            Console.WriteLine("F {0} + C {1}: F {2}", (double)f1, (double)c1, (double)(f1 + c1));
            Console.WriteLine("F {0} + K {1}: F {2}", (double)f1, (double)k1, (double)(f1 + k1));
            Console.WriteLine("******************************************");

            Console.WriteLine("OPERACIONES LOGICAS - CONVERSIONES (CASTING)");
            Console.WriteLine("F {0} = F {1:N3}: {2}", (double)f1, (double)f1, (f1 == f1));
            Console.WriteLine("F {0} = C {1:N3}: {2}", (double)f1, (double)(Celsius)f1, (f1 == (Celsius)f1));
            Console.WriteLine("F {0} = K {1:N3}: {2}", (double)f1, (double)(Kelvin)f1, (f1 == (Kelvin)f1));
            Console.WriteLine();
            Console.WriteLine("K {0} = K {1:N3}: {2}", (double)k1, (double)k1, (k1 == k1));
            Console.WriteLine("K {0} = C {1:N3}: {2}", (double)k1, (double)(Celsius)k1, (k1 == (Celsius)k1));
            Console.WriteLine("K {0} = F {1:N3}: {2}", (double)k1, (double)(Fahrenheit)k1, (k1 == (Fahrenheit)k1));
            Console.WriteLine();
            Console.WriteLine("C {0} = C {1:N3}: {2}", (double)c1, (double)c1, (c1 == c1));
            Console.WriteLine("C {0} = F {1:N3}: {2}", (double)c1, (double)(Fahrenheit)c1, (c1 == (Fahrenheit)c1));
            Console.WriteLine("C {0} = K {1:N3}: {2}", (double)c1, (double)(Kelvin)c1, (c1 == (Kelvin)c1));
            Console.WriteLine("******************************************");
        }
    }
}
