using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Arrays
{
    public class RemoveElement
    {
        
            public int removeElement(int[] nums, int val)
            {
                int count = 0;
                int i = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] != val)
                    {
                        nums[i] = nums[j];
                        count++;
                        i++;
                    }
                }
                return count;
            }
        
    }
}
