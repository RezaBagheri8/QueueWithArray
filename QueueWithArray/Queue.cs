using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueWithArray
{
    public class Queue
    {
        public int size;
        public int[] queue;
        public int front;
        public int rear;
        public Queue(int sizeOfQueue)
        {
            size = sizeOfQueue;
            queue = new int[sizeOfQueue];
            front = -1;
            rear = -1;
        }

        public void Enqueue(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("The queue is full!");
            }
            else
            {
                rear++;
                queue[rear] = item;
            }
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty!");
            }
            else
            {
                front++;
                int result = queue[front];
                Console.WriteLine(result);

                int j = 0;
                for (int i = front+1; i <= rear; i++)
                {
                    queue[j] = queue[i];
                    j++;
                }

                rear--;
                front = -1;
            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty!");
            }
            else
            {
                for (int i = front + 1; i <= rear; i++)
                {
                    Console.WriteLine(queue[i]);
                }
            }
        }

        public bool IsFull()
        {
            if (queue.Length == (rear + 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsEmpty()
        {
            if (rear == -1 || front == rear)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
