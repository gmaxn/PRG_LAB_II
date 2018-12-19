using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

            while (Program.SeguirCargando())
            {
                Empleado e = Program.PedirDatosEmpleado();

                if (e != null && !(empleados.Contains(e)))
                {
                    empleados.Add(e);
                }
            }

            if(empleados != null)
            {
                foreach (Empleado emp in empleados)
                {
                    Console.WriteLine(emp.MostrarDatos());
                }
            }
            Console.ReadKey();
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
        public static Empleado PedirDatosEmpleado()
        {

            string nombre;
            int antiguedad;
            float valorHora;
            int cantHorasTrabajadas;

            if (Program.ObtenerNombre("Nombre: ", 2, "Error intente nuevamente: ", out nombre))
            {
                if (Program.ObtenerAntiguedad("Antiguedad: ", 2, "Error intente nuevamente: ", out antiguedad))
                {
                    if (Program.ObtenerValorHora("Valor Hora: ", 2, "Error intente nuevamente: ", out valorHora))
                    {
                        if (Program.ObtenerCantHorasTrabajadas("Cantidad de Horas trabajadas: ", 2, "Error intente nuevamente: ", out cantHorasTrabajadas))
                        {
                            return new Empleado(nombre, antiguedad, valorHora, cantHorasTrabajadas);
                        }
                    }
                }
            }
            return null;
        }
        public static bool ObtenerNombre(string request, int intentos, string msgError, out string nombre)
        {
            bool returnAux = false;
            Console.Write(request);
            nombre = Console.ReadLine().ToLower();

            if (nombre.Length > 15 && nombre != null)
                nombre = null;

            foreach (char c in nombre)
            {
                if ((c < 'a' || c > 'z'))
                    nombre = null;
            }

            if (nombre != null)
            {
                nombre = char.ToUpper(nombre[0]).ToString() + nombre.Remove(0, 1);
                returnAux = true;
            }

            return returnAux;
        }
        public static bool ObtenerAntiguedad(string request, int intentos, string msgError, out int numero)
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
        public static bool ObtenerValorHora(string request, int intentos, string msgError, out float numero)
        {
            Console.Write(request);
            while (!float.TryParse(Console.ReadLine(), out numero) || numero <= 0)
            {
                if (intentos == 0)
                    return false;

                Console.WriteLine(msgError + "({0})", intentos);
                intentos--;
            }
            return true;
        }
        public static bool ObtenerCantHorasTrabajadas(string request, int intentos, string msgError, out int numero)
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
        

