using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(10);
            queue.Enqueue(10);
            queue.Enqueue(12);
            queue.Enqueue(16);
            queue.Enqueue(18);
            queue.Enqueue(20);
            queue.Enqueue(4);

            Console.WriteLine("Elements in queue are: ");
            queue.Print();

            // dequeue an element
            var delElement = queue.Dequeue();
            Console.WriteLine("\nelement removed: " + delElement);

            Console.WriteLine("\nCenter element of queue is: " + queue.Center());

            Console.WriteLine("\nReversed queue is: ");
            queue.Reverse();
            queue.Print();

            Console.WriteLine("\nsize of queue is: " + queue.Size());

            // Print using iterator
            Console.WriteLine("\nprint using iterator: ");
            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // sort the queue
            Console.WriteLine("\nSorted queue is: ");
            queue.Sort();
            queue.Print();

            Console.ReadLine();
        }
    }
}
