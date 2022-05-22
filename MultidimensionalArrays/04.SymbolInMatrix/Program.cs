using System;
using System.Linq;

namespace _04.SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());
            char[,] matrix = new char[dimensions, dimensions];

            for (int row = 0; row < dimensions; row++)
            {
                string line = Console.ReadLine();
                char[] charLine = line.ToCharArray();
                for (int col = 0; col < dimensions; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            char searchedSymbol = Console.ReadLine()[0];
            bool symbolIsFound = false;
            bool secondBrake = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == searchedSymbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        symbolIsFound = true;
                        secondBrake = true;
                        break;
                        
                    }
                }
                if (secondBrake == true)
                {
                    break;
                }
            }

            if (symbolIsFound == false)
            {
                Console.WriteLine($"{searchedSymbol} does not occur in the matrix");
            }


        }
    }
}
