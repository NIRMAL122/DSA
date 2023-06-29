using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    public class Memoization1
    {
        Dictionary<int,int> dict= new Dictionary<int,int>();
        public int AddTo47(int n)
        {
            if (dict.ContainsKey(n))
            {
                return dict[n];
            }
            else
            {
                dict.Add(n, n + 47);
                Console.WriteLine("Test");
                return n + 47;
            }
        }
    }
}
