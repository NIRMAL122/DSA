using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    public class FibonacciDynamicProgramming
    {

        int calculations = 0;
        //time complexity: O(2^n)
        public int Fib(int n)
        {
            //calculations++;
            if (n < 2)
            {
                return n;
            }
            return Fib(n - 1) + Fib(n - 2);
            
        }

        private static Dictionary<int,int> cache = new Dictionary<int,int>();   

        //time complexity: O(n)
        public int FibDP(int n)
        {

            calculations++;
            if (cache.ContainsKey(n))
            {
                return cache[n];
            }
            
            if (n < 2)
            {
                return n;
            }
            cache.Add(n, FibDP(n-1)+ FibDP(n-2));
            return cache[n];
        }

        public void printCalculations()
        {
            Console.WriteLine("calculations: " + calculations);
        }

        
    }
}
