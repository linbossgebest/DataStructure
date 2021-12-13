using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEndQueue
{
    /// <summary>
    /// 双端队列
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Deque<T>
    {
        LinkedList<T> linkedList;

        public Deque()
        {
            linkedList = new LinkedList<T>();
        }

        public void AddFront(T t)
        {
            linkedList.AddFirst(t);
        }

        public void AddRear(T t)
        {
            linkedList.AddLast(t);
        }

        public T RemoveFront()
        {
            var front = linkedList.First();
            linkedList.Remove(front);
            return front;
        }

        public T RemoveRear()
        {
            var rear = linkedList.Last();
            linkedList.Remove(rear);
            return rear;
        }

        public bool IsEmpty()
        {
            return linkedList.Count == 0;
        }

        public int Size()
        {
            return linkedList.Count;
        }
    }
}
