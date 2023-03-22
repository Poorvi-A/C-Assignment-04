using System;
using System.Collections.Generic;

namespace PriorityQueue_Implementation_one
{
    partial class Program
    {
        class PriorityQueue<T> where T : IEquatable<T> {

            private IDictionary<int, IList<T>> elements;

            public PriorityQueue()
            {
                elements = new Dictionary<int, IList<T>>();
            }

            public PriorityQueue(IDictionary< int, IList<T>> elements) : this()
            {
                foreach (var kvp in elements)
                {
                    Enqueue(kvp.Key, kvp.Value);
                }
            }

            public int Count
            {
                get
                {
                    return elements.Count;
                }
            }

            public bool Contains(T item)
            {
                foreach (var kvp in elements)
                {
                    if (kvp.Value.Equals(item))
                        return true;
                }
                return false;
            }

            public T Dequeue()
            {
                if (Count == 0)
                    throw new InvalidOperationException("Priority Queue is empty");

                int highestPriority = GetHighestPriority();
                T item = elements[highestPriority][0];
                elements[highestPriority].RemoveAt(0);

                if (elements[highestPriority].Count == 0)
                    elements.Remove(highestPriority);

                return item;
            }

            public void Enqueue(int priority, IList<T> item)
            {
                foreach (var items in item)
                {
                    if ( !elements.ContainsKey(priority) )
                        elements[priority] = new List<T>();

                    elements[priority].Add(items);
                }
            }

            public T Peek()
            {
                if (Count == 0)
                    throw new InvalidOperationException("PriorityQueue is empty");

                int highestPriority = GetHighestPriority();
                T item = elements[highestPriority][0];

                return item;
            }

            private int GetHighestPriority()
            {
                int highestPriority = int.MinValue;

                foreach (var kvp in elements)
                {
                    if (kvp.Key > highestPriority)
                        highestPriority = kvp.Key;
                }
                return highestPriority;
            }


        }
    }
}
