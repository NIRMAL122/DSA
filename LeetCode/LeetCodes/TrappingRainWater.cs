using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class TrappingRainWater
    {
        public void Trap(int[] height)
        {
            int[] maxLeft= new int[height.Length];
            int[] maxRight= new int[height.Length];
            int[] minLR= new int[height.Length];
            maxLeft[0]=0;
            maxRight[maxRight.Length-1]=0;

            int maxl = 0;
            int maxr = 0;

            int ans = 0;

            for(int i=1;i<height.Length;i++)
            {
                int maxTemp= height[i-1];
                maxl= Math.Max(maxl, maxTemp);
                maxLeft[i]= maxl;
            }
            for(int i= height.Length-2;i>=0;i--)
            {
                int maxTemp= height[i+1];
                maxr= Math.Max(maxr, maxTemp);
                maxRight[i]= maxr;
            }
            for(int i=0; i < height.Length; i++)
            {
                minLR[i]= Math.Min(maxLeft[i], maxRight[i]);
            }
            for(int i=0; i < height.Length; i++)
            {
                int tempAns = minLR[i] - height[i];
                if (tempAns>0)
                {
                    ans= ans+ tempAns;
                }
            }



            foreach (int ii in maxLeft) { Console.Write(ii+","); }
            Console.WriteLine();
            foreach (int ii in maxRight) { Console.Write(ii+","); }
            Console.WriteLine();
            foreach (int ii in minLR) { Console.Write(ii+","); }
            Console.WriteLine();
            Console.WriteLine("Answer= "+ans);
        }
    }
}
