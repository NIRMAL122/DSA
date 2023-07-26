using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class StarPattern
    {
        public void invertedRightAngleTriangle()
        {
            for(int i=0; i < 5; i++)
            {
                for(int j=i;j<5;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void rightAngleTriangle()
        {
            for (int i = 1; i <= 5; i++)
            {
                for(int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                for (int j=4;j>i;j--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public void triange()
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 4; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }

                for (int n = 1; n < i; n++)
                {
                    Console.Write("*");
                }
                for (int m=5; m>i; m--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public void UKG()
        {
            string str = "nirmal singh";
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach(char c in str)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            foreach(KeyValuePair<char,int> kvp in dict)
            {
                Console.WriteLine("key= "+kvp.Key+" value= "+kvp.Value);
            }
        }
    }
}
