using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue
    {
        private int[] array;
        private int front;
        private int rear;
        private int size;

        public Queue(int capacity)
        {
            array = new int[capacity];
            front = 0;
            rear = -1;
            size = 0;
        }

        public void Enqueue(int element)
        {
            if (rear == array.Length - 1)
            {
                Console.WriteLine("Queue is full");
                return;
            }
            array[++rear] = element;
            size++;
        }

        public int Dequeue()
        {
            if (rear == -1)
            {
                throw new Exception("Nothing to pop. Queue is empty");
            }
            int element = array[front++];

            size--;

            return element;
        }

        public int peek()
        {
            if (size == 0)
            {
                Console.WriteLine("Qeueue is empty");
            }
            return array[front];
        }

        public bool Contains(int element)
        {
            for (int i = front; i <= rear; i++)
            {
                if (element == array[i])
                {
                    return true;
                }
            }
            return false;
        }

        public int Size()
        {
            return size;
        }

        public int Center()
        {
            if (size == 0)
            {
                Console.WriteLine("Queue is empty");
            }
            int idx = front + (size - 1) / 2;
            return array[idx];
        }
        public void Reverse()
        {
            int start = front, end = rear;
            while (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;

                start++;
                end--;
            }
        }

        public void Print()
        {
            for (int item = front; item <= rear; item++)
            {
                Console.Write(array[item] + " ");
            }
            Console.WriteLine();
        }

        // iterator
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = front; i <= rear; i++)
            {
                yield return array[i];
            }
        }


        // sort using merge sort
        public void Sort()
        {
            int[] sorted = MergeSort(array, front, rear);
            sorted.CopyTo(array, front);
        }

        private int[] MergeSort(int[] arr, int start, int end)
        {
            if (start == end)
            {
                return new int[] { arr[start] };
            }

            int mid = start + (end - start) / 2;

            int[] left = MergeSort(arr, start, mid);
            int[] right = MergeSort(arr, mid + 1, end);

            return Merge(left, right);
        }

        private int[] Merge(int[] first, int[] second)
        {
            int[] result = new int[first.Length + second.Length];

            int i = 0, j = 0, k = 0;

            while (i < first.Length && j < second.Length)
            {
                if (first[i] < second[j])
                {
                    result[k++] = first[i++];
                }
                else
                {
                    result[k++] = second[j++];
                }
            }

            while (i < first.Length)
            {
                result[k++] = first[i++];
            }
            while (j < second.Length)
            {
                result[k++] = second[j++];
            }

            return result;
        }
    }
}
