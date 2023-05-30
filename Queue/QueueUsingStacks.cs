using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class QueueUsingStacks
    {
        public QueueUsingStacks()
        {
            
        }

        Stack<int> org = new Stack<int>();
        Stack<int> copy = new Stack<int>();

        private void orgToCopy()
        {
            while(org.Count > 0)
            {
                copy.Push(org.Pop());
            }
        }

        private void copyToOrg()
        {
            while (copy.Count > 0)
            {
                org.Push(copy.Pop());
            }
        }

        public void Push(int x)
        {
            org.Push(x);
        }

        public int Pop()
        {
            orgToCopy();
            int popedItem = copy.Pop();
            copyToOrg();
            return popedItem; 
        }

        public int Peek()
        {
            orgToCopy();
            int topItem=copy.Peek();
            copyToOrg();
            return topItem;
        }

        public bool Empty()
        {
            if(org.Count > 0) { return false; }
            return true;
        }

        public void print()
        {
            if (org.Count == 0)
            {
                Console.WriteLine("Empty, nothing to Print");
                return;
            }
            orgToCopy();
            foreach(int item in copy)
            {
                Console.Write("-->"+ item);
            }
            Console.WriteLine();
            copyToOrg();

            
        }


    }
}
