using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E26
{
    public class Sets
    {
        public static int[] GetRandomSet(int size, int minValue, int maxValue)
        {
            int[] numericSet = new int[size];
            Random r = new Random();

            for (int i = 0; i < size; i++)
                numericSet[i] = r.Next(minValue, maxValue);

            return numericSet;
        }
        public static void QuickSortDecreciente(int[] set, int desde, int hasta)
        {
            int i = desde, j = hasta;
            int temp;
            int pivote = set[(desde + hasta) / 2];

            /* particion */
            while (i <= j)
            {
                while (set[i] > pivote) //---> criterio de ordenamiento
                    i++;

                while (set[j] < pivote) //---> criterio de ordenamiento
                    j--;

                if (i <= j)
                {
                    temp = set[i];
                    set[i] = set[j];
                    set[j] = temp;
                    i++;
                    j--;
                }
            }

            /* recursividad */
            if (desde < j)
                Sets.QuickSortDecreciente(set, desde, j);

            if (i < hasta)
                Sets.QuickSortDecreciente(set, i, hasta);
        }
        public static void QuickSortCreciente(int[] set, int desde, int hasta)
        {
            int i = desde, j = hasta;
            int temp;
            int pivote = set[(desde + hasta) / 2];

            /* particion */
            while (i <= j)
            {
                while (set[i] < pivote) //---> criterio de ordenamiento
                    i++;

                while (set[j] > pivote) //---> criterio de ordenamiento
                    j--;

                if (i <= j)
                {
                    temp = set[i];
                    set[i] = set[j];
                    set[j] = temp;
                    i++;
                    j--;
                }
            }
            /* recursividad */
            if (desde < j)
                Sets.QuickSortCreciente(set, desde, j);

            if (i < hasta)
                Sets.QuickSortCreciente(set, i, hasta);
        }
        public static void OrdenarSoloNegativosCreciente(int[] set)
        {
            int desde = 0;
            while (set[desde] >= 0)
                desde++;
            Sets.QuickSortCreciente(set, desde, set.Length - 1);
        }
        public static string ShowSet(int[] set)
        {
            int i = 0;
            StringBuilder sb = new StringBuilder();
            while (i < set.Length)
            {
                sb.AppendFormat("Posicion {0}: {1}", i, set[i]);
                sb.AppendLine();
                i++;
            }
            return sb.ToString();
        }
    }
}
