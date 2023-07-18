using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class ContainerWithMostWater
    {
        // Linear time solution - O(n)
        public void MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int max = 0;

            while (left < right)
            {
                int area = (right-left) * Math.Min(height[left], height[right]);
                max = Math.Max(max, area);
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            Console.WriteLine(max);
        }

        //time: O(n^2)                               
        public void MaxAreaBF(int[] height)
        {
            int max = 0;
            for(int i=0;i<height.Length-1;i++)
            {
                for(int j= i + 1; j < height.Length; j++)
                {
                    int len= Math.Min(height[i], height[j]) ;
                    int br = j - i;

                    int tempArea = len * br;

                    max= Math.Max(max, tempArea);
                }
            }

            Console.WriteLine(max);
        }
    }
}
