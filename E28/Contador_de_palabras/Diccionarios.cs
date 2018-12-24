using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_palabras
{
    public class Diccionarios
    {
        public static Dictionary<string, int> ContadorDePalabras(string texto)
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            string palabra = null;
            int replicas;

            foreach (char c in texto)
            {
                if (!(c == ' ' || c == '.' || c == ','))
                {
                    palabra += c;
                    continue;
                }

                if (palabra != null)
                {
                    if (!diccionario.ContainsKey(palabra))
                    {
                        diccionario.Add(palabra, 1);
                        palabra = null;
                    }
                    else
                    {
                        replicas = diccionario[palabra];
                        diccionario.Remove(palabra);
                        diccionario.Add(palabra, replicas + 1);
                        palabra = null;
                    }
                }
            }
            if (palabra != null)
            {
                if (!diccionario.ContainsKey(palabra))
                    diccionario.Add(palabra, 1);
                else
                {
                    replicas = diccionario[palabra];
                    diccionario.Remove(palabra);
                    diccionario.Add(palabra, replicas + 1);
                }
            }
            return diccionario;
        }
        public static Dictionary<string, int> OrdenarDiccionario(Dictionary<string, int> dictionary)
        {
            Dictionary<string, int> tempDictionary = new Dictionary<string, int>();
            KeyValuePair<string, int> tmp;

            while (dictionary.Count > 0)
            {
                tmp = dictionary.First();
                foreach (KeyValuePair<string, int> pair in dictionary)
                {
                    if (pair.Value > tmp.Value)
                        tmp = pair;
                }
                dictionary.Remove(tmp.Key);
                tempDictionary.Add(tmp.Key, tmp.Value);
            }
            return tempDictionary;
        }
        public static string ShowDictionary(Dictionary<string, int> dictionary)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;


            foreach (KeyValuePair<string, int> entry in dictionary)
            {
                sb.AppendFormat("Posicion {0,2}: Replicas: {1,2} - Palabra: {2}\n", i, entry.Value, entry.Key);
                i++;
            }
            return sb.ToString();
        }
    }
}
