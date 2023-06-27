using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectionSort
    {
        public void SelectionSortFun(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                int smallest=i;
                int temp = arr[i];
                
                for(int j=i+1;j<arr.Length;j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest= j;
                    }
                }
                arr[i] = arr[smallest];
                arr[smallest] = temp;
            }
            foreach(int item in arr)
            {
                Console.Write(item+", ");
            }
        }
    }
}
