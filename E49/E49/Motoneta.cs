using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E49
{
    public class Motoneta : VehiculoDeCarrera
    {
        private short _cilindrada;

        public short Cilindrada
        {
            get { return this._cilindrada; }
            set { this._cilindrada = value; }
        }

        public Motoneta(short numero, string escuderia, short cilindrada)
            : base(numero, escuderia)
        {
            this._cilindrada = cilindrada;
        }
    }
}
