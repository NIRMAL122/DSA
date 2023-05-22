using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ReverseString
    {
        public void Reverse(string str)
        {
            char[] strArr= str.ToCharArray();
            char[] reversedStr= new char[strArr.Length];
            int a = 0;

            for(int i = strArr.Length - 1; i >= 0; i--)
            {
                reversedStr[a] = strArr[i];
                a++;
            }

            string result= new string(reversedStr);
            Console.WriteLine("Reverse of {0} is {1}", str, result);
            

            //foreach (char c in reversedStr)
            //{
            //    Console.Write(c);
            //}
        }

        public void Reverse2(string str)
        {
            string result = "";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                result = result + str[i];
            }
            Console.WriteLine(result);
        }

        public void Reverse3(string str)
        {
            string result= new string(str.Reverse().ToArray());
            Console.WriteLine(result);
        }
    }
}
