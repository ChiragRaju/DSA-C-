using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Strings
{
    internal class FindFirstNonRepeaitingChar
    {
        public static void Main(string[] args)
        {
            // Input string
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            // Find the first non-repeated character
            char? result = FindFirstNonRepeatedCharacter(input);

            // Display the result
            if (result.HasValue)
            {
                Console.WriteLine($"The first non-repeated character is: '{result.Value}'");
            }
            else
            {
                Console.WriteLine("No non-repeated character found.");
            }
        }

        public static char? FindFirstNonRepeatedCharacter(string input)
        {
            // Dictionary to store character counts
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            // Count occurrences of each character
            foreach (char c in input)
            {
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts[c] = 1;
                }
            }

            // Find the first character with a count of 1
            foreach (char c in input)
            {
                if (charCounts[c] == 1)
                {
                    return c; // Return the first non-repeated character
                }
            }

            return null; // No non-repeated character found
        }
    }
}
