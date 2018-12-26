using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 1. Instancio una clase y llamao a un metodo 'X'
                Persona p = new Persona();
                p.MetodoQueGeneraError();
            }
            catch (MyThirdException e)
            {
                Exception ex = e;

                while (ex != null)
                {
                    Console.WriteLine(ex.Message);
                    ex = ex.InnerException;
                }
            }
        }
    }
}
