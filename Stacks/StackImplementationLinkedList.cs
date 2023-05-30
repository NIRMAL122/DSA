using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class Node
    {
        public string value { get; set; }
        public Node next { get; set; }
        public Node(string _value)
        {
            this.value = _value;
            this.next = null;

        }
    }
    public class StackImplementationLinkedList
    {
        public Node top;
        public Node bottom;
        public int length;

        public StackImplementationLinkedList()
        {
            this.top = null;
            this.bottom = null;
            this.length = 0;
        }

        public string Peek()
        {
            if (this.length > 0)
            {
                return this.top.value;
            }
            return "NOT Found";
        }

        public void Push(string value)
        {
            Node newNode = new Node(value);
            if (this.length == 0)
            {
                this.top = newNode;
                this.bottom = newNode;
            }
            else
            {
                Node holdingPointer = this.top;
                this.top = newNode;
                this.top.next = holdingPointer;
            }
            this.length++;
        }

        public void Pop()
        {
            if (this.length == 0)
            {
                Console.WriteLine("No data avaialable in Stack");
                this.bottom = null;
                return;
            }
            this.top = this.top.next;
            this.length--;

        }

        public bool isEmpty()
        {
            if (this.length == 0) { return true; }
            return false;
        }

        public void printStack()
        {
            if (this.length == 0)
            {
                Console.WriteLine("Empty Stack");
                return;
            }
            Node current = this.top;
            while (current != null)
            {
                
                Console.WriteLine(current.value);
                Console.WriteLine("   |");
                current = current.next;
            }

            Console.WriteLine();
            Console.WriteLine("Length: "+ this.length);
        }
    }
}
