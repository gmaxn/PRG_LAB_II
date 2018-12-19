using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha;
            if(PedirFechaDeNacimiento(1, out fecha))
            {
                Console.WriteLine("la persona vivio {0} días", CalcularEdad(fecha));
            }
            Console.ReadKey();
        }

        public static int CalcularEdad(DateTime fechaDeNacimiento)
        {
            TimeSpan time = DateTime.Now - fechaDeNacimiento;
            return time.Days;
        }
        public static bool PedirFechaDeNacimiento(int intentos, out DateTime fechaDeNacimiento)
        {
            int[] diaMesAño = new int[3];
            Console.WriteLine("presione una tecla para ingresar fecha");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("presione una tecla para ingresar fecha");
            if (Program.ObtenerNumeroDelUsuario("dia: ", intentos, "dia incorrecto", out diaMesAño[0]))
            {
                if (Program.ObtenerNumeroDelUsuario("mes: ", intentos, "mes incorrecto", out diaMesAño[1]))
                {
                    if (Program.ObtenerNumeroDelUsuario("año: ", intentos, "año incorrecto", out diaMesAño[2]))
                    {
                        fechaDeNacimiento = new DateTime(diaMesAño[2], diaMesAño[1], diaMesAño[0]);
                        return true;
                    }
                }
            }
            fechaDeNacimiento = new DateTime(0, 0, 0);
            return false;
        }
        public static bool ObtenerNumeroDelUsuario(string request, int intentos, string msgError, out int numero)
        {
            Console.Write(request);
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
