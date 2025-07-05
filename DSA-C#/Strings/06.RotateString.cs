using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Strings
{
    internal class RotateString
    {
//Example 1:
//Input: s = "abcde", goal = "cdeab"
//Output: true
//Example 2:

//Input: s = "abcde", goal = "abced"
//Output: false

        public bool RotatesString(string s, string goal)
        {
            return (s.Length == goal.Length && (s + s).Contains(goal));
        }
    }
}
