using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class ExcelSheetColumnNumber
    {
        public void TitleToNumber(string columnTitle)
        {
            
            int cycle = 0;
            foreach (char c in columnTitle)
            {
                int n= (int)c-65+1;
                cycle = cycle *26+n;

            }

            Console.WriteLine(cycle);
        }
    }
}
