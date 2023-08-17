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
            int product = 0;
            int tempProduct = 1;

            if (nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
                return;
            }

            for (int i=0;i<nums.Length;i++)
            {
                tempProduct= tempProduct * nums[i];
                if(tempProduct>product) { product = tempProduct; }
                else { tempProduct = 1; }
            }

            Console.WriteLine(product);
        }
    }
}
