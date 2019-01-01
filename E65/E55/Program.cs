using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E55
{
    class Program
    {
        static void Main(string[] args)
        {
        	// Mi central
            Centralita c = new Centralita("Carlitos S.A.");


            // Mis 4 llamadas
            Local l1 = new Local("Bernal", "Rosario", 30, 2.65f);
            Local l2 = new Local("Lanús", "San Rafael", 45, 1.99f);
            Local l3 = l2;

            Provincial l4 = new Provincial("Morón", "Bernal", 21, Provincial.Franja.Franja_1);
            Provincial l5 = new Provincial(l2, Provincial.Franja.Franja_3);
            Provincial l6 = new Provincial("Costa del Este", "Banfield", 21, Provincial.Franja.Franja_3);

            try
            {
                c += l1;
                c += l1;
                c += l2;
                c += l3;
                c += l4;
                c += l5;
                c += l6;
            }
            catch (CentralitaException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(c.ToString());
            Console.WriteLine("Guardado Exitoso: " + c.Guardar());

        }
        public static Llamada GeneradorDeLlamadas()
        {
            string[] local = new string[] { "Temperley", "Lomas de Zamora", "Banfield", "Lanus", "Escalada", "Gerli", "Avellaneda" };
            string[] provincial = new string[] { "Moron", "Bernal", "Rosario", "Buenos Aires", "La Plata" };
            int duracion = new Random().Next(0, 60);

            Llamada l;

            switch (new Random().Next(0,1))
            {
                case 0:
                    l = new Local(local[new Random().Next(0, 6)], local[new Random().Next(0, 6)], duracion, 2.65f);
                    break;
                case 1:
                    l = new Provincial(provincial[new Random().Next(0, 4)], provincial[new Random().Next(0, 4)], duracion, (Provincial.Franja)new Random().Next(0, 2));
                    break;
                default:
                    l = null;
                    break;
            }

            return l;

        }
    }

}
