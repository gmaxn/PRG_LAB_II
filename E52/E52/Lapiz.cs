using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E52
{
    public class Lapiz : IAcciones
    {
        private float _tamañoMina;
        ConsoleColor IAcciones.Color
        {
            get { return ConsoleColor.Gray; }
            set { throw new NotImplementedException(); }
        }

        float IAcciones.UnidadesDeEscritura
        {
            get{ return this._tamañoMina; }
            set{ throw new NotImplementedException(); }
        }
        public Lapiz(int unidades)
        {
            this._tamañoMina = unidades;
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            foreach (char c in texto)
            {
                if (c > 32 && c != 255)
                {
                    this._tamañoMina -= 0.1F;
                }
            }
            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }
        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo:  " + this.GetType().Name);
            sb.AppendLine("Color: " + ((IAcciones)this).Color);
            sb.AppendLine("Nivel de tinta: " + ((IAcciones)this).UnidadesDeEscritura);
            return sb.ToString();
        }
    }
}
