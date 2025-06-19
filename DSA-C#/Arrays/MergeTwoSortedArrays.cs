using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Arrays
{
    public class MergeTwoSortedArrays
    {

        public static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3; // Number of initialized elements in nums1
            int[] nums2 = { 2, 5, 6 };
            int n = 3; // Number of initialized elements in nums2

            var merge=new MergeTwoSortedArrays();
            merge.MergeSortedArray(nums1, m, nums2, n);
            Console.WriteLine("Merged array: " + string.Join(", ", nums1));

        }
        public void MergeSortedArray(int[] nums1,int m,int[] nums2,int n)
        {
            // Initialize pointers for nums1 and nums2
            int i = m - 1; // Last element of nums1
            int j = n - 1; // Last element of nums2
            int k = m + n - 1; // Last position in merged array
            // Merge the arrays from the end
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                k--;
            }
            // If there are remaining elements in nums2, copy them
            while (j >= 0)
            {
                nums1[k] = nums2[j];
                j--;
                k--;
            }
            
        }

    }
}
