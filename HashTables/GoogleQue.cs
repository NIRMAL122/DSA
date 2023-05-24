using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    public class GoogleQue
    {
        public void FirstRecurringCharacter(int[] arr)
        {
            Dictionary<int,int> dict=new Dictionary<int,int>();
            foreach(int item in arr)
            {
                if (dict.ContainsKey(item))
                {
                    Console.WriteLine("First recurring character: {0}", item);
                    break;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }
        }
    }
}
