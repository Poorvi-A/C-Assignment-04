using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue_Implementation_3
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var pq = new PriorityQueue<string>();
            pq.Enqueue(1, "Task 1");
            pq.Enqueue(3, "Task 2");
            pq.Enqueue(2, "Task 3");

            Console.WriteLine("count:" + pq.Count );
            Console.WriteLine("Peek:" + pq.Peek() );

            Console.WriteLine("Dequeueing tasks:");

            while (pq.Count > 0)
            {
                string task = pq.Dequeue();
                Console.WriteLine(task);
            }

            Console.ReadLine();
        }
    }
}
