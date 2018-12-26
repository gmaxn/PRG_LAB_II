using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E36
{
    public class VehiculoDeCarrera
    {
        private short _numero;
        private string _escuderia;
        private bool _enCompetencia;
        private short _cantidadCombustible;
        private short _vueltasRestantes;

        public short Numero
        {
            get { return this._numero; }
            set { this._numero = value; }
        }
        public string Escuderia
        {
            get { return this._escuderia; }
            set { this._escuderia = value; }
        }
        public bool EnCompetencia
        {
            get { return this._enCompetencia; }
            set { this._enCompetencia = value; }
        }
        public short Combustible
        {
            get { return this._cantidadCombustible; }
            set { this._cantidadCombustible = value; }
        }
        public short Vueltas
        {
            get { return this._vueltasRestantes; }
            set { this._vueltasRestantes = value; }
        }

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this._numero = numero;
            this._escuderia = escuderia;
            this._enCompetencia = false;
            this._cantidadCombustible = 0;
            this._vueltasRestantes = 0;
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos Vehiculo Nº: " + this._numero);
            sb.AppendLine("Escuderia: " + this._escuderia);
            sb.AppendFormat("Inscripto: {0}\n", this._enCompetencia ? "SI" : "NO");
            sb.AppendLine("Cantidad de Combustible: " + this._cantidadCombustible);
            sb.AppendLine("Vueltas Restantes: " + this._vueltasRestantes);
            return sb.ToString();
        }
    }
}
