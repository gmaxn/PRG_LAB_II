using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_palabras
{
    class Program
    {
        static void Main(string[] args)
        {
            string rtb = "Informar mediante un MessageBox el TOP 3 de palabras con más apariciones";

            Dictionary<string, int> diccionario = Diccionarios.ContadorDePalabras(rtb);
            diccionario = Diccionarios.OrdenarDiccionario(diccionario);

            Console.WriteLine(Diccionarios.ShowDictionary(diccionario)); 
        }

    }
}
