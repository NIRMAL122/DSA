using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class MaximumSubarray
    {
        public int  MaximumSubarrayFun(int[] nums)
        {
            int currentSum = nums[0];  // Stores the current subarray sum
            int maxSum = nums[0];      // Stores the maximum subarray sum

            // Iterate through the array starting from the second element
            for (int i = 1; i < nums.Length; i++)
            {
                // Calculate the current subarray sum including the current element
                currentSum = Math.Max(nums[i], currentSum + nums[i]);

                // Update the maximum subarray sum if necessary
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }
    }
}
