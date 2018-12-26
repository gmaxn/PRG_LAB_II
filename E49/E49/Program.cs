using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E49
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia<AutoF1> C1 = new Competencia<AutoF1>(10, 10);
            Competencia<MotoCross> C2 = new Competencia<MotoCross>(10, 10);
            Competencia<VehiculoDeCarrera> C3 = new Competencia<VehiculoDeCarrera>(10, 10);

            AutoF1 A1 = new AutoF1(1, "Ferrari", 900);
            AutoF1 A2 = A1;
            AutoF1 A3 = new AutoF1(3, "McLaren", 950);
            AutoF1 A4 = new AutoF1(4, "Mercedes", 1000);
            AutoF1 A5 = new AutoF1(4, "Mercedes", 1000);

            MotoCross M1 = new MotoCross(1, "Yamaha", 450);
            MotoCross M2 = M1;
            MotoCross M3 = new MotoCross(3, "Kawasaki", 475);
            MotoCross M4 = new MotoCross(5, "Honda", 250);
            MotoCross M5 = new MotoCross(5, "Honda", 250);

            VehiculoDeCarrera V1 = A1;
            VehiculoDeCarrera V2 = A2;
            VehiculoDeCarrera V3 = A3;
            VehiculoDeCarrera V4 = M1;
            VehiculoDeCarrera V5 = M3;
            VehiculoDeCarrera V6 = new Motoneta(6, "Zanella", 50);

            //Console.WriteLine(A4 == A5);
            //Console.WriteLine(A1 == A4);


            try
            {
                Console.WriteLine("Inscripciones Competencia AutoF1");
                Console.WriteLine("********************************");
                Console.WriteLine("AutoF1 A1 - " + (C1 + A1));
                Console.WriteLine("AutoF1 A2 - " + (C1 + A2));
                Console.WriteLine("AutoF1 A3 - " + (C1 + A3));
                Console.WriteLine("AutoF1 A4 - " + (C1 + A4));
                Console.WriteLine("AutoF1 A5 - " + (C1 + A5));
                //Console.WriteLine("MotoCross M1 - " + (C1 + M1));
                //Console.WriteLine("Vehiculo V1 - " + (C1 + V1));

                Console.WriteLine("Inscripciones Competencia MotoCross");
                Console.WriteLine("********************************");
                Console.WriteLine("Vehiculo V1 - " + (C2 + M1));
                Console.WriteLine("Vehiculo V2 - " + (C2 + M2));
                Console.WriteLine("Vehiculo V3 - " + (C2 + M3));
                Console.WriteLine("Vehiculo V4 - " + (C2 + M4));
                Console.WriteLine("Vehiculo V5 - " + (C2 + M5));
                //Console.WriteLine("AutoF1 A1 - " + (C2 + A1));
                //Console.WriteLine("Vehiculo V5 - " + (C2 + V1));

                Console.WriteLine("Inscripciones Competencia VehiculoDeCarrera");
                Console.WriteLine("********************************");
                Console.WriteLine("Vehiculo V1 - " + (C3 + A1));
                Console.WriteLine("Vehiculo V2 - " + (C3 + M1));
                Console.WriteLine("Vehiculo V3 - " + (C3 + V3));
                Console.WriteLine("Vehiculo V4 - " + (C3 + V4));
                Console.WriteLine("Vehiculo V5 - " + (C3 + V5));
                Console.WriteLine("Vehiculo V5 - " + (C3 + V6));

            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(new CompetenciaNoDisponibleException(e.Message, e.Nombre, e.NombreMetodo, e).ToString());
            }
            catch (Exception e)
            {
                throw new Exception("Comuniquese con el administrador\n", e);
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(C1.MostrarDatos());
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(C2.MostrarDatos());
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(C3.MostrarDatos());
            Console.ReadKey();
            Console.Clear();
        }
    }
}
