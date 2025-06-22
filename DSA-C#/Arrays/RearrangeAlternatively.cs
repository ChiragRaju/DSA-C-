using System;
using System.Collections.Generic;

namespace DSA_C_.Arrays
{

    // Rearrange an array such that positive and negative numbers are arranged alternatively.


    //Input:  arr[] = [1, 2, 3, -4, -1, 4]
    //Output: [-4, 1, -1, 2, 3, 4]

    

    public class RearrangeAlternatively
    {

        public static int[] Rearrange(int[] nums)
        {
            int[] arr = new int[nums.Length]; // Create array of required size
            int pos = 0;
            int neg = 1;

            foreach (int num in nums)
            {
                if (num < 0)
                {
                    if (neg < nums.Length)
                    {
                        arr[neg] = num;
                        neg += 2;
                    }
                }
                else
                {
                    if (pos < nums.Length)
                    {
                        arr[pos] = num;
                        pos += 2;
                    }
                }
            }

            return arr;
        }


        public static int[] RearrangeAlternativelyWithOrder(int[] arr)
        {
            List<int> positiveList = new List<int>();
            List<int> negativeList = new List<int>();

            // Separate positive and negative numbers
            foreach (int num in arr)
            {
                if (num >= 0)
                    positiveList.Add(num);
                else
                    negativeList.Add(num);
            }

            int pos = 0, neg = 0, i = 0;
            int[] result = new int[arr.Length];

            // Alternate positive and negative
            while (pos < positiveList.Count && neg < negativeList.Count)
            {
                result[i++] = negativeList[neg++];
                result[i++] = positiveList[pos++];
            }

            // Add remaining negatives
            while (neg < negativeList.Count)
                result[i++] = negativeList[neg++];

            // Add remaining positives
            while (pos < positiveList.Count)
                result[i++] = positiveList[pos++];

            return result;
        }




        // Example usage
        public static void Main()
        {
            int[] arr = { 1, 2, 3, -4, -1, 4 };
            int[] result = RearrangeAlternativelyWithOrder(arr);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
