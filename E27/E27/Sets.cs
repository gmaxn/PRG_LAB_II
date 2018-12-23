using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E27
{
    public class Sets
    {
        public static Stack<int> GetRandomStack(int size, int minValue, int maxValue)
        {
            Stack<int> arr = new Stack<int>();
            Random r = new Random();
            for (int i = 0; i < size; i++)
                arr.Push(r.Next(minValue, maxValue));
            return arr;
        }
        public static Stack<int> SortStackDecreciente(Stack<int> set)
        {
            Stack<int> tmpStack = new Stack<int>();

            while (set.Count() > 0)
            {
                // pop out the first element 
                int tmp = set.Pop();
                //set.Pop();

                // while temporary stack is not empty and top 
                // of stack is greater than temp 
                while (tmpStack.Count() > 0 && tmpStack.Peek() > tmp)
                {
                    // pop from temporary stack and push 
                    // it to the input stack 
                    set.Push(tmpStack.Pop());
                    //tmpStack.Pop();
                }
                // push temp in tempory of stack 
                tmpStack.Push(tmp);
            }
            return tmpStack;
        }
        public static Stack<int> SortStackCreciente(Stack<int> set)
        {
            Stack<int> tmpStack = new Stack<int>();

            while (set.Count() > 0)
            {
                // pop out the first element 
                int tmp = set.Pop();
                //set.Pop();

                // while temporary stack is not empty and top 
                // of stack is greater than temp 
                while (tmpStack.Count() > 0 && tmpStack.Peek() < tmp)
                {
                    // pop from temporary stack and push 
                    // it to the input stack 
                    set.Push(tmpStack.Pop());
                    //tmpStack.Pop();
                }
                // push temp in tempory of stack 
                tmpStack.Push(tmp);
            }
            return tmpStack;
        }
        public static Stack<int> SortStackPosCrecienteNegDecreciente(Stack<int> set)
        {
            Stack<int> neg = new Stack<int>();
            Stack<int> pos = new Stack<int>();
            Stack<int> sorted = new Stack<int>();

            foreach (int n in set)
            {
                if (n >= 0)
                    pos.Push(n);
                else
                    neg.Push(n);
            }

            pos = SortStackCreciente(pos);
            neg = SortStackDecreciente(neg);

            foreach (int n in neg)
                sorted.Push(n);

            foreach (int n in pos)
                sorted.Push(n);

            return sorted;
        }
        public static string ShowStack(Stack<int> set)
        {
            int i = 0;
            StringBuilder sb = new StringBuilder();
            foreach (int n in set)
            {
                sb.AppendFormat("Posicion {0,2}: {1,4}", i, n);
                sb.AppendLine();
                i++;
            }
            return sb.ToString();
        }

        public static Queue<int> GetRandomQueue(int size, int minValue, int maxValue)
        {
            Queue<int> arr = new Queue<int>();
            Random r = new Random();
            for (int i = 0; i < size; i++)
                arr.Enqueue(r.Next(minValue, maxValue));
            return arr;
        }
        public static Queue<int> SortQueueDecreciente(Queue<int> set)
        {
            Queue<int> tmpQueue = new Queue<int>();
            bool flag = false;

            while (set.Count() > 0)
            {
                // Dequeue out the first element 
                int tmp = set.Dequeue();

                foreach (int n in set)
                {
                    if (n > tmp)
                        flag = true;
                }

                if (flag)
                    set.Enqueue(tmp);

                if (!flag)
                    tmpQueue.Enqueue(tmp);

                flag = false;
            }
            return tmpQueue;
        }
        public static Queue<int> SortQueueCreciente(Queue<int> set)
        {
            Queue<int> tmpQueue = new Queue<int>();
            bool flag = false;

            while (set.Count() > 0)
            {
                // pop out the first element 
                int tmp = set.Dequeue();

                foreach (int n in set)
                {
                    if (n < tmp)
                        flag = true;
                }

                if (flag)
                    set.Enqueue(tmp);

                if (!flag)
                    tmpQueue.Enqueue(tmp);

                flag = false;
            }
            return tmpQueue;
        }
        public static Queue<int> SortQueuePosCrecienteNegDecreciente(Queue<int> set)
        {
            Queue<int> neg = new Queue<int>();
            Queue<int> pos = new Queue<int>();
            Queue<int> sorted = new Queue<int>();

            foreach (int n in set)
            {
                if (n >= 0)
                    pos.Enqueue(n);
                else
                    neg.Enqueue(n);
            }

            pos = SortQueueDecreciente(pos);
            neg = SortQueueCreciente(neg);

            foreach (int n in pos)
                sorted.Enqueue(n);

            foreach (int n in neg)
                sorted.Enqueue(n);

            return sorted;
        }
        public static string ShowQueue(Queue<int> set)
        {
            int i = 0;
            StringBuilder sb = new StringBuilder();
            foreach (int n in set)
            {
                sb.AppendFormat("Posicion {0,2}: {1,4}", i, n);
                sb.AppendLine();
                i++;
            }
            return sb.ToString();
        }

        public static List<int> GetRandomList(int size, int minValue, int maxValue)
        {
            List<int> arr = new List<int>();
            Random r = new Random();
            for (int i = 0; i < size; i++)
                arr.Add(r.Next(minValue, maxValue));
            return arr;
        }
        public static List<int> SortListDecreciente(List<int> set, int desde, int hasta)
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
                Sets.SortListDecreciente(set, desde, j);

            if (i < hasta)
                Sets.SortListDecreciente(set, i, hasta);

            return set;
        }
        public static List<int> SortListCreciente(List<int> set, int desde, int hasta)
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
                Sets.SortListCreciente(set, desde, j);

            if (i < hasta)
                Sets.SortListCreciente(set, i, hasta);

            return set;
        }
        public static List<int> SortListPosCrecienteNegDecreciente(List<int> set)
        {
            List<int> neg = new List<int>();
            List<int> pos = new List<int>();
            List<int> sorted = new List<int>();

            foreach (int n in set)
            {
                if (n >= 0)
                    pos.Add(n);
                else
                    neg.Add(n);
            }

            pos = SortListDecreciente(pos, 0, pos.Count - 1);
            neg = SortListCreciente(neg, 0, neg.Count - 1);

            foreach (int n in pos)
                sorted.Add(n);

            foreach (int n in neg)
                sorted.Add(n);

            return sorted;
        }
        public static string ShowList(List<int> set)
        {
            int i = 0;
            StringBuilder sb = new StringBuilder();
            foreach (int n in set)
            {
                sb.AppendFormat("Posicion {0,2}: {1,4}", i, n);
                sb.AppendLine();
                i++;
            }
            return sb.ToString();
        }
    }
}
