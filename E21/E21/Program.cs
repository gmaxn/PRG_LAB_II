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
            Celsius c1 = new Celsius(1, 1);
            Fahrenheit f1 = new Fahrenheit(33.8, (float)274.15);

            Celsius aux = c1 + f1;

            Console.WriteLine(c1 == f1);
        }
    }
}
