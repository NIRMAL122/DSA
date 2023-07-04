using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class WordBreak
    {
        public bool WordBreakFun(string s, IList<string> wordDict)
        {
            HashSet<string> words = new HashSet<string>(wordDict);
            int n= s.Length;
            bool[] dp= new bool[n+1];
            dp[0] = true;
            foreach (bool item in dp) { Console.WriteLine(item); }

            for(int i=1; i <= n; i++)
            {
                for(int j=0;j<i;j++)
                {
                    string sub= s.Substring(j,i-j);
                    Console.WriteLine("sub= "+sub);
                    if (dp[j] && words.Contains(sub))
                    {
                        Console.WriteLine("TEST=>"+ sub);
                        dp[i] = true;
                        break;
                    }
                }
            }
            foreach (bool item in dp) { Console.WriteLine(item); }
            return dp[n];


        }
    }
}
