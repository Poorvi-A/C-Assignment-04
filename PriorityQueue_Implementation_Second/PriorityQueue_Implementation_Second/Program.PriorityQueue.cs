using System;
using System.Collections.Generic;
using System.Linq;

public interface IPriority
{
    int Priority { get; }

}

public class PriorityQueue<T> where T : IEquatable<T>, IPriority
{
    private IDictionary<int, IList<T>> elements;

    public PriorityQueue()
    {
        elements = new Dictionary<int, IList<T>>();
    }

    public PriorityQueue(IEnumerable<T> elements) : this()
    {
        foreach (T item in elements)
        {
            Enqueue(item);
        }
    }

    public int Count
    {
        get
        {
            return elements.Values.Sum(List => List.Count);
        }
    }

    public bool Contains(T item)
    {
        foreach(var list in elements.Values)
        {
            if( list.Contains(item) )
            {
                return true;
            }
        }
        return false;
    }

    public T Dequeue()
    {
        int priority = GetHighestPriority();

        IList<T> list = elements[priority];
        T item = list[0];
        list.RemoveAt(0);

        if (list.Count == 0)
        {
            elements.Remove(priority);
        }
        return item;
    }

    public void Enqueue(T item)
    {
        int priority = item.Priority;
        if( !elements.ContainsKey(priority))
        {
            elements.Add(priority, new List<T>());
        }
        elements[priority].Add(item);
    }

    public T Peek()
    {
        int priority = GetHighestPriority();
        IList<T> list = elements[priority];
        return list[0];
    }

    private int GetHighestPriority()
    {
        int maxPriority = int.MinValue;
        foreach (int priority in elements.Keys)
        {
            if (priority > maxPriority)
            {
                maxPriority = priority;
            }
        }
        return maxPriority;

    }
}