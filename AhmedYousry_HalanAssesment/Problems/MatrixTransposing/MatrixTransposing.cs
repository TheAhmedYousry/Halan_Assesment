using System;
using System.Collections.Generic;
using System.Text;

namespace HalanAssesment.Problems.MatrixTransposing
{
    static class MatrixTransposing
    {
        //public static int[,] input = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
        // public static int[,] input = new int[,] { { 1, 2 }, { 3, 4 } };
        public static int[,] input = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 }, { 17, 18, 19, 20 } };
        //public static int[,] input = new int[,] { { }, { } };
        //public static int[,] input = new int[,] { { 1 }, { 4 } };
        public static int[,] Transpose(int[,] MatrixInput)
        {
            Console.WriteLine("Input Matrix:\n");
            for (int i = 0; i < MatrixInput.GetLength(0); i++)
            {
                for (int x = 0; x < MatrixInput.GetLength(1); x++)
                {
                    Console.Write(MatrixInput[i, x]);
                    Console.Write("\t");
                }
                Console.Write("\n");
            }

            int[,] result = new int[MatrixInput.GetLength(1), MatrixInput.GetLength(0)];
            for (int i = 0; i < MatrixInput.GetLength(0); i++)
            {
                for (int x = 0; x < MatrixInput.GetLength(1); x++)
                {
                    result[x, i] = MatrixInput[i, x];
                }
            }
            Console.WriteLine("\nOutput Matrix:\n");
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int x = 0; x < result.GetLength(1); x++)
                {
                    Console.Write(result[i, x]);
                    Console.Write("\t");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.ReadKey();
            return result;
        }
    }
}
