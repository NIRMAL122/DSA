using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class QuickSort
    {
        public void QuickSortFun(int[] arr)
        {
            Divide(arr,0, arr.Length-1);
            foreach(int item in arr)
            {
                Console.Write(item+", ");
            }
        }

        public static void Divide(int[] ar, int low, int high)
        {
            if (low < high)
            {
                int partitionIx = Partition(ar, low, high);
                Divide(ar, low, partitionIx - 1);
                Divide(ar, partitionIx + 1,high);
            }
        }

        public static int Partition(int[] ar, int low, int high)
        {
            int pivot = ar[high];
            int i = low - 1;
            for(int j = low; j < high; j++)
            {
                if (ar[j] <= pivot)
                {
                    i++;
                    Swap(ar, i, j);
                }
            }

            Swap(ar, i+1,high);
            return i + 1;
        }

        public static void Swap(int[] array, int i, int j)
        {
            int temp= array[i];
            array[i]= array[j];
            array[j]= temp;
        }
    }
}
