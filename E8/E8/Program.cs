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
            Empleado e = new Empleado();
        }


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
    public class Empleado
    {
        #region ** CLASS CORE **
        // >> Campos
        private string nombre;
        private int antiguedad;
        private int cantHorasTrabajadas;

        // >> Propiedades
        public string Nombre
        {
            get { return this.nombre; }
        }
        public int Antiguedad
        {
            get { return this.antiguedad; }
        }
        public int CantHorasTrabajadas
        {
            get { return this.cantHorasTrabajadas; }
        }


        // >> Constructores
        public Empleado()
        { }
        public Empleado(string nombre, int antiguedad, int cantHorasTrabajadas)
        {
            this.nombre = nombre;
            this.antiguedad = antiguedad;
            this.cantHorasTrabajadas = cantHorasTrabajadas;
        }

        // >> Mostrar Datos
        public string ShowData()
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }
        #endregion

        // >> Metodos
        public void ObtenerDatos()
        {

            //if(Program.)
        }

        public string ObtenerNombre()
        {
            Console.Write("nombre: ");
            string nombre = Console.ReadLine();

            if (nombre.Length < 10 && nombre != null)
            {
                foreach (char c in nombre)
                {
                    if ((c > 'A' || c < 'Z') || (c > 'a' || c < 'z'))
                    {
                        nombre = null;
                    }
                }

            }
            else
            {
                nombre = null;
            }

            return nombre;
            
            
            if(Console.ReadLine().ToStri < 10)


        }


    }
}
