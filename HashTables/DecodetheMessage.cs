using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    public class DecodetheMessage
    {
        public void DecodeMessage(string key, string message)
        {
            Dictionary<char,char> ht=new Dictionary<char, char>();
            ht.Add(' ', ' ');
            int alpha = 97;
            string result = "";

            //Console.WriteLine(key);
            //string str=key.Replace(" ","");
            //Console.WriteLine(str);

            foreach(char s in key)
            {
                if (ht.ContainsKey(s))
                {
                    continue;
                }
                else
                {
                    ht[s] = (char)alpha;
                    alpha++;
                }
            }

            foreach(char s in message)
            {
                if (ht.ContainsKey(s))
                {
                    result=result+ ht[s];
                }
            }

            //foreach(KeyValuePair<char, char> de in ht)
            //{
            //    Console.WriteLine("{0},{1}", de.Key,de.Value);
            //}

            Console.WriteLine(result);

            string a = "abc";
            //string b= a.Reverse().ToString();
            Console.WriteLine(a.Reverse().ToString());
        }
    }
}
