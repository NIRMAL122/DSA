namespace HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashTableImplementation obj = new HashTableImplementation(2);
            //obj.set("apple", 1000);
            //obj.set("mango", 50);
            //List<string> result =obj.keys();
            //foreach(string key in result)
            //{
            //    Console.WriteLine(key);
            //}


            //GoogleQue obj= new GoogleQue();
            //int[] arr = { 1,1,2,2 };
            //int result=obj.FirstRecurringCharacterNestedLoop(arr);
            //Console.WriteLine(result);


            //JewelsAndStones obj=new JewelsAndStones();
            //int result=obj.NumJewelsInStones("aA", "aAAbbbb");
            //Console.WriteLine(result);


            //HowManyNumbersAreSmallerThantheCurrentNumber obj= new HowManyNumbersAreSmallerThantheCurrentNumber();
            //int[] arr = { 7,7,7,7 };
            //obj.SmallerNumbersThanCurrent(arr);


            //DecodetheMessage obj=new DecodetheMessage();
            //obj.DecodeMessage("the quick brown fox jumps over the lazy dog", "vkbs bs t suepuv");
            //obj.DecodeMessage("eljuxhpwnyrdgtqkviszcfmabo", "zwx hnfx lqantp mnoeius ycgk vcnjrdb");


            BuddyStrings obj= new BuddyStrings();
            obj.BuddyStringsFun("abac", "abad");


        }
    }
}