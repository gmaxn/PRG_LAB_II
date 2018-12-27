using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E53
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor _colorTinta;
        private float _tinta;

        public ConsoleColor Color
        {
            get{ return this._colorTinta; }
            set{ this._colorTinta = value; }
        }
        public float UnidadesDeEscritura
        {
            get{ return this._tinta; }
            set{ this._tinta = value; }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this._colorTinta = color;
            this._tinta = unidades;
        }

        public bool Recargar(int unidades)
        {
            this._tinta += unidades;
            return true;
        }
        public EscrituraWrapper Escribir(string texto)
        {
            foreach (char c in texto)
            {
                if (c > 32 && c != 255)
                {
                    this._tinta -= 0.3F;
                }
            }
            return new EscrituraWrapper(texto, this.Color);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo:  " + this.GetType().Name);
            sb.AppendLine("Color: " + this.Color);
            sb.AppendLine("Nivel de tinta: " + this.UnidadesDeEscritura);
            return sb.ToString();
        }
    }
}
