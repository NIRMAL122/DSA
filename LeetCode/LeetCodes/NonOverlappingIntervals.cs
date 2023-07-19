using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class NonOverlappingIntervals
    {
        public void EraseOverlapIntervals(int[][] intervals)
        {
            var sortedIntervals = intervals.Clone() as int[][];
            Array.Sort(sortedIntervals, (a, b) => a[0].CompareTo(b[0]));

            for(int i=0;i< sortedIntervals.Length;i++)
            {
                Console.Write(sortedIntervals[i][0] + "," + sortedIntervals[i][1]);
                Console.WriteLine();
            }

            int ans = 0;
            var prevEnd = sortedIntervals[0][1];

            for(int i=1;i<sortedIntervals.Length;i++)
            {
                var curr = sortedIntervals[i];
                if (prevEnd > curr[0])
                {
                    ans++;
                    prevEnd= Math.Min(prevEnd, curr[1]); 
                }
                else
                {
                    prevEnd= curr[1];
                }
            }
            Console.WriteLine(ans);
        }
    }
}
