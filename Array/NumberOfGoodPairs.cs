using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class NumberOfGoodPairs
    {
        public void NumIdenticalPairs(int[] nums)
        {
            Dictionary<int, int> dict=new Dictionary<int, int>();
            int count = 0;
            
            foreach(int num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;

                }
                else
                {
                    dict[num] = 1;
                }
            }

            foreach(KeyValuePair<int, int> pair in dict) 
            {
                Console.WriteLine(pair);
            }

            foreach(var entry in dict)
            {
                int fq = entry.Value;
                count = count + (fq * (fq - 1)) / 2;
            }

            Console.WriteLine(count);

           


        }
    }
}
