using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalasTemperatura
{
    public class Fahrenheit
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
            get { return Fahrenheit.equivalenciaRespectoKelvin; }
            //
        }

        // Constructores
        private Fahrenheit()
        {
            Fahrenheit.equivalenciaRespectoKelvin = (float)255.9278;
        }
        public Fahrenheit(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Fahrenheit(double cantidad, float equivalenciaRespectoKelvin)
        {
            this.cantidad = cantidad;
            Fahrenheit.equivalenciaRespectoKelvin = equivalenciaRespectoKelvin;
        }
    }
}
