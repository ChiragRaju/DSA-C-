using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Strings
{
    public class _10
    {
        public static int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            int length = 0;
            bool foundChar = false;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    foundChar = true;
                    length++;
                }
                else if (foundChar)
                {
                    break; // Stop counting when we hit a space after finding the last word
                }
            }
            return length;
        }

        // using array split trim
        public static int LengthOfLastWordUsingSplit(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            string[] words = s.Trim().Split(' ');
            return words.Length > 0 ? words[words.Length - 1].Length : 0;
        }
    }
}
