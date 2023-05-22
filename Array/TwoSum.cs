using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class TwoSum
    {
        public void twoSumFunction(int[] arr, int target)
        {
            Dictionary<int,int> dict=new Dictionary<int, int>();

            for(int i=0; i<arr.Length; i++)
            {
                int remainder = target - arr[i];
                if (dict.ContainsKey(remainder))
                {
                    int index = dict[remainder];

                    Console.WriteLine("pair {0},{1}",index,i);
                }

                dict[arr[i]] = i;
            }

            

            
           

            foreach(KeyValuePair<int,int> pair in dict)
            {
                Console.WriteLine(pair);
            }
        }
    }
}
