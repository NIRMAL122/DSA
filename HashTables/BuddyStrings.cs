using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    public class BuddyStrings
    {
        public void BuddyStringsFun(string s, string goal)
        {
            int count = 0;
            int firstDiff = -1;
            int secDiff = -1;
            int equal = 0;

            if (s.Equals(goal))
            {
                HashSet<char> hs = new HashSet<char>();

                foreach (char ch in s)
                {
                    if (hs.Contains(ch))
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        hs.Add(ch);
                    }
                }
                //Console.WriteLine("false");
            }
            else
            {

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != goal[i])
                    {
                        count++;
                    }
                    else
                    {
                        equal++;
                    }
                }

                if (count > 2 || s.Length != goal.Length) { Console.WriteLine("False"); }
                else
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] != goal[i])
                        {
                            if (firstDiff == -1) { firstDiff = i; }
                            else if (secDiff == -1) { secDiff = i; }
                            else { Console.WriteLine("false"); }

                        }
                    }

                    if (secDiff!=-1 && s[firstDiff] == goal[secDiff] && s[secDiff] == goal[firstDiff])
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
            }

        }
    }
}
