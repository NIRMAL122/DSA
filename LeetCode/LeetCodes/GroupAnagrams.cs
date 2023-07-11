using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class GroupAnagrams
    {
        public void GroupAnagramsFun(string[] strs)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            foreach (string str in strs)
            {
                char[] chars= str.ToCharArray();
                Array.Sort(chars);
                string sortedStr= new string(chars);

                if(!dict.ContainsKey(sortedStr))
                {
                    dict[sortedStr] = new List<string>();
                }
                dict[sortedStr].Add(str);
            }

            foreach(KeyValuePair<string,List<string>> kvp in dict)
            {
                Console.WriteLine("key= "+kvp.Key);
                foreach(string str in kvp.Value)
                {
                    Console.WriteLine("value="+str);
                }
            }

            IList<IList<string>>result= new List<IList<string>>(dict.Values);
            foreach(IList<string> str in result)
            {
                Console.Write("[");
                foreach(string s in str)
                {
                    Console.Write("[");
                    Console.Write(s);
                    Console.Write("]");
                }
                Console.Write("],");
            }
        }
    }
}
