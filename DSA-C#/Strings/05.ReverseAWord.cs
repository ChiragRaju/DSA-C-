using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Strings
{

    class ReverseWordsInString
    {
        public static void Main(string[] args)
        {
            string s = "The sky is blue";
            string result = ReverseWords(s);
            Console.WriteLine(result); // Output: "blue is sky The"
        }

        public static string ReverseWords(string s)
        {
            // Step 1: Trim the string and split by spaces
            string[] words = s.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Step 2: Create a StringBuilder to store the reversed words
            StringBuilder reverseBuilder = new StringBuilder();

            // Step 3: Loop through the words array in reverse order
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reverseBuilder.Append(words[i]);  // Append the word

                // Append a space if it's not the last word
                if (i != 0)
                {
                    reverseBuilder.Append(" ");
                }
            }

            // Step 4: Convert StringBuilder to string and return
            return reverseBuilder.ToString();
        }
    }

}
