using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Boligrafos;


namespace E17
{
    class Program
    {
        static void Main(string[] args)
        {
            string dibujoB1 = "";
            string dibujoB2 = "";

            Boligrafo boligrafo1 = new Boligrafo();
            Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);

            Console.Write("color del Boligrafo 01: {0}\n", boligrafo1.GetColor());
            Console.Write("nivel de tinta del Boligrafo 01: {0}\n\n", boligrafo1.GetTinta());

            Console.Write("color del Boligrafo 02: {0}\n", boligrafo2.GetColor());
            Console.Write("nivel de tinta del Boligrafo 02: {0}\n\n", boligrafo2.GetTinta());

            boligrafo1.Pintar(50, out dibujoB1);
            Console.Write("Boligrafo 01 pudo gastar: ");
            Console.ForegroundColor = boligrafo1.GetColor();
            Console.Write("{0}\n\n", dibujoB1);
            Console.ResetColor();

            boligrafo2.Pintar(25, out dibujoB2);
            Console.Write("Boligrafo 02 pudo gastar: ");
            Console.ForegroundColor = boligrafo2.GetColor();
            Console.Write("{0}\n\n", dibujoB2);
            Console.ResetColor();


            Console.Write("color del Boligrafo 01: {0}\n", boligrafo1.GetColor());
            Console.Write("nivel de tinta del Boligrafo 01: {0}\n\n", boligrafo1.GetTinta());

            Console.Write("color del Boligrafo 02: {0}\n", boligrafo2.GetColor());
            Console.Write("nivel de tinta del Boligrafo 02: {0}\n\n", boligrafo2.GetTinta());


            boligrafo1.Recargar();
            boligrafo2.Recargar();

            Console.Write("color del Boligrafo 01: {0}\n", boligrafo1.GetColor());
            Console.Write("nivel de tinta del Boligrafo 01: {0}\n\n", boligrafo1.GetTinta());

            Console.Write("color del Boligrafo 02: {0}\n", boligrafo2.GetColor());
            Console.Write("nivel de tinta del Boligrafo 02: {0}\n\n", boligrafo2.GetTinta());


            Console.ReadKey();
        }
    }
}


 