using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E37
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central telefonica
            Centralita c = new Centralita("Carlitos S.A.");

            // Mis 6 llamadas
            Local l1 = new Local("Banfield", "Lanús", 30, 2.65f);
            Local l2 = new Local("Lomas de Zamora", "Temperley", 45, 1.99f);
            Local l3 = l1;

            Provincial l4 = new Provincial("Banfield", "Costa del Este", 21, Provincial.Franja.Franja_1);
            Provincial l5 = new Provincial(l4, Provincial.Franja.Franja_3);
            Provincial l6 = new Provincial("Rosario", "Santa Fe", 21, Provincial.Franja.Franja_3);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c.Llmadas.Add(l1);
            c.Llmadas.Add(l2);
            c.Llmadas.Add(l3);
            c.Llmadas.Add(l4);
            c.Llmadas.Add(l5);
            c.Llmadas.Add(l6);
            Console.WriteLine(c.Mostrar());

            Console.ReadKey();
        }
    }
}
