using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class MergeIntervals
    {
        public void Merge(int[][] intervals)
        {
            Array.Sort(intervals,(a,b)=> a[0].CompareTo(b[0]));

            //foreach (int[] interval in intervals)
            //{
            //    foreach(int value in interval)
            //    {
            //        Console.WriteLine(value);
            //    }
            //}

            List<int[]> list = new List<int[]>();

            int[] currentInterval = intervals[0];
            //foreach(int item in currentInterval)
            //{
            //    Console.WriteLine(item);
            //}

            list.Add(currentInterval);

            foreach (int[] i in intervals)
            {
                int currentEnd = currentInterval[1];
                Console.WriteLine("currentEnd= "+ currentEnd);
                int nextStart= i[0];
                Console.WriteLine("next start= "+ nextStart);
                int nextEnd = i[1];
                Console.WriteLine("next End= "+nextEnd);

                if(currentEnd>= nextStart)
                {
                    currentInterval[1] = Math.Max(currentEnd, nextEnd);
                }
                else
                {
                    currentInterval = i;
                    list.Add(currentInterval);
                }
            }

            foreach(int[] item in list)
            {
                foreach(int ii in item)
                {

                    Console.WriteLine(ii) ;
                }
            }

        }
    }
}
