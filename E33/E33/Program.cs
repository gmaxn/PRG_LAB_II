using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro l = new Libro();

            Console.WriteLine(l[0]);
            Console.WriteLine(l[1]);
            l[0] = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam facilisis, urna nec sodales faucibus, nisl enim convallis mi, in vulputate nibh justo at libero.";
            l[1] = "Nulla rutrum nisl iaculis commodo luctus. Vestibulum facilisis, urna sit amet placerat luctus, augue risus accumsan nulla, a accumsan turpis felis nec purus. Vestibulum et facilisis augue. Donec faucibus sagittis pharetra.";
            Console.WriteLine(l[0]);
            Console.WriteLine(l[1]);
        }
    }
}
