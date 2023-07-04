using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class ExperimentArea
    {
        public void test()
        {
            int[] a = { 1, 2 };
            List<int[]> list = new List<int[]>();
            list.Add(a);

            a[1] = 10;

            foreach(int[] itm in list)
            {
                foreach(int ii in itm)
                {

                    Console.WriteLine(ii);
                }
            }
        }
       
        
    }
}
