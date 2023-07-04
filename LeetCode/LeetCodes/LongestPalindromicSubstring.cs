using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class LongestPalindromicSubstring
    {
            public string LongestPalindrome(string s)
            {
                if (string.IsNullOrEmpty(s))
                    return string.Empty;

                int start = 0;
                int maxLength = 1;

                for (int i = 0; i < s.Length; i++)
                {
                    // Check for odd-length palindromes with current character as the center
                    int lengthOdd = ExpandAroundCenter(s, i, i);
                    if (lengthOdd > maxLength)
                    {
                        maxLength = lengthOdd;
                        start = i - (maxLength - 1) / 2;
                    }

                    // Check for even-length palindromes with current and next characters as the center
                    int lengthEven = ExpandAroundCenter(s, i, i + 1);
                    if (lengthEven > maxLength)
                    {
                        maxLength = lengthEven;
                        start = i - maxLength / 2 + 1;
                    }
                }

                return s.Substring(start, maxLength);
            }

            private int ExpandAroundCenter(string s, int left, int right)
            {
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    left--;
                    right++;
                }

                return right - left - 1;
            }
        }

        

    
}
