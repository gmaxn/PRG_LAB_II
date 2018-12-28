using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E54
{
    class ClaseQueIntentaDividirPorCero
    {
        // 3.
        public ClaseQueIntentaDividirPorCero(int a)
        {
            try
            {
                new ClaseQueIntentaDividirPorCero();
            }
            catch (DivideByZeroException e)
            {
                // Atrapo la excepcion producida en la instanciacion,
                // la gaurdo en una segunda excepcion y la relanzo.
                MySecondException ex = new MySecondException("MySecondException", e);
                throw ex;
            }
        }
        // 4.
        public ClaseQueIntentaDividirPorCero()
        {
            try
            {
                ClaseQueIntentaDividirPorCero.MetodoEstatico();
            }
            catch (DivideByZeroException e)
            {
                // Atrapo la excepcion producida en el metodo
                // estatico y la relanzo.
                throw e;
            }
        }
        // 5.
        public static void MetodoEstatico()
        {
            try
            {
                int aux = 0;
                int res = 10 / aux;
            }
            catch (DivideByZeroException e)
            {
                // Atrapo la excepcion producida
                // y la relanzo.
                throw e;
            }
        }
    }
}
