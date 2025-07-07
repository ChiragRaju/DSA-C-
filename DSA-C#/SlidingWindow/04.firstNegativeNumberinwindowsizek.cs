using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.SlidingWindow
{
    public class firstNegativeNumberinwindowsizek
    {
        
        public static void firstMain()
        {
            int[] arr = { };
            int k = 3;
            var list = FirstNegativeNumber(arr, k);
            int count = 0;
            foreach(var num in list)
            {
                if (num != 0)
                count++;
            }
            Console.WriteLine(count);
        }
        //public static List<int> FirstNegativeNumber(int[] arr, int k)
        //{
        //    //bruteforce approach
        //    var list = new List<int>();
        //    int n=arr.Length;
        //    for (int i = 0; i < arr.Length-k; i++)
        //    {
        //        int firstNegative = 0;
        //        int j = i;
        //        while(j<i+k-1)
        //        {
        //            if(arr[j]<=0)
        //            {
        //                firstNegative = arr[j];
        //                break;
        //            }
        //            j++;
        //        }
        //        list.Add(firstNegative);
                
        //    }
        //    return list;
        //}

        //optimal approach using sliding window
        // how to solve any sliding window 
        //first run the j loop and calculate outside if condition

        public static List<int> FirstNegativeNumber(int[] arr, int k)
        {
            var result = new List<int>();
            var queue = new Queue<int>();
            int left = 0;
            for (int right = 0; right < arr.Length; right++)
            {
                if(arr[right] < 0)
                {
                    queue.Enqueue(right);
                }
                if(right-left+1==k)
                {
                    if(queue.Count>0 && queue.Peek()>=left)
                    {
                        result.Add(arr[queue.Peek()]);
                    }
                }
                else
                {
                    result.Add(0);
                }
                left++;
            }
            return result;

        }


    }
}
