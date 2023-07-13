using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class TwoSumII
    {
        public void TwoSum(int[] numbers, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int[] result = new int[2];

            for (int number=0;number<numbers.Length; number++)
            {
                int remainder = target - numbers[number];
                if (dict.ContainsKey(remainder))
                {
                    //Console.WriteLine("{0},{1}",dict[remainder]+1, number+1);
                    result[0] = dict[remainder] + 1;
                    result[1] = number + 1;
                }
                else if (dict.ContainsKey(numbers[number]))
                {
                    continue;
                }
                else
                {
                    dict.Add(numbers[number], number);
                }
            }

            foreach(int it in result)
            {
                Console.WriteLine(it);
            }


        }
    }
}
