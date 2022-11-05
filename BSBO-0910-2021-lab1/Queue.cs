using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBO_0910_2021_lab1
{
    internal class Queue
    {

        public Item head = null;

        public void Push(Item item)
        {
            if (head == null)
            { 
                head = item;
            }
            else
            {
                Item current = head;
                while( current.next != null)
                {
                    current = current.next; 
                }
                current.next = item;
            }
            item.next = null;
        }

        public Item Pop()
        {
            if (head == null)
            {
                throw new Exception("Head is null in Pop method");
            }
            else
            {
                Item current = head;
                head = head.next;
                return current;
            }
        }

        public int Get(int idx)
        {
            Item oldHead = head;
            for (int i = 0; i < idx; i++)
                Push(Pop());
            
            int result = head.value;
            while (head != oldHead)
                Push(Pop());

            return result;
        }

        public void Set(int idx, int newVal)
        {
            Item oldHead = head;
            for (int i = 0; i < idx; i++)
                Push(Pop());

            head.value = newVal;
            while (head != oldHead)
                Push(Pop());
        }

        public void Print()
        {
            Item current = head;
            while (current != null)
            {
                Console.Write(current.value + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
