using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class ReverseAString
    {
        public string ReverseStringIterative(string str)
        {
            
            string ans= "";
            for(int i=str.Length-1;i>=0;i--)
            {
                ans= ans + str[i];
            }
            return ans;
        }

        public string ReverseStringRecursive(string str)
        {
            if (str.Length == 0)
            {
                return "";
            }

            return ReverseStringRecursive(str.Substring(1))+str[0];


        }
    }
}
