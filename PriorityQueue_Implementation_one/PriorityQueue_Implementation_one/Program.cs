using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace PriorityQueue_Implementation_one
{
    partial class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<string> pq = new PriorityQueue<string>();

            pq.Enqueue(2, new List<string> { "two", "another two" });
            pq.Enqueue(1, new List<string> { "one" } );
            pq.Enqueue(3, new List<string> { "three"} );

            Console.WriteLine("Peek: " + pq.Peek());
            Console.WriteLine("Count: " + pq.Count);

            while (pq.Count > 0)
            {
                Console.WriteLine(pq.Dequeue());
            }

            Console.ReadLine();
        }
    }
}
