using System;
using DSA_C_.DP; 

class Program
{
    static void Main(string[] args)
    {
        //longest common subsequence
        string s = "abcde";
        string t = "ace";

        int result = LongestCommonSubSequence.LCS(s, t);

        Console.WriteLine($"Length of Longest Common Subsequence: {result}");

        Console.Write("Enter the Fibonacci number to calculate: ");
        int n = int.Parse(Console.ReadLine());  

        long results = Fibannacci.Fibonacci(n);
        Console.WriteLine($"Fibonacci({n}) = {results}");


    }
}
