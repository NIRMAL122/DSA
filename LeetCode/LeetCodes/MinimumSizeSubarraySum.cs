using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class MinimumSizeSubarraySum
    {
        public void MinSubArrayLen(int target, int[] nums)
        {
            int minLength = int.MaxValue;
            int left = 0;
            int sum = 0;

            for(int right=0; right<nums.Length; right++)
            {
                sum= sum + nums[right];

                while (sum >= target)
                {
                    minLength= Math.Min(minLength, right-left+1);
                    sum= sum - nums[left];
                    left++;
                }
            }

            if(minLength== int.MaxValue)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(minLength);
            }
        }
    }
}
