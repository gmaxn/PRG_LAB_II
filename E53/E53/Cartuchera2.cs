using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E53
{
    public class Cartuchera2
    {
        private List<Boligrafo> _boligrafos;
        private List<Lapiz> _lapices;

        public Cartuchera2()
        {
            this._boligrafos = new List<Boligrafo>();
            this._lapices = new List<Lapiz>();
        }

        public bool ProbarElementos()
        {
            int boligrafosLength = _boligrafos.Count;
            int lapicesLength = _lapices.Count;

            foreach (Boligrafo b in this._boligrafos)
            {
                if (b.UnidadesDeEscritura > 0.1F)
                {
                    b.UnidadesDeEscritura -= 0.1F;
                    boligrafosLength--;
                }
            }
            foreach (Lapiz l in this._lapices)
            {
                if (((IAcciones)l).UnidadesDeEscritura > 0.3F)
                {
                    ((IAcciones)l).UnidadesDeEscritura -= 0.3F;
                    lapicesLength--;
                }
            }
            if (boligrafosLength == 0 && lapicesLength == 0)
                return true;

            return false;
        }
    }
}
