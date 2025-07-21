using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Greedy_Algorithm
{
    public class _05
    {
        // Greedy Algorithm to find the minimum number of platforms required in a railway station
        // Given two arrays arrival and departure, where arrival[i] is the arrival time of the i-th train and departure[i] is the departure time of the i-th train.
        // Input:
        // int[] arrival = { 1000, 1015, 1020, 1030, 1045 };
        // int[] departure = { 1010, 1025, 1035, 1040, 1050 };
        // Output:
        // Minimum number of platforms required: 3

        
        public static void Main(string[] args)
        {
            int[] arrival = { 1000, 1015, 1020, 1030, 1045 };
            int[] departure = { 1010, 1025, 1035, 1040, 1050 };
            int platformsNeeded = FindMinimumPlatforms(arrival, departure);
            Console.WriteLine($"Minimum number of platforms required: {platformsNeeded}");
        }
        public static int FindMinimumPlatforms(int[] arrival, int[] departure)
        {
            Array.Sort(arrival);
            Array.Sort(departure);
            int platformNeeded = 1;
            int maxPlatforms = 1;
            int i = 1, j = 0;
            while (i < arrival.Length && j < departure.Length)
            {
                if (arrival[i] <= departure[j])
                {
                    platformNeeded++;
                    i++;
                }
                else
                {
                    platformNeeded--;
                    j++;
                }
                maxPlatforms = Math.Max(maxPlatforms, platformNeeded);
            }
            return maxPlatforms;
        }
    }
}
