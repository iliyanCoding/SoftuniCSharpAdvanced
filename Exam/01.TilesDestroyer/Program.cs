using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TilesDestroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] whiteTiles = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] grayTiles = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Dictionary<int, string> locations = new Dictionary<int, string>()
            {
                { 40, "Sink" },
                { 50, "Oven" },
                { 60, "Countertop" },
                { 70, "Wall" },

            };

            Dictionary<string, int> locationsWithTiles = new Dictionary<string, int>()
            {
                { "Sink", 0 },
                { "Oven", 0 },
                { "Countertop", 0 },
                { "Wall", 0 },
                { "Floor", 0},
            };



            Queue<int> grayTilesQueue = new Queue<int>();
            for (int i = 0; i < grayTiles.Length; i++)
            {
                grayTilesQueue.Enqueue(grayTiles[i]);
            }

            Stack<int> whiteTilesStack = new Stack<int>();
            for (int i = 0; i < whiteTiles.Length; i++)
            {
                whiteTilesStack.Push(whiteTiles[i]);
            }

            while (grayTilesQueue.Count > 0 && whiteTilesStack.Count > 0)
            {
                int currGrayTile = grayTilesQueue.Peek();
                int currWhiteTile = whiteTilesStack.Peek();

                if (currGrayTile == currWhiteTile)
                {
                    int largerTile = currWhiteTile + currGrayTile;
                    if (locations.ContainsKey(largerTile))
                    {
                        grayTilesQueue.Dequeue();
                        whiteTilesStack.Pop();
                        string location = locations[largerTile];
                        locationsWithTiles[location] += 1;
                    }
                    else
                    {
                        grayTilesQueue.Dequeue();
                        whiteTilesStack.Pop();
                        string location = "Floor";
                        locationsWithTiles[location] += 1;
                    }
                }
                else
                {
                    currWhiteTile = currWhiteTile / 2;
                    whiteTilesStack.Pop();
                    whiteTilesStack.Push(currWhiteTile);
                    grayTilesQueue.Dequeue();
                    grayTilesQueue.Enqueue(currGrayTile);
                }
            }

            if (whiteTilesStack.Count > 0)
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", whiteTilesStack)}");
            }
            else
            {
                Console.WriteLine("White tiles left: none");
            }

            if (grayTilesQueue.Count > 0)
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", grayTilesQueue)}");
            }
            else
            {
                Console.WriteLine("Grey tiles left: none");
            }

            //var sortedDict = from entry in locationsWithTiles orderby entry.Value descending select entry;


            foreach (var location in locationsWithTiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (location.Value > 0)
                {
                    Console.WriteLine($"{location.Key}: {location.Value}");
                }
            }
        }
    }
}
