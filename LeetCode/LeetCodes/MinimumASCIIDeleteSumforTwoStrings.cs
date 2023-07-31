using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class MinimumASCIIDeleteSumforTwoStrings
    {
        public void MinimumDeleteSum(string s1, string s2)
        {

             int[,] dp = new int[s1.Length + 2, s2.Length + 2];

            for (int i = 0; i <= s1.Length; i++)
            {
                for (int j = 0; j <= s2.Length; j++)
                {
                    dp[i, j] = -1;
                }
            }

            Console.WriteLine(go(s1,s2));

            int go(string s1, string s2, int i=0, int j=0)
            {
                    if (dp[i, j] != -1)
                        return dp[i, j];

                int cost = 0;
                if(i==s1.Length && j== s2.Length)
                {
                    cost = 0;
                }
                else if (i == s1.Length)
                {
                    cost = cost + go(s1, s2, i, j + 1) + s2[j];
                }
                else if(j == s2.Length)
                {
                    cost = cost + go(s1, s2, i + 1,j)+ s1[i];
                }
                else if (s1[i] == s2[j])
                {
                    cost = cost + go(s1, s2, i + 1, j + 1);
                }

                else
                {
                    int first= go(s1,s2,i+1,j)+s1[i];
                    int second= go(s1,s2,i,j+1)+s2[j];

                    cost= cost+ Math.Min(first, second);
                }

                return  dp[i, j] = cost;
            }
            
        }
    }
}
