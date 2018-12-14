using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafos
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private void SetTinta(short tinta)
        {
            if (tinta >= 0 && tinta <= 100)
                if ((this.tinta + tinta) <= 100)
                    this.tinta += tinta;
        }

        public Boligrafo()
        {
            this.tinta = cantidadTintaMaxima;
            this.color = ConsoleColor.Blue;
        }
        public Boligrafo(short nivelTinta, ConsoleColor colorTinta)
        {
            this.tinta = nivelTinta;
            this.color = colorTinta;
        }
        public bool Pintar(int gasto, out string dibujo)
        {
            dibujo = "";

            if (gasto <= this.tinta)
            {
                SetTinta((short)(this.tinta - gasto));

                for (int i = 0; i < gasto; i++)
                    dibujo += "*";

                return true;
            }
            return false;
        }
        public void Recargar()
        {
            SetTinta((short)((this.tinta - cantidadTintaMaxima) * -1));
        }
    }
}
