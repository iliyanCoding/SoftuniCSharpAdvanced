using System;

namespace _06.TheVLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Statistic")
                {
                    break;
                }
                else
                {
                    string[] commandArgs = input.Split(' ');
                    string vlogerName = commandArgs[0];
                    if (commandArgs[1] == "joined")
                    {

                    }
                }
            }
        }
    }
}
