using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Basics
{
    public class primeNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find all prime numbers up to that number:");
            int n = Convert.ToInt32(Console.ReadLine());
            PrintPrimesUpTo(n);
        }
        public static void PrintPrimesUpTo(int n)
        {
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

    }
}
