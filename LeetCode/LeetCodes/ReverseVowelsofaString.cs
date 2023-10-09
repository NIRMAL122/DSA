using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class ReverseVowelsofaString
    {
        public void ReverseVowels(string s)
        {
            var vowels = "aeiouAEIOU";
            var extract= s.Where(c=>vowels.Contains(c)).Reverse().ToArray();
            var res = s.ToCharArray();

            Console.WriteLine(res);

            int j = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    res[i] = extract[j];
                    j++;
                }
            }

            Console.WriteLine(res);
        }


        public void ReverseVowelsII(string s)
        {
            string vowels = "AEIOUaeiou";

            

            StringBuilder vow = new StringBuilder();
            StringBuilder result = new StringBuilder();

            foreach(char c in s)
            {
                if (vowels.Contains(c))
                {

                    vow.Append(c);
                }
            }

            var a = vow.ToString().Reverse().ToArray();
            int i = 0;
            
            foreach(char c in s)
            {
                if(vowels.Contains(c))
                {
                    result.Append(a[i]);
                    i++;
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
