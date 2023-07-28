using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class PredicttheWinner
    {
        public void PredictTheWinnerFun(int[] nums)
        {
            Console.WriteLine(PredictTheWinner_helper(0, 0, 0, nums.Length - 1, true));

            bool PredictTheWinner_helper(int score1, int score2, int left, int right, bool turn)
            {
                if (left > right) return score1 >= score2;

                if (turn)
                {
                    return PredictTheWinner_helper(score1 + nums[left], score2, left + 1, right, false) ||
                            PredictTheWinner_helper(score1 + nums[right], score2, left, right - 1, false);
                }
                else
                {
                    return PredictTheWinner_helper(score1, score2 + nums[left], left + 1, right, true) &&
                            PredictTheWinner_helper(score1, score2 + nums[right], left, right - 1, true);
                }
            }
        }
    }
}
