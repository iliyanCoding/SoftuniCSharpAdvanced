using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);
            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');

                if (command[0].ToLower() == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                else if (command[0].ToLower() == "remove")
                {
                    if(stack.Count >= int.Parse(command[1]))
                    {
                        for (int i = 0; i < int.Parse(command[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                    
                }
                else if (command[0].ToLower() == "end")
                {
                    break;
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
