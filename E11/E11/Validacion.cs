using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E11
{
    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool returnAux = true;
            if (valor < min || valor > max)
                returnAux = false;
            return returnAux;
        }
    }
}
