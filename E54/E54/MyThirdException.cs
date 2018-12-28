using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E54
{
    public class MyThirdException : Exception
    {
        public MyThirdException(string mensaje, Exception inner)
            : base(mensaje, inner)
        { }
        public MyThirdException(string mensaje)
            : base(mensaje)
        { }
    }
}
