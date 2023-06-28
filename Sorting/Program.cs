namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Sorting");
            //SortFunction obj= new SortFunction();
            //obj.SortFun();

            int[] nums = { 5,1,3,2,4 };

            //BubbleSort obj = new BubbleSort();
            //obj.BubbleSortFun(nums);

            //SelectionSort obj = new SelectionSort();
            //obj.SelectionSortFun(nums);

            //InsertionSort obj= new InsertionSort();
            //obj.InsertionSortFun(nums);

            //MergeSort obj = new MergeSort();
            //obj.MergeSortFun(nums);

            QuickSort obj= new QuickSort();
            obj.QuickSortFun(nums);
        }
    }
}