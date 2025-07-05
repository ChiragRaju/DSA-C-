using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DSA_C_.Sorting
{
   public class BubbleSort
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 3, 4, 5, 6, 7, 8, 9, };

            // Call bubble sort on the entire array
            bubbleSort(arr);

            // Print the sorted array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }

        public static void bubbleSort(int[] arr)
        {
            bool didSwap;

            for (int i = arr.Length - 1; i > 0; i--)
            {
                didSwap = false;  // Reset didSwap to false before each pass

                // Loop through the unsorted part of the array
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap the adjacent elements
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                        didSwap = true;  // Set didSwap to true to indicate a swap occurred
                    }
                }

                // If no elements were swapped in the inner loop, the array is sorted
                if (!didSwap)
                {
                    break;
                }
            }
        }
    }

}
