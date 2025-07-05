using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Strings
{
    internal class UniqueOccurance
    {

public class UniqueOccurrences
    {
        public static void Main(string[] args)
        {
            // Input string
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            // Count character occurrences
            var frequencyMap = CountCharacterOccurrences(input);

            // Print character frequencies
            Console.WriteLine("\nCharacter Frequencies:");
            foreach (var pair in frequencyMap)
            {
                Console.WriteLine($"Character '{pair.Key}': {pair.Value} occurrence(s)");
            }

            // Check if occurrences are unique
            bool isUnique = HasUniqueOccurrences(frequencyMap);

            // Display the result
            Console.WriteLine($"\nThe string has unique character occurrences: {isUnique}");
        }

        // Method to count character occurrences
        public static Dictionary<char, int> CountCharacterOccurrences(string input)
        {
            Dictionary<char, int> frequencyMap = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (frequencyMap.ContainsKey(c))
                {
                    frequencyMap[c]++;
                }
                else
                {
                    frequencyMap[c] = 1;
                }
            }

            return frequencyMap;
        }

        // Method to check for unique occurrences
        public static bool HasUniqueOccurrences(Dictionary<char, int> frequencyMap)
        {
            HashSet<int> uniqueFrequencies = new HashSet<int>();

            foreach (var frequency in frequencyMap.Values)
            {
                if (uniqueFrequencies.Contains(frequency))
                {
                    return false; // Duplicate frequency found
                }
                uniqueFrequencies.Add(frequency);
            }

            return true; // All frequencies are unique
        }
    }

}
}
