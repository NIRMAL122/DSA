namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Sorting");
            //SortFunction obj= new SortFunction();
            //obj.SortFun();

            int[] nums = { 1, 5, 4, 23, 0, 1, 23, 11, 7, 456, 234, 2, 3 };

            //BubbleSort obj = new BubbleSort();
            //obj.BubbleSortFun(nums);

            //SelectionSort obj = new SelectionSort();
            //obj.SelectionSortFun(nums);

            //InsertionSort obj= new InsertionSort();
            //obj.InsertionSortFun(nums);

            MergeSort obj = new MergeSort();
            obj.MergeSortFun(nums);
        }
    }
}