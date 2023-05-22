using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class MergeArray
    {
        public void MergeSortedArray(int[] arr1, int[] arr2)
        {
            int newArrayLength = arr1.Length + arr2.Length;
            int[] arr3=new int[newArrayLength];

            for(int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr3[arr1.Length+i] = arr2[i];
            }

            Array.Sort(arr3);

            foreach(int i in arr3)
            {
                Console.WriteLine(i);
            }
        }

        public void MergeSortedArray2(int[] arr1, int[] arr2)
        {
            int newArrayLength = arr1.Length + arr2.Length;
            int[] arr3 = new int[newArrayLength];
            int i=0, j=0, k = 0;

            while(i< arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    arr3[k] = arr1[i];
                    k++;
                    i++;
                }
                else
                {
                    arr3[k] = arr2[j];
                    k++; j++;
                }
            }

            while (i < arr1.Length)
            {
                arr3[k] = arr1[i];
                k++;
                i++;
            }
            while (j < arr2.Length)
            {
                arr3[k] = arr2[j];
                k++;
                j++;

            }


            foreach (int item in arr3)
            {
                Console.WriteLine(item);
            }

        }
    }
}
