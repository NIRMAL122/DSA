using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCodes
{
    public class Search2DMatrix
    {
        public void SearchMatrix(int[][] matrix, int target)
        {
            HashSet<int> set = new HashSet<int>();

            for(int i=0;i<matrix.Length;i++)
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    set.Add(matrix[i][j]);
                }
            }

            foreach (int item in set) { Console.WriteLine(item); }

            if(set.Contains(target)) { Console.WriteLine("TRUE"); }
            else { Console.WriteLine("FALSE"); }
        }
    }
}

