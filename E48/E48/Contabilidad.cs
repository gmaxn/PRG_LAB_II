using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E48
{
    public class Contabilidad<T, U>
        where T : Documento
        where U : Documento, new()
    {
        private List<T> _egresos;
        private List<U> _ingresos;

        public Contabilidad()
        {
            this._egresos = new List<T>();
            this._ingresos = new List<U>();
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, T egreso)
        {
            if (!(c._egresos.Contains(egreso)))
            {
                c._egresos.Add(egreso);
            }
            return c;
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            if (!(c._ingresos.Contains(ingreso)))
            {
                c._ingresos.Add(ingreso);
            }
            return c;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("LISTA DE EGRESOS: ");
            foreach (Documento d in this._egresos)
            {
                if (d is Factura)
                    sb.AppendLine("Factura NRO - " + d.Numero);
            }
            sb.AppendLine("LISTA DE INGRESOS: ");
            foreach (Documento d in this._ingresos)
            {
                if (d is Recibo)
                    sb.AppendLine("Recibo NRO - " + d.Numero);
            }

            return sb.ToString();
        }
        
    }
}
