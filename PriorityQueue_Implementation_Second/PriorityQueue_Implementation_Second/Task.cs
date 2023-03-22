using System;

namespace PriorityQueue_Implementation_Second
{
    class Task : IEquatable<Task>, IPriority
    {
        public string Name { get; set; }
        public int Priority { get; set; }

        public Task(string name, int priority)
        {
            Name = name;
            Priority = priority;
        }

        public bool Equals(Task other)
        {
            return Name.Equals(other.Name) && Priority == other.Priority;
        }
    }
}
