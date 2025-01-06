using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Arrays
{
    internal class MostFrequentEle
    {
        public static void Main(string[] args)
        {
            // Correct array declaration
            int[] arr = { 3, 4, 5, 5, 5 };

            // Get the frequency map
            Dictionary<int, int> result = Frequency(arr);

            // Display the most frequent element and its frequency
            int highestFrequency = 0;
            int mostFrequentElement = arr[0];

            foreach (var entry in result)
            {
                if (entry.Value > highestFrequency)
                {
                    highestFrequency = entry.Value;
                    mostFrequentElement = entry.Key;
                }
            }

            Console.WriteLine("Most frequent element: " + mostFrequentElement + ", Frequency: " + highestFrequency);
        }

        // Correct method signature and body
        public static Dictionary<int, int> Frequency(int[] arr)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            return frequencyMap; // Return the frequency map
        }
    }

}

