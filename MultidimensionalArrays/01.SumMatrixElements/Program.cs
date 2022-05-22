using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int columns = dimensions[1];

            int[,] matrix = new int[dimensions[0], dimensions[1]];
            for (int i = 0; i < matrix.GetLength(0); i++)
            { 
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            int matrixSum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixSum += matrix[i, j];
                }
                
            }

            Console.WriteLine(rows);
            Console.WriteLine(columns);
            Console.WriteLine(matrixSum);
        }
    }
}
