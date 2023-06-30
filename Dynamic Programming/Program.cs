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


            FibonacciDynamicProgramming obj = new FibonacciDynamicProgramming();
            //Console.WriteLine("Simple  -> " + obj.Fib(40));
            //Console.WriteLine("Dynamic -> " + obj.FibDP(5));
            Console.WriteLine("bottomUp  -> " + obj.Fib2(5));
            //obj.printCalculations();


            //int[] arr = { 10,5,7,20,1,3,40};
            //HouseRobber obj = new HouseRobber();
            //obj.Rob(arr);

            //BestTimeToBuyAndSellStock obj = new BestTimeToBuyAndSellStock();
            //obj.MaxProfit(arr);

            //ClimbingStairs obj= new ClimbingStairs();
            //obj.ClimbStairs(30);

        }
    }
}