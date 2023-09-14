using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class ReplaceVowelsWithStar
    {
        public void Fun(string str)
        {
            string vowels = "AEIOUaeiou";
            StringBuilder result = new StringBuilder();

            foreach(char c in str)
            {
                if (vowels.Contains(c))
                {
                    result.Append("*");
                }
                else
                {
                    result.Append(c);
                }
            }

            Console.WriteLine(result);
        }
    }
}
