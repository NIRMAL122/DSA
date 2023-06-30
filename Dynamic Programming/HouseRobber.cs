using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    public class HouseRobber
    {
        public void Rob(int[] nums)
        {
            int n= nums.Length;
            if (n == 0) Console.WriteLine(0);
            if(n==1) Console.WriteLine(nums[0]);

            int[] robbed = new int[n];
            robbed[0] = nums[0];
            robbed[1] = Math.Max(nums[0], nums[1]);
            for(int i = 2; i < n; i++)
            {
                //To calculate robbed[i], we take the maximum value between two options:

                //Robbing the current house(nums[i]) plus the maximum amount that can be robbed from two houses before(robbed[i - 2]).
                //Skipping the current house and taking the maximum amount that can be robbed up to the previous house(robbed[i - 1]).
                robbed[i]= Math.Max(robbed[i - 2] + nums[i], robbed[i - 1]);
            }

            Console.WriteLine("Robbery Amount= "+ robbed[n-1]);
        }
    }
}
