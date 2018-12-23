using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace E27
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = Sets.GetRandomStack(20, -100, 100);
            Queue<int> q = Sets.GetRandomQueue(20, -100, 100);
            List<int> l = Sets.GetRandomList(20, -100, 100);


            Console.WriteLine("STACK DESORDENADO");
            Console.WriteLine(Sets.ShowStack(s));
            Console.WriteLine("----------------------");
            s = Sets.SortStackPosCrecienteNegDecreciente(s);
            Console.WriteLine("STACK ORDENADO");
            Console.WriteLine(Sets.ShowStack(s));
            Console.WriteLine("----------------------");
            Console.ReadKey();
            Console.Clear();
            ////////////////////////////////////////////

            Console.WriteLine("QUEUE DESORDENADO");
            Console.WriteLine(Sets.ShowQueue(q));
            Console.WriteLine("----------------------");
            q = Sets.SortQueuePosCrecienteNegDecreciente(q);
            Console.WriteLine("QUEUE ORDENADO");
            Console.WriteLine(Sets.ShowQueue(q));
            Console.WriteLine("----------------------");
            Console.ReadKey();
            Console.Clear();
            ////////////////////////////////////////////

            Console.WriteLine("LIST DESORDENADO");
            Console.WriteLine(Sets.ShowList(l));
            Console.WriteLine("----------------------");
            l = Sets.SortListPosCrecienteNegDecreciente(l);
            Console.WriteLine("LIST ORDENADO");
            Console.WriteLine(Sets.ShowList(l));
            Console.WriteLine("----------------------");
            Console.ReadKey();
            Console.Clear();
            ////////////////////////////////////////////               
        }
    }


}
