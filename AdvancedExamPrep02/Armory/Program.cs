using System;
using System.Collections.Generic;
using System.Linq;

namespace TrufleHunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dimension = int.Parse(Console.ReadLine());
            char[,] matrix = new char[dimension, dimension];
            Dictionary<char, int> truflesDictionary = new Dictionary<char, int>()
            {
                { 'B', 0 },
                { 'S', 0 },
                { 'W', 0 },
            
            };
            for (int row = 0; row < dimension; row++)
            {
                char[] line = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int col = 0; col < dimension; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int eated = 0;

            while (true)
            {
                string[] commandArgs = Console.ReadLine().Split(' ');
                if (commandArgs[0] == "Collect")
                {
                    int newRow = int.Parse(commandArgs[1]);
                    int newCol = int.Parse(commandArgs[2]);
                    Collect(newRow, newCol, matrix, truflesDictionary);
                }
                else if (commandArgs[0] == "Wild_Boar")
                {
                    int newRow = int.Parse(commandArgs[1]);
                    int newCol = int.Parse(commandArgs[2]);
                    string direction = commandArgs[3];
                    switch (direction)
                    {
                        case "up":
                            while (IsRowValid(newRow, matrix))
                            {
                                if (BoarIsEating(newRow, newCol, matrix, truflesDictionary))
                                {
                                    eated++;
                                }
                                newRow += 2;
                            }
                            break;
                            
                        case "down":
                            while (IsRowValid(newRow, matrix))
                            {
                                if (BoarIsEating(newRow, newCol, matrix, truflesDictionary))
                                {
                                    eated++;
                                }
                                newRow -= 2;
                            }
                            break;
                        case "left":

                            while (IsColValid(newRow, matrix))
                            {
                                if (BoarIsEating(newRow, newCol, matrix, truflesDictionary))
                                {
                                    eated++;
                                }
                                newCol -= 2;
                            }
                            break;


                        case "right":
                            while (IsColValid(newCol, matrix))
                            {
                                if (BoarIsEating(newRow, newCol, matrix, truflesDictionary))
                                {
                                    eated++;
                                }
                                newCol += 2;
                            }
                            break;
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"Peter manages to harvest {truflesDictionary['B']} black, {truflesDictionary['S']} summer, and { truflesDictionary['W']} white truffles.");
            Console.WriteLine($"The wild boar has eaten {eated} truffles.");
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsRowValid(int row, char[,] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0);
        }
        private static bool IsColValid(int col, char[,] matrix)
        {
            return col >= 0 && col < matrix.GetLength(1);
        }

        static void Collect(int row, int col, char[,] matrix, Dictionary<char, int> truflesDictionary)
        {
                if (truflesDictionary.ContainsKey(matrix[row, col]))
                {
                    truflesDictionary[matrix[row, col]]++;
                    matrix[row, col] = '-';
                }
        }

        static bool BoarIsEating(int row, int col, char[,] matrix, Dictionary<char, int> truflesDictionary)
        {
            if (truflesDictionary.ContainsKey(matrix[row, col]))
            {
                matrix[row, col] = '-';
                return true;
            }
            return false;
        }
    }
}
