using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia C = new Competencia(10, 5);

            AutoF1 A1 = new AutoF1(1, "Ferrari");
            AutoF1 A2 = A1;
            AutoF1 A3 = new AutoF1(2, "McLaren");
            AutoF1 A4 = new AutoF1(3, "Ferrari");
            AutoF1 A5 = new AutoF1(4, "Williams");
            AutoF1 A6 = new AutoF1(4, "Williams");
            AutoF1 A7 = new AutoF1(6, "Mercedes");

            Console.WriteLine("Inscripciones a la competencia");
            Console.WriteLine("******************************");
            Console.WriteLine("AutpF1 A1 - " + (C + A1));
            Console.WriteLine("AutpF1 A2 - " + (C + A2));
            Console.WriteLine("AutpF1 A3 - " + (C + A3));
            Console.WriteLine("AutpF1 A4 - " + (C + A4));
            Console.WriteLine("AutpF1 A5 - " + (C + A5));
            Console.WriteLine("AutpF1 A6 - " + (C + A6));
            Console.WriteLine("AutpF1 A7 - " + (C + A7));
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(C.MostrarDatos());
        }
    }
}
