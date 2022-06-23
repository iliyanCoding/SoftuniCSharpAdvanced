using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BeaverAtWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int branchesCount = 0;
            int beaverPositionRow = 0;
            int beaverPositionCol = 0;
            int collectedBranches = 0;
            int dimension = int.Parse(Console.ReadLine());
            char[,] matrix = new char[dimension, dimension];
            for (int rows = 0; rows < dimension; rows++)
            {
                char[] line = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int cols = 0; cols < dimension; cols++)
                {
                    matrix[rows, cols] = line[cols];
                    if (matrix[rows, cols] == 'B')
                    {
                        beaverPositionRow = rows;
                        beaverPositionCol = cols;
                    }
                    else if (char.IsLower(matrix[rows, cols]))
                    {
                        branchesCount++;
                    }
                }
            }

            string command = Console.ReadLine();
            while (command == "end" && branchesCount > 0)
            {
                if (command == "up")
                {
                    if (char.IsLower(matrix[beaverPositionRow - 1, beaverPositionCol]))
                    {
                        collectedBranches++;
                    }
                }
                else if (command == "down")
                {

                }
                else if (command == "left")
                {

                }
                else if (command == "right")
                {

                }
            }
        }
    }
}
