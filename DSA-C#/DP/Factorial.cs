using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.DP
{
    public class Factorial
    {
        public static int Fact(int n)
        {
            int[] dp=new int[n + 1];
            dp[0]=1; // Base case: 0! = 1
            for (int i = 1; i <= n; i++)
            {
                dp[i] = dp[i - 1] * i; // Calculate factorial iteratively
            }
            return dp[n]; // Return the factorial of n
        }
    }
    //use memoization
    public class FactorialMemoization
    {
        private static int[] memo;
        public static int Fact(int n)
        {
            memo = new int[n + 1];
            return FactorialHelper(n);
        }
        private static int FactorialHelper(int n)
        {
            if (n == 0 || n == 1)
                return 1; // Base case: 0! = 1 and 1! = 1
            if (memo[n] != 0)
                return memo[n]; // Return cached result
            memo[n] = n * FactorialHelper(n - 1); // Store the result in memo array
            return memo[n];
        }
    }
}
