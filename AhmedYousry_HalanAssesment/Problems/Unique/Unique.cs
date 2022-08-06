using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace HalanAssesment.Problems.Unique
{
    static class Unique
    {
        static string[] input = { "apples", "oranges", "flowers", "apples" };

        public static void RunUniqueProblem()
        {
            Console.Write("\nInput array is : \n[");
            foreach (var str in input)
            {
                Console.Write(str);
                Console.Write(",");
            }
            Console.Write("\b");
            Console.Write("]\n");

            SortedDictionary<string, bool> resultDictionary = new SortedDictionary<string, bool>();
            // To handle if an entry is repeated n times where n is odd and n > 2
            List<string> forbiddenWords = new List<string>();
            List<string> result = new List<string>();
            foreach (string input in input)
            {
                if (!resultDictionary.ContainsKey(input) && !forbiddenWords.Contains(input))
                {
                    resultDictionary[input] = true;
                }
                else
                {
                    resultDictionary.Remove(input);
                    forbiddenWords.Add(input);
                }
            }
            Console.Write("\nOutput array is : \n");
            Console.Write("[");
            foreach (var keyValuePair in resultDictionary)
            {
                Console.Write(keyValuePair.Key);
                Console.Write(",");
            }
            Console.Write("\b");
            Console.Write("]\n");
            return;
        }

    }
}
