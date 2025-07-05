using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_.Arrays
{
    public class CountTriplet
    {
        public static int countTriplet(int[] triplets)
        {
            var set=new HashSet<int>();
            int count = 0;
            foreach(int num in triplets)
            {
                set.Add(num);

            }
            for(int i = 0; i < triplets.Length; i++)
            {
                for (int j = i + 1; j < triplets.Length; j++)
                {
                    int sum = triplets[i] + triplets[j];
                    if (set.Contains(sum))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
