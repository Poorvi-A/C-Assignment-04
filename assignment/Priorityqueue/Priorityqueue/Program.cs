using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priorityqueue
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue queue = new PriorityQueue();
            queue.Enqueue(2);
            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(1);
            queue.Enqueue(8);

            Console.WriteLine("\nElements inside queue are: ");
            queue.Print();

            Console.WriteLine("\nPeek element is: " + queue.Peek());

            // print using iterator
            Console.WriteLine("\nPrint using iterator: ");
            foreach (int element in queue)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nContains: " + queue.Contains(10));

            Console.WriteLine("\nElement removed: " + queue.Dequeue());
            queue.Print();

            Console.WriteLine("\nCenter element is: " + queue.Center());

            Console.WriteLine("\nReverse : ");
            queue.Reverse();
            queue.Print();

            Console.ReadLine();
        }
    }
}
