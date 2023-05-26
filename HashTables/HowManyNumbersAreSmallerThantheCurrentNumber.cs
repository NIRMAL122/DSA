using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    public class HowManyNumbersAreSmallerThantheCurrentNumber
    {
        public void SmallerNumbersThanCurrent(int[] nums)
        {
            int[] result= new int[nums.Length];
            

            for(int i=0;i<nums.Length;i++)
            {
                int count = 0;
                for (int j=0;j<nums.Length;j++)
                {
                    if (nums[i] > nums[j])
                    {
                        count++;
                    }
                }
                result[i]=count;
            }

            foreach (int item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}
