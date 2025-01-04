using System;
using DSA_C_.DP; 

class Program
{
    static void Main(string[] args)
    {
        //longest common subsequence
        string s = "abcde";
        string t = "ace";
        int n=s.Length;
        int m=t.Length;

        int result = LongestCommonSubSequence.LCSRecursive(s,t,n-1,m-1);

        Console.WriteLine($"Length of Longest Common Subsequence: {result}");

        Console.Write("Enter the Fibonacci number to calculate: ");
        int input = int.Parse(Console.ReadLine());  

        long results = Fibannacci.Fibonacci(input);
        Console.WriteLine($"Fibonacci({input}) = {results}");


    }
}
