using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ContainsDuplicate
    {
        public bool ContainsDuplicateNumber(int[] arr)
        {
            
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i=0; i<arr.Length; i++)
            {
                    
                if (dict.ContainsKey(arr[i]))
                {
                    return true;
                    break;
                }
                else
                {
                    dict[arr[i]] = i;
                    
                }
            }
            return false;
            
        }
    }
}
