using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace E31
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente(1, "Juan");
            Cliente c2 = new Cliente(2, "Martin");
            Cliente c3 = new Cliente(3, "Omar");
            Cliente c4 = new Cliente(4, "David");

            Negocio n1 = new Negocio("SARASA SA");
            PuestoAtencion p1 = new PuestoAtencion(PuestoAtencion.Puesto.CAJA_1);

            Console.WriteLine(((n1 + c1) ? "cliente agregado" : "cliente no agregado"));
            Console.WriteLine(((n1 + c2) ? "cliente agregado" : "cliente no agregado"));
            Console.WriteLine(((n1 + c3) ? "cliente agregado" : "cliente no agregado"));
            Console.WriteLine(((n1 + c4) ? "cliente agregado" : "cliente no agregado"));

            Console.WriteLine(((~n1) ? string.Format("cliente {0} atendido, puesto atencion {1}", n1.Cliente.Nombre, PuestoAtencion.NumeroActual) : string.Format("cliente {0} no atendido", n1.Cliente.Nombre)));
            Console.WriteLine(((~n1) ? string.Format("cliente {0} atendido, puesto atencion {1}", n1.Cliente.Nombre, PuestoAtencion.NumeroActual) : string.Format("cliente {0} no atendido", n1.Cliente.Nombre)));
            Console.WriteLine(((~n1) ? string.Format("cliente {0} atendido, puesto atencion {1}", n1.Cliente.Nombre, PuestoAtencion.NumeroActual) : string.Format("cliente {0} no atendido", n1.Cliente.Nombre)));
            Console.WriteLine(((~n1) ? string.Format("cliente {0} atendido, puesto atencion {1}", n1.Cliente.Nombre, PuestoAtencion.NumeroActual) : string.Format("cliente {0} no atendido", n1.Cliente.Nombre)));



        }
    }
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int Numero
        {
            get { return this.numero; }
        }
        public Cliente(int numero)
        {
            this.numero = numero;
        }
        public Cliente(int numero, string nombre)
            : this(numero)
        {
            this.nombre = nombre;
        }
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return (c1.numero == c2.numero);
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                if (clientes.Count > 0)
                    return clientes.Dequeue();
                return null;
            }
            set
            {
                if (this != value)
                    this.clientes.Enqueue(value);
            }
        }

        private Negocio()
        {
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.CAJA_1);
            this.clientes = new Queue<Cliente>();
        }
        public  Negocio(string nombre)
            : this()
        {
            this.nombre = nombre;
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;
            if (n.clientes.Count == 0)
            {
                n.Cliente = c;
                retorno = true;
            }
            if (n != c)
            {
                n.Cliente = c;
                retorno = true;
            }
            return retorno;
        }
        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.clientes.First());
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach(Cliente aux in n.clientes)
            {
                if (aux == c)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
    }
    public class PuestoAtencion
    {
        public enum Puesto { CAJA_1, CAJA_2 };

        private static int numeroActual;
        private Puesto puesto;
        
        public static int NumeroActual
        {
            get
            {
                    PuestoAtencion.numeroActual++;
                    return PuestoAtencion.numeroActual;
            }
        } 
        private PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public bool Atender(Cliente c)
        {
            Cliente aux = c;
            Thread.Sleep(new Random().Next(500, 1000));
            return true;
        }
    }
}
