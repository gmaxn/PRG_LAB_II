using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E34
{
    public class VehiculoTerrestre
    {
        public enum Colores { Rojo, Blanco, Azul, Gris, Negro }

        public short cantidadRuedas;
        public short cantidadPuertas;
        public Colores color;
        public short cantidadMarchas;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
            this.cantidadMarchas = cantidadMarchas;
        }
    }
}
