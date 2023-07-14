using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class LongestArithmeticSubsequenceofGivenDifference
    {
        //BruteForce
        public void LongestSubsequence(int[] arr, int difference)
        {
            int maxLength = 0;
            for(int i=0;i<arr.Length;i++)
            {
                int current = arr[i];
                int currentLength = 1;
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] - current == difference)
                    {
                        current = arr[j];
                        currentLength++;
                    }
                }
                maxLength = Math.Max(maxLength, currentLength);
            }
            Console.WriteLine(maxLength);

        }

        //using dp
        public void LongestSubsequenceDP(int[] arr, int difference)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int ans = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i] - difference;
                int tempAns = 0;

                //check answer exist for temp already or not
                if(dict.ContainsKey(temp))
                {
                    tempAns= dict[temp];
                }

                //update current answer
                dict[arr[i]] = 1 + tempAns;

                //ans update
                ans= Math.Max(ans, dict[arr[i]]);
            }

            foreach(KeyValuePair<int, int> pair in dict)
            {
                Console.WriteLine("key="+pair.Key+ " value="+pair.Value);
            }

            Console.WriteLine(ans);
        }
    }
}
