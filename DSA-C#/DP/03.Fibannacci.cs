using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.DP
{
    public static class Fibannacci
    {
        //memoization
        private static Dictionary<int, long> memo = new Dictionary<int, long>();
        public static long Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            if (memo.ContainsKey(n))
            {
                return memo[n];
            }

            // Compute and store the value in the dictionary
            long value = Fibonacci(n - 1) + Fibonacci(n - 2);
            memo[n] = value;

            return value;

        }

    }
}
