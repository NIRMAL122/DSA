using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SortFunction
    {
        public void SortFun()
        {
            int[] arr = { 1, 3, 7, 2, 99, 23, 12, 101 };
            Array.Sort(arr);
            foreach (int i in arr) 
            { 
                Console.Write(i);
                Console.WriteLine();
            }

            string[] arr2 = { "sam", "aeon", "ben", "devon" };
            Array.Sort(arr2);
            foreach(string str in arr2)
            {
                Console.Write(str);
                Console.WriteLine();
            }

            char[] chars = { 'a', 'b', 'd', 'm', 'b', 'a', 'c' };
            Array.Sort(chars);
            foreach(char c in chars)
            {
                Console.Write(c);
                Console.WriteLine();
            }
        }
    }
}
