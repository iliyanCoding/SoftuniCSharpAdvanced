using System;
using System.Linq;

namespace _02.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[,] matrix = new string[dimensions[0], dimensions[1]];
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = line[col];
                }
            }

            int count = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] &&
                        matrix[row, col] == matrix[row + 1, col] &&
                        matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
    

