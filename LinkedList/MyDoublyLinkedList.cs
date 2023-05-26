using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class dNode
    {
        public int value { get; set; }
        public dNode Next { get; set; }
        public dNode Previous { get; set; }
        public dNode(int _value)
        {
            this.value = _value;
            this.Next = null;
            this.Previous = null;
        }
    }

    public class MyDoublyLinkedList
    {
        public dNode Head;
        public dNode Tail;
        public int length;

        public MyDoublyLinkedList(int value)   //constructor
        {
             this.Head= new dNode(value);
            this.Tail = Head;
            this.length = 1;
        }

        public void PrintDLinkedList()
        {
            if (this.Head == null)
            {
                Console.WriteLine("No Data Available");
                return;
            }
            dNode currentNode= this.Head;
            while(currentNode!= null)
            {
                Console.Write("-->"+currentNode.value);
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
            Console.WriteLine("Length = "+this.length);
        }

        public void Append(int value)
        {
            dNode newNode= new dNode(value);
            this.Tail.Next= newNode;
            newNode.Previous = this.Tail;
            this.Tail= newNode;
            this.length++;
        }

        public void Prepend(int value)
        {
            dNode newNode= new dNode(value);
            newNode.Next = this.Head;
            this.Head.Previous= newNode;
            this.Head = newNode;
            this.length++;
        }

        public void Insert(int index, int value)
        {
            index = checkIndex(index);
            if (index == 0) { Prepend(value); return; }
            if (index >= this.length) { Append(value); return; }

            dNode newNode = new dNode(value);
            dNode leaderNode = Traversal(index - 1);
            dNode afterNode = leaderNode.Next;

            leaderNode.Next = newNode;
            newNode.Next = afterNode;
            newNode.Previous = leaderNode;
            afterNode.Previous = newNode;
            
            this.length++;
            
        }

        public void Remove(int index)
        {
            index = checkIndex(index);

            if (index == 0)
            {
                this.Head = Head.Next;
                return;
            }

            dNode leaderNode= Traversal(index - 1);
            dNode deleteNode = leaderNode.Next;
            dNode afterNode = deleteNode.Next;

            leaderNode.Next = afterNode;
            afterNode.Previous=leaderNode;

            this.length--;

        }

        private int checkIndex(int index)
        {
            return Math.Max(Math.Min(index, this.length-1), 0);
        }

        private dNode Traversal(int index)
        {
            dNode currentNode= this.Head;
            int counter = 0;
            while(counter!= index)
            {
                currentNode = currentNode.Next;
                counter++;
            }
            return currentNode;
        }
    }
}
