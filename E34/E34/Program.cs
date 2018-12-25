using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E34
{

    class Program
    {
        static void Main(string[] args)
        {
            VehiculoTerrestre v1 = new Auto(4, 4, VehiculoTerrestre.Colores.Negro, 6, 4);
            VehiculoTerrestre v2 = new Moto(2, 0, VehiculoTerrestre.Colores.Rojo, 6, 125);
            VehiculoTerrestre v3 = new Camion(4, 4, VehiculoTerrestre.Colores.Gris, 6, 2500);

            Console.WriteLine(((Auto)v1).cantidadPasajeros);
            Console.WriteLine(((Moto)v2).cilindrada);
            Console.WriteLine(((Camion)v3).pesoCarga);
        }
    }


}
