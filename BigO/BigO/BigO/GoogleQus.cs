using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    public class GoogleQus
    {

        //worst code-
        //time complexity= O(n2)-because of nested loop,
        // time complexity= O(n2)-because of nested loop,
        
        
        public void FindPairs(int[] arr) { 
            for(int i=0;i<arr.Length-1;i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == 8)
                    {
                        Console.WriteLine("pair is {0},{1}", arr[i], arr[j]);
                    }
                }
            }
        }


        //best solution -
        //time complexity= O(n) where n is the number of elements in the input array.
        //space complexity= O(n) - worst case- if all elements in the array are unique, the dictionary would store n key-value pairs
        public void FindPairsMoreEfficiently(int[] arr, int targetSum)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int complement = targetSum - arr[i];

                if (pairs.ContainsKey(complement))
                {
                    int pairIndex = pairs[complement];
                    Console.WriteLine($"Pair found: ({arr[i]}, {arr[pairIndex]})");
                }

                pairs[arr[i]] = i;
            }
        }
    }
}
