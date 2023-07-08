using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class PutMarblesInBags
    {
        public void MinimumDifference(int[] nums, int k)
        {
            List<int> sum= new List<int>();
            for(int i=0;i<nums.Length-1;i++)
            {
                sum.Add(nums[i] + nums[i+1]);
            }

            sum.Sort();
            foreach(int item in sum)
            {
                Console.WriteLine(item);
            }

            long maxSum = 0;
            long minSum = 0;
            int lengthOfList = sum.Count();
            if(lengthOfList > k-1)
            {
                for (int i = 0; i < k-1; i++)
                {
                    minSum = minSum + sum[i];
                    maxSum = maxSum + sum[sum.Count - 1 - i];
                }

                Console.WriteLine("max= " + maxSum + " min= " + minSum);
                long result = maxSum - minSum;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }
            


        }

    }
}
