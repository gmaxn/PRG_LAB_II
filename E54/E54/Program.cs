using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO;

namespace E54
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = string.Format("\\{0}{1}{2}-{3}{4}.txt", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute);
            StringBuilder path = new StringBuilder(fileLocation + fileName);
            StringBuilder data = new StringBuilder();

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
                    data.AppendLine(ex.Message);
                    ex = ex.InnerException;
                }
                ArchivoTexto.Guardar(path.ToString(), data.ToString());
            }
            Console.WriteLine(ArchivoTexto.Leer(path.ToString()));
        }
    }
}
