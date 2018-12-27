using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E51
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
    }
}
