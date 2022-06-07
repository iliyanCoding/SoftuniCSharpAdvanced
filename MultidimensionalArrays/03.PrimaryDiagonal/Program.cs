using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());

            int[,] matrix = new int[dimensions, dimensions];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = line[cols];
                }
            }

            int sumOfDiagonals = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                sumOfDiagonals += matrix[rows, rows];
            }
            Console.WriteLine(sumOfDiagonals);
        }
    }
}
