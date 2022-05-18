using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(nums[i]);
            }
            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }
            bool xIsFound = false;
            foreach (var num in queue)
            {
                if (num == x)
                {
                    xIsFound = true;
                    Console.WriteLine("true");
                }
            }
            if (xIsFound == false)
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}
