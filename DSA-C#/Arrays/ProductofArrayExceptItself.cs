using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Arrays
{
    public class ProductofArrayExceptItself
    {
        public static int[] ProductofArrayExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] leftProducts = new int[n];
            int[] rightProducts = new int[n];
            int[] result = new int[n];
            // Calculate left products
            leftProducts[0] = 1;
            for (int i = 1; i < n; i++)
            {
                leftProducts[i] = leftProducts[i - 1] * nums[i - 1];
            }
            // Calculate right products
            rightProducts[n - 1] = 1;
            for (int i = n - 2; i >= 0; i--)
            {
                rightProducts[i] = rightProducts[i + 1] * nums[i + 1];
            }
            // Calculate result
            for (int i = 0; i < n; i++)
            {
                result[i] = leftProducts[i] * rightProducts[i];
            }
            return result;
        }

        //optimal solution
        public static int[] ProductofArrayExceptSelfOptimal(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            result[0] = 1;
            // Calculate left products
            for (int i = 1; i < n; i++)
            {
                result[i] = result[i - 1] * nums[i - 1];
            }
            int rightProduct = 1;
            // Calculate right products and multiply with left products
            for (int i = n - 1; i >= 0; i--)
            {
                result[i] *= rightProduct;
                rightProduct *= nums[i];
            }
            return result;
        }
    }
}
