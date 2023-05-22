using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class MoveZeros
    {
        public void MoveZerosFunc(int[] arr) 
        {
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]==0)
                {
                    for(int j = i; j <= arr.Length-1; j++)
                    {
                        arr[j] = arr[j + 1];
                        
                    }
                    arr[arr.Length - 1] = 0;
                }
            }

            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public void MoveZerosFuncEff(int[] arr)
        {
            int nonZeroIndex = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]!=0)
                {
                    arr[nonZeroIndex] = arr[i];
                    nonZeroIndex++;
                }

            }
            for(int j=nonZeroIndex; j < arr.Length; j++)
            {
                arr[j] = 0;
            }

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }

    }
}
