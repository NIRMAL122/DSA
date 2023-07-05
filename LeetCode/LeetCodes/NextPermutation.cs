using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class NextPermutation
    {
        public void NextPermutationFun(int[] nums)
        {
            int i = nums.Length - 2;
            while(i>=0 && nums[i] >= nums[i+1])
            {
                i--;
            }

            Console.WriteLine("i= "+i);

            if(i>=0)
            {
                int j= nums.Length-1;
                while(j>i && nums[j] <= nums[i])
                {
                    j--;
                }

                Console.WriteLine("j= " + j);
                swap(nums,i, j);
            }

            Reverse(nums, i + 1, nums.Length - 1);

            foreach(int item in nums)
            {
                Console.Write(item+" ,");
            }
        }

        private void swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i]= nums[j];
            nums[j]= temp;
        }

        private void Reverse(int[] nums, int i, int j)
        {
            while (i < j)
            {
                swap(nums, i, j);
                i++;
                j--;
            }
        }
    }
}
