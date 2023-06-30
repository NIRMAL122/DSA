using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    public class BestTimeToBuyAndSellStock
    {
        public void MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            for(int i=0;i<prices.Length;i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else if (prices[i]-minPrice>maxProfit)
                {
                    maxProfit = prices[i]-minPrice;
                }
            }

            Console.WriteLine("Max Profit: "+maxProfit);
           
        }
    }
}
