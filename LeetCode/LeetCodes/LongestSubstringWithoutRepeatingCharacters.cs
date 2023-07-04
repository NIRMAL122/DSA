using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public void LengthOfLongestSubstring(string s)
        {
            int start = 0;
            int maxLength = 0;
            Dictionary<char,int> dict = new Dictionary<char,int>();

            for(int i=0;i<s.Length;i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    start=Math.Max(start, dict[s[i]]+1);
                    dict[s[i]] = i;
                }
                else
                {
                    dict.Add(s[i], i);
                }

                maxLength=Math.Max(maxLength, i-start+1);
            }

            foreach(KeyValuePair<char,int> kvp in dict)
            {
                Console.WriteLine("key: "+ kvp.Key+" Value: "+kvp.Value);
            }

            Console.WriteLine(maxLength);
        }
    }
}
