using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA_C_.Strings
{

    //    Given an array of characters chars, compress it using the following algorithm:

    //Begin with an empty string s.For each group of consecutive repeating characters in chars:

    //If the group's length is 1, append the character to s.
    //Otherwise, append the character followed by the group's length.
    //The compressed string s should not be returned separately, but instead, be stored in the input character array chars.Note that group lengths that are 10 or longer will be split into multiple characters in chars.
    //    After you are done modifying the input array, return the new length of the array.

    //You must write an algorithm that uses only constant extra space.




    //Example 1:

    //Input: chars = ["a", "a", "b", "b", "c", "c", "c"]
    //Output: Return 6, and the first 6 characters of the input array should be: ["a", "2", "b", "2", "c", "3"]
    //Explanation: The groups are "aa", "bb", and "ccc". This compresses to "a2b2c3".
    //Example 2:

    //Input: chars = ["a"]
    //Output: Return 1, and the first character of the input array should be: ["a"]
    //Explanation: The only group is "a", which remains uncompressed since it's a single character.
    //Example 3:

    //Input: chars = ["a", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b"]
    //Output: Return 4, and the first 4 characters of the input array should be: ["a", "b", "1", "2"].
    //Explanation: The groups are "a" and "bbbbbbbbbbbb". This compresses to "ab12".
    public class _11
    {
        public static int Compress(char[] chars)
        {
            var result = new StringBuilder();

            int i = 0;
            while (i < chars.Length)
            {
                char currentChar = chars[i];
                int count = 0;

                // Count consecutive characters
                while (i < chars.Length && chars[i] == currentChar)
                {
                    i++;
                    count++;
                }

                result.Append(currentChar);

                if (count > 1)
                {
                    result.Append(count.ToString()); // convert count to string
                }
            }

            // Now copy result back to chars[]
            for (int j = 0; j < result.Length; j++)
            {
                chars[j] = result[j];
            }

            return result.Length;
        }
        //public static int Compress(char[] chars)
        //{

        //    int j = 0; // write pointer
        //    int i = 0; // read pointer

        //    while (i < chars.Length)
        //    {
        //        char currentChar = chars[i];
        //        int count = 0;

        //        // Count how many times currentChar repeats
        //        while (i < chars.Length && chars[i] == currentChar)
        //        {
        //            i++;
        //            count++;
        //        }

        //        // Write the character
        //        chars[j++] = currentChar;

        //        // If count > 1, write each digit of count
        //        if (count > 1)
        //        {
        //            foreach (char c in count.ToString())
        //            {
        //                chars[j++] = c;
        //            }
        //        }
        //    }

        //    return j; // new length after compression
        //}
    }
}
