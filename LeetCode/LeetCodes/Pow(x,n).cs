using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class Pow_x_n_
    {
        public void MyPow(double x, int n)
        {
            double ans = 1;
            if (n >= 0)
            {
                while (n > 0)
                {
                    ans = ans * x;
                    n--;
                }
            }
            else
            {
                while(n< 0)
                {
                    ans = ans * x;
                    n++;
                }

                ans = 1 / ans;
            }

            Console.WriteLine(ans);
        }

        public void MyPowEff(double x, long n)
        {
            var result= helper(x, Math.Abs(n));
            if(n>0)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(1/result);
            }
        }
        public static double helper(double x, long n)
        {
            if (x == 0) { return 0; }
            if (n == 0) { return 1; }

            var res= helper(x, n/2);
            res = res * res;
            if (n % 2==1)
            {
                return x * res;
            }
            else
            {
                return res;
            }
        }

        
    }
}
