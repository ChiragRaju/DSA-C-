using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DSA_C_.Basics
{
    public class ReversePallindromeNumber
    {
        public static bool isPalindrome(int num)
        {
            int originalNum = num;  // Store the original number
            int reversedNum = 0;

            // Reverse the number
            while (num != 0)
            {
                int lastDigit = num % 10;  // Get the last digit
                reversedNum = reversedNum * 10 + lastDigit;  // Build the reversed number
                num = num / 10;  // Remove the last digit from the original number
            }

            // Compare the original number with the reversed number
            return originalNum == reversedNum;
        }

        // Main function to test the palindrome checker
        public static void Main(string[] args)
        {
            int num = 1234;

            // Check if the number is a palindrome
            if (isPalindrome(num))
            {
                Console.WriteLine(num + " is a palindrome.");
            }
            else
            {
                Console.WriteLine(num + " is not a palindrome.");
            }
        }

    }
}
