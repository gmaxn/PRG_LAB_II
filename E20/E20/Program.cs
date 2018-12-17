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
            Peso p2 = new Peso(5, (float)0.025);
            Peso p3 = new Peso(40, (float)0.025);

            Dolar d1 = new Dolar(1, 1);
            Dolar d2 = new Dolar(5, 1);
            Dolar d3 = new Dolar(1.13, 1);

            Euro e1 = new Euro(1, (float)1.13);
            Euro e2 = new Euro(5, (float)1.13);
            Euro e3 = new Euro((float)(1 / 1.13), (float)1.13);


            Console.WriteLine("OPERACIONES MISMO TIPO");
            Console.WriteLine("USD(1) + USD(5): " + (double)(d1 + d2));
            Console.WriteLine("EUR(1) + EUR(5): " + (double)(e1 + e2));
            Console.WriteLine("ARS(1) + ARS(5): " + (double)(p1 + p2));
            Console.WriteLine("*****************************************");


            Console.WriteLine("OPERACIONES DOLAR");
            Console.WriteLine("USD(1) + EUR(1): USD " + (double)(d1 + e1));
            Console.WriteLine("USD(1) + EUR(5): USD " + (double)(d1 + e2));
            Console.WriteLine("USD(1) + ARS(1): USD " + (double)(d1 + p1));
            Console.WriteLine("USD(1) + ARS(5): USD " + (double)(d1 + p2));
            Console.WriteLine("USD(1) - EUR(1): USD " + (double)(d1 - e1));
            Console.WriteLine("USD(5) - EUR(5): USD " + (double)(d2 - e2));
            Console.WriteLine("USD(1) - ARS(1): USD " + (double)(d1 - p1));
            Console.WriteLine("USD(1) - ARS(5): USD " + (double)(d1 - p2));
            Console.WriteLine("*****************************************");

            Console.WriteLine("OPERACIONES EURO");
            Console.WriteLine("EUR(1) + USD(1): EUR " + (double)(e1 + d1));
            Console.WriteLine("EUR(1) + USD(5): EUR " + (double)(e1 + d2));
            Console.WriteLine("EUR(1) + ARS(1): EUR " + (double)(e1 + p1));
            Console.WriteLine("EUR(1) + ARS(5): EUR " + (double)(e1 + p2));
            Console.WriteLine("EUR(1) - USD(1): EUR " + (double)(e1 - d1));
            Console.WriteLine("EUR(1) - USD(5): EUR " + (double)(e1 - d2));
            Console.WriteLine("EUR(1) - ARS(1): EUR " + (double)(e1 - p1));
            Console.WriteLine("EUR(1) - ARS(5): EUR " + (double)(e1 - p2));
            Console.WriteLine("*****************************************");

            Console.WriteLine("OPERACIONES PESO");
            Console.WriteLine("{0} ARS + {1} USD = ARS{2}", p3.GetCantidad, d1.GetCantidad, (double)(p3 + d1));
            Console.WriteLine("{0} USD + {1} ARS = USD{2}", d1.GetCantidad, p3.GetCantidad, (double)(d1 + p3));

            Console.WriteLine("ARS(1) + USD(5): ARS " + (double)(p1 + d2));
            Console.WriteLine("ARS(1) + EUR(1): ARS " + (double)(p1 + e1));
            Console.WriteLine("ARS(1) + EUR(5): ARS " + (double)(p1 + e2));
            Console.WriteLine("ARS(1) - USD(1): ARS " + (double)(p1 - d1));
            Console.WriteLine("ARS(1) - USD(5): ARS " + (double)(p1 - d2));
            Console.WriteLine("ARS(1) - EUR(1): ARS " + (double)(p1 - e1));
            Console.WriteLine("ARS(1) - EUR(5): ARS " + (double)(p1 - e2));
            Console.WriteLine("*****************************************");

            Console.WriteLine("OPERACIONES LOGICAS");
            Console.WriteLine("{0} ARS == {1} USD = {2}", p3.GetCantidad, d1.GetCantidad, p3 == d1);
            Console.WriteLine("{0} USD == {1} EUR = {2}", d3.GetCantidad, e1.GetCantidad, d3 == e1);
            Console.WriteLine("{0} EUR == {1} USD = {2}", e3.GetCantidad, d1.GetCantidad, e3 == d1);
            Console.WriteLine("*****************************************");

            Console.ReadKey();

        }
    }
}


 