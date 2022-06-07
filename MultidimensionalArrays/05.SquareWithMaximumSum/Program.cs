using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[dimensions[0], dimensions[1]];
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = line[cols];
                }
            }

            long maxSum = long.MinValue;
            string bestSquare2x2 = string.Empty;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    long sum =
                        matrix[row, col] +
                        matrix[row, col + 1] +
                        matrix[row + 1, col] +
                        matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        bestSquare2x2 = matrix[row, col] + " " + matrix[row, col + 1] + "\r\n" + 
                        matrix[row + 1, col] + " " + matrix[row + 1, col + 1];

                    }
                }
            }

            Console.WriteLine(bestSquare2x2);
            Console.WriteLine(maxSum);
        }
    }
}
