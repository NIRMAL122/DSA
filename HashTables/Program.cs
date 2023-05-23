namespace HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashTableImplementation obj = new HashTableImplementation(50);
            obj.set("apple", 1000);
            obj.set("mango", 50);

            Console.WriteLine(obj.get("mango"));

        }
    }
}