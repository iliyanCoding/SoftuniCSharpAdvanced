using System;
using System.Linq;

namespace _06.JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int[rowsCount][];
            for (int rows = 0; rows < rowsCount; rows++)
            {
                jaggedArr[rows] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');
                if (command[0] == "END")
                {
                    break;
                }
                else if (command[0] == "Add")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if (row >= 0 && row < jaggedArr.Length && col >= 0 && col < jaggedArr[row].Length)
                    {
                        jaggedArr[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (command[0] == "Subtract")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if (row >= 0 && row < jaggedArr.Length && col >= 0 && col < jaggedArr[row].Length)
                    {
                        jaggedArr[row][col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
            }

            foreach (int[] row in jaggedArr)
            {
                Console.WriteLine(string.Join(' ', row));
            }
        }
    }
}
