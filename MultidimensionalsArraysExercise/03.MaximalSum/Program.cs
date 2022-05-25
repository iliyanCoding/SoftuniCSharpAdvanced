using System;
using System.Linq;

namespace _03.MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[,] matrix = new int[dimensions[0], dimensions[1]];
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = line[col];
                }
            }

            long maxSum = long.MinValue;
            string bestMatrix = string.Empty;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    long currSum = matrix[row, col] +
                        matrix[row, col + 1] +
                        matrix[row, col + 2] +
                        matrix[row + 1, col] +
                        matrix[row + 1, col + 1] +
                        matrix[row + 1, col + 2] +
                        matrix[row + 2, col] +
                        matrix[row + 2, col + 1] +
                        matrix[row + 2, col + 2];

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        bestMatrix = matrix[row, col] + " " + matrix[row, col + 1] + " " + matrix[row, col + 2] + "\r\n" +
                            matrix[row + 1, col] + " " + matrix[row + 1, col + 1] + " " + matrix[row + 1, col + 2] + "\r\n" +
                            matrix[row + 2, col] + " " + matrix[row + 2, col + 1] + " " + matrix[row + 2, col + 2] + "\r\n";
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine(bestMatrix);
        }
    }
}
