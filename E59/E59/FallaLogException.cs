using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E59
{
    public class FallaLogException : Exception
    {
        public FallaLogException(string msg, Exception inner)
            : base(msg, inner)
        { }

        public FallaLogException(string msg)
            : base(msg)
        { }


        public override string ToString()
        {
            return "Mensaje: " + base.Message + ", Origen del error: " + base.Source;
        }
    }
}
