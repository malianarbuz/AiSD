using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    internal class List
    {
        public Node head;
        public Node tail;
        public int count;
        void AddFirst(int number) 
        {
            head.prev = new Node();
            head.prev.next = head;
            head = head.prev;
            head.data = number;

        }
        void AddLast(int number)
        {
            tail.next = new Node();
            tail.next.prev = tail;
            tail = tail.next;
            tail.data = number;
        }
        void RemoveFirst()
        {
        }
        void RemoveLast()
        {
        }
        void ToString()
        { 
        }
        void ToArray()
        { 
        }
    }
}
