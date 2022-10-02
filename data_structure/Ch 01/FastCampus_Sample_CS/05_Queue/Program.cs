using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _05_Queue
{
    internal class Program
    {
        static int[] m_queue = new int[5];
        static int front = -1;
        static int rear = -1;

        static void Main(string[] args)
        {
            Enqueue(10);
            Enqueue(20);
            Enqueue(30);
            Enqueue(40);
            Enqueue(50);

            Dequeue();
            Dequeue();
            Dequeue();

            Enqueue(60);
            Enqueue(70);

            Dequeue();
            Dequeue();
            Dequeue();

            for (int i = 0; i < m_queue.Length; i++)
            {
                Console.WriteLine("Index" + i + " - " + m_queue[i]);
            }
        }

        private static void Dequeue()
        {
            if (front == -1)
                return;

            int value = m_queue[front % m_queue.Length];

            Console.WriteLine("Dequeue - " + value);

            m_queue[front % m_queue.Length] = 0;

            front++;

            if (front > rear)
            {
                front = -1;
                rear = -1;
            }
        }

        private static void Enqueue(int value)
        {
            rear++;

            if (rear - front > m_queue.Length - 1)
            {
                rear--; 
            }

            m_queue[rear % m_queue.Length] = value;

            if (front == -1)
                front = 0;
        }
    }
}
