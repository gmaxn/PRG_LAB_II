using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E51
{
    public class CentralitaException : Exception
    {
        public CentralitaException(string msg, Exception inner)
            : base(msg, inner)
        { }

        public CentralitaException(string msg)
            : base(msg)
        { }

        
        public override string ToString()
        {
            return "Mensaje: " + base.Message + ", Origen del error: " + base.Source;
        }
    }
}
