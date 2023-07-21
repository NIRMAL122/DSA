using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class NumberofLongestIncreasingSubsequence
    {
        //yet to try out before anything else
        public int FindNumberOfLIS(int[] nums)
        {
            // 1. O(n^2) Recursive solution with Caching
            Dictionary<int, int[]> dp = new Dictionary<int, int[]>();
            int lenLIS = 0, res = 0;

            int[] DFS(int i)
            {
                if (dp.ContainsKey(i))
                    return dp[i];

                int maxLen = 1, maxCnt = 1;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] > nums[i])
                    {
                        int[] result = DFS(j);
                        int length = result[0];
                        int count = result[1];
                        if (length + 1 > maxLen)
                        {
                            maxLen = length + 1;
                            maxCnt = count;
                        }
                        else if (length + 1 == maxLen)
                        {
                            maxCnt += count;
                        }
                    }
                }
                if (maxLen > lenLIS)
                {
                    lenLIS = maxLen;
                    res = maxCnt;
                }
                else if (maxLen == lenLIS)
                {
                    res += maxCnt;
                }
                dp[i] = new int[] { maxLen, maxCnt };
                return dp[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                DFS(i);
            }
            return res;
        }
    }
}
