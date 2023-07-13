using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class ProductofArrayExceptSelf
    {
        public void ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            int prefix = 1;
            int postfix = 1;
            //result[0]=prefix;

            for(int i=0;i<nums.Length;i++) 
            {
                result[i]=prefix;
                prefix= prefix * nums[i];
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] = postfix * result[i];
                postfix = postfix * nums[i];
            }


            foreach (int it in result)
            {
                Console.WriteLine(it);
            }
        }
    }
}
