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

            //int[] numbers = { 1, 2,3,3,5, 4,6,7 };
            //GoogleQus googleObj=new GoogleQus();
            //googleObj.FindPairs(numbers);
            //googleObj.FindPairsMoreEfficiently(numbers, 8);

            CommonElementInTwoArray obj=new CommonElementInTwoArray();
            string[] a = { "a","b","c","d","a"};
            string[] b = { "d", "e", "f" };
            bool result=obj.isThereAnyCommon(a, b);
            Console.WriteLine(result);

            bool resultEff=obj.isThereAnyCommonEfficient(a, b);
            Console.WriteLine(resultEff);

        }
    }
}