using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Arrays
{
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSum = int.MinValue;
            int currSum = 0;

            foreach (int num in nums)
            {
                currSum += num;
                maxSum = Math.Max(maxSum, currSum);

                if (currSum < 0)
                {
                    currSum = 0;
                }
            }

            return maxSum;
        }
    }

}
