using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class PeakIndexinaMountainArray
    {
        public void PeakIndexInMountainArrayFun(int[] arr)
        {
            int i = 0;
            int j = arr.Length - 1;

            while(i< j)
            {
                if (arr[i] < arr[j])
                {
                    i++;
                }
                else if (arr[i] > arr[j])
                {
                    j--;
                }
                else
                {
                    i++;
                    j--;
                }

                //if (i == j) { Console.WriteLine(i); }
            }

            Console.WriteLine("i= "+i+" j= "+j);
        }
    }
}
