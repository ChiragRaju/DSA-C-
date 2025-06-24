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

    }
}
