using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.DP
{
    internal class MinCostClimbingStairs
    {
        public static int MinCost(int[] cost)
        {
            int n = cost.Length;

            // If there are less than 2 steps, the cost is the minimum of the steps.
            if (n == 2) return Math.Min(cost[0], cost[1]);

            // Initialize the first two costs
            int prev2 = cost[0]; // dp[i-2]
            int prev = cost[1];  // dp[i-1]

            // Iterate through the cost array starting from the third step
            for (int i = 2; i < n; i++)
            {
                int current = cost[i] + Math.Min(prev, prev2);
                prev2 = prev;
                prev = current;
            }

            // The result is the minimum cost to reach the top
            return Math.Min(prev, prev2);
        }

        public static void Main(string[] args)
        {
            // Example inputs
            int[] cost1 = { 10, 15, 20 };
            int[] cost2 = { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };

            Console.WriteLine($"Minimum cost for cost1: {MinCost(cost1)}"); // Output: 15
            Console.WriteLine($"Minimum cost for cost2: {MinCost(cost2)}"); // Output: 6
        }
    }
}
