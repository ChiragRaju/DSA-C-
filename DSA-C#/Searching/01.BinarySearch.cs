using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Searching
{
    internal class BinarySearch
    {
        public static void main(String[] args)
        {
            int[] arr = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
            int target = 23;
            int result = binarySearch(arr, target);

            if (result != -1)
                Console.WriteLine("Element found at index: " + result);
        else
                Console.WriteLine("Element not found.");
        }

        // Binary Search function
        public static int binarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if the middle element is the target
                if (arr[mid] == target)
                    return mid;

                // If target is greater, ignore the left half
                if (arr[mid] < target)
                    left = mid + 1;

                // If target is smaller, ignore the right half
                else
                    right = mid - 1;
            }

            // Target is not present in the array
            return -1;
        }

    }
}
