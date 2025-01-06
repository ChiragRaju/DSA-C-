using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Arrays
{
    internal class UnionOfTwoArrays
    {
        public class UnionOptimal
        {
            // Method to find the union of two arrays
            public static HashSet<int> FindUnion(int[] arr1, int[] arr2)
            {
                HashSet<int> unionSet = new HashSet<int>(); // Initialize the HashSet

                // Add elements from the first array
                foreach (int num in arr1)
                {
                    unionSet.Add(num);
                }

                // Add elements from the second array
                foreach (int num in arr2)
                {
                    unionSet.Add(num);
                }

                return unionSet; // Return the union set
            }

            public static void Main(string[] args)
            {
                int[] arr1 = { 1, 2, 3, 4, 5 };
                int[] arr2 = { 3, 4, 5, 6, 7 };

                // Call the FindUnion method and store the result
                HashSet<int> unionSet = FindUnion(arr1, arr2);

                // Output result
                Console.WriteLine("Union of two arrays: " + string.Join(", ", unionSet));
            }
        }

    }
}

