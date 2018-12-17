﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        // Atributos
        private double cantidad;
        private static float cotizRespectoDolar;

        // Getters - Setters - Indexers
        public double GetCantidad
        {
            get { return this.cantidad; }
            //
        }
        public static float GetCotizacion
        {
            get { return Dolar.cotizRespectoDolar; }
            //
        }

        // Constructores
        private Dolar()
        {
            Dolar.cotizRespectoDolar = (float)(1);
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            Dolar.cotizRespectoDolar = cotizacion;
        }

        // Sobrecarga de Operadores
        public static bool operator ==(Dolar da, Dolar db)
        {
            return (da.GetCantidad == db.GetCantidad);
            //
        }
        public static bool operator !=(Dolar da, Dolar db)
        {
            return !(da == db);
            //
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            double aux = d.GetCantidad * Dolar.GetCotizacion + e.GetCantidad * Euro.GetCotizacion;
            return new Dolar((float)(aux / Dolar.GetCotizacion));
            //
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            double aux = d.GetCantidad * Dolar.GetCotizacion - e.GetCantidad * Euro.GetCotizacion;
            return new Dolar((float)(aux / Dolar.GetCotizacion));
            //
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            return (float)(d.GetCantidad * Dolar.GetCotizacion) == (float)(e.GetCantidad * Euro.GetCotizacion);
            //
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
            //
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            double aux = d.GetCantidad * Dolar.GetCotizacion + p.GetCantidad * Peso.GetCotizacion;
            return new Dolar((float)(aux / Dolar.GetCotizacion));
            //
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            double aux = d.GetCantidad * Dolar.GetCotizacion - p.GetCantidad * Peso.GetCotizacion;
            return new Dolar((float)(aux / Dolar.GetCotizacion));   
            //
        }
        public static bool operator ==(Dolar d, Peso p)
        {
            return (float)(d.GetCantidad * Dolar.GetCotizacion) == (float)(p.GetCantidad * Peso.GetCotizacion);
            //
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
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
        public static implicit operator double(Dolar d)
        {
            return d.cantidad;
        }
        public static implicit operator Dolar(double d)
        {
            throw new NotImplementedException();
            //
        }
        public static explicit operator Euro(Dolar d)
        {
            throw new NotImplementedException();
            //
        }
        public static explicit operator Peso(Dolar d)
        {
            throw new NotImplementedException();
            //
        }
    }
    
}
