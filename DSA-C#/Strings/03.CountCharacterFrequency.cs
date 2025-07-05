using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Strings
{
    internal class CountCharacterFrequency
    {
      
public class CharacterFrequency
    {
        public static void Main(string[] args)
        {
            // Input string
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            // Call the method to count character occurrences
            Dictionary<char, int> charFrequency = CountCharacterOccurrences(input);

            // Display the results
            Console.WriteLine("Character frequencies:");
            foreach (var pair in charFrequency)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

        public static Dictionary<char, int> CountCharacterOccurrences(string input)
        {
            // Initialize the dictionary to store character frequencies
            Dictionary<char, int> frequencyMap = new Dictionary<char, int>();

            // Iterate over each character in the string
            foreach (char c in input)
            {
                if (frequencyMap.ContainsKey(c))
                {
                    // Increment the count if the character already exists in the dictionary
                    frequencyMap[c]++;
                }
                else
                {
                    // Add the character to the dictionary with an initial count of 1
                    frequencyMap[c] = 1;
                }
            }

            return frequencyMap; // Return the frequency map
        }
    }

}
}
