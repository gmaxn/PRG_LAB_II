using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E42
{
    public class Persona
    {
        public void MetodoQueGeneraError()
        {
            try
            {
                // 2. Dicho Metodo Instancia otra clase que produce un error 
                //    del tipo division por 0.
                new ClaseQueIntentaDividirPorCero(0);
            }
            catch (MySecondException e)
            {
                // Atrapo la excepcion producida en la instanciacion de la clase,
                // la gaurdo en una tercera excepcion y la relanzo.
                MyThirdException ex = new MyThirdException("MyThirdException", e);
                throw ex;
            }
        }
    }
}
