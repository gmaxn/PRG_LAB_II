using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E11
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux;
            int min = 0;
            int max = 0;
            float promedio;

            while(SeguirCargando())
            {
                if(int.TryParse(Console.ReadLine(), out aux))
                {
                    if(Validacion.Validar(aux, -100, 100))
                    {
                        if (aux > max)
                            max = aux;

                        if (aux < min)
                            min = aux;
                    }
                }               
            }

        }
        public static string MostrarMaxMin(int[] numeros)
        {
            int max = numeros[0], min = numeros[0];
            StringBuilder sb = new StringBuilder();
            foreach (int i in numeros)
            {
                if (i > max)
                    max = i;

                if (i < min)
                    min = i;
            }
            sb.AppendLine("El valor Maximo del conjunto es: " + max);
            sb.AppendLine("El valor Minimo del conjunto es: " + min);
            return sb.ToString();
        }
        public static bool SeguirCargando()
        {
            ConsoleKeyInfo cki;
            Console.WriteLine("presione una tecla para cargar o Escape (Esc) para salir");
            cki = Console.ReadKey();
            Console.Clear();
            Console.WriteLine("presione una tecla para cargar o Escape (Esc) para salir");
            if (cki.Key == ConsoleKey.Escape)
                return false;
            return true;
        }
        public static bool ObtenerNumeroNatural(string request, int intentos, string msgError, out int numero)
        {
            Console.WriteLine(request);
            while (Validacion.Validar())
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
