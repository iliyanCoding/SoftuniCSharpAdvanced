using System;
using System.Collections;
using System.Collections.Generic;

namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>(songs);
            while (queue.Count > 0)
            {
                string commandArgs = Console.ReadLine();
                

                if (commandArgs.Contains("Play"))
                {
                    queue.Dequeue();
                    
                }
                else if (commandArgs.Contains("Add"))
                {
                    string command = commandArgs.Substring(0, 3);
                    string currSong = commandArgs.Substring(4);
                    bool isSongContained = false;
                    foreach (var song in queue)
                    {
                        if (song == currSong)
                        {
                            Console.WriteLine($"{song} is already contained!");
                            isSongContained = true;
                        }
                    }
                    if (!isSongContained)
                    {
                        queue.Enqueue(currSong);
                    }
                }
                else if (commandArgs.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
            }
            Console.WriteLine("No more songs!");
            
        }
    }
}
