using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ThreeSum
    {
        public void ThreeSumFun(int[] nums)
        {
            for(int i=0;i<nums.Length;i++)
            {
                for(int j=i+1;j<nums.Length;j++)
                {
                    for(int k = j+1; k < nums.Length; k++)
                    {
                        if (nums[i]+ nums[j] + nums[k] == 0)
                        {
                            Console.WriteLine("[{0},{1},{2}]", nums[i],nums[j],nums[k]);
                        }
                    }
                }
            }
        }

        public IList<IList<int>> ThreeSumEff(int[] nums)
        {
            Array.Sort(nums); // Sort the array in ascending order
            List<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue; // Skip duplicate values for i

                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        // Skip duplicate values for left and right
                        while (left < right && nums[left] == nums[left + 1])
                            left++;
                        while (left < right && nums[right] == nums[right - 1])
                            right--;

                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return result;
        }
    }
}
