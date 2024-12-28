using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Basics
{
    internal class Reverseanumorstring
    {
        public void ReverseString(char[] s)
        {
            int start = 0;
            int end = s.Length - 1;

            // Loop to reverse the array in place
            while (start < end)
            {
                char temp = s[start];
                s[start] = s[end];
                s[end] = temp;
                start++;
                end--;
            }
        }
    }
}
