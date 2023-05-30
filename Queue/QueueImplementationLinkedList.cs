using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
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
    
    public class QueueImplementationLinkedList
    {
        public Node first;
        public Node last;
        public int length;

        public QueueImplementationLinkedList()
        {
            this.first = null;
            this.last = null;
            this.length= 0;
        }

        public void Peek()
        {
            if (length > 0) { Console.WriteLine(first.value); }
            else { Console.WriteLine("Queue is Empty"); }
            
        }

        public void Enqueue(string value)
        {
            Node newNode = new Node(value);
            if(length==0)
            {
                first= newNode;
                last= newNode;
            }
            else
            {
                last.next= newNode;
                last = newNode;
            }
            length++;
        }

        public void Dequeue()
        {
            if(length== 0)
            {
                last = null;
                Console.WriteLine("Queue is Already Empty");
                return;
            }
            first = first.next;
            length--;

        }

        public void PrintQueue()
        {
            
            if (length == 0) { Console.WriteLine("Queue is Empty, Nothing to Print!!"); return; }

            Node current = first;
            while (current != null)
            {
                Console.Write("-->"+current.value);
                current = current.next;
            }
            Console.WriteLine();
            Console.WriteLine("Length: "+length);
        }
    }
}
