using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 算法.数组
{
    public static class 买卖股票的最佳时机_II
    {
        public static int MaxProfit(int[] prices)
        {
            int nums = 0, sum = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] > prices[i + 1])
                {
                    // 7<1 过  （规律：前一个小于后一个）
                }
                else if (prices[i] < prices[i + 1])
                {
                    nums = prices[i + 1] - prices[i];
                    sum += nums;
                    nums = 0;
                }
            }
            return sum;
        }
    }
}
