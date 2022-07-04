using System;
using System.Linq;

namespace ExamPrepMatrixes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] armory = new char[size, size];
            int row = 0;
            int col = 0;
            int goldCoins = 0;
            bool isInBounds = true;
            for (int i = 0; i < size; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < size; j++)
                {
                    armory[i, j] = line[j];
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (armory[i, j] == 'A')
                    {
                        row = i;
                        col = j;
                    }
                }
            }

            while (goldCoins < 64 && IsInTheShop(row, col, armory))
            {
                string direction = Console.ReadLine();

                if (char.IsDigit(armory[row, col]))
                {
                    goldCoins += (int)armory[row, col];
                    armory[row, col] = '-';
                }
                else if (armory[row, col] == 'M')
                {
                    armory[row, col] = '-';
                    for (int i = 0; i < armory.GetLength(0); i++)
                    {
                        for (int j = 0; j < armory.GetLength(1); j++)
                        {
                            if (armory[i, j] == 'M')
                            {
                                row = i;
                                col = j;
                                armory[i, j] = '-';
                            }
                        }
                    }
                }
                switch (direction)
                {
                    case "up":
                        armory[row, col] = '-';
                        armory[row - 1, col] = 'A';
                        break;
                    case "down":
                        armory[row, col] = '-';
                        armory[row + 1, col] = 'A';
                        
                        break;
                    case "left":
                        armory[row, col] = '-';
                        armory[row , col - 1] = 'A';
                        break;
                    case "right":
                        armory[row, col] = '-';
                        armory[row, col + 1] = 'A';
                        break;

                }
            }

            if (IsInTheShop(row, col, armory))
            {
                Console.WriteLine("I do not need more swords!");
            }
            else if (goldCoins >= 65)
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
            }

            Console.WriteLine($"The king paid {goldCoins} gold coins.");

            PrintMatrix(row, col, armory);


        }

        private static bool IsInTheShop(int row, int col, char[,] armory)
        {
            return row >= 0 && row < armory.GetLength(0) && col >= 0 && col < armory.GetLength(1);
        }

        private static void PrintMatrix(int rows, int cols, char[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
