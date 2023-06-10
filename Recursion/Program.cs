namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Factorial obj= new Factorial();
            Console.WriteLine(obj.FactorialIterative(5));
            Console.WriteLine(obj.FactorialRecursive(5));
        }
    }
}