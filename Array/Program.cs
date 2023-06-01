namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ArrayIntro obj= new ArrayIntro();
            //obj.ArrayIntroduction();

            //MyArray obj=new MyArray();
            //obj.Push("air");
            //obj.Push(1);
            //obj.Push("hello");
            //obj.Push("Jack");
            //obj.Push("John Wick");
            //Object result=obj.Pop();
            //Object result=obj.Get(1);
            //Console.WriteLine(result);
            //obj.DeleteAtIndex(1);
            //obj.PrintArr();

            //ReverseString obj=new ReverseString();
            //obj.Reverse("hello This code was written by Nirmal Singh");
            //obj.Reverse3("hello Nirmal");


            //MergeArray obj = new MergeArray();
            //int[] a = { 1, 2, 5, 7 };
            //int[] b = { 3, 9 };
            //obj.MergeSortedArray2(a, b);

            //TwoSum obj = new TwoSum();
            //obj.twoSumFunction(a, 8);

            //MoveZeros obj= new MoveZeros();
            //int[] nums = { 0, 0, 1 };
            //obj.MoveZerosFunc(nums);
            //obj.MoveZerosFuncEff(nums);

            //ContainsDuplicate obj= new ContainsDuplicate();
            //int[] nums = {1,2,3,4,5};
            //bool result =obj.ContainsDuplicateNumber(nums);
            //Console.WriteLine(result);

            //RotateArray obj=new RotateArray();
            //int[] arr = {1,2,3,4,5,6,7};
            //obj.RotateArrayFuncEff(arr,10);

            //MaximumSubarray obj= new MaximumSubarray();
            //int[] arr = { 5, 4, -1, 7, 8 };
            //int result=obj.MaximumSubarrayFun(arr);
            //Console.WriteLine(result);

            //LongestWord obj = new LongestWord();
            //obj.longestWrodFun("singh Nirmal happss");

            //NumberOfGoodPairs obj= new NumberOfGoodPairs();
            //int[] arr = { 1,1,1,1,2,3,3,3,4,5 };
            //obj.NumIdenticalPairs(arr);

            //KidWithGreatestNumberOfCandies obj=new KidWithGreatestNumberOfCandies();
            //int[] arr = { 4,3,8,5,3 };
            //obj.KidsWithCandiesEff(arr, 3);

            //LeftAndRigthSumDifferences obj=new LeftAndRigthSumDifferences();
            //int[] arr = { 10, 4, 8, 3 };
            //obj.LeftRightDifferenceEff(arr);

            ThreeSum obj= new ThreeSum();
            int[] arr = { -1, 0, 1, 2, -1, -4 };
            //obj.ThreeSumFun(arr);
            IList<IList<int>> triplets = obj.ThreeSumEff(arr);

            foreach (List<int> triplet in triplets)
            {
                Console.WriteLine(string.Join(", ", triplet));
            }
        }
    }
}