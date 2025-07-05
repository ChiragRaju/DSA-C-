using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.DP
{
    public class LongestCommonSubSequence
    {
        public static int LCSRecursive(string s, string t, int i, int j)
        {
            // Base case: If either index is out of bounds
            if (i < 0 || j < 0)
                return 0;

            // Characters match, move both pointers back
            if (s[i] == t[j])
                return 1 + LCSRecursive(s, t, i - 1, j - 1);

            // Characters don't match, take the maximum of skipping one character from either string
            return Math.Max(LCSRecursive(s, t, i - 1, j), LCSRecursive(s, t, i, j - 1));
        }

        public static void Main(string[] args)
        {
            string s = "abcde";
            string t = "ace";

            int n = s.Length;
            int m = t.Length;

            // Directly call the recursive function with string lengths
            int result = LCSRecursive(s, t, n - 1, m - 1);

            Console.WriteLine($"Length of Longest Common Subsequence: {result}");
        }
    }

}

//memoization

public class LongestCommonSubSequences
{
    private static int LCSMemoized(int i, int j, string s, string t, int[,] memo)
    {
        // Base case: If any string is exhausted
        if (i < 0 || j < 0)
            return 0;

        // If already computed, return the stored result
        if (memo[i, j] != -1)
            return memo[i, j];

        // If characters match
        if (s[i] == t[j])
            memo[i, j] = 1 + LCSMemoized(i - 1, j - 1, s, t, memo);
        else
        {
            // If characters don't match, take the max of two cases:
            // 1. Skipping a character from the first string
            // 2. Skipping a character from the second string
            memo[i, j] = Math.Max(
                LCSMemoized(i - 1, j, s, t, memo),
                LCSMemoized(i, j - 1, s, t, memo)
            );
        }

        return memo[i, j];
    }

    public static int LCS(string s, string t)
    {
        int n = s.Length;
        int m = t.Length;

        // Initialize a memoization table with -1
        int[,] memo = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                memo[i, j] = -1;
            }
        }

        return LCSMemoized(n - 1, m - 1, s, t, memo);
    }
}

//tabulation top down approach

public class LongestCommonSubsequence
{
    public static int LCSTable(string s, string t)
    {
        int m = s.Length;
        int n = t.Length;

        // Initialize the dp table
        int[,] dp = new int[m + 1, n + 1];

        // we start with i=1 and j=1 because if i==0 or j==0 we fill it will 0 
        //for (int i = 1; i <= m; i++)
        //{
        //    for (int j = 1; j <= n; j++)
        //    {
        //        if (i == 0 ||  j==0) 
        //        {
        //            dp[i, j] = 0;
        //        }


        // Fill the dp table using bottom-up approach
        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (s[i - 1] == t[j - 1]) // Characters match
                {
                    dp[i, j] = 1 + dp[i - 1, j - 1];
                }
                else // Characters don't match
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }

        // The bottom-right cell contains the length of the LCS
        return dp[m, n];
    }

    public static void Main(string[] args)
    {
        // Example strings
        string s = "abcde";
        string t = "ace";

        // Find the length of the longest common subsequence
        int result = LCSTable(s, t);

        Console.WriteLine($"Length of Longest Common Subsequence: {result}");
    }
}




