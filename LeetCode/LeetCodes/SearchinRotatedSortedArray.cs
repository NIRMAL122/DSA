using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class SearchinRotatedSortedArray
    {
        public void Search(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dict.Add(nums[i], i);
            }

            foreach (KeyValuePair<int, int> kvp in dict)
            {
                if (kvp.Key == target) { Console.WriteLine(kvp.Value); return; }
                
            }

            Console.WriteLine(-1);

        }
    }
}
