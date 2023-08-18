using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class MaximumProductSubarray
    {
        public void MaxProduct(int[] nums)
        {
            var maxProduct = nums.Max();
            //Console.WriteLine(maxProduct);
            int curMin = 1; 
            int curMax = 1;

            foreach (var n in nums)
            {
                var tmp = curMax * n;

                curMax = new int[] { n, n * curMin, n * curMax }.Max();
                curMin = new int[] { n, n * curMin, tmp }.Min();

                maxProduct = Math.Max(maxProduct, curMax);
            }

            Console.WriteLine(maxProduct);
        }
    }
}
