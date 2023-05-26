using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int value { get; set; }
        public Node next { get; set; }
        public Node(int _value)
        {
            this.value= _value;
            this.next = null;
        }
    }  

    public class MyLinkedList
    {
        public Node head;
        public Node tail;
        public int length;

        public MyLinkedList(int value)  //constructor
        {
            this.head= new Node(value);
            this.tail = this.head;
            this.length = 1;
        }

        public void PrintLinkedList()
        {
            if(this.head == null)
            {
                Console.WriteLine("No data available");
                return;
            }
            Node current= this.head;
            while(current != null)
            {
                Console.Write("-->"+current.value);
                current = current.next;
            }
            Console.WriteLine();
            Console.WriteLine("Length = "+this.length);
        }

        public void Prepend(int value)
        {
            Node newNode=new Node(value);
            newNode.next = this.head;
            this.head = newNode;
            this.length++;
        }

        public void Append(int value)
        {
            Node newNode = new Node(value);
            this.tail.next = newNode;
            this.tail= newNode;
            newNode.next = null;
            this.length++;
        }

        public void Insert(int index, int value)
        {
            index = IndexCheck(index);
            if (index==0)
            {
                Prepend(value);
                return;
            }
            if(index>=this.length)
            {
                Append(value);
                return;
            }

            Node newNode= new Node(value);

            Node leaderNode = Traversal(index - 1);
            Node afterNode = leaderNode.next;

            leaderNode.next= newNode;
            newNode.next = afterNode;
            this.length++;
        }

        public void Remove(int index)
        {
            index = IndexCheck(index);
            if (index == 0)
            {
                this.head = head.next; 
                this.length--;
                return;
            }
            Node leaderNode = Traversal(index - 1);
            Node toBeRemoved= leaderNode.next;
            Node afterNode = toBeRemoved.next;

            leaderNode.next = afterNode;
            this.length--;
        }

        private Node Traversal(int index)
        {
            Node CurrentNode= this.head;
            int counter = 0;

            while (counter != index)
            {
                CurrentNode = CurrentNode.next;
                counter++;
            }
            return CurrentNode;
        }

        private int IndexCheck(int index)
        {
            return Math.Max(Math.Min(index, this.length-1),0);
        }

        public void Reverse()
        {
            Node a = head;
            tail = head;
            Node b= a.next;

            for(int i=0;i<length-1;i++)
            {
                Node c=b.next;
                b.next = a;
                a = b;
                b=c;
            }
            head.next = null;
            head = a;

        }

    }
}
