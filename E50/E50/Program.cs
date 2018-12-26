using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E50
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "string";
            int integer = 1;

            Serializar<int, string> S1 = new Serializar<int, string>();
            GuardarTexto<string, string> G1 = new GuardarTexto<string, string>();

            Console.WriteLine(S1.Leer());
            Console.WriteLine(S1.Guardar(integer));

            Console.WriteLine(G1.Leer());
            Console.WriteLine(G1.Guardar(str));
            Console.ReadKey();
        }
    }
}
