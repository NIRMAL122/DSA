using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    public class pairOfArray
    {
        

        public void pairElement(string[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                for(int j=0;j<array.Length;j++)
                {
                    Console.WriteLine("Pair {0},{1}", array[i], array[j]);
                }
            }
        }
    }
}
