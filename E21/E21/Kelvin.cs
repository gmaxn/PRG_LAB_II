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
        private static float equivalenteEnKelvin;

        // Getters - Setters - Indexers
        public double GetCantidad
        {
            get { return this.cantidad; }
            //
        }
        public static float GetEquivalencia
        {
            get { return Kelvin.equivalenteEnKelvin; }
            //
        }

        // Constructores
        private Kelvin()
        {
            Kelvin.equivalenteEnKelvin = (float)(1);
        }
        public Kelvin(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Kelvin(double cantidad, float equivalenteEnKelvin)
        {
            this.cantidad = cantidad;
            Kelvin.equivalenteEnKelvin = equivalenteEnKelvin;
        }
    }
}
