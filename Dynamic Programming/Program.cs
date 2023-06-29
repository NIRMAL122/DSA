namespace Dynamic_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dynamic Programming");

            //Memoization1 obj= new Memoization1();
            //Console.WriteLine("Run1: "+obj.AddTo47(5));
            //Console.WriteLine("Run2: "+obj.AddTo47(5));
            //Console.WriteLine("Run3: "+obj.AddTo47(5));


            FibonacciDynamicProgramming obj= new FibonacciDynamicProgramming();
            Console.WriteLine("Dynamic -> " + obj.FibDP(1000));
            //Console.WriteLine("Simple  -> "+obj.Fib(40));
            obj.printCalculations();

        }
    }
}