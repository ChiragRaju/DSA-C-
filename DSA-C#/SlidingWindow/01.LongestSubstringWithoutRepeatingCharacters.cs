using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.SlidingWindow
{

    //input s = "abcabcbb"
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public static void main(string[] args)
        {
            string s = "abcabcbb";
            int result = LongestSubstring(s);
            Console.WriteLine($"The length of the longest substring without repeating characters in '{s}' is: {result}");

        }

        public static int LongestSubstring(string s)
        {
            int maxLength = 0;
            int left = 0;
            var dict = new Dictionary<char, int>();

            for (int r = 0; r < s.Length; r++)
            {
                char currentChar = s[r];

                // if (dict.ContainsKey(currentChar) && dict[currentChar] >= left)
                //{
                //    left = dict[currentChar] + 1;
                //}

                //use this or that 

                if (dict.TryGetValue(currentChar, out int value) && value >= left)
                {
                    left = value + 1;
                }

                dict[currentChar] = r;

                int currLength = r - left + 1;
                maxLength = Math.Max(maxLength, currLength);
            }

            return maxLength;

        }

    }
}
