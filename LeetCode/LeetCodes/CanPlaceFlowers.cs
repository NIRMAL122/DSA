using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class CanPlaceFlowers
    {
        public bool CanPlaceFlowersFun(int[] flowerbed, int n)
        {
            int prew = 0;
            int next = 0;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (i != flowerbed.Length - 1)
                {
                    next = flowerbed[i + 1];
                }
                if (flowerbed[i] == 0 && prew == 0 && next == 0)
                {
                    n--;
                    flowerbed[i] = 1;
                }
                prew = flowerbed[i];

            }
            return n <= 0;
        }
    }
}
