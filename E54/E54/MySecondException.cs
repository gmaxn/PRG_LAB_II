using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E54
{
    public class MySecondException : Exception
    {
        public MySecondException(string mensaje, Exception inner)
            : base(mensaje, inner)
        { }
        public MySecondException(string mensaje)
            : base(mensaje)
        { }
    }
}
