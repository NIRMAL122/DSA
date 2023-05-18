using System.Diagnostics;

namespace BigO
{
    public class Program
    {
        static void Main(string[] args)
        {

            //string[] arr = { "a", "b", "c" };
            //pairOfArray obj= new pairOfArray();
            //obj.pairElement(arr);

            //string[] nemo = { "nemo", "jack", "hill", "romeo", "casta", "nemo" };
            //string[] large = new string[10000];
            //Array.Fill(large, "nemo");
            //FindNemo nemoObj = new FindNemo();
            //nemoObj.findNemo(nemo);

            int[] numbers = { 1, 2, 4, 4,6,7 };
            GoogleQus googleObj=new GoogleQus();
            googleObj.FindPairs(numbers);


            googleObj.FindPairsMoreEfficiently(numbers, 8);

        }
    }
}