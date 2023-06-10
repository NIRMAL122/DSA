using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Factorial
    {
        public int FactorialIterative(int num)
        {
            int ans = 1;
            for(int i = num; i > 1; i--)
            {
                ans= ans*i;
            }
            return ans;
        }

        public int FactorialRecursive(int num)
        {
            if (num == 2){ return 2; }
            if(num==1) { return 1; }
            return num * FactorialRecursive(num - 1);
        }
    }
}
