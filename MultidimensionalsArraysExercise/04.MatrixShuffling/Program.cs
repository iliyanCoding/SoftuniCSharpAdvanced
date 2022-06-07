using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[,] matrix = new string[dimensions[0], dimensions[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');
                bool isCommandValid = false;
                if (command[0] == "swap" && command.Length == 5)
                {
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);

                    if (row1 < matrix.GetLength(0) && col1 < matrix.GetLength(1) &&
                        row2 < matrix.GetLength(0) && col2 < matrix.GetLength(1))
                    {
                        string bucket = string.Empty;
                        bucket = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = bucket;

                        isCommandValid = true;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }

                if (command[0] == "END")
                {
                    break;
                }

                if (isCommandValid == false)
                {
                    Console.WriteLine("Invalid input!");
                }

            }
        }
    }
}
