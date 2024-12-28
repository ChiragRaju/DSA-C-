using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Strings
{
    internal class CheckPallindrome
    {
        public static bool IsPalindrome(string s)
        {
            // If the string is empty, it's considered a palindrome
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            int start = 0;
            int last = s.Length - 1;

            // Use two pointers to compare characters from both ends
            while (start <= last)
            {
                char currFirst = s[start];
                char currLast = s[last];

                // Ignore non-alphanumeric characters on both ends
                if (!char.IsLetterOrDigit(currFirst))
                {
                    start++;
                }
                else if (!char.IsLetterOrDigit(currLast))
                {
                    last--;
                }
                else
                {
                    // If the characters don't match (case-insensitive), it's not a palindrome
                    if (char.ToLower(currFirst) != char.ToLower(currLast))
                    {
                        return false;
                    }
                    // Move both pointers inward
                    start++;
                    last--;
                }
            }
            // If all characters matched, it's a palindrome
            return true;
        }

        // Main function to test the palindrome checker
        public static void Main(string[] args)
        {
           
            // Test cases
            string test1 = "A man, a plan, a canal, Panama";
            string test2 = "race a car";
            string test3 = " ";

            // Checking if each test case is a palindrome
            Console.WriteLine("\"" + test1 + "\" is a palindrome: " + IsPalindrome(test1));
            Console.WriteLine("\"" + test2 + "\" is a palindrome: " + IsPalindrome(test2));
            Console.WriteLine("\"" + test3 + "\" is a palindrome: " + IsPalindrome(test3));
        }

    }
}
