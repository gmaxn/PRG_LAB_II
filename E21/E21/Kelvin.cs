using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalasTemperatura
{
    public class Kelvin
    {
        // Atributos
        private double cantidad;
        private static float equivalenciaRespectoKelvin;

        // Getters - Setters - Indexers
        public double GetCantidad
        {
            get { return this.cantidad; }
            //
        }
        public static float GetEquivalencia
        {
            get { return Kelvin.equivalenciaRespectoKelvin; }
            //
        }

        // Constructores
        private Kelvin()
        {
            Kelvin.equivalenciaRespectoKelvin = (float)(1);
        }
        public Kelvin(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Kelvin(double cantidad, float equivalenciaRespectoKelvin)
        {
            this.cantidad = cantidad;
            Kelvin.equivalenciaRespectoKelvin = equivalenciaRespectoKelvin;
        }
    }
}
