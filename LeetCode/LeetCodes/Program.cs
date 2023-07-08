namespace LeetCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SingleNumber obj = new SingleNumber();
            //int[] arr = { 1, 2, 3, 2,4, 3, 1 };
            //obj.SingleNumberFun(arr);

            //ExcelSheetColumnNumber obj = new ExcelSheetColumnNumber();
            //obj.TitleToNumber("AA");
            //obj.TitleToNumber("AB");
            //obj.TitleToNumber("BB");
            //obj.TitleToNumber("ZY");


            //LongestPalindromicSubstring obj = new LongestPalindromicSubstring();
            //Console.WriteLine(obj.LongestPalindrome("ccc"));

            //LongestSubstringWithoutRepeatingCharacters obj = new LongestSubstringWithoutRepeatingCharacters();
            //obj.LengthOfLongestSubstring("abca");

            //MergeIntervals obj = new MergeIntervals();
            //int[][] arr = new int[][]
            //{
            //  new int[]{1,3 },
            //  new int[]{8,10 },
            //  new int[]{2,6 },
            //  new int[]{15,18 }
            //};
            //obj.Merge(arr);


            //ExperimentArea obj = new ExperimentArea();
            //obj.test();

            //string s = "catsandog";
            //IList<string> wordDict = new List<string> { "cats", "dog", "sand", "and", "cat","o" };
            //WordBreak obj = new WordBreak();
            //Console.WriteLine(obj.WordBreakFun(s, wordDict));

            //NextPermutation obj = new NextPermutation();
            //int[] arr = { 5,1,1 };
            //obj.NextPermutationFun(arr);

            //LongestSubarrayof1AfterDeletingOneElement obj = new LongestSubarrayof1AfterDeletingOneElement();
            //int[] arr = { 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1,1,1};
            //obj.LongestSubarray(arr);

            //MinimumSizeSubarraySum obj= new MinimumSizeSubarraySum();
            //int[] arr = { 1, 2, 3, 4, 5,7 };
            //obj.MinSubArrayLen(15, arr);

            //MaximizetheConfusionofanExam obj = new MaximizetheConfusionofanExam();
            //obj.MaxConsecutiveAnswers("TTTFTFTTFTTTT",2);


            PutMarblesInBags obj= new PutMarblesInBags();
            int[] arr = { 46, 37, 46, 17, 40, 50, 54, 11, 1, 25, 43, 21, 31, 29, 58, 49, 73, 54, 5, 52, 73, 54, 6, 22, 58, 9, 34, 21, 58, 68, 63 };
            obj.MinimumDifference(arr,30);



        }
    }
}