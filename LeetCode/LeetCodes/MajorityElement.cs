using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class MajorityElement
    {
        public int MajorityElementFun(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }

            foreach (KeyValuePair<int,int> kvp in dict)
            {
                if (kvp.Value > nums.Length / 2)
                {
                    return kvp.Key;
                }
            }
            return 0;
        }
    }
}
