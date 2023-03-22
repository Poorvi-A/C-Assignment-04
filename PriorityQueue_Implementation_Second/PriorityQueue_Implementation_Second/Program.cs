using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue_Implementation_Second
{
    partial class Program
    {
        static void Main(string[] args)
        {

            PriorityQueue<Task> pq = new PriorityQueue<Task>();

            pq.Enqueue(new Task("Task 1", 2));
            pq.Enqueue(new Task("Task 2", 1));
            pq.Enqueue(new Task("Task 3", 3));
            pq.Enqueue(new Task("Task 4", 2));

            Console.WriteLine("Count: " + pq.Count);
            Console.WriteLine("Peek: " + pq.Peek().Name);
            Console.WriteLine(pq.Contains(new Task("Task 1",2) ) );

            while (pq.Count > 0)
            {
                Task task = pq.Dequeue();
                Console.WriteLine(task.Name + " (Priority - " + task.Priority + ")");
            }

            Console.ReadLine();
        }
    }
}
