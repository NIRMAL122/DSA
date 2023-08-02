using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class MergeStringsAlternately
    {
        public void MergeAlternately(string word1, string word2)
        {
            int i = 0;
            int j= 0;
            StringBuilder res= new StringBuilder();

            while(i< word1.Length && j < word2.Length)
            {
                res.Append(word1[i]);
                res.Append(word2[j]);
                i++;
                j++;
            }

            while (i < word1.Length)
            {
                res.Append(word1[i]);
                i++;
            }
            while (j < word2.Length)
            {
                res.Append(word2[j]);
                j++;
            }

            Console.WriteLine(res.ToString());
        }
    }
}
