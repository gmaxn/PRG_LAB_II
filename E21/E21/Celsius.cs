using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalasTemperatura
{
    public class Celsius
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
        public static float GetEquivalenciaKelvin
        {
            get { return Celsius.equivalenciaRespectoKelvin; }
            //
        }

        // Constructores
        private Celsius()
        {
            Celsius.equivalenciaRespectoKelvin = (float)274.15;
        }
        public Celsius(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Celsius(double cantidad, float equivalenciaRespectoKelvin)
        {
            this.cantidad = cantidad;
            Celsius.equivalenciaRespectoKelvin = equivalenciaRespectoKelvin;
        }

        // Sobrecarga de Operadores
        public static bool operator ==(Celsius ca, Celsius cb)
        {
            return (ca.GetCantidad == cb.GetCantidad);
            //
        }
        public static bool operator !=(Celsius ca, Celsius cb)
        {
            return !(ca == cb);
            //
        }

        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.cantidad + ((f.GetCantidad - 32) * 5 / 9));
            //
        }
        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.cantidad - ((f.GetCantidad - 32) * 5 / 9));
            //
        }
        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return (c.GetCantidad  == ((f.GetCantidad - 32) * 5 / 9));
            //
        }
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
            //
        }


        public static Celsius operator +(Celsius c, Kelvin k)
        {
            double cant = c.cantidad + (k.GetCantidad * Kelvin.GetEquivalencia);
            return new Celsius(cant);
            //
        }
        public static Celsius operator -(Celsius c, Kelvin k)
        {
            double aux = c.GetCantidad * Celsius.GetEquivalenciaKelvin - k.GetCantidad * Kelvin.GetEquivalencia;
            return new Celsius((float)(aux / Celsius.GetEquivalenciaKelvin));
            //
        }
        public static bool operator ==(Celsius c, Kelvin k)
        {
            return (float)(c.GetCantidad * Celsius.GetEquivalenciaKelvin) == (float)(k.GetCantidad * Kelvin.GetEquivalencia);
            //
        }
        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
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
        public static implicit operator double(Celsius c)
        {
            return c.cantidad;
        }
        public static implicit operator Celsius(double d)
        {
            throw new NotImplementedException();
            //
        }
        public static explicit operator Kelvin(Celsius d)
        {
            throw new NotImplementedException();
            //
        }
        public static explicit operator Fahrenheit(Celsius d)
        {
            throw new NotImplementedException();
            //
        }
    }
}
