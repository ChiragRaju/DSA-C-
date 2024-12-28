using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Searching
{

    class HashSearchExample
    {
        static void Main(string[] args)
        {
            int[] arr = { 23, 12, 5, 67, 45, 65 };
            int target = 67;

            // Create a Dictionary to store the value as the key and index as the value
            Dictionary<int, int> hashMap = new Dictionary<int, int>();

            // Store all elements in the Dictionary
            for (int i = 0; i < arr.Length; i++)
            {
                hashMap[arr[i]] = i;
            }

            // Search for the target
            if (hashMap.ContainsKey(target))
            {
                Console.WriteLine("Element found at index: " + hashMap[target]);
            }
            else
            {
                Console.WriteLine("Element not found.");
            }
        }
    }

}
