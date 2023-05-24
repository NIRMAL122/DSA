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


            GoogleQue obj= new GoogleQue();
            int[] arr = { 2, 3, 5, 2, 5, 6, 3 };
            obj.FirstRecurringCharacter(arr);


        }
    }
}