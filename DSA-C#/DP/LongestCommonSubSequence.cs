using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.DP
{
    public class LongestCommonSubSequence
    {
        private static int LCSRecursive(int i, int j, string s, string t)
        {
           
            if (i < 0 || j < 0)
                return 0;
           
            if (s[i] == t[j])
                return 1 + LCSRecursive(i - 1, j - 1, s, t);

            return Math.Max(LCSRecursive(i - 1, j, s, t), LCSRecursive(i, j - 1, s, t));
        }
        public static int LCS(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
           
            return LCSRecursive(n - 1, m - 1, s, t);
        }

    }
}
