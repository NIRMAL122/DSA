﻿namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList l = new MyLinkedList(10);
            l.Append(23);
            l.Append(12);
            l.Append(76);
            l.Insert(2, 25);
            l.Remove(34);
            l.PrintLinkedList();
            l.Reverse();
            l.PrintLinkedList();



            //MyDoublyLinkedList dl = new MyDoublyLinkedList(10);
            //dl.Append(20);
            //dl.Append(30);
            //dl.Append(40);
            //dl.Prepend(6);
            //dl.Prepend(4);
            //dl.Prepend(2);
            //dl.Insert(3, 8);
            //dl.Insert(4, 10);
            //dl.Remove(5);
            //dl.PrintDLinkedList();


        }
    }
}