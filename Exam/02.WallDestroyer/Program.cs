using System;
using System.Linq;

namespace Wall_Derstroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wallSize = int.Parse(Console.ReadLine());
            char[,] wall = new char[wallSize, wallSize];
            int vRow = 0;
            int vCol = 0;
            for (int row = 0; row < wallSize; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int col = 0; col < wallSize; col++)
                {
                    wall[row, col] = line[col];
                    if (wall[row, col] == 'V')
                    {
                        vRow = row;
                        vCol = col;
                    }
                }
            }
            int holesCount = 0;
            int rodsHitted = 0;
            string direction = Console.ReadLine();
            bool cablesHitted = false;
            while (direction != "End")
            {
                if (direction == "up")
                {
                    if (vRow - 1 >= 0 && vRow - 1 <= wallSize)
                    {
                        if (wall[vRow - 1, vCol] == '-')
                        {
                            wall[vRow, vCol] = '*';
                            holesCount++;
                            vRow--;
                            wall[vRow, vCol] = 'V';
                        }
                        else if (wall[vRow - 1, vCol] == 'R')
                        {
                            rodsHitted++;
                            Console.WriteLine("Vanko hit a rod!");

                        }
                        else if (wall[vRow - 1, vCol] == 'C')
                        {
                            holesCount++;
                            wall[vRow, vCol] = '*';

                            cablesHitted = true;
                            wall[vRow - 1, vCol] = 'E';
                            holesCount++;
                            break;
                        }
                        else if (wall[vRow - 1, vCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{vRow - 1}, {vCol}]!");
                            wall[vRow, vCol] = '*';
                            vRow = vRow - 1;
                        }

                    }
                }
                else if (direction == "down")
                {
                    if (vRow + 1 >= 0 && vRow + 1 <= wallSize - 1)
                    {
                        if (wall[vRow + 1, vCol] == '-')
                        {
                            wall[vRow, vCol] = '*';
                            holesCount++;
                            vRow++;
                            wall[vRow, vCol] = 'V';
                        }
                        else if (wall[vRow + 1, vCol] == 'R')
                        {
                            rodsHitted++;
                            Console.WriteLine("Vanko hit a rod!");
                        }
                        else if (wall[vRow + 1, vCol] == 'C')
                        {
                            holesCount++;
                            wall[vRow, vCol] = '*';

                            cablesHitted = true;
                            wall[vRow + 1, vCol] = 'E';
                            holesCount++;
                            break;


                        }
                        else if (wall[vRow + 1, vCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{vRow + 1}, {vCol}]!");
                            wall[vRow, vCol] = '*';
                            vRow = vRow + 1;
                        }

                    }
                }
                else if (direction == "left")
                {
                    if (vCol - 1 >= 0 && vCol - 1 <= wallSize)
                    {
                        if (wall[vRow, vCol - 1] == '-')
                        {
                            wall[vRow, vCol] = '*';
                            holesCount++;
                            vCol--;
                            wall[vRow, vCol] = 'V';
                        }
                        else if (wall[vRow, vCol - 1] == 'R')
                        {
                            rodsHitted++;
                            Console.WriteLine("Vanko hit a rod!");
                        }
                        else if (wall[vRow, vCol - 1] == 'C')
                        {
                            holesCount++;
                            wall[vRow, vCol] = '*';

                            cablesHitted = true;
                            wall[vRow, vCol - 1] = 'E';
                            holesCount++;
                            break;


                        }
                        else if (wall[vRow, vCol - 1] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{vRow}, {vCol - 1}]!");
                            wall[vRow, vCol] = '*';
                            vCol = vCol - 1;
                        }

                    }
                }
                else if (direction == "right")
                {
                    if (vCol + 1 >= 0 && vCol + 1 <= wallSize - 1)
                    {
                        if (wall[vRow, vCol + 1] == '-')
                        {
                            wall[vRow, vCol] = '*';
                            holesCount++;
                            vCol++;
                            wall[vRow, vCol] = 'V';
                        }
                        else if (wall[vRow, vCol + 1] == 'R')
                        {
                            rodsHitted++;
                            Console.WriteLine("Vanko hit a rod!");
                        }
                        else if (wall[vRow, vCol + 1] == 'C')
                        {
                            holesCount++;
                            wall[vRow, vCol] = '*';

                            cablesHitted = true;
                            wall[vRow, vCol + 1] = 'E';
                            holesCount++;
                            break;


                        }
                        else if (wall[vRow, vCol + 1] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{vRow}, {vCol + 1}]!");
                            wall[vRow, vCol] = '*';
                            vCol = vCol + 1;
                        }

                    }
                }


                direction = Console.ReadLine();
                if (direction == "End")
                {
                    holesCount++;

                    break;
                }



            }

            if (cablesHitted)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holesCount} hole(s).");
            }
            else
            {
                Console.WriteLine($"Vanko managed to make {holesCount} hole(s) and he hit only {rodsHitted} rod(s).");
            }
            for (int i = 0; i < wallSize; i++)
            {
                for (int a = 0; a < wallSize; a++)
                {
                    Console.Write(wall[i, a]);
                }
                Console.WriteLine();
            }
        }
    }
}