using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class SubstringWithLargestVariance
    {
        public int LargestVariance(string s)
        {
            int count1 = 0;
            int count2 = 0;
            int maxVariance = 0;

            // Create distinct list of character pairs
            List<(char, char)> pairs = new List<(char, char)>();
            HashSet<char> distinctChars = new HashSet<char>(s);

            foreach (char l1 in distinctChars)
            {
                foreach (char l2 in distinctChars)
                {
                    if (l1 != l2)
                    {
                        pairs.Add((l1, l2));
                    }
                }
            }

            // Run once for original string order, then again for reverse string order
            for (int runs = 0; runs < 2; runs++)
            {
                foreach ((char, char) pair in pairs)
                {
                    count1 = count2 = 0;
                    foreach (char letter in s)
                    {
                        // No reason to process letters that aren't part of the current pair
                        if (letter != pair.Item1 && letter != pair.Item2)
                        {
                            continue;
                        }

                        if (letter == pair.Item1)
                        {
                            count1++;
                        }
                        else if (letter == pair.Item2)
                        {
                            count2++;
                        }

                        if (count1 < count2)
                        {
                            count1 = count2 = 0;
                        }
                        else if (count1 > 0 && count2 > 0)
                        {
                            maxVariance = Math.Max(maxVariance, count1 - count2);
                        }
                    }
                }

                // Reverse the string for the second time around
                char[] sArray = s.ToCharArray();
                Array.Reverse(sArray);
                s = new string(sArray);
            }

            return maxVariance;
        }


    }
}
