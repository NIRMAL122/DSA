using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class LongestConsecutiveSequence
    {
        public void longestConsecutive(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            int longest = 0;

            foreach(int i in nums)
            {
                if (!set.Contains(i-1))
                {
                    int length = 0;
                    while (set.Contains(i + length))
                    {
                        length= length+1;
                    }
                    longest= Math.Max(longest, length);
                }
            }

            Console.WriteLine(longest);
        }
    }
}
