using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            int sum = 0;
            Dictionary<char, int> romanDict = new()
        {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };
            for (int i = 0; i < s.Length; i++)
            {
                char romanChar = s[i];
                romanDict.TryGetValue(romanChar, out int num);

                if (i + 1 < s.Length && romanDict[s[i + 1]] > romanDict[s[i]])
                {
                    sum = sum - num;
                }
                else
                {
                    sum = sum + num;
                }
            }
            return sum;



        }
    }
}
