using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno A1 = new Alumno(52645, "Lopez", "Martin");
            Alumno A2 = new Alumno(45613, "Gonzalez", "Eduardo");
            Alumno A3 = new Alumno(46321, "Perez", "German");

            A1.Estudiar(4, 5);
            A2.Estudiar(7, 4);
            A3.Estudiar(2, 5);

            A1.CalcularFinal();
            A2.CalcularFinal();
            A3.CalcularFinal();

            Console.WriteLine(A1.Mostrar());
            Console.WriteLine(A2.Mostrar());
            Console.WriteLine(A3.Mostrar());
            Console.ReadKey();
        }
    }
}
