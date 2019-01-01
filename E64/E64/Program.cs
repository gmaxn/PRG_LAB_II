using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;


namespace E64
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar un negocio con 2 cajas y agregarle algunos clientes.
            Negocio negocio = new Negocio(new Caja(), new Caja());
            negocio.Clientes.AddRange(new string[] { "cliente1", "cliente2", "cliente3", "cliente4" });

            // Crear thread para asignar las cajas a los clientes.
            Thread asignarCaja = new Thread(negocio.AsignarCaja);
            asignarCaja.Start();

             
            //Join method waits for finishing other threads by calling its join method.
            asignarCaja.Join();
            
            // Crear thread para atender los clientes de la caja1.
            // y en su propiedad “Name” asignar el nombre de la caja que está atendiendo.
            Thread atenderClientesCaja1 = new Thread(negocio.Caja1.AtenderClientes);
            atenderClientesCaja1.Name = "caja1";
            atenderClientesCaja1.Start();

            // Crear thread para atender los clientes de la caja2.
            // y en su propiedad “Name” asignar el nombre de la caja que está atendiendo.
            Thread atenderClientesCaja2 = new Thread(negocio.Caja2.AtenderClientes);
            atenderClientesCaja2.Name = "caja2";
            atenderClientesCaja2.Start();

            Console.ReadKey();
        }
    }
}
