using System;
using System.Collections.Generic;
using System.Linq;

class PriorityQueue<T> where T : IEquatable<T>
{
    private class PriorityNode
    {
        public int Priority { get; private set; }
        public T Data { get; private set; }

        public PriorityNode(int priority, T data)
        {
            Priority = priority;
            Data = data;
        }
    }

    private List<PriorityNode> elements = new List<PriorityNode>();

    public PriorityQueue() { }

    public PriorityQueue(IDictionary<int, IList<T>> elements)
    {
        foreach (var kvp in elements)
        {
            int priority = kvp.Key;
            IList<T> data = kvp.Value;

            foreach (T item in data)
            {
                Enqueue(priority, item);
            }
        }
    }

    public int Count
    {
        get { return elements.Count; }
    }

    public bool Contains(T item)
    {
        foreach( var ele in elements)
        {
            if (ele.Data.Equals(item))
            {
                return true;
            }
        }
        return false;
    }

    public T Dequeue()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Priority - Queue is empty");
        }

        int highPriorityIndex = GetHighestPriorityIndex();
        T data = elements[highPriorityIndex].Data;
        elements.RemoveAt(highPriorityIndex);
        return data;
    }

    public void Enqueue(int priority, T item)
    {
        PriorityNode node = new PriorityNode(priority, item);

        int index = 0;

        while( index < elements.Count && elements[index].Priority > priority)
        {
            index++;
        }
        elements.Insert(index, node);
    }

    public T Peek()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return elements[GetHighestPriorityIndex()].Data;

    }

    private int GetHighestPriorityIndex()
    {
        int highPriorityIndex = 0;
       for(int i = 0; i < elements.Count; i++)
        {
            if( elements[i].Priority > elements[highPriorityIndex].Priority )
            {
                highPriorityIndex = i;
            }
        }

        return highPriorityIndex;
    }
}
