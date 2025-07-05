using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.SlidingWindow
{
    public class MaximumSubarrayWithSizeK
    {
        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int k = 9;
            int result = MaxSubarrayWithSizeK(nums, k);
            Console.WriteLine($"The maximum length of subarray with sum {k} is: {result}");
        }
        public static int maxSubarrayWithSizeK(int[] arr, int k)
        {
            int left = 0;
            int right = 0;
            int maxSubbarray = 0;
            int sum = 0;
            while (right < arr.Length)
            {
                 sum+= arr[right];
                if (right - left + 1 < k)
                {
                    right++;
                }
                else if (right - left + 1 == k)
                {
                    maxSubbarray = Math.Max(maxSubbarray, sum);
                    sum -= arr[left];
                    left++;
                    right++;

                }

            }
            return maxSubbarray;
        }
        public static int MaxSubarrayWithSizeK(int[] arr, int k)
        {
            if (arr.Length < k)
                throw new ArgumentException("Window size k is larger than the array length.");

            int maxSum = 0;
            int windowSum = 0;

            // Step 1: Sum of the first window
            for (int i = 0; i < k; i++)
            {
                windowSum += arr[i];
            }

            maxSum = windowSum;

            // Step 2: Slide the window
            for (int i = k; i < arr.Length; i++)
            {
                windowSum += arr[i];       // Add the element coming in
                windowSum -= arr[i - k];   // Remove the element going out
                maxSum = Math.Max(maxSum, windowSum);
            }

            return maxSum;
        }

    }
}
