using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.SlidingWindow
{
    public  class MaximumSubaaraySumK
    {
        public static int MaxLenSubarraySumEqualsK_NonNegative(int[] arr, int k)
        {
            int left = 0, sum = 0, maxLen = 0;

            for (int right = 0; right < arr.Length; right++)
            {
                sum += arr[right];

                while (sum > k && left <= right)
                {
                    sum -= arr[left++];
                }

                if (sum == k)
                {
                    maxLen = Math.Max(maxLen, right - left + 1);
                }
            }

            return maxLen;
        }

        public static int MaxLenSubarraySumEqualsKWhile_NonNegative(int[] arr, int k)
        {
            int left = 0, right = 0;
            int sum = 0, maxLen = 0;

            while (right < arr.Length)
            {
                sum += arr[right];

                while (sum > k && left <= right)
                {
                    sum -= arr[left++];
                }

                if (sum == k)
                {
                    maxLen = Math.Max(maxLen, right - left + 1);
                }

                right++;
            }

            return maxLen;
        }


        //with negative numbers
        public static int MaxLenSubarraySumEqualsK_WithNegatives(int[] nums, int k)
        {
            var map = new Dictionary<int, int>(); // sum -> first index
            map[0] = -1;
            int sum = 0, maxLen = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (map.ContainsKey(sum - k))
                {
                    maxLen = Math.Max(maxLen, i - map[sum - k]);
                }

                // Only store the first occurrence
                if (!map.ContainsKey(sum))
                {
                    map[sum] = i;
                }
            }

            return maxLen;
        }


    }
}
