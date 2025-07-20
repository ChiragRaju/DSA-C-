using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA_C_.SlidingWindow
{
//    You are given a string s and an integer k.You can choose any character of the string and change it to any other uppercase English character. You can perform this operation at most k times.
//    Return the length of the longest substring containing the same letter you can get after performing the above operations.



//Example 1:

//Input: s = "ABAB", k = 2
//Output: 4
//Explanation: Replace the two 'A's with two 'B's or vice versa.
//Example 2:

//Input: s = "AABABBA", k = 1
//Output: 4
//Explanation: Replace the one 'A' in the middle with 'B' and form "AABBBBA".
//The substring "BBBB" has the longest repeating letters, which is 4.You are given a string s and an integer k.You can choose any character of the string and change it to any other uppercase English character. You can perform this operation at most k times.
//    Return the length of the longest substring containing the same letter you can get after performing the above operations.



//Example 1:

//Input: s = "ABAB", k = 2
//Output: 4
//Explanation: Replace the two 'A's with two 'B's or vice versa.
//Example 2:

//Input: s = "AABABBA", k = 1
//Output: 4
//Explanation: Replace the one 'A' in the middle with 'B' and form "AABBBBA".
//The substring "BBBB" has the longest repeating letters, which is 4.
    public class _05
    {

        public static void Main(string[] args)
        {
            string s = "AABABBA";
            int k = 2;
            int result = LongestSubstringAfterReplacement(s, k);
            Console.WriteLine($"The length of the longest substring after replacement is: {result}");
        }
        public static int LongestSubstringAfterReplacement(string s, int k)
        {
            var charCount = new Dictionary<char, int>();
            int maxFreq = 0;
            int left = 0;
            int maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                char currentChar = s[right];

                if (!charCount.ContainsKey(currentChar))
                {
                    charCount[currentChar] = 0;
                }
                charCount[currentChar]++;

                // Track the count of the most frequent character in current window
                maxFreq = Math.Max(maxFreq, charCount[currentChar]);

                // If remaining chars to make all same > k, shrink window
                if ((right - left + 1) - maxFreq > k)
                {
                    charCount[s[left]]--;
                    left++;
                }

                // Update maxLength
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}



