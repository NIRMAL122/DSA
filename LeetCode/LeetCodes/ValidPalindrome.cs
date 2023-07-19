using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            string str = s.ToLower();
            // removing non alphanumeric using Regex
            string str1 = Regex.Replace(str, @"[^a-zA-Z0-9]", "");
            // removing non alphanumeric using Linq
            //string str1 = new string(str.Where(char.IsLetterOrDigit).ToArray());
            Console.WriteLine(str1);

            int left = 0;
            int right = str1.Length-1;
            while (left < right)
            {
                if (str1[left] == str1[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    return false;
                }

            }

            return true;

        }
    }
}
