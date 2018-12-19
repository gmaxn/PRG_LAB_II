using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            int año;

            while (Program.ObtenerNumeroDelUsuario("ingrese un año:", 3, "ha ingresado un valor incorrecto. intente nuevamente: ", out año))
                Console.WriteLine(CalcularAñoBisiesto(año));

                Console.ReadKey();
        }

        public static string CalcularAñoBisiesto(int año)
        {
            int[] modulos = new int[3];
            modulos[0] = año % 4;
            modulos[1] = año % 100;
            modulos[2] = año % 400;

            if ((modulos[1] == 0 && modulos[2] == 0) || (modulos[0] == 0 && modulos[1] != 0))
                return ("Es Bisiesto");
            else
                return ("No es Bisiesto");
        }
        public static bool ObtenerNumeroDelUsuario(string request, int intentos, string msgError, out int numero)
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
