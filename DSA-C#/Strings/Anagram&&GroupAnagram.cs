using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DSA_C_.Strings
{
    internal class Anagram__GroupAnagram
    {   //Anagram
        public bool IsAnagram(string s, string t)
        {
            // Convert strings to character arrays
            char[] s1 = s.ToCharArray();
            char[] s2 = t.ToCharArray();

            // Sort the character arrays
            Array.Sort(s1);
            Array.Sort(s2);

            // Compare lengths first
            if (s1.Length != s2.Length)
            {
                return false;
            }

            // Compare sorted arrays
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    return false;
                }
            }

            return true;
        }

        // Group Anagram
        //Input: strs = ["eat","tea","tan","ate","nat","bat"]

        //Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            // Dictionary to store grouped anagrams
            var map = new Dictionary<string, List<string>>();

            foreach (string word in strs)
            {
                // Convert the word to a character array and sort it
                char[] chars = word.ToCharArray();
                Array.Sort(chars);
                string sortedWord = new string(chars);

                // Check if the sorted word exists as a key in the dictionary
                if (!map.ContainsKey(sortedWord))
                {
                    map[sortedWord] = new List<string>();
                }

                // Add the original word to the corresponding group
                map[sortedWord].Add(word);
            }

            // Return the grouped anagrams as a list of lists
            return new List<IList<string>>(map.Values);
        }
        public static void Main()
        {

            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            var result = GroupAnagrams(strs);

            foreach (var group in result)
            {
                Console.WriteLine("[" + string.Join(", ", group) + "]");
            }
        }
    }
}


   


//DRY RUN 
//Step-by-Step Execution:
//Initialize:

//Create an empty dictionary map where the key is a sorted string, and the value is a List<string> of anagrams.
//First Iteration (word = "eat"):

//Convert "eat" to a character array: ['e', 'a', 't'].
//Sort the character array: ['a', 'e', 't'].
//Convert it back to a string: "aet".
//Check if "aet" exists in map. It does not.
//Add a new entry to map: {"aet": ["eat"]}.
//Second Iteration (word = "tea"):

//Convert "tea" to a character array: ['t', 'e', 'a'].
//Sort the character array: ['a', 'e', 't'].
//Convert it back to a string: "aet".
//Check if "aet" exists in map. It does.
//Add "tea" to the list: {"aet": ["eat", "tea"]}.
//Third Iteration (word = "tan"):

//Convert "tan" to a character array: ['t', 'a', 'n'].
//Sort the character array: ['a', 'n', 't'].
//Convert it back to a string: "ant".
//Check if "ant" exists in map. It does not.
//Add a new entry to map: {"aet": ["eat", "tea"], "ant": ["tan"]}.
//Fourth Iteration (word = "ate"):

//Convert "ate" to a character array: ['a', 't', 'e'].
//Sort the character array: ['a', 'e', 't'].
//Convert it back to a string: "aet".
//Check if "aet" exists in map. It does.
//Add "ate" to the list: {"aet": ["eat", "tea", "ate"], "ant": ["tan"]}.
//Fifth Iteration (word = "nat"):

//Convert "nat" to a character array: ['n', 'a', 't'].
//Sort the character array: ['a', 'n', 't'].
//Convert it back to a string: "ant".
//Check if "ant" exists in map. It does.
//Add "nat" to the list: {"aet": ["eat", "tea", "ate"], "ant": ["tan", "nat"]}.
//Sixth Iteration (word = "bat"):

//Convert "bat" to a character array: ['b', 'a', 't'].
//Sort the character array: ['a', 'b', 't'].
//Convert it back to a string: "abt".
//Check if "abt" exists in map. It does not.
//Add a new entry to map: {"aet": ["eat", "tea", "ate"], "ant": ["tan", "nat"], "abt": ["bat"]}
 

