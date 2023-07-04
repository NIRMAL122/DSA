using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class SingleNumber
    {
        public void SingleNumberFun(int[] nums)
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

            foreach(KeyValuePair<int, int> kvp in dict)
            {
                Console.WriteLine("key: "+kvp.Key+", value: "+kvp.Value);
                if (kvp.Value == 1) { Console.WriteLine("result="+ kvp.Key); }
            }
        }
    }
}
