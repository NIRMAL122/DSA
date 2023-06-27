using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class MergeSort
    {
        public void MergeSortFun(int[] nums)
        {
            Divide(nums,0, nums.Length-1);
            foreach(int item in nums)
            {
                Console.Write(item+", ");
            }
        }

        public static void Divide(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle=(left+right)/2;

                Divide(arr, left, middle);
                Divide(arr, middle + 1, right);

                Merge(arr, left, middle, right);
            }
        }

        public static void Merge(int[] ar, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] leftAr= new int[n1];
            int[] rightAr= new int[n2];

            for(int i=0; i<n1; i++)
            {
                leftAr[i] = ar[left+i];
            }

            for(int j=0; j < n2; j++)
            {
                rightAr[j] = ar[middle + 1 + j];
            }

            int leftIx = 0; //left Index
            int rightIx = 0; //right Index
            int mergeIx = left; // merged Index

            while (leftIx<n1 && rightIx<n2)
            {
                if(leftAr[leftIx] <= rightAr[rightIx])
                {
                    ar[mergeIx]= leftAr[leftIx]; 
                    leftIx++;
                }
                else
                {
                    ar[mergeIx]= rightAr[rightIx];
                    rightIx++;
                }
                mergeIx++;
            }

            while (leftIx < n1)
            {
                ar[mergeIx] = leftAr[leftIx];
                leftIx++;
                mergeIx++;
            }

            while(rightIx< n2)
            {
                ar[mergeIx] = rightAr[rightIx];
                rightIx++;
                mergeIx++;
            }
        }
    }
}
