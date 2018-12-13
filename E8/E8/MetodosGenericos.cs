using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E8
{
    class MetodosGenericos
    {
        public static bool ObtenerDecimal(string request, int intentos, string msgError, out float numero)
        {
            Console.WriteLine(request);
            while (!float.TryParse(Console.ReadLine(), out numero) || numero <= 0)
            {
                if (intentos == 0)
                    return false;


                Console.WriteLine(msgError + "({0})", intentos);
                intentos--;
            }
            return true;
        }
        public static bool ObtenerNumeroNatural(string request, int intentos, string msgError, out int numero)
        {
            Console.WriteLine(request);
            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1)
            {
                if (intentos == 0)
                    return false;


                Console.WriteLine(msgError + "({0})", intentos);
                intentos--;
            }
            return true;
        }
    }
}
