using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class LeftAndRigthSumDifferences
    {
        public void LeftRightDifference(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int leftSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum = leftSum + nums[j];
                }
                int rightSum = 0;
                for (int k = i + 1; k < nums.Length; k++)
                {
                    rightSum = rightSum + nums[k];
                }

                result[i] = Math.Abs(leftSum - rightSum);
            }
            
            foreach(int item in result)
            {
                Console.WriteLine(item);
            }
        }

        public void LeftRightDifferenceEff(int[] nums)
        {
            int[] result=new int[nums.Length];
            int totalSum = nums.Sum();
            int leftSum = 0;
            int rightSum = 0;



            //Console.WriteLine(totalSum);

            for(int i=0;i<nums.Length;i++)
            {
                totalSum=totalSum - nums[i];
                rightSum = totalSum;
                result[i]= Math.Abs(leftSum - rightSum);
                leftSum = leftSum + nums[i];
            }

            foreach (int item in result) { Console.WriteLine(item); }
        }
    }
}
