using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E33
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>(100);
        }
        
        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < this.paginas.Count)
                {
                    return paginas[i];
                }
                return "";
            }
            set
            {
                if (i >= 0)
                {
                    if (i < this.paginas.Count)
                    {
                        paginas[i] = value;
                    }
                    paginas.Add(value);
                }
            }
        }
    }
}
