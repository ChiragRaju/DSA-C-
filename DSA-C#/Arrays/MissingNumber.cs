using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Arrays
{
    public class MissingNumber
    {
        //Input: arr[] = [1, 2, 3, 5]
        //Output: 4
        public static int FindMissingNumber(int[] arr)
        {
            int sum = 0;
            foreach(int num in arr)
            {
                sum+= num;

            }
            int n = arr.Length + 1;
            int expectedSum = n * (n + 1) / 2; 
            return expectedSum - sum;
        }
    }
}
