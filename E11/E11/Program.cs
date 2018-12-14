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
             
            int i = 0;
            int aux;
            int min = 0;
            int max = 0;
            int promedio = 0;

            Console.WriteLine("ingrese 10 numeros: ");
            while(i<10)
            {
                if (ObtenerEntero("", 2, "intente nuevamente", out aux))
                {
                    if(i == 0)
                    {
                        min = aux;
                        max = aux;
                    }
                        
                    if (Validacion.Validar(aux, -100, 100))
                    {
                        if (aux > max)
                            max = aux;

                        if (aux < min)
                            min = aux;

                        promedio += aux;
                    }
                    else
                    {
                        break;
                    }
                }

                i++;
            }
            if(i == 10)
            {
                Console.WriteLine("El valor Maximo del conjunto es: " + max);
                Console.WriteLine("El valor Minimo del conjunto es: " + min);
                Console.WriteLine("El valor el promedio del conjunto es: " + (float)promedio/10);
            }
            

        }

        public static bool ObtenerEntero(string request, int intentos, string msgError, out int numero)
        {
            Console.Write(request);
            while (!int.TryParse(Console.ReadLine(), out numero))
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
