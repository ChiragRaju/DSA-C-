using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.DP
{
    internal class ClimbingStairs
    {
       public static int Stairs(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];

        }
        public static void main(string[] args) 
        {
            int result = Stairs(5);
            Console.WriteLine($"Number of ways to climb 5 stairs: {result}");
        }

    }
}
