using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class KidWithGreatestNumberOfCandies
    {
        public void KidsWithCandies(int[] candies, int extraCandies)
        {
            bool[] arr = new bool[candies.Length];
            
            for (int i = 0; i < candies.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < candies.Length; j++)
                {
                    if ((candies[i] + extraCandies) >= candies[j])
                    {
                        //Console.WriteLine(candies[i] + extraCandies);
                        count++;
                        //Console.WriteLine(count);
                    }
                }
                if (count >= candies.Length)
                {
                    arr[i] = true;
                }
                else
                {
                    arr[i] = false;
                }
            }
            foreach(bool cand in arr)
            {
                Console.WriteLine(cand);
            }
        }

        public void KidsWithCandiesEff(int[] candies, int extraCandies)
        {
            int MaxCandies = 0;
            IList<bool> list= new List<bool>();

            foreach(int candy in candies)
            {
                MaxCandies= Math.Max(candy, MaxCandies);
            }
            Console.WriteLine(MaxCandies);

            foreach(int candy in candies)
            {
                bool result = candy + extraCandies >= MaxCandies;
                list.Add(result);
            }

            foreach (bool item in list) { Console.WriteLine(item); }
        }

    }
}
