namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Queue");

            //QueueImplementationLinkedList obj=new QueueImplementationLinkedList();
            //obj.Enqueue("Sam");
            //obj.Enqueue("Joey");
            //obj.Enqueue("Ross");
            //obj.Enqueue("Dwight");
            //obj.Enqueue("Jim");
            //obj.PrintQueue();
            //obj.Dequeue();
            //obj.PrintQueue();


            QueueUsingStacks obj= new QueueUsingStacks();
            obj.Push(1);
            obj.Push(2);
            obj.Push(3);
            obj.Push(4);
            obj.Push(5);
            obj.Pop();
            Console.WriteLine(obj.Empty());
            Console.WriteLine(obj.Peek());
            obj.print();

        }
    }
}