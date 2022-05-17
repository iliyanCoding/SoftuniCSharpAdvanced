using System;
using System.Collections.Generic;

namespace _06.SuperMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else if (command == "End")
                {
                    Console.WriteLine($"{queue.Count} people remaining.");
                    break;
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
        }
    }
}
