using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.DP
{
    internal class LongestCommonSubstring
    {
        public static int LCSTable(string s, string t)
        {
            int m = s.Length;
            int n = t.Length;

            // Initialize the dp table
            int[,] dp = new int[m + 1, n + 1];
            int maxLength = 0;  // To store the maximum length of common substring

            // Fill the dp table using bottom-up approach
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (s[i - 1] == t[j - 1]) // Characters match
                    {
                        dp[i, j] = 1 + dp[i - 1, j - 1]; // Extend the current common substring
                        maxLength = Math.Max(maxLength, dp[i, j]); // Update max length
                    }
                    else
                    {
                        dp[i, j] = 0; // Reset if characters don't match
                    }
                }
            }

            // Return the length of the longest common substring
            return maxLength;
        }

        public static void Main(string[] args)
        {
            // Example strings
            string s = "abcde";
            string t = "ace";

            // Find the length of the longest common substring
            int result = LCSTable(s, t);

            Console.WriteLine($"Length of Longest Common Substring: {result}");
        }
    }
}
