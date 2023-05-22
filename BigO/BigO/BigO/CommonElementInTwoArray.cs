using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    public class CommonElementInTwoArray
    {
        //O(n^2) - time complexity because of nested loop
        //O(1) - space complexity
        public bool isThereAnyCommon(string[] arr1, string[] arr2)
        {
            for(int i=0;i<arr1.Length;i++) 
            { 
                for(int j=0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //O(n) - time complexity
        //O(n) - space complexity
        public bool isThereAnyCommonEfficient(string[] arr1, string[] arr2)
        {
            //adding first array into dictonary, key as arrayValue and value as true/false
            Dictionary<string,bool> dict = new Dictionary<string,bool>();
            foreach(string item in arr1){
                dict[item]=true;
            }


            foreach(string item in arr2)
            {
                if (dict.ContainsKey(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
