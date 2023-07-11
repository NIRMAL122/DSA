using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class ValidAnagram
    {
        public void IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) { Console.WriteLine("False");return; }
            else
            {
                Dictionary<char, int> dict = new Dictionary<char, int>();
                foreach (char c in s)
                {
                    if(dict.ContainsKey(c))
                    {
                        dict[c]++;
                    }
                    else
                    {
                        dict.Add(c, 1);
                    }
                }
                //foreach (KeyValuePair<char,int> kvp in dict)
                //{
                //    Console.WriteLine("key= "+kvp.Key+" value= "+kvp.Value);
                //}

                foreach(char ch in t)
                {
                    if(!dict.ContainsKey(ch) || dict[ch]==0)
                    {
                        Console.WriteLine("FAlse");
                        return;
                    }
                    else
                    {
                        if(dict.ContainsKey(ch) && dict[ch] > 0)
                        {
                            dict[ch]--;
                        }
                    }
                }

                //foreach (KeyValuePair<char, int> kvp in dict)
                //{
                //    Console.WriteLine("key= " + kvp.Key + " value= " + kvp.Value);
                //}
            }

            Console.WriteLine("True");



        }
    }
}
