using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Arrays
{
    internal class removeDuplicateeEle
    {

        class Program
        {
            static List<T> RemoveDuplicates<T>(T[] array)
            {
                // Convert array to list for processing


                // Create a new list to store unique elements
                List<T> uniqueList = new List<T>();

                // Loop through the input list
                foreach (T item in array)
                {
                    // If the item is not already in the uniqueList, add it
                    if (!uniqueList.Contains(item))
                    {
                        uniqueList.Add(item);
                    }
                }

                return uniqueList;
            }

            static void Main()
            {
                // Input array
                int[] numbers = new int[] { 1, 2, 2, 3, 4, 4, 5 };

                // Remove duplicates from array
                List<int> result = RemoveDuplicates(numbers);

                Console.WriteLine("Array after removing duplicates:");
                foreach (int number in result)
                {
                    Console.WriteLine(number);
                }
            }

        }
    }
}