using HalanAssesment.Problems.Palindrome;
using HalanAssesment.Problems.Unique;
using HalanAssesment.Problems.MatrixTransposing;
using HalanAssesment.Problems.SumAmongArray;
using System;
using System.Collections.Generic;
using System.IO;

namespace HalanAssesment
{
    class Program
    {
        static void Main(string[] args)
        {
            #region introduction -- not related to the problem :D
            string introduction = "Hello! This is the Halan Assesment.";
            Console.SetCursorPosition((Console.WindowWidth - introduction.Length) / 2, Console.CursorTop);
            Console.WriteLine(introduction);
            #endregion
            RunProgram();


        }
        public static void RunProgram()
        {
            Console.WriteLine("\nPlease select which problem you'd like to view?\n1) Palindrome Problem\n2) Unique strings out problem\n3) Matrix Transposing problem\n4) Sum Among Array\n5) Containers PseudoCode\n6) Buckets PseudoCode");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    {
                        Palindrome.RunPalindromeProblem();
                        break;
                    }
                case "2":
                    {
                        Unique.RunUniqueProblem();
                        break;
                    }
                case "3":
                    {
                        MatrixTransposing.Transpose(MatrixTransposing.input);
                        break;
                    }
                case "4":
                    {
                        SumAmongArray.GetSumAmongArray(SumAmongArray.input);
                        break;
                    }
                case "5":
                    {
                        var path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Problems\\Containers\\Containers.txt";
                        string text = System.IO.File.ReadAllText(path);
                        System.Console.WriteLine("\n{0}", text);
                        break;
                    }
                case "6":
                    {
                        var path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Problems\\Buckets\\Buckets.txt";
                        string text = System.IO.File.ReadAllText(path);
                        System.Console.WriteLine("\n{0}", text);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("\nPlease enter a valid problem number");
                        RunProgram();
                        break;
                    }
            }
            Console.WriteLine("\nWould you like to try another problem? (y/n)");
            input = Console.ReadLine();
            switch (input.ToString().ToLower())
            {
                case "y":
                    {
                        RunProgram();
                        break;
                    }
                case "n":
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("\nPlease enter a valid problem number");
                        RunProgram();
                        break;
                    }
            }
            return;
        }



    }
}
