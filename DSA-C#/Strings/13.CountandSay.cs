using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Strings
{
    public class _13
    {
        public static void Mains(string[] args)
        {
            Console.WriteLine(CountAndSay(4)); // Output: "1211"
            Console.WriteLine(CountAndSay(5)); // Output: "111221"
        }
        public static string CountAndSay(int n)
        {
            if (n == 1)
                return "1";
            var Say = CountAndSay(n - 1);
            StringBuilder result = new StringBuilder();
            for(int i = 0; i < Say.Length; i++)
            {
                int count = 1;
                char currentChar = Say[i];
                while (i < Say.Length-1 && Say[i] == Say[i + 1])
                {
                    count++;
                    i++;
                }
                result.Append(count).Append(currentChar);

            }
            return result.ToString();


        }

    }
}
