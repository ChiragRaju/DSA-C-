using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Greedy_Algorithm
{
    // Greedy Algorithm to find the starting gas station index from which we can complete the circuit
    // Given two arrays gas and cost, where gas[i] is the amount of gas at station i and cost[i] is the cost to travel from station i to the next station.
    //input
    // int[] gas = { 1, 2, 3, 4, 5 };
    // int[] cost = { 3, 4, 5, 1, 2 };
    //output
    // The starting gas station index is: 3

    public class Gas_Station
    {
        public static void Main(string[] args)
        {
            int[] gas = { 1, 2, 3, 4, 5 };
            int[] cost = { 3, 4, 5, 1, 2 };
            int startIndex = CanCompleteCircuit(gas, cost);
            Console.WriteLine($"The starting gas station index is: {startIndex}");
        }
        public static int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int total_cost = 0;
            int total_gas = 0;
            for (int i = 0; i < gas.Length; i++)
            {
                total_gas += gas[i];
                total_cost += cost[i];
            }
            if (total_cost > total_gas)
            {
                return -1;
            }
            int start = 0;
            int currentGas = 0;
            for (int i = 0; i < gas.Length; i++)
            {
                currentGas += gas[i] - cost[i];
                if (currentGas < 0)
                {
                    currentGas = 0;
                    start = i + 1;
                }
            }
            return start;
        }
    }
}
