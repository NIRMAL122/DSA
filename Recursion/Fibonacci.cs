
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Fibonacci
    {
        // O(n) - Linear
        public int FibonacciIterative(int n)
        {
            List<int> list = new List<int>();

            list.Add(0);
            list.Add(1);

            for(int i = 2; i <= n; i++)
            {
                list.Add(list[i - 1] + list[i-2]);
            }
            return list[n];
        }

       
        // O(2^n) - exponential- recursive algorithms that solve a problem of size N
       public int FibonacciRecursive(int n)
        {
            if (n < 2) { return n; }

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }
}
