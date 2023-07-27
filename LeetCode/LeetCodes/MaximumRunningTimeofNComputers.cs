using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class MaximumRunningTimeofNComputers
    {
        
            public long MaxRunTime(int n, int[] batteries)
            {
                long sumPower = 0;
                foreach (int power in batteries)
                    sumPower += power;

                long left = 1;
                long right = sumPower / n;

                while (left < right)
                {
                    long target = right - (right - left) / 2;
                    long extra = 0;

                    foreach (int power in batteries)
                        extra += Math.Min(power, target);

                    if (extra >= (long)(n * target))
                        left = target;
                    else
                        right = target - 1;
                }

                return left;
            }
        }
    
}
