using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MyQueue
    {
        private Queue<int> m_Queue;
        private readonly int kk;
        /** Initialize your data structure here. */
        public MyQueue()
        {          
            m_Queue = new Queue<int>();
        }
        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            m_Queue.Enqueue(x);
        }
        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            int pop = m_Queue.Dequeue();
            return pop;
        }
        /** Get the front element. */
        public int Peek()
        {
            int peek = m_Queue.Peek();
            return peek;
        }
        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return m_Queue.Count == 0;
        }
        public static int downToZero()
        {
            int n = 21;

            if (n <= 3)
            {
                return n;
            }
            int count = 0;
            Queue<int> m_Queue = new Queue<int>();
            m_Queue.Enqueue(n);

            while (m_Queue.Count > 0)
            {
                bool found = false;

                int item = m_Queue.Peek();
                if (item == 0)
                {
                    break;
                }
                m_Queue.Dequeue();

                int kalan = item % 2;
                int result = item / 2;
                if (kalan == 0)
                {
                    m_Queue.Enqueue(result);
                    count++;
                    continue;
                }
                else
                {
                    for (int i = 2; i < result; i++)
                    {
                        if (item % i == 0)
                        {
                            int sonuc = item / i;
                            m_Queue.Enqueue(sonuc);
                            count++;
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        m_Queue.Enqueue(item - 1);
                        count++;
                    }
                }
            }
            return count;
        }
        // Complete the solve function below.
        static int[] solve()
        {
            int[] arr = new int[] { 33, 11, 44, 11, 55 };
            int[] queries = new int[] { 1, 2, 3, 4, 5 };




            return new int[] { 1 };
        }
    }
}
