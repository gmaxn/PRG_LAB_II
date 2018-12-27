using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E53
{
    public class Cartuchera1
    {
        bool flag = true;
        List<IAcciones> c;

        public bool ProbarElementos()
        {
            foreach (IAcciones aux in this.c)
            {
                if (aux.UnidadesDeEscritura > 1)
                    aux.UnidadesDeEscritura--;
                else
                {
                    aux.Recargar(10);
                    flag = false;
                }
            }
            return flag;
        }
    }
}
