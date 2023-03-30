using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priorityqueue
{
    class PriorityQueue
    {
        private ArrayList array;

        public PriorityQueue()
        {
            array = new ArrayList();
        }

        public void Enqueue(int element)
        {
            int idx = 0;

            foreach (int item in array)
            {
                if (element < item)
                {
                    break;
                }
                idx++;
            }
            array.Insert(idx, element);
        }

        public int Dequeue()
        {
            if (array.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            int element = (int)array[0];
            array.RemoveAt(0);

            return element;
        }

        public int Peek()
        {
            if (array.Count == 0)
            {
                throw new InvalidOperationException("queue is empty");
            }

            return (int)array[0];
        }

        public bool Contains(int value)
        {
            for (int i = 0; i < array.Count; i++)
            {
                if (value == (int)array[i])
                {
                    return true;
                }
            }
            return false;
        }

        public int Size()
        {
            return array.Count;
        }

        public int Center()
        {
            if (array.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            int mid = array.Count / 2;
            return (int)array[mid];

        }

        public void Reverse()
        {
            int left = 0;
            int right = array.Count - 1;

            while (left < right)
            {
                int temp = (int)array[left];
                array[left] = array[right];
                array[right] = temp;

                left++;
                right--;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < array.Count; i++)
            {
                yield return (int)array[i];
            }
        }

        public void Print()
        {
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
