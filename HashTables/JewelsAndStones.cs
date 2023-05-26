using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    public class JewelsAndStones
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            Hashtable ht = new Hashtable();
            int count = 0;
            foreach(char c in jewels)
            {
                ht[c] = c;
            }

            //foreach(var item in ht.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            foreach(char stone in stones)
            {
                if(ht.ContainsKey(stone))
                {
                    count++;
                }
            }
            
            return count;
        }
    }
}
