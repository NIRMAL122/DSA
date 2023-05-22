using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Arrays
{
    public class LongestWord
    {
        public void longestWrodFun(string strr)
        {
            string str = Regex.Replace(strr, @"[\p{P}-[.]]+", "");
            string[] array = str.Split(" ");
            int longestWordIndex=0;

            //Console.WriteLine(array[0].Length);

            for(int i=1; i<array.Length; i++)
            {
                if (array[i].Length > array[longestWordIndex].Length)
                {
                    longestWordIndex = i;
                }
            }



            Console.WriteLine(array[longestWordIndex]);

            foreach (string word in array)
            {
                Console.WriteLine(word);
            }
        }
    }
}
