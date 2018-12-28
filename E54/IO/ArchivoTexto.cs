using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace IO
{
    public static class ArchivoTexto
    {
        public static bool Guardar(string ruta, string datos)
        {
            bool existingFile = File.Exists(ruta); // archivo existe == true,  append : create
            try
            {
                using (StreamWriter file = new StreamWriter(ruta, existingFile))
                {
                    file.WriteLine(datos);
                }
                return true;       
            }
            catch (Exception e)
            {
                return false;
            }       
        }
        public static string Leer(string ruta)
        {
            string datos;
            try
            {
                using (StreamReader file = new StreamReader(ruta))
                {
                    datos = file.ReadToEnd();
                }
                return datos;
            }
            catch (Exception e)
            {
                throw new FileNotFoundException();
            }
        }
    }
}
