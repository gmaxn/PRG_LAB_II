using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace E27
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = Sets.GetRandomStack(20, -100, 100);
            Queue<int> queue = Sets.GetRandomQueue(20, -100, 100);
            //List<int> list = Sets.GetRandomList(20, -100, 100);


            Console.WriteLine("STACK DESORDENADO");
            Console.WriteLine(Sets.ShowStackSet(stack));
            Console.WriteLine("----------------------");
            stack = Sets.SortStackPosCrecienteNegDecreciente(stack);
            Console.WriteLine("STACK ORDENADO");
            Console.WriteLine(Sets.ShowStackSet(stack));
            Console.WriteLine("----------------------");
            Console.ReadKey();
            Console.Clear();
            ////////////////////////////////////////////
            Console.WriteLine("QUEUE DESORDENADO");
            Console.WriteLine(Sets.ShowQueueSet(queue));
            Console.WriteLine("----------------------");
            queue = Sets.SortQueuePosCrecienteNegDecreciente(queue);
            Console.WriteLine("QUEUE ORDENADO");
            Console.WriteLine(Sets.ShowQueueSet(queue));
            Console.WriteLine("----------------------");
            Console.ReadKey();
            Console.Clear();
            ////////////////////////////////////////////  
            //Console.WriteLine("LIST DESORDENADO");
            //Console.WriteLine(Sets.ShowListSet(list));
            //Console.WriteLine("----------------------");
            //list = Sets.SortListPosCrecienteNegDecreciente(list);
            //Console.WriteLine("LIST ORDENADO");
            //Console.WriteLine(Sets.ShowListSet(list));
            //Console.WriteLine("----------------------");
            //Console.ReadKey();
            //Console.Clear();
            ////////////////////////////////////////////               
        }
    }

    public class Sets
    {
        public static Stack<int> GetRandomStack(int size, int minValue, int maxValue)
        {
            Stack<int> arr = new Stack<int>();
            Random r = new Random();
            for(int i=0; i<size; i++)
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

            foreach(int n in set)
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
        public static string ShowStackSet(Stack<int> set)
        {
            int i = 0;
            StringBuilder sb = new StringBuilder();
            foreach (int n in set)
            {
                sb.AppendFormat("Posicion {0}: {1}", i, n);
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

            while (set.Count() > 0)
            {
                // pop out the first element 
                int tmp = set.Dequeue();
                //set.Pop();

                // while temporary stack is not empty and top 
                // of stack is greater than temp 
                while (tmpQueue.Count() > 0 && tmpQueue.Peek() > tmp)
                {
                    // pop from temporary stack and push 
                    // it to the input stack 
                    set.Enqueue(tmpQueue.Dequeue());
                    //tmpStack.Pop();
                }
                // push temp in tempory of stack 
                tmpQueue.Enqueue(tmp);
            }
            return tmpQueue;
        }
        public static Queue<int> SortQueueCreciente(Queue<int> set)
        {
            Queue<int> tmpQueue = new Queue<int>();

            while (set.Count() > 0)
            {
                // pop out the first element 
                int tmp = set.Dequeue();
                //set.Dequeue();

                // while temporary stack is not empty and top 
                // of stack is greater than temp 
                while (tmpQueue.Count() > 0 && tmpQueue.Peek() < tmp)
                {
                    // pop from temporary stack and push 
                    // it to the input stack 
                    set.Enqueue(tmpQueue.Dequeue());
                    //tmpQueue.Dequeue();
                }
                // push temp in tempory of stack 
                tmpQueue.Enqueue(tmp);
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
            Console.WriteLine("*******");
            Console.WriteLine(Sets.ShowQueueSet(pos));
            Console.WriteLine("*******");
            Console.WriteLine(Sets.ShowQueueSet(neg));
            
            pos = SortQueueCreciente(pos);
            neg = SortQueueDecreciente(neg);

            foreach (int n in pos)
                sorted.Enqueue(n);

            foreach (int n in neg)
                sorted.Enqueue(n);



            return sorted;
        }
        public static string ShowQueueSet(Queue<int> set)
        {
            int i = 0;
            StringBuilder sb = new StringBuilder();
            foreach (int n in set)
            {
                sb.AppendFormat("Posicion {0}: {1}", i, n);
                sb.AppendLine();
                i++;
            }
            return sb.ToString();
        }
    }
}
