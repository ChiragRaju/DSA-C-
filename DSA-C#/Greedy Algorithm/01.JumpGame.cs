using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Greedy_Algorithm
{
    public class JumpGame
    {
        public static void Main(string[] args)
        {
            int[] nums = { 2, 3, 1, 1, 4 };
            bool canJump = CanJump(nums);
            Console.WriteLine($"Can jump to the last index: {canJump}");
        }
        public static bool CanJump(int[] nums)
        {
            int maxReach = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > maxReach) return false; // If we can't reach this index, return false
                maxReach = Math.Max(maxReach, i + nums[i]); // Update the maximum reachable index
                if (maxReach >= nums.Length-1)
                {
                   return true; // If we can reach or exceed the last index, return true
                }

               
            }
            return true; // If we can reach the last index, return true
        }
    }
}
