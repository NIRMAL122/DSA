using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    public class ClimbingStairs
    {
        public void ClimbStairs(int n)
        {
            Console.WriteLine(fib(n+1));
        }

        private static Dictionary<int,int> cache= new Dictionary<int,int>();
        private static int fib(int n)
        {
            if(n<2) { return n; }

            if (cache.ContainsKey(n))
            {
                return cache[n];
            }

            cache.Add(n, fib(n-2)+fib(n-1));
            return cache[n];
        }
    }
}
