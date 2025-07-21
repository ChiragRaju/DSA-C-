using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Transactions;

namespace DSA_C_.Arrays
{
    public class _13BestTimetoBuySellStocks
    {
        // You are given an array prices where prices[i] is the price of a stock on the i-th day.

        //You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

        //Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.

        //input 
        //int[] prices = { 7, 1, 5, 3, 6, 4 };

        public static void Main(string[] args)
        {
           int[] prices = { 7, 1, 5, 3, 6, 4 };
            int maxProfit = BuySellsStocks(prices);
            Console.WriteLine($"The maximum profit from buying and selling stocks is: {maxProfit}");
        }

        public static int BuySellsStocks(int[] prices)
        {
            int maxProfit = 0;
            int minPrice=int.MaxValue;

            foreach (int price in prices) {
                if (price < minPrice) {
                    minPrice = price;
                }
                else
                {
                    maxProfit = Math.Max(maxProfit, price - minPrice);
                }
            }

           return maxProfit;

            //int minPrice = int.MaxValue;
            //int maxProfit = 0;

            //foreach (var price in prices)
            //{
            //    minPrice = Math.Min(minPrice, price);
            //    maxProfit = Math.Max(maxProfit, price - minPrice);
            //}

            //return maxProfit;

        }
    }
}
