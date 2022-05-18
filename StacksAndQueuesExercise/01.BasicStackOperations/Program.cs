using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
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
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                stack.Push(nums[i]);
            }
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }
            bool xIsFound = false;
            foreach (var num in stack)
            {
                if (num == x)
                {
                    xIsFound = true;
                    Console.WriteLine("true");
                }
            }
            if (xIsFound == false)
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }

        }
    }
}
