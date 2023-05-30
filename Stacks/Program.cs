namespace Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Stacks");

            //StackImplementationLinkedList obj= new StackImplementationLinkedList();
            //obj.Push("google");
            //obj.Push("udemy.com");
            //obj.Push("youtube");
            //obj.Push("outlook");
            //obj.Pop();
            //obj.Pop();
            //obj.Push("chatGPT");
            //Console.WriteLine(obj.isEmpty());
            //Console.WriteLine(obj.Peek());
            //obj.printStack();

            StackImplementationArray obj= new StackImplementationArray();
            obj.Push("Google");
            obj.Push("youtube");
            obj.Push("Udemy");
            obj.printStack();
            obj.Pop();
            obj.Pop();
            obj.Pop();
            obj.Pop();
            obj.printStack();
            obj.Peek();
        }
    }
}