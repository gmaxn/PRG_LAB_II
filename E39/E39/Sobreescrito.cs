using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E39
{
    abstract public class Sobreescrito
    {
        protected string miAtributo;

        public abstract string MiPropiedad
        { get; }

        public Sobreescrito()
        {
            this.miAtributo = "Probar Abstractos";
        }
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }
        public override bool Equals(object obj)
        {
            return obj.GetType() == this.GetType();
        }
        public override int GetHashCode()
        {
            return (int)1142510187;
        }

        public abstract string MiMetodo();     
    }
}
