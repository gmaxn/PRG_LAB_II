using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E48
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> C1 = new Contabilidad<Factura, Recibo>();

            Recibo R1 = new Recibo();
            Recibo R2 = new Recibo(1);
            Recibo R3 = R1;

            Factura F1 = new Factura(1);
            Factura F2 = new Factura(2);
            Factura F3 = F1;

            C1 += R1;
            C1 += R2;
            C1 += R3;

            C1 += F1;
            C1 += F2;
            C1 += F3;

            Console.WriteLine(C1.ToString());
        }
    }
}
