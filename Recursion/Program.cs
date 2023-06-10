namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Factorial obj= new Factorial();
            //Console.WriteLine(obj.FactorialIterative(5));
            //Console.WriteLine(obj.FactorialRecursive(5));

            //Fibonacci obj= new Fibonacci();
            //int result=obj.FibonacciIterative(8);
            //int result=obj.FibonacciRecursive(8);
            //Console.WriteLine(result);

            ReverseAString obj= new ReverseAString();
            //obj.ReverseStringIterative("yoyo mastery");
            Console.WriteLine(obj.ReverseStringRecursive("nirmal singh"));
        }
    }
}