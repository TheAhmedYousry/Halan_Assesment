using System;
using System.Collections.Generic;
using System.Text;

namespace HalanAssesment.Problems.Palindrome
{
    static class Palindrome
    {
        public static void RunPalindromeProblem()
        {
            Console.WriteLine("\nPlease enter the count of digits");
            string result = "";
            Stack<int> forReversing = new Stack<int>();
            int input;
            var randomGenerator = new Random();

            var _input = Console.ReadLine();
            try
            {
                input = int.Parse(_input);
            }
            catch
            {
                input = 0;
                Console.WriteLine("Invalid Input!");

            }
            if (input >= 19 || input <= 0)
            {
                Console.WriteLine("Input must be between 0 > && < 19");

            }
            var oneSideCount = input / 2;
            while ((result.Length <= oneSideCount && input % 2 != 0) || (result.Length < oneSideCount && input % 2 == 0))
            {
                int number = randomGenerator.Next(0, 9);
                if (result.Contains(number.ToString()))
                    number = randomGenerator.Next(0, 9);
                else
                {
                    result += number.ToString();
                    forReversing.Push(number);
                }
            }
            if (input % 2 != 0)
                forReversing.Pop();
            while (forReversing.Count > 0)
            {
                result += forReversing.Pop();
            }
            Console.WriteLine(result);
            return;
        }

    }

}

