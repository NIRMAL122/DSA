using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSort
    {
        public void BubbleSortFun(int[] arr)
        {
            for(int i=arr.Length; i>0; i--)
            {
                int temp = 0;
                for(int j = 0; j < i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j]= arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            foreach(int item in arr)
            {
                Console.Write(item+", ");
            }
        }
        
    }
}
