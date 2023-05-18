using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    public class FindNemo
    {
        public void findNemo(string[] array)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "nemo")
                {
                    Console.WriteLine("Found Nemo!!");
                }
            }

            sw.Stop();

            Console.WriteLine("time Taken : {0} ms", sw.Elapsed.TotalMilliseconds);


        }
    }
}
