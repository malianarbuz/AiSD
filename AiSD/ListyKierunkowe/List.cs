using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ListyKierunkowe
{
   internal class List
    {
        public Node head;
        public Node tail;
        public int count;

        public void AddFirst(int number)
        {
            if (count > 0)
            { 
            head.prev = new Node();
            head.prev.next = head;
            head = head.prev;
            head.data = number;
                count++;
            }
            else
            {
                head = new Node();
                head.data = number;
                tail = head;
                count++;
            }

        }
        public void AddLast(int number)
        {
            if(count>0)
            {
                tail.next = new Node();
                tail.next.prev = tail;
                tail = tail.next;
                tail.data = number;
                count++;
            }
            else
            {
                head = new Node();
                head.data = number;
                tail = head;
                count++;
            }
        }
        public void RemoveFirst()
        {
            if (count > 1)
            {
                head = head.next;
                head.prev = null;
                count--;
            }
            else if (count == 1)
            {
                head = null;
                tail = null;
                count--;
            }

        }
        public void RemoveLast()
        {
            if(count>1)
            {
                tail = tail.prev;
                tail.next = null;
                count--;
            }
            else if (count == 1)
            {
                head = null;
                tail = null;
                count--;
            }
        }
        public String ConvertToString()
        {
            Node b = head;           
            String str=null;
            while(b!=null)
            {
                str += "  "+b.data.ToString();
                b = b.next;
            }
            return str;
        }
        public int[] ConvertToArray()
        {
            Node b = head;
            int[] arr = null;
            int i = 0;
            while (b != null)
            {
                arr[i] = b.data;
                b = b.next;
                i++;
            }
            return arr;
        }
    }
}
