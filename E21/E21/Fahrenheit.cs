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
            Fahrenheit.equivalenteEnKelvin = (float)(274.15);
        }
        public Fahrenheit(double cantidad)
        {
            this.cantidad = cantidad;
        }

        // Sobrecarga de Operadores
        public static bool operator ==(Fahrenheit fa, Fahrenheit fb)
        {
            return ((float)(double)fa == (float)(double)fb);
            //
        }
        public static bool operator !=(Fahrenheit fa, Fahrenheit fb)
        {
            return !(fa == fb);
            //
        }

        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit((double)f + (double)((Fahrenheit)k));
        }
        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit((double)f - (double)((Fahrenheit)k));
        }
        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return ((float)(double)f == (float)(double)((Fahrenheit)k));
        }
        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
            //
        }

        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit((double)f + (double)((Fahrenheit)c));
        }
        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit((double)f - (double)((Fahrenheit)c));
        }
        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return ((float)(double)f == (float)(double)((Fahrenheit)c));
        }
        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == c);
            //
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // Conversiones Explicitas / Implicitas
        public static implicit operator double(Fahrenheit f)
        {
            return f.cantidad;
        }
        public static implicit operator Fahrenheit(double d)
        {
            return new Fahrenheit(d);
            //
        }
        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((((double)f - 32) * 5/9));
        }
        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((((double)f - 32) * 5/9) + 273.15);
        }
    }
}
