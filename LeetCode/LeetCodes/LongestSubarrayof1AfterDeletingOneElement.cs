using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class LongestSubarrayof1AfterDeletingOneElement
    {
        public void LongestSubarray(int[] nums)
        {
            int maxLength = 0;
            int left = 0;
            int right = 0;
            int countZeros = 0;
            bool hasDeletedElement = false;

            while (right < nums.Length)
            {
                if (nums[right] == 0)
                {
                    countZeros++;
                    if (hasDeletedElement==false)
                    {
                        Console.WriteLine("right= "+right);
                        hasDeletedElement = true;
                    }
                    else
                    {
                        maxLength = Math.Max(maxLength, right - left - 1);
                        Console.WriteLine("maxLength= "+maxLength);
                        while (nums[left] == 1)
                        {
                            left++;
                        }
                        left++; // skip the first 0 encountered after deletion
                        Console.WriteLine("left= "+left);
                    }
                }

                right++;
            }

            Console.WriteLine("right= "+right);

            maxLength = Math.Max(maxLength, right - left - 1);
            Console.WriteLine( maxLength);
        }
    }
}

