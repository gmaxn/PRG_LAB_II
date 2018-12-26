using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E43
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia C = new Competencia(10, 10);

            VehiculoDeCarrera V1 = new AutoF1(1, "Ferrari", 900);
            VehiculoDeCarrera V2 = new AutoF1(2, "McLaren", 1000);
            VehiculoDeCarrera V3 = new AutoF1(2, "McLaren", 800);
            VehiculoDeCarrera V4 = new MotoCross(4, "Yamaha", 450);
            VehiculoDeCarrera V5 = new MotoCross(5, "Honda", 450);
            VehiculoDeCarrera V6 = V4;
            VehiculoDeCarrera V7 = new VehiculoDeCarrera(50, "McLaren");

            try
            {
                Console.WriteLine("Inscripciones a la competencia");
                Console.WriteLine("******************************");
                Console.WriteLine("Vehiculo V1 - " + (C + V1));
                Console.WriteLine("Vehiculo V2 - " + (C + V2));
                Console.WriteLine("Vehiculo V3 - " + (C + V3));
                Console.WriteLine("Vehiculo V4 - " + (C + V4));
                Console.WriteLine("Vehiculo V5 - " + (C + V5));
                Console.WriteLine("Vehiculo V6 - " + (C + V6));
                Console.WriteLine("Vehiculo V7 - " + (C + V7));
            }
            catch(Exception e)
            {
                Exception ex = e;

                while (ex != null)
                {
                    if(ex is CompetenciaNoDisponibleException)
                        Console.WriteLine(ex.ToString());
                    ex = ex.InnerException;
                }
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(C.MostrarDatos());
        }
    }
}
