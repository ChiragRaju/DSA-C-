using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.DP
{
    internal class SubsetProblem
    {
        public static bool IsSubsetSum(int[] nums, int target)
        {
            int n = nums.Length;

            // Initialize the DP table
            bool[,] dp = new bool[n + 1, target + 1];

            // Base Case: A sum of 0 is always possible with an empty subset
            for (int i = 0; i <= n; i++)
            {
                dp[i, 0] = true;
            }

            // Fill the DP table
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= target; j++)
                {
                    if (nums[i - 1] <= j) // Include or exclude the current number
                    {
                        dp[i, j] = dp[i - 1, j] || dp[i - 1, j - nums[i - 1]];
                    }
                    else // Exclude the current number
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                }
            }

            // Return whether it's possible to achieve the target sum
            return dp[n, target];
        }

        public static void Main(string[] args)
        {
            int[] nums = { 3, 34, 4, 12, 5, 2 };
            int target = 9;

            if (IsSubsetSum(nums, target))
            {
                Console.WriteLine("Subset with the given sum exists.");
            }
            else
            {
                Console.WriteLine("Subset with the given sum does not exist.");
            }
        }
    }
}
