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
        private static float equivalenteEnKelvin;

        // Getters - Setters - Indexers
        public double GetCantidad
        {
            get { return this.cantidad; }
            //
        }
        public static float GetEquivalencia
        {
            get { return Fahrenheit.equivalenteEnKelvin; }
            //
        }

        // Constructores
        private Fahrenheit()
        {
            Fahrenheit.equivalenteEnKelvin = (float)255.9278;
        }
        public Fahrenheit(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Fahrenheit(double cantidad, float equivalenteEnKelvin)
        {
            this.cantidad = cantidad;
            Fahrenheit.equivalenteEnKelvin = equivalenteEnKelvin;
        }
    }
}
