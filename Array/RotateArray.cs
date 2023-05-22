using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class RotateArray
    {
        public void RotateArrayFunc(int[] nums, int k)
        {
            for(int i=0;i<k;i++)
            {
                int temp = nums[nums.Length - 1];
                //Console.WriteLine("temp:{0}",temp);
                for (int j=nums.Length-1;j>0;j--)
                {
                    
                    nums[j] = nums[j-1];
                }
                nums[0] = temp;
            }

            foreach(int i in nums)
            {
                Console.WriteLine(i);
            }
        }

        public void RotateArrayFuncEff(int[] nums, int k)
        {
            k = k % nums.Length;

            ReverseArray(nums, 0, nums.Length - 1);
            ReverseArray(nums, 0,k-1);
            ReverseArray(nums,k,nums.Length-1);

            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }


        }

        static void  ReverseArray(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }
        }
    }
}
