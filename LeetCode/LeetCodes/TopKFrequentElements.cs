using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class TopKFrequentElements
    {
        public void TopKFrequent(int[] nums, int k)
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
            var sortedDictionary = dict.OrderByDescending(x => x.Value)
                                .ToDictionary(x => x.Key, x => x.Value);


            foreach( var x in sortedDictionary)
            {
                Console.WriteLine(x);
            }

            int[] result = new int[k];


            List<int> list = new List<int>();
            list = sortedDictionary.Keys.ToList();

            for(int i=0;i<k;i++)
            {
                result[i] = list[i];
            }

            foreach (int iem in result) { Console.WriteLine(iem); }

        }
    }
}
