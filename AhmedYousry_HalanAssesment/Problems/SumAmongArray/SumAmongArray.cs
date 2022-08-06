using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HalanAssesment.Problems.SumAmongArray
{
    static class SumAmongArray
    {
        public static int?[] input = { 1, 2, 5, 6, 4, 11 };
        //public static int?[] input = { 1, 2, 5, 6, 4, -11, 12, 14, -10 };
        //public static int?[] input = { 1, 1, 1, 1, 1, 1 };
        public static void GetSumAmongArray(int?[] array)
        {
            Console.Write("\nInput Array : \n[");
            foreach (var num in input)
            {
                Console.Write(num);
                Console.Write(',');
            }
            Console.Write("\b");
            Console.Write("]\n");

            var biggestElementIndex = GetIndexOfBiggestElement(array);
            array[biggestElementIndex] = null;
            var secondBiggestElement = GetIndexOfBiggestElement(array);
            Console.WriteLine("\nMax: [" + biggestElementIndex + ',' + secondBiggestElement + "]\n");


            var smallestElementIndex = GetIndexOfSmallestElement(array);
            array[smallestElementIndex] = null;
            var secondsmallestElement = GetIndexOfSmallestElement(array);
            Console.WriteLine("\nMin: [" + smallestElementIndex + ',' + secondsmallestElement + "]\n");
            return;
        }

        public static int GetIndexOfBiggestElement(int?[] array)
        {
            return array.ToList().IndexOf(array.Max());
        }
        public static int GetIndexOfSmallestElement(int?[] array)
        {
            return array.ToList().IndexOf(array.Min());
        }
    }
}
