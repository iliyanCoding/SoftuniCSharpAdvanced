using System;
using System.Collections.Generic;
using System.Linq;

namespace Blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> swordsDictionary = new Dictionary<int, string>()
            {
                { 70, "Gladius" },
                { 80, "Shamshir" },
                { 90, "Katana"},
                { 110, "Sabre" },
                { 150, "Broadsword" },
            };
            SortedDictionary<string, int> forgedSwordsDictionary = new SortedDictionary<string, int>()
            {
                { "Gladius", 0 },
                { "Shamshir", 0 },
                { "Katana", 0 },
                { "Sabre", 0 },
                { "Broadsword", 0 },
            };

            int forgedSwords = 0;

            int[] steel = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] carbon = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> steelQueue = new Queue<int>();
            for (int i = 0; i < steel.Length; i++)
            {
                steelQueue.Enqueue(steel[i]);
            }

            Stack<int> carbonStack = new Stack<int>();
            for (int i = 0; i < carbon.Length; i++)
            {
                carbonStack.Push(carbon[i]);
            }

            while (carbonStack.Count > 0 && steelQueue.Count > 0)
            {
                int currSteel = steelQueue.Peek();
                int currCarbon = carbonStack.Pop();

                int currSwordSum = currSteel + currCarbon;

                if (swordsDictionary.ContainsKey(currSwordSum))
                {
                    string sword = swordsDictionary[currSwordSum];
                    if (!forgedSwordsDictionary.ContainsKey(sword))
                    {
                        forgedSwordsDictionary.Add(sword, 0);
                    }
                    forgedSwordsDictionary[sword]++;
                    forgedSwords++;
                    steelQueue.Dequeue();
                }
                else
                {
                    steelQueue.Dequeue();
                    carbonStack.Push(currCarbon + 5);
                }
            }

            if (forgedSwords > 0)
            {
                Console.WriteLine($"You have forged {forgedSwords} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }

            if (steelQueue.Count > 0)
            {
                Console.WriteLine($"Steel left: {string.Join(", ", steelQueue)}");
            }
            else
            {
                Console.WriteLine("Steel left: none");
            }

            if (carbonStack.Count > 0)
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", carbonStack)}");
            }
            else
            {
                Console.WriteLine("Carbon left: none");
            }

            foreach (var sword in forgedSwordsDictionary)
            {
                if (sword.Value > 0)
                {
                    Console.WriteLine($"{sword.Key}: {sword.Value}");
                }
            }
        }
    }
}
