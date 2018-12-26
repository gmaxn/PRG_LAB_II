using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E38
{
    class Sobreescrito
    {
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }

        public override bool Equals(object obj)
        {
            return (this.GetType() == obj.GetType());
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
